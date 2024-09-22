namespace Ideogram.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GenerateImage()
    {
        using var api = GetAuthenticatedApi();

        GenerateImageResponse image = await api.Generate.PostGenerateImageAsync(new ImageRequest
        {
            Prompt = "A beautiful sunset",
            AspectRatio = AspectRatio.ASPECT169,
            Seed = Random.Shared.Next(),
            StyleType = StyleType.REALISTIC,
            Resolution = Resolution.x1024768,
        });
        
        Console.WriteLine($"Generated image: {image.Data[0].Url}");
        
        image.Data[0].Url.Should().NotBeNullOrEmpty();
    }
}
