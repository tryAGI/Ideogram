#nullable enable

namespace Ideogram
{
    public partial interface IImagesGenerateClient
    {
        /// <summary>
        /// Generate images with Nano Banana 2, from a text prompt or by editing source images<br/>
        /// Generate one or more images with Nano Banana 2. The prompt is<br/>
        /// consumed by the model directly, without rewriting.<br/>
        /// Supplying source images turns the request into an edit: the model<br/>
        /// applies the prompt to the sources. Provide them either as<br/>
        /// `image_asset_identifiers` references (images already stored with<br/>
        /// Ideogram) or as raw `images` bytes (multipart requests only) — if both<br/>
        /// are supplied, the references win and the bytes are ignored. Without<br/>
        /// source images the prompt alone drives the generation.<br/>
        /// The output is served at the closest aspect ratio the model supports,<br/>
        /// at the requested `resolution_tier` (1K by default).<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageNanoBanana2Response> PostGenerateImageV2NanoBanana2Async(

            global::Ideogram.GenerateImageNanoBanana2Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate images with Nano Banana 2, from a text prompt or by editing source images<br/>
        /// Generate one or more images with Nano Banana 2. The prompt is<br/>
        /// consumed by the model directly, without rewriting.<br/>
        /// Supplying source images turns the request into an edit: the model<br/>
        /// applies the prompt to the sources. Provide them either as<br/>
        /// `image_asset_identifiers` references (images already stored with<br/>
        /// Ideogram) or as raw `images` bytes (multipart requests only) — if both<br/>
        /// are supplied, the references win and the bytes are ignored. Without<br/>
        /// source images the prompt alone drives the generation.<br/>
        /// The output is served at the closest aspect ratio the model supports,<br/>
        /// at the requested `resolution_tier` (1K by default).<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateImageNanoBanana2Response>> PostGenerateImageV2NanoBanana2AsResponseAsync(

            global::Ideogram.GenerateImageNanoBanana2Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate images with Nano Banana 2, from a text prompt or by editing source images<br/>
        /// Generate one or more images with Nano Banana 2. The prompt is<br/>
        /// consumed by the model directly, without rewriting.<br/>
        /// Supplying source images turns the request into an edit: the model<br/>
        /// applies the prompt to the sources. Provide them either as<br/>
        /// `image_asset_identifiers` references (images already stored with<br/>
        /// Ideogram) or as raw `images` bytes (multipart requests only) — if both<br/>
        /// are supplied, the references win and the bytes are ignored. Without<br/>
        /// source images the prompt alone drives the generation.<br/>
        /// The output is served at the closest aspect ratio the model supports,<br/>
        /// at the requested `resolution_tier` (1K by default).<br/>
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
        /// The prompt to generate images from, or the edit instruction to apply when source images are supplied. The model consumes it directly, without rewriting.
        /// </param>
        /// <param name="imageAssetIdentifiers">
        /// Existing upload or generated image assets to edit, by reference. Takes priority over `images` if both are supplied.
        /// </param>
        /// <param name="images">
        /// The source images to edit (max 10, max size 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifiers` is also supplied.
        /// </param>
        /// <param name="aspectRatio">
        /// The requested output aspect ratio, for example "1:1", "16:9", or "9:16". The output is served at the closest aspect ratio the model supports, at the requested resolution tier. Defaults to "1:1".
        /// </param>
        /// <param name="resolutionTier">
        /// The output resolution tier.<br/>
        /// Default Value: 1K
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageNanoBanana2Response> PostGenerateImageV2NanoBanana2Async(
            string prompt,
            bool? dryRun = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? imageAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? images = default,
            string? aspectRatio = default,
            global::Ideogram.GenerateImageNanoBanana2RequestResolutionTier? resolutionTier = default,
            int? numImages = default,
            int? seed = default,
            bool? async = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}