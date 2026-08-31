#nullable enable

namespace Ideogram
{
    public partial interface IAutoModelClient
    {
        /// <summary>
        /// Transform images from an instruction, letting the server pick the best model<br/>
        /// Transform one or more source images by describing the change in plain<br/>
        /// language, without choosing a model. The server selects the model best<br/>
        /// suited to the request and may route different requests to different<br/>
        /// models. Supply the sources either as `image_asset_identifiers`<br/>
        /// references (images already stored with Ideogram) or as raw `images`<br/>
        /// bytes (multipart requests only) — callers are never required to upload<br/>
        /// assets first. If both are supplied, the references win and the bytes<br/>
        /// are ignored.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ToolImageToImageResponse> PostToolImageToImageAsync(

            global::Ideogram.ToolImageToImageRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transform images from an instruction, letting the server pick the best model<br/>
        /// Transform one or more source images by describing the change in plain<br/>
        /// language, without choosing a model. The server selects the model best<br/>
        /// suited to the request and may route different requests to different<br/>
        /// models. Supply the sources either as `image_asset_identifiers`<br/>
        /// references (images already stored with Ideogram) or as raw `images`<br/>
        /// bytes (multipart requests only) — callers are never required to upload<br/>
        /// assets first. If both are supplied, the references win and the bytes<br/>
        /// are ignored.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ToolImageToImageResponse>> PostToolImageToImageAsResponseAsync(

            global::Ideogram.ToolImageToImageRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transform images from an instruction, letting the server pick the best model<br/>
        /// Transform one or more source images by describing the change in plain<br/>
        /// language, without choosing a model. The server selects the model best<br/>
        /// suited to the request and may route different requests to different<br/>
        /// models. Supply the sources either as `image_asset_identifiers`<br/>
        /// references (images already stored with Ideogram) or as raw `images`<br/>
        /// bytes (multipart requests only) — callers are never required to upload<br/>
        /// assets first. If both are supplied, the references win and the bytes<br/>
        /// are ignored.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.
        /// </summary>
        /// <param name="prompt">
        /// The instruction describing how to transform the source images.
        /// </param>
        /// <param name="imageAssetIdentifiers">
        /// Existing upload or generated image assets to transform, by reference. Takes priority over `images` if both are supplied.
        /// </param>
        /// <param name="images">
        /// The source images to transform (max 10, max size 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifiers` is also supplied.
        /// </param>
        /// <param name="aspectRatio">
        /// The output aspect ratio. `AUTO` (the default) lets the server pick the ratio; the model generally preserves the source images' composition. Any other value requests a shape hint formatted as "WIDTHxHEIGHT", for example "16x9" or "9x23". The selected model may serve the closest shape and resolution it supports. Omit `resolution` when supplying a non-`AUTO` value.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="resolution">
        /// The requested output resolution, formatted as "WIDTHxHEIGHT" (for example "900x2300"). The output is served at the closest resolution the selected model supports. Omit `aspect_ratio` (or leave it `AUTO`) when supplying a resolution.
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
        /// The internal generation category to attribute to the output, as a URL-safe base64 UUID without padding.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request blocks until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ToolImageToImageResponse> PostToolImageToImageAsync(
            string prompt,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? imageAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? images = default,
            string? aspectRatio = default,
            string? resolution = default,
            global::Ideogram.ToolImageToImageRequestResolutionTier? resolutionTier = default,
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