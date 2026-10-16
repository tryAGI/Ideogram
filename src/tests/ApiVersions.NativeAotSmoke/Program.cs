using System.Net;
using System.Text;
using Ideogram;
using V2 = Ideogram.V2;
using var http = new HttpClient(new OfflineHandler());
using var legacy = new IdeogramClient("synthetic", httpClient: http);
var oldResult = await legacy.Generate.PostGenerateImageAsync(new ImageRequest { Prompt = "test" });
if (oldResult.Data?.Count != 0) return 1;
using var current = new V2.IdeogramV2Client("synthetic", httpClient: http);
var newResult = await current.CreateImageGenerateIdeogram45Async(prompt: "test");
if (newResult.GenerationId != "offline" || newResult.Data?.Count != 0) return 2;
Console.WriteLine("NativeAOT: v1/v2 request serialization, Api-Key and response deserialization passed offline.");
return 0;
sealed class OfflineHandler : HttpMessageHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token)
    {
        if (request.Headers.GetValues("Api-Key").Single() != "synthetic" || request.Headers.Authorization is not null) throw new InvalidOperationException("Invalid auth");
        _ = await request.Content!.ReadAsByteArrayAsync(token);
        var json = request.RequestUri!.AbsolutePath == "/generate"
            ? """{"created":"2026-10-16T00:00:00Z","data":[]}"""
            : """{"generation_kind":"sampling","generation_id":"offline","seed":7,"data":[]}""";
        return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(json, Encoding.UTF8, "application/json") };
    }
}
