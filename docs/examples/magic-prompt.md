# Magic Prompt



This example assumes `using Ideogram;` is in scope and `apiKey` contains your Ideogram API key.

```csharp
using var api = new IdeogramClient(apiKey);

MagicPromptResponse response = await api.Prompt.PostMagicPromptAsync(new MagicPromptRequest
{
    Prompt = "a cat sitting on a windowsill",
    MagicPromptVersion = MagicPromptVersionEnum.V0,
    ClassifyPromptCategory = true,
});

Console.WriteLine($"Enhanced prompt: {response.MagicPrompt}");
```