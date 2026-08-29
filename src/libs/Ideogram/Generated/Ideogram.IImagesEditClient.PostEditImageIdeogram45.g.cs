#nullable enable

namespace Ideogram
{
    public partial interface IImagesEditClient
    {
        /// <summary>
        /// Transform images with Ideogram 4.5 image-to-image, by asset id or by uploaded bytes<br/>
        /// Generate a new image conditioned on one or more source images, with an<br/>
        /// optional prompt to guide the transformation. Supply the sources either<br/>
        /// as `image_asset_identifiers` references (images already stored with<br/>
        /// Ideogram) or as raw `images` bytes (multipart requests only) — callers<br/>
        /// are never required to upload assets first. If both are supplied, the<br/>
        /// references win and the bytes are ignored. The first source is the<br/>
        /// primary image being transformed; any further sources are additional<br/>
        /// references.<br/>
        /// By default the request blocks until the output image is ready and<br/>
        /// returns it in `data`. Set `async` to true to return immediately after<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.EditImageIdeogram45Response> PostEditImageIdeogram45Async(

            global::Ideogram.EditImageIdeogram45Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transform images with Ideogram 4.5 image-to-image, by asset id or by uploaded bytes<br/>
        /// Generate a new image conditioned on one or more source images, with an<br/>
        /// optional prompt to guide the transformation. Supply the sources either<br/>
        /// as `image_asset_identifiers` references (images already stored with<br/>
        /// Ideogram) or as raw `images` bytes (multipart requests only) — callers<br/>
        /// are never required to upload assets first. If both are supplied, the<br/>
        /// references win and the bytes are ignored. The first source is the<br/>
        /// primary image being transformed; any further sources are additional<br/>
        /// references.<br/>
        /// By default the request blocks until the output image is ready and<br/>
        /// returns it in `data`. Set `async` to true to return immediately after<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.EditImageIdeogram45Response>> PostEditImageIdeogram45AsResponseAsync(

            global::Ideogram.EditImageIdeogram45Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transform images with Ideogram 4.5 image-to-image, by asset id or by uploaded bytes<br/>
        /// Generate a new image conditioned on one or more source images, with an<br/>
        /// optional prompt to guide the transformation. Supply the sources either<br/>
        /// as `image_asset_identifiers` references (images already stored with<br/>
        /// Ideogram) or as raw `images` bytes (multipart requests only) — callers<br/>
        /// are never required to upload assets first. If both are supplied, the<br/>
        /// references win and the bytes are ignored. The first source is the<br/>
        /// primary image being transformed; any further sources are additional<br/>
        /// references.<br/>
        /// By default the request blocks until the output image is ready and<br/>
        /// returns it in `data`. Set `async` to true to return immediately after<br/>
        /// the request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="prompt">
        /// Optional guidance for the transformation. Image-to-image conditions on the source images, so the model can run from the sources alone.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic rewriting of the edit instruction into the structured format the model consumes). `AUTO` (the default) and `ON` rewrite; `OFF` sends the prompt verbatim. Ignored when no prompt is supplied.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="imageAssetIdentifiers">
        /// Existing upload or generated image assets to transform, by reference. Takes priority over `images` if both are supplied.
        /// </param>
        /// <param name="images">
        /// The source images to transform (max 5, max size 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifiers` is also supplied.
        /// </param>
        /// <param name="numImages">
        /// The number of output images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// The output size: either "auto" (the default) or an exact size<br/>
        /// formatted as "WIDTHxHEIGHT", for example "1024x1024" or<br/>
        /// "1152x768". With "auto", the output uses the supported resolution<br/>
        /// closest to the first source image's dimensions. An exact size must<br/>
        /// have both dimensions multiples of 32 and at least 256px, the total<br/>
        /// size at most 2048x2048 pixels, and the aspect ratio at most 6:1.<br/>
        /// Pricing is tiered by total pixels: up to 1024x1024 bills as 1K,<br/>
        /// above that as 2K.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="async">
        /// When false (the default), the request blocks until the output image is ready and returns it in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.EditImageIdeogram45Response> PostEditImageIdeogram45Async(
            string? prompt = default,
            global::Ideogram.MagicPromptOption? magicPrompt = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? imageAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? images = default,
            int? numImages = default,
            string? size = default,
            global::Ideogram.EditImageIdeogram45RequestRenderingSpeed? renderingSpeed = default,
            int? seed = default,
            bool? async = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}