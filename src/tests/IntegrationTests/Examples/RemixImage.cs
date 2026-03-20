/*
order: 40
title: Remix Image
slug: remix-image
*/

namespace Ideogram.IntegrationTests;

public partial class Tests
{
    //// Remix an existing image with Ideogram 3.0. Provide a source image and a new prompt
    //// to guide the remix, along with an image weight to control how much the original image
    //// influences the result.

    [TestMethod]
    [Ignore("Requires a valid image file and paid API call")]
    public async Task Example_RemixImage()
    {
        using var api = GetAuthenticatedClient();

        // Create a placeholder 1x1 pixel PNG for demonstration
        var imageBytes = new byte[] { 0x89, 0x50, 0x4E, 0x47 };

        ImageGenerationResponseV3 response = await api.Generate.PostRemixImageV3Async(
            new RemixImageRequestV3
            {
                Image = imageBytes,
                Imagename = "source.png",
                Prompt = "Transform this scene into a watercolor painting style",
                ImageWeight = 40,
                AspectRatio = AspectRatioV3.x16x9,
                MagicPrompt = MagicPromptOption.On,
                NegativePrompt = "blurry, low quality",
                Seed = 12345,
            });

        Console.WriteLine($"Created: {response.Created}");

        foreach (var image in response.Data)
        {
            Console.WriteLine($"Image URL: {image.Url}");
            Console.WriteLine($"Resolution: {image.Resolution}");
        }

        response.Data.Should().NotBeNullOrEmpty();
        response.Data[0].Url.Should().NotBeNullOrEmpty();
    }
}
