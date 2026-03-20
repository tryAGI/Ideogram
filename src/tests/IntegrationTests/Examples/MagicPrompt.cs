/*
order: 20
title: Magic Prompt
slug: magic-prompt
*/

namespace Ideogram.IntegrationTests;

public partial class Tests
{
    //// Use the Magic Prompt feature to enhance a simple prompt into a more detailed
    //// image generation prompt that produces better results.

    [TestMethod]
    public async Task Example_MagicPrompt()
    {
        using var api = GetAuthenticatedClient();

        MagicPromptResponse response = await api.Prompt.PostMagicPromptAsync(new MagicPromptRequest
        {
            Prompt = "a cat sitting on a windowsill",
            MagicPromptVersion = MagicPromptVersionEnum.V0,
            ClassifyPromptCategory = true,
        });

        Console.WriteLine($"Enhanced prompt: {response.MagicPrompt}");

        response.MagicPrompt.Should().NotBeNullOrEmpty();
    }
}
