# Remix Image



This example assumes `using Ideogram;` is in scope and `apiKey` contains your Ideogram API key.

```csharp
using var api = new IdeogramClient(apiKey);

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
```