#nullable enable

namespace Ideogram
{
    public partial interface IImagesEditClient
    {
        /// <summary>
        /// Edit images with Gemini 3.1 Flash from an instruction, by asset id or by uploaded bytes<br/>
        /// Edit one or more source images by describing the change in plain language.<br/>
        /// Supply the sources either as `image_asset_identifiers` references (images<br/>
        /// already stored with Ideogram) or as raw `images` bytes (multipart requests<br/>
        /// only) — callers are never required to upload assets first. If both are<br/>
        /// supplied, the references win and the bytes are ignored.<br/>
        /// By default the request blocks until the edited images are ready and<br/>
        /// returns them in `data`. Set `async` to true to return immediately after<br/>
        /// the request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.EditImageGemini31FlashResponse> PostEditImageGemini31FlashAsync(

            global::Ideogram.EditImageGemini31FlashRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit images with Gemini 3.1 Flash from an instruction, by asset id or by uploaded bytes<br/>
        /// Edit one or more source images by describing the change in plain language.<br/>
        /// Supply the sources either as `image_asset_identifiers` references (images<br/>
        /// already stored with Ideogram) or as raw `images` bytes (multipart requests<br/>
        /// only) — callers are never required to upload assets first. If both are<br/>
        /// supplied, the references win and the bytes are ignored.<br/>
        /// By default the request blocks until the edited images are ready and<br/>
        /// returns them in `data`. Set `async` to true to return immediately after<br/>
        /// the request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.EditImageGemini31FlashResponse>> PostEditImageGemini31FlashAsResponseAsync(

            global::Ideogram.EditImageGemini31FlashRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit images with Gemini 3.1 Flash from an instruction, by asset id or by uploaded bytes<br/>
        /// Edit one or more source images by describing the change in plain language.<br/>
        /// Supply the sources either as `image_asset_identifiers` references (images<br/>
        /// already stored with Ideogram) or as raw `images` bytes (multipart requests<br/>
        /// only) — callers are never required to upload assets first. If both are<br/>
        /// supplied, the references win and the bytes are ignored.<br/>
        /// By default the request blocks until the edited images are ready and<br/>
        /// returns them in `data`. Set `async` to true to return immediately after<br/>
        /// the request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="prompt">
        /// The edit instruction to apply to the source images.
        /// </param>
        /// <param name="imageAssetIdentifiers">
        /// Existing upload or generated image assets to edit, by reference. Takes priority over `images` if both are supplied.
        /// </param>
        /// <param name="images">
        /// The source images to edit (max 10, max size 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifiers` is also supplied.
        /// </param>
        /// <param name="numImages">
        /// The number of edited images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="aspectRatio">
        /// The requested output aspect ratio, for example "1:1", "16:9", or "9:16". The output is served at the closest aspect ratio the model supports, at 1K resolution. Defaults to "1:1".
        /// </param>
        /// <param name="async">
        /// When false (the default), the request blocks until the edited images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.EditImageGemini31FlashResponse> PostEditImageGemini31FlashAsync(
            string prompt,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? imageAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? images = default,
            int? numImages = default,
            int? seed = default,
            string? aspectRatio = default,
            bool? async = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}