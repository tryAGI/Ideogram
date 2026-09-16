#nullable enable

namespace Ideogram
{
    public partial interface IAutoModelClient
    {
        /// <summary>
        /// Generate or transform images, letting the server pick the best model<br/>
        /// Generate one or more images without choosing a model. The server<br/>
        /// selects the model best suited to the request and may route different<br/>
        /// requests to different models.<br/>
        /// Supplying source images turns the request into a transform: the server<br/>
        /// picks a model that can edit, and the prompt describes the change to<br/>
        /// apply. Provide the sources either as `image_asset_identifiers`<br/>
        /// references (images already stored with Ideogram) or as raw `images`<br/>
        /// bytes (multipart requests only) — if both are supplied, the references<br/>
        /// win and the bytes are ignored. `negative_prompt` and<br/>
        /// `style_reference_asset_identifiers` only apply without source images;<br/>
        /// combining them with sources is rejected with a 422 rather than<br/>
        /// silently ignored.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.
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
        /// Generate or transform images, letting the server pick the best model<br/>
        /// Generate one or more images without choosing a model. The server<br/>
        /// selects the model best suited to the request and may route different<br/>
        /// requests to different models.<br/>
        /// Supplying source images turns the request into a transform: the server<br/>
        /// picks a model that can edit, and the prompt describes the change to<br/>
        /// apply. Provide the sources either as `image_asset_identifiers`<br/>
        /// references (images already stored with Ideogram) or as raw `images`<br/>
        /// bytes (multipart requests only) — if both are supplied, the references<br/>
        /// win and the bytes are ignored. `negative_prompt` and<br/>
        /// `style_reference_asset_identifiers` only apply without source images;<br/>
        /// combining them with sources is rejected with a 422 rather than<br/>
        /// silently ignored.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.
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
        /// Generate or transform images, letting the server pick the best model<br/>
        /// Generate one or more images without choosing a model. The server<br/>
        /// selects the model best suited to the request and may route different<br/>
        /// requests to different models.<br/>
        /// Supplying source images turns the request into a transform: the server<br/>
        /// picks a model that can edit, and the prompt describes the change to<br/>
        /// apply. Provide the sources either as `image_asset_identifiers`<br/>
        /// references (images already stored with Ideogram) or as raw `images`<br/>
        /// bytes (multipart requests only) — if both are supplied, the references<br/>
        /// win and the bytes are ignored. `negative_prompt` and<br/>
        /// `style_reference_asset_identifiers` only apply without source images;<br/>
        /// combining them with sources is rejected with a 422 rather than<br/>
        /// silently ignored.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The prompt to generate images from, or the instruction describing how to transform the source images when sources are supplied.
        /// </param>
        /// <param name="imageAssetIdentifiers">
        /// Existing upload or generated image assets to transform, by reference. Takes priority over `images` if both are supplied. Supplying sources turns the request into a transform.
        /// </param>
        /// <param name="images">
        /// The source images to transform (max 10, max size 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifiers` is also supplied.
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from the images. Descriptions in the prompt take precedence over descriptions in the negative prompt. Not every model consults it. Cannot be combined with source images.
        /// </param>
        /// <param name="styleReferenceAssetIdentifiers">
        /// Existing upload or generated image assets whose style should guide the generation, by reference. Cannot be combined with source images.
        /// </param>
        /// <param name="aspectRatio">
        /// The output aspect ratio. `AUTO` (the default) picks the most suitable ratio from the request. Without source images the value must be one of the supported ratio buckets (for example "16x9" or "1x1"); with source images any "WIDTHxHEIGHT" shape hint is accepted and the selected model serves the closest shape it supports. Omit `resolution` when supplying a non-`AUTO` value.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="resolution">
        /// The requested output resolution, formatted as "WIDTHxHEIGHT" (for example "1280x800"). The output is served at the closest resolution the selected model supports. Omit `aspect_ratio` (or leave it `AUTO`) when supplying a resolution.
        /// </param>
        /// <param name="resolutionTier">
        /// The output resolution tier. Influences which model serves the request; not every model offers every tier. When omitted the server uses the selected model's default tier.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `AUTO`.<br/>
        /// Default Value: AUTO
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
        /// When false (the default), the request blocks until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
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
            global::Ideogram.MagicPromptOption? magicPrompt = default,
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