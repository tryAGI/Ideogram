#nullable enable

namespace Ideogram
{
    public partial interface IAutoModelClient
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
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageV2AutoResponse> PostGenerateImageV2AutoAsync(

            global::Ideogram.GenerateImageV2AutoRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
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
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateImageV2AutoResponse>> PostGenerateImageV2AutoAsResponseAsync(

            global::Ideogram.GenerateImageV2AutoRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="imageAssetIdentifiers">
        /// Existing upload or generated image assets to transform, by reference. Takes priority over `images` if both are supplied. Supplying sources turns the request into a transform.
        /// </param>
        /// <param name="images">
        /// Optional source images to edit (max 10, max 25MB each; JPEG, PNG, or WEBP). Multipart requests only.
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from the images. The prompt takes precedence over the negative prompt. Not every model uses it. Cannot be combined with source images.
        /// </param>
        /// <param name="styleReferenceAssetIdentifiers">
        /// Existing upload or generated image assets whose style should guide the generation, by reference. Cannot be combined with source images.
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
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="private">
        /// Whether the generated images should be kept private. When omitted, the default follows the caller's plan; some plans always generate privately.
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. The output images are added to it when the request completes.
        /// </param>
        /// <param name="categoryId">
        /// The internal generation category to attribute to the output, as a URL-safe base64 UUID without padding. Only applies when source images are supplied.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request waits until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` with the returned `generation_id` for the result.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageV2AutoResponse> PostGenerateImageV2AutoAsync(
            string prompt,
            bool? dryRun = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? imageAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? images = default,
            string? negativePrompt = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? styleReferenceAssetIdentifiers = default,
            string? aspectRatio = default,
            string? resolution = default,
            global::Ideogram.GenerateImageV2AutoRequestResolutionTier? resolutionTier = default,
            global::Ideogram.MagicPromptMode? magicPrompt = default,
            int? numImages = default,
            int? seed = default,
            bool? @private = default,
            string? targetCollectionId = default,
            string? categoryId = default,
            bool? async = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}