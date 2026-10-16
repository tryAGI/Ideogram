#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// Generate with automatic model selection<br/>
        /// Generate images with the model Ideogram picks as best suited to each<br/>
        /// request. Optionally upload source images as `images` using<br/>
        /// `multipart/form-data` to edit them with the prompt. Returns results<br/>
        /// directly by default; set `async` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.GenerateImageV2AutoResponse> CreateImageGenerateAutoAsync(

            global::Ideogram.V2.AutoModelPostGenerateImageV2AutoRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with automatic model selection<br/>
        /// Generate images with the model Ideogram picks as best suited to each<br/>
        /// request. Optionally upload source images as `images` using<br/>
        /// `multipart/form-data` to edit them with the prompt. Returns results<br/>
        /// directly by default; set `async` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.GenerateImageV2AutoResponse>> CreateImageGenerateAutoAsResponseAsync(

            global::Ideogram.V2.AutoModelPostGenerateImageV2AutoRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with automatic model selection<br/>
        /// Generate images with the model Ideogram picks as best suited to each<br/>
        /// request. Optionally upload source images as `images` using<br/>
        /// `multipart/form-data` to edit them with the prompt. Returns results<br/>
        /// directly by default; set `async` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The prompt to generate images from or, when source images are supplied, the change to make to them.
        /// </param>
        /// <param name="images">
        /// Optional source images to edit (max 10, max 25MB each; JPEG, PNG, or WEBP). Multipart requests only.
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from the images. The prompt takes precedence over the negative prompt. Not every model uses it. Cannot be combined with source images.
        /// </param>
        /// <param name="aspectRatio">
        /// The output aspect ratio. `auto` (the default) picks the most suitable ratio for the request. Without source images the value must be a supported ratio (for example "16x9" or "1x1"); with source images any "WIDTHxHEIGHT" value is accepted and the output uses the closest supported shape. Omit `resolution` when supplying a non-`auto` value.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="resolution">
        /// The requested output resolution, formatted as "WIDTHxHEIGHT" (for example "1280x800"). The output is served at the closest resolution the selected model supports. Omit `aspect_ratio` (or leave it `auto`) when supplying a resolution.
        /// </param>
        /// <param name="resolutionTier">
        /// The output resolution tier. Affects which model serves the request, since not every model offers every tier. When omitted, the selected model's default tier is used.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="private">
        /// Whether the generated images should be kept private. When omitted, the default follows the caller's plan; some plans always generate privately.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request waits until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` with the returned `generation_id` for the result.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.GenerateImageV2AutoResponse> CreateImageGenerateAutoAsync(
            string prompt,
            bool? dryRun = default,
            global::System.Collections.Generic.IList<byte[]>? images = default,
            string? negativePrompt = default,
            string? aspectRatio = default,
            string? resolution = default,
            global::Ideogram.V2.V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier? resolutionTier = default,
            global::Ideogram.V2.MagicPromptMode? magicPrompt = default,
            int? numImages = default,
            int? seed = default,
            bool? @private = default,
            bool? async = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}