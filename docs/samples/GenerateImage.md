```csharp
using var api = new IdeogramClient(apiKey);

GenerateImageResponse image = await api.Generate.PostGenerateImageAsync(new ImageRequest
{
    Prompt = "A beautiful sunset",
    AspectRatio = AspectRatio.Aspect169,
    Seed = Random.Shared.Next(),
    StyleType = StyleType.Realistic,
    Resolution = Resolution.x1024768,
});

Console.WriteLine($"Generated image: {image.Data[0].Url}");
```