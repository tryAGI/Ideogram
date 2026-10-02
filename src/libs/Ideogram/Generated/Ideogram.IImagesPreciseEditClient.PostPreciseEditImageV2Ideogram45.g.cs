#nullable enable

namespace Ideogram
{
    public partial interface IImagesPreciseEditClient
    {
        /// <summary>
        /// Precise edit with Ideogram 4.5<br/>
        /// Edit an image with Ideogram 4.5 and get the result back at that image's<br/>
        /// exact width and height. Upload the image as `image` using<br/>
        /// `multipart/form-data`, with optional `reference_images` and a `mask`.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.<br/>
        /// `context_window` narrows the edit to one region of the image, so a<br/>
        /// large image keeps its detail: pass `x,y,width,height`, or `auto`<br/>
        /// together with a `mask`. The result always keeps the image's own width<br/>
        /// and height.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.PreciseEditImageIdeogram45Response> PostPreciseEditImageV2Ideogram45Async(

            global::Ideogram.PreciseEditImageIdeogram45Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Precise edit with Ideogram 4.5<br/>
        /// Edit an image with Ideogram 4.5 and get the result back at that image's<br/>
        /// exact width and height. Upload the image as `image` using<br/>
        /// `multipart/form-data`, with optional `reference_images` and a `mask`.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.<br/>
        /// `context_window` narrows the edit to one region of the image, so a<br/>
        /// large image keeps its detail: pass `x,y,width,height`, or `auto`<br/>
        /// together with a `mask`. The result always keeps the image's own width<br/>
        /// and height.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.PreciseEditImageIdeogram45Response>> PostPreciseEditImageV2Ideogram45AsResponseAsync(

            global::Ideogram.PreciseEditImageIdeogram45Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Precise edit with Ideogram 4.5<br/>
        /// Edit an image with Ideogram 4.5 and get the result back at that image's<br/>
        /// exact width and height. Upload the image as `image` using<br/>
        /// `multipart/form-data`, with optional `reference_images` and a `mask`.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.<br/>
        /// `context_window` narrows the edit to one region of the image, so a<br/>
        /// large image keeps its detail: pass `x,y,width,height`, or `auto`<br/>
        /// together with a `mask`. The result always keeps the image's own width<br/>
        /// and height.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The edit instruction, in natural language or as a structured JSON<br/>
        /// prompt. Natural language is automatically converted into a<br/>
        /// structured prompt; valid structured JSON is used as is.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// The image to edit, as an existing upload or generated image asset. Supply this or `image`, never both. Takes priority over `image` if both are supplied. Cannot be combined with `mask`.
        /// </param>
        /// <param name="image">
        /// The image to edit, as raw bytes (max 50MB; JPEG, PNG, or WEBP). Multipart requests only; ignored if `image_asset_identifier` is also supplied. Required when supplying a `mask` or a `context_window`. The output always matches this image's width and height, and pixels the edit did not meaningfully change are copied exactly from it.
        /// </param>
        /// <param name="imagename">
        /// The image to edit, as raw bytes (max 50MB; JPEG, PNG, or WEBP). Multipart requests only; ignored if `image_asset_identifier` is also supplied. Required when supplying a `mask` or a `context_window`. The output always matches this image's width and height, and pixels the edit did not meaningfully change are copied exactly from it.
        /// </param>
        /// <param name="referenceImageAssetIdentifiers">
        /// Optional additional images to guide the edit, by reference. These are never edited themselves; only `image_asset_identifier` or `image` is. Requires the image being edited to be supplied by reference too, and cannot be combined with `mask`.
        /// </param>
        /// <param name="referenceImages">
        /// Optional images to guide the edit (max 4, max 50MB each; JPEG, PNG, or WEBP). They are never edited themselves; only `image` is. Multipart requests only; ignored if `reference_image_asset_identifiers` is also supplied. A request with a `mask` can include at most three, because the mask takes up one reference slot.
        /// </param>
        /// <param name="mask">
        /// An optional mask that limits the edit to part of `image` (max 50MB; JPEG, PNG, or WEBP). Multipart requests only. Black marks the area to edit and white the area to keep; values in between are rounded to the nearer of the two. The mask must have the same width and height as `image` and contain both black and white areas. Requires `image` as raw bytes; masks cannot be combined with asset references. A masked request can include at most three `reference_images`.
        /// </param>
        /// <param name="maskname">
        /// An optional mask that limits the edit to part of `image` (max 50MB; JPEG, PNG, or WEBP). Multipart requests only. Black marks the area to edit and white the area to keep; values in between are rounded to the nearer of the two. The mask must have the same width and height as `image` and contain both black and white areas. Requires `image` as raw bytes; masks cannot be combined with asset references. A masked request can include at most three `reference_images`.
        /// </param>
        /// <param name="contextWindow">
        /// How much of the image being edited the model may see and change.<br/>
        /// `none`, the default, edits the whole image. A large image may come back smaller than it was sent.<br/>
        /// `auto` fits a region around what the `mask` selects and edits only that region, so its detail is kept. It requires a `mask`. A small enough image has no region to fit and is edited as it is.<br/>
        /// `x,y,width,height` names the region explicitly, in the edited image's own pixels with the origin at its top-left corner — for example `1024,512,2048,1536`. The region must lie inside the image, measure at least 256px on each side, have an aspect ratio between 1:6 and 6:1, and cover no more than 4194304 pixels. A `mask` may select only pixels inside it.<br/>
        /// With `auto` or an explicit region, every pixel outside the region is returned exactly as supplied and the output keeps the image's own width and height.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="quality">
        /// The rendering quality to use. `very_low` is the fastest and cheapest, and `high` takes longer and is priced higher.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Run copyright detection on the generated images. Adds latency; flagged images are returned with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request waits until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` with the returned `generation_id` for the result.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl">
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.<br/>
        /// Example: https://api.example.com/webhooks/ideogram
        /// </param>
        /// <param name="private">
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. The output images are added to it when the request completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.PreciseEditImageIdeogram45Response> PostPreciseEditImageV2Ideogram45Async(
            string prompt,
            bool? dryRun = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceImageAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? referenceImages = default,
            byte[]? mask = default,
            string? maskname = default,
            string? contextWindow = default,
            global::Ideogram.PreciseEditImageIdeogram45RequestQuality? quality = default,
            int? seed = default,
            int? numImages = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}