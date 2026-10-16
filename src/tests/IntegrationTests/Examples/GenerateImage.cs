/*
order: 10
title: Generate Image
slug: generate-image
*/

namespace Ideogram.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GenerateImage()
    {
        using var api = GetAuthenticatedClient();

        GenerateImageResponse image = await api.Generate.PostGenerateImageAsync(new ImageRequest
        {
            Prompt = "A beautiful sunset",
            AspectRatio = AspectRatio.Aspect169,
            Seed = Random.Shared.Next(),
            StyleType = StyleType.Realistic,
            Resolution = Resolution.x1024768,
        });
        
        var images = image.Data;
        Assert.IsNotNull(images, "Synchronous generation should return image data.");
        images.Should().NotBeEmpty();
        Console.WriteLine($"Generated image: {images[0].Url}");
        
        images[0].Url.Should().NotBeNullOrEmpty();
    }
}
