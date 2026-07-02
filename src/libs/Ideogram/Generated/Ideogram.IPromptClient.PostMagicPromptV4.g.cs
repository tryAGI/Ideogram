#nullable enable

namespace Ideogram
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// Generate a Magic Prompt with Ideogram 4.0<br/>
        /// Transforms a basic prompt into an enhanced Ideogram 4.0 magic prompt.<br/>
        /// The magic prompt model version is fixed; callers cannot select it.<br/>
        /// When `aspect_ratio` is `AUTO` (the default), the model selects the most<br/>
        /// suitable aspect ratio for the prompt and returns it in the response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.MagicPromptV4Response> PostMagicPromptV4Async(

            global::Ideogram.MagicPromptV4Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a Magic Prompt with Ideogram 4.0<br/>
        /// Transforms a basic prompt into an enhanced Ideogram 4.0 magic prompt.<br/>
        /// The magic prompt model version is fixed; callers cannot select it.<br/>
        /// When `aspect_ratio` is `AUTO` (the default), the model selects the most<br/>
        /// suitable aspect ratio for the prompt and returns it in the response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.MagicPromptV4Response>> PostMagicPromptV4AsResponseAsync(

            global::Ideogram.MagicPromptV4Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a Magic Prompt with Ideogram 4.0<br/>
        /// Transforms a basic prompt into an enhanced Ideogram 4.0 magic prompt.<br/>
        /// The magic prompt model version is fixed; callers cannot select it.<br/>
        /// When `aspect_ratio` is `AUTO` (the default), the model selects the most<br/>
        /// suitable aspect ratio for the prompt and returns it in the response.
        /// </summary>
        /// <param name="textPrompt">
        /// The natural-language prompt to enhance into an Ideogram 4.0 magic<br/>
        /// prompt. Named `text_prompt` to match the Ideogram 4.0 generate<br/>
        /// request surface.<br/>
        /// Example: a cat
        /// </param>
        /// <param name="aspectRatio">
        /// Target aspect ratio. Defaults to `AUTO`, which lets the model<br/>
        /// select the most suitable ratio and return it in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.MagicPromptV4Response> PostMagicPromptV4Async(
            string textPrompt,
            global::Ideogram.AspectRatioV4? aspectRatio = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}