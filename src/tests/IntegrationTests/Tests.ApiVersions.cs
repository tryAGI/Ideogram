using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using V2 = Ideogram.V2;

namespace Ideogram.IntegrationTests;

public partial class Tests
{
    private const string V2ImageResponse = """
        {"generation_kind":"sampling","generation_id":"task-1","seed":7,
         "data":[{"url":"https://images.example.test/result.png","prompt":"A sunset",
                  "resolution":"1024x1024","is_image_safe":true,"seed":7}]}
        """;

    [TestMethod]
    [DataRow(false)]
    [DataRow(true)]
    public async Task LegacyClient_PreservesAuthorizationApiAndSendsApiKey(bool explicitHeader)
    {
        using var http = new HttpClient(new VersionedHandler(async (request, token) =>
        {
            Assert.AreEqual("/generate", request.RequestUri?.AbsolutePath);
            Assert.AreEqual(explicitHeader ? "explicit-key" : "replacement-key", request.Headers.GetValues("Api-Key").Single());
            Assert.IsNull(request.Headers.Authorization);
            Assert.IsNotNull(request.Content);
            Assert.AreEqual("application/json", request.Content.Headers.ContentType?.MediaType);
            using var body = JsonDocument.Parse(await request.Content.ReadAsStringAsync(token));
            Assert.AreEqual("A sunset", body.RootElement.GetProperty("image_request").GetProperty("prompt").GetString());
            return JsonReply("""{"created":"2026-10-16T00:00:00Z","data":[]}""");
        }));
        using var client = new IdeogramClient("original-key", httpClient: http);
        IIdeogramClient legacyInterface = client;
        legacyInterface.AuthorizeUsingBearer("replacement-key");
        if (explicitHeader)
        {
            client.Options.Headers["Api-Key"] = "explicit-key";
        }
        var response = await legacyInterface.Generate.PostGenerateImageAsync(new ImageRequest { Prompt = "A sunset" });
        Assert.IsNotNull(response.Data);
        Assert.AreEqual(0, response.Data.Count);
    }

    [TestMethod]
    public async Task V2Client_GeneratesWithIndependentTypesAndApiKey()
    {
        using var http = new HttpClient(new VersionedHandler(async (request, token) =>
        {
            AssertV2Request(request, "/v2/image/generate/ideogram-4-5");
            var parts = await ReadPartsAsync(request, token);
            Assert.AreEqual("A sunset", parts["prompt"]);
            Assert.AreEqual("7", parts["seed"]);
            Assert.IsFalse(parts.ContainsKey("text_prompt"));
            return JsonReply(V2ImageResponse);
        }));
        using var client = new V2.IdeogramV2Client("v2-key", httpClient: http);
        var result = await client.CreateImageGenerateIdeogram45Async(prompt: "A sunset", seed: 7);
        Assert.AreEqual("task-1", result.GenerationId);
        Assert.IsNotNull(result.Data);
        Assert.AreEqual("https://images.example.test/result.png", result.Data.Single().Url);
    }

    [TestMethod]
    public async Task V2Client_UploadsImageWithFilenameAndMimeType()
    {
        using var http = new HttpClient(new VersionedHandler(async (request, token) =>
        {
            AssertV2Request(request, "/v2/image/precise-edit/ideogram-4-5");
            Assert.IsInstanceOfType<MultipartFormDataContent>(request.Content);
            var image = ((MultipartFormDataContent)request.Content).Single(part => part.Headers.ContentDisposition?.Name?.Trim('"') == "image");
            Assert.AreEqual("source.png", image.Headers.ContentDisposition?.FileName?.Trim('"'));
            Assert.AreEqual("image/png", image.Headers.ContentType?.MediaType);
            CollectionAssert.AreEqual(new byte[] { 1, 2, 3 }, await image.ReadAsByteArrayAsync(token));
            return JsonReply(V2ImageResponse);
        }));
        using var client = new V2.IdeogramV2Client("v2-key", httpClient: http);
        var result = await client.CreateImagePreciseEditIdeogram45Async(new V2.ImagesPreciseEditPostPreciseEditImageV2Ideogram45Request
        {
            Prompt = "Change the color",
            Image = [1, 2, 3],
            Imagename = "source.png",
        });
        Assert.AreEqual("task-1", result.GenerationId);
    }

    [TestMethod]
    [DataRow("pending", null)]
    [DataRow("failed", "content_policy_violation")]
    public async Task V2Client_PreservesAsyncStatusWithoutRequiringImageData(string status, string? failureReason)
    {
        var calls = 0;
        using var http = new HttpClient(new VersionedHandler(async (request, token) =>
        {
            calls++;
            if (calls == 1)
            {
                AssertV2Request(request, "/v2/image/generate/ideogram-4-5");
                Assert.AreEqual("true", (await ReadPartsAsync(request, token))["async"]);
                return JsonReply("""{"generation_kind":"sampling","generation_id":"task-1","seed":7}""");
            }
            Assert.AreEqual(HttpMethod.Get, request.Method);
            AssertV2Request(request, "/v2/generations/task-1");
            return JsonReply($$"""{"generation_id":"task-1","status":"{{status}}","created":"2026-10-16T00:00:00Z","failure_reason":{{JsonSerializer.Serialize(failureReason)}}} """);
        }));
        using var client = new V2.IdeogramV2Client("v2-key", httpClient: http);
        var accepted = await client.CreateImageGenerateIdeogram45Async(prompt: "A sunset", async: true);
        Assert.IsNull(accepted.Data);
        var result = await client.GetGenerationsByGenerationIdAsync(accepted.GenerationId);
        Assert.AreEqual(status, V2.GenerationResponseStatusExtensions.ToValueString(result.Status));
        Assert.AreEqual(failureReason, result.FailureReason);
        Assert.IsNull(result.Data);
        Assert.AreEqual(2, calls);
    }

    private static void AssertV2Request(HttpRequestMessage request, string path)
    {
        Assert.AreEqual(path, request.RequestUri?.AbsolutePath);
        Assert.AreEqual("v2-key", request.Headers.GetValues("Api-Key").Single());
        Assert.IsNull(request.Headers.Authorization);
    }

    private static async Task<Dictionary<string, string>> ReadPartsAsync(HttpRequestMessage request, CancellationToken token)
    {
        Assert.IsInstanceOfType<MultipartFormDataContent>(request.Content);
        var result = new Dictionary<string, string>();
        foreach (var part in (MultipartFormDataContent)request.Content)
        {
            Assert.IsNotNull(part.Headers.ContentDisposition?.Name);
            result.Add(part.Headers.ContentDisposition.Name.Trim('"'), await part.ReadAsStringAsync(token));
        }
        return result;
    }

    private static HttpResponseMessage JsonReply(string json) => new(HttpStatusCode.OK)
    {
        Content = new StringContent(json, Encoding.UTF8, "application/json"),
    };

    private sealed class VersionedHandler(Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> respond) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) => respond(request, cancellationToken);
    }
}
