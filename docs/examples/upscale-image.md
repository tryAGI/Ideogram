# Upscale Image



This example assumes `using Ideogram;` is in scope and `apiKey` contains your Ideogram API key.

```csharp
using var api = new IdeogramClient(apiKey);

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
```