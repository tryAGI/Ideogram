# Edit Image



This example assumes `using Ideogram;` is in scope and `apiKey` contains your Ideogram API key.

```csharp
using var api = new IdeogramClient(apiKey);

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
```