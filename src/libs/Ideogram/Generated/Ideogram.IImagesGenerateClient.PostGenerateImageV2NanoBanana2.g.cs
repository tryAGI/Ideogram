#nullable enable

namespace Ideogram
{
    public partial interface IImagesGenerateClient
    {
        /// <summary>
        /// Generate with Nano Banana 2<br/>
        /// Generate images with Nano Banana 2. Optionally upload source images as<br/>
        /// `images` using `multipart/form-data` to edit them with the prompt.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
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
        /// Generate with Nano Banana 2<br/>
        /// Generate images with Nano Banana 2. Optionally upload source images as<br/>
        /// `images` using `multipart/form-data` to edit them with the prompt.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
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
        /// Generate with Nano Banana 2<br/>
        /// Generate images with Nano Banana 2. Optionally upload source images as<br/>
        /// `images` using `multipart/form-data` to edit them with the prompt.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The prompt to generate images from, or the edit instruction to apply when source images are supplied. It is passed to the model as written.
        /// </param>
        /// <param name="imageAssetIdentifiers">
        /// Existing upload or generated image assets to edit, by reference. Takes priority over `images` if both are supplied.
        /// </param>
        /// <param name="images">
        /// Optional source images to edit (max 10, max 25MB each; JPEG, PNG, or WEBP). Multipart requests only.
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