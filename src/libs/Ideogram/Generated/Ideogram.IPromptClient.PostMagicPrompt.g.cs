#nullable enable

namespace Ideogram
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// Generate Magic Prompt<br/>
        /// Transforms basic prompts into a magic prompt. Internal use only (feature flagged). TODO: update description if enabled externally.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.MagicPromptResponse> PostMagicPromptAsync(
            global::Ideogram.MagicPromptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate Magic Prompt<br/>
        /// Transforms basic prompts into a magic prompt. Internal use only (feature flagged). TODO: update description if enabled externally.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to enhance with a magic prompt<br/>
        /// Example: a cat
        /// </param>
        /// <param name="magicPromptVersion">
        /// The magic prompt version to use when magic prompt option is set to AUTO or ON.<br/>
        /// Example: V_0
        /// </param>
        /// <param name="classifyPromptCategory">
        /// Whether to classify the prompt into a use case category.<br/>
        /// Default Value: true<br/>
        /// Example: false
        /// </param>
        /// <param name="styleType">
        /// The style type to generate with.<br/>
        /// Default Value: GENERAL<br/>
        /// Example: GENERAL
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducible generation<br/>
        /// Example: 12345
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.MagicPromptResponse> PostMagicPromptAsync(
            string prompt,
            global::Ideogram.MagicPromptVersionEnum magicPromptVersion,
            bool classifyPromptCategory,
            global::Ideogram.StyleTypeV3? styleType = default,
            int? seed = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}