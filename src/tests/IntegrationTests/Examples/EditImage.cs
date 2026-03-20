/*
order: 60
title: Edit Image
slug: edit-image
*/

namespace Ideogram.IntegrationTests;

public partial class Tests
{
    //// Edit a specific region of an image using Ideogram 3.0 with a mask.
    //// Black regions in the mask indicate which parts of the image should be edited,
    //// while the prompt guides the content of the edited area.

    [TestMethod]
    [Ignore("Requires valid image and mask files and paid API call")]
    public async Task Example_EditImage()
    {
        using var api = GetAuthenticatedClient();

        // Create placeholder 1x1 pixel PNGs for demonstration
        var imageBytes = new byte[] { 0x89, 0x50, 0x4E, 0x47 };
        var maskBytes = new byte[] { 0x89, 0x50, 0x4E, 0x47 };

        ImageGenerationResponseV3 response = await api.Generate.PostEditImageV3Async(
            new EditImageRequestV3
            {
                Image = imageBytes,
                Imagename = "photo.png",
                Mask = maskBytes,
                Maskname = "mask.png",
                Prompt = "Replace the background with a starry night sky",
                MagicPrompt = MagicPromptOption.On,
                StyleType = StyleTypeV3.General,
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
