/*
order: 50
title: Upscale Image
slug: upscale-image
*/

namespace Ideogram.IntegrationTests;

public partial class Tests
{
    //// Upscale an image to a higher resolution with optional prompt guidance.
    //// You can control the resemblance to the original and the level of detail
    //// added during the upscaling process.

    [TestMethod]
    [Ignore("Requires a valid image file and paid API call")]
    public async Task Example_UpscaleImage()
    {
        using var api = GetAuthenticatedClient();

        // Create a placeholder 1x1 pixel PNG for demonstration
        var imageBytes = new byte[] { 0x89, 0x50, 0x4E, 0x47 };

        GenerateImageResponse response = await api.Generate.PostUpscaleImageAsync(
            new UpscaleImageRequest
            {
                ImageRequest = new UpscaleInitialImageRequest
                {
                    Prompt = "A detailed landscape with sharp textures",
                    Resemblance = 60,
                    Detail = 70,
                    MagicPromptOption = MagicPromptOption.On,
                    Seed = 12345,
                },
                ImageFile = imageBytes,
                ImageFilename = "input.png",
            });

        Console.WriteLine($"Upscaled images count: {response.Data.Count}");

        foreach (var image in response.Data)
        {
            Console.WriteLine($"Image URL: {image.Url}");
        }

        response.Data.Should().NotBeNullOrEmpty();
        response.Data[0].Url.Should().NotBeNullOrEmpty();
    }
}
