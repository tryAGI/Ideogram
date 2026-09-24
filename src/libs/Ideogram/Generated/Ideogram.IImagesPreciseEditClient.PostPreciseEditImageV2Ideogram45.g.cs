#nullable enable

namespace Ideogram
{
    public partial interface IImagesPreciseEditClient
    {
        /// <summary>
        /// Edit an image with Ideogram 4.5, keeping the source's exact geometry<br/>
        /// Edit an image with Ideogram 4.5, returning output at that image's exact<br/>
        /// width and height. An image too large for the model is scaled down to<br/>
        /// fit while keeping its exact proportion, and one whose aspect ratio is<br/>
        /// outside 1:6 to 6:1 is rejected — this endpoint never reshapes, so there<br/>
        /// is no size to reshape it to. Unlike<br/>
        /// `POST /v2/image/generate/ideogram-4-5`, this endpoint takes no `size`:<br/>
        /// the output always matches the image being edited, so the edit drops<br/>
        /// back into whatever it came from without reframing.<br/>
        /// Supply the image to edit as an `image_asset_identifier` reference or as<br/>
        /// raw `image` bytes (multipart requests only); if both are supplied, the<br/>
        /// reference wins and the bytes are ignored. Add up to four more images<br/>
        /// via `reference_image_asset_identifiers` or `reference_images` to guide<br/>
        /// the edit — those are never edited themselves.<br/>
        /// Supply a `mask` to confine the edit to part of the image being edited.<br/>
        /// The mask is optional — without one the prompt is applied to the whole<br/>
        /// image. Masks are read as an additional reference image, so a masked<br/>
        /// request may carry at most three `reference_images`.<br/>
        /// The `prompt` is the edit instruction. It accepts either natural<br/>
        /// language or a structured JSON prompt; the server detects which was<br/>
        /// supplied. A natural-language instruction is automatically rewritten<br/>
        /// into the model's structured edit contract, while a prompt that is<br/>
        /// already valid structured JSON is consumed directly.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
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
        /// Edit an image with Ideogram 4.5, keeping the source's exact geometry<br/>
        /// Edit an image with Ideogram 4.5, returning output at that image's exact<br/>
        /// width and height. An image too large for the model is scaled down to<br/>
        /// fit while keeping its exact proportion, and one whose aspect ratio is<br/>
        /// outside 1:6 to 6:1 is rejected — this endpoint never reshapes, so there<br/>
        /// is no size to reshape it to. Unlike<br/>
        /// `POST /v2/image/generate/ideogram-4-5`, this endpoint takes no `size`:<br/>
        /// the output always matches the image being edited, so the edit drops<br/>
        /// back into whatever it came from without reframing.<br/>
        /// Supply the image to edit as an `image_asset_identifier` reference or as<br/>
        /// raw `image` bytes (multipart requests only); if both are supplied, the<br/>
        /// reference wins and the bytes are ignored. Add up to four more images<br/>
        /// via `reference_image_asset_identifiers` or `reference_images` to guide<br/>
        /// the edit — those are never edited themselves.<br/>
        /// Supply a `mask` to confine the edit to part of the image being edited.<br/>
        /// The mask is optional — without one the prompt is applied to the whole<br/>
        /// image. Masks are read as an additional reference image, so a masked<br/>
        /// request may carry at most three `reference_images`.<br/>
        /// The `prompt` is the edit instruction. It accepts either natural<br/>
        /// language or a structured JSON prompt; the server detects which was<br/>
        /// supplied. A natural-language instruction is automatically rewritten<br/>
        /// into the model's structured edit contract, while a prompt that is<br/>
        /// already valid structured JSON is consumed directly.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
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
        /// Edit an image with Ideogram 4.5, keeping the source's exact geometry<br/>
        /// Edit an image with Ideogram 4.5, returning output at that image's exact<br/>
        /// width and height. An image too large for the model is scaled down to<br/>
        /// fit while keeping its exact proportion, and one whose aspect ratio is<br/>
        /// outside 1:6 to 6:1 is rejected — this endpoint never reshapes, so there<br/>
        /// is no size to reshape it to. Unlike<br/>
        /// `POST /v2/image/generate/ideogram-4-5`, this endpoint takes no `size`:<br/>
        /// the output always matches the image being edited, so the edit drops<br/>
        /// back into whatever it came from without reframing.<br/>
        /// Supply the image to edit as an `image_asset_identifier` reference or as<br/>
        /// raw `image` bytes (multipart requests only); if both are supplied, the<br/>
        /// reference wins and the bytes are ignored. Add up to four more images<br/>
        /// via `reference_image_asset_identifiers` or `reference_images` to guide<br/>
        /// the edit — those are never edited themselves.<br/>
        /// Supply a `mask` to confine the edit to part of the image being edited.<br/>
        /// The mask is optional — without one the prompt is applied to the whole<br/>
        /// image. Masks are read as an additional reference image, so a masked<br/>
        /// request may carry at most three `reference_images`.<br/>
        /// The `prompt` is the edit instruction. It accepts either natural<br/>
        /// language or a structured JSON prompt; the server detects which was<br/>
        /// supplied. A natural-language instruction is automatically rewritten<br/>
        /// into the model's structured edit contract, while a prompt that is<br/>
        /// already valid structured JSON is consumed directly.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The edit instruction to apply to the sources. Accepts either<br/>
        /// natural language or a structured JSON prompt; the server detects<br/>
        /// which was supplied. Natural language is automatically rewritten<br/>
        /// into the model's structured edit contract, while structured JSON<br/>
        /// is consumed directly.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// The image to edit, as an existing upload or generated image asset. Supply this or `image`, never both. Takes priority over `image` if both are supplied. Cannot be combined with `mask`.
        /// </param>
        /// <param name="image">
        /// The image to edit, as raw bytes (max size 25MB; JPEG, PNG, or WEBP only). Multipart requests only; ignored if `image_asset_identifier` is also supplied. Required when supplying a `mask`.
        /// </param>
        /// <param name="imagename">
        /// The image to edit, as raw bytes (max size 25MB; JPEG, PNG, or WEBP only). Multipart requests only; ignored if `image_asset_identifier` is also supplied. Required when supplying a `mask`.
        /// </param>
        /// <param name="referenceImageAssetIdentifiers">
        /// Optional additional images to guide the edit, by reference. These are never edited themselves; only `image_asset_identifier` or `image` is. Requires the image being edited to be supplied by reference too, and cannot be combined with `mask`.
        /// </param>
        /// <param name="referenceImages">
        /// Optional additional images to guide the edit (max 4, max size 25MB each), as raw bytes; only JPEG, PNG, and WEBP formats are supported. These are never edited themselves; only `image` is. Multipart requests only; ignored if `reference_image_asset_identifiers` is also supplied. A masked request may carry at most three, because the mask occupies one of the model's reference slots.
        /// </param>
        /// <param name="mask">
        /// An optional mask confining the edit to part of `image`, as raw bytes (multipart requests only; JPEG, PNG, or WEBP, max 25MB). Black marks the area to edit and white the area to preserve; values in between are rounded to whichever is nearer. The mask must have the same width and height as `image`, and must contain both black and white areas. Requires the image being edited to be uploaded as raw `image` bytes in the same request; masks cannot be combined with asset references. The mask is supplied to the model as an additional reference image, so a masked request may carry at most three `reference_images`.
        /// </param>
        /// <param name="maskname">
        /// An optional mask confining the edit to part of `image`, as raw bytes (multipart requests only; JPEG, PNG, or WEBP, max 25MB). Black marks the area to edit and white the area to preserve; values in between are rounded to whichever is nearer. The mask must have the same width and height as `image`, and must contain both black and white areas. Requires the image being edited to be uploaded as raw `image` bytes in the same request; masks cannot be combined with asset references. The mask is supplied to the model as an additional reference image, so a masked request may carry at most three `reference_images`.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. `ultra` renders multiple candidate edits internally and returns the one that best applies the instruction; it takes longer than `quality`, is priced higher, and supports at most 4 images per request.<br/>
        /// Default Value: default
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
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request blocks until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
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
            global::Ideogram.PreciseEditImageIdeogram45RequestRenderingSpeed? renderingSpeed = default,
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