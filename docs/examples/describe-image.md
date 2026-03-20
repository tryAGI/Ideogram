# Describe Image



This example assumes `using Ideogram;` is in scope and `apiKey` contains your Ideogram API key.

```csharp
using var api = new IdeogramClient(apiKey);

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
```