/*
order: 30
title: Describe Image
slug: describe-image
*/

namespace Ideogram.IntegrationTests;

public partial class Tests
{
    //// Use the Vision API to describe the contents of an image. This endpoint
    //// analyzes an uploaded image and returns text descriptions.

    [TestMethod]
    [Ignore("Requires a valid image file")]
    public async Task Example_DescribeImage()
    {
        using var api = GetAuthenticatedClient();

        // Create a simple 1x1 pixel PNG for demonstration
        var imageBytes = new byte[] { 0x89, 0x50, 0x4E, 0x47 };

        DescribeResponse response = await api.Vision.PostDescribeAsync(new DescribeRequest
        {
            ImageFile = imageBytes,
            ImageFilename = "test.png",
        });

        Console.WriteLine($"Description count: {response.Descriptions?.Count}");

        foreach (var description in response.Descriptions ?? [])
        {
            Console.WriteLine($"  Description: {description.Text}");
        }

        response.Should().NotBeNull();
    }
}
