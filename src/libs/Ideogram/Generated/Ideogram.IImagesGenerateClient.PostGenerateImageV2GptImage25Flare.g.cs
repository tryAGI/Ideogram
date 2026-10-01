#nullable enable

namespace Ideogram
{
    public partial interface IImagesGenerateClient
    {
        /// <summary>
        /// Generate with GPT Image 2.5 Flare<br/>
        /// Generate images with GPT Image 2.5 Flare, the fast variant of GPT Image<br/>
        /// 2.5. Optionally upload source images as `images` using<br/>
        /// `multipart/form-data` to edit them with the prompt. Returns results<br/>
        /// directly by default; set `async` or supply a `webhook_url` to get a<br/>
        /// `generation_id` and poll `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageGptImage25FlareResponse> PostGenerateImageV2GptImage25FlareAsync(

            global::Ideogram.GenerateImageGptImage25FlareRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with GPT Image 2.5 Flare<br/>
        /// Generate images with GPT Image 2.5 Flare, the fast variant of GPT Image<br/>
        /// 2.5. Optionally upload source images as `images` using<br/>
        /// `multipart/form-data` to edit them with the prompt. Returns results<br/>
        /// directly by default; set `async` or supply a `webhook_url` to get a<br/>
        /// `generation_id` and poll `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateImageGptImage25FlareResponse>> PostGenerateImageV2GptImage25FlareAsResponseAsync(

            global::Ideogram.GenerateImageGptImage25FlareRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with GPT Image 2.5 Flare<br/>
        /// Generate images with GPT Image 2.5 Flare, the fast variant of GPT Image<br/>
        /// 2.5. Optionally upload source images as `images` using<br/>
        /// `multipart/form-data` to edit them with the prompt. Returns results<br/>
        /// directly by default; set `async` or supply a `webhook_url` to get a<br/>
        /// `generation_id` and poll `GET /v2/generations/{generation_id}`.
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
        /// Optional source images to edit (max 16, max 25MB each; JPEG, PNG, or WEBP). Multipart requests only.
        /// </param>
        /// <param name="mask">
        /// An optional mask for the first source image (max 25MB; JPEG, PNG, or WEBP). Multipart requests only. Fully transparent pixels mark the areas to edit. The mask must have the same dimensions as the first source image, and requires source `images` in the same request.
        /// </param>
        /// <param name="maskname">
        /// An optional mask for the first source image (max 25MB; JPEG, PNG, or WEBP). Multipart requests only. Fully transparent pixels mark the areas to edit. The mask must have the same dimensions as the first source image, and requires source `images` in the same request.
        /// </param>
        /// <param name="background">
        /// The output background. `transparent` returns images with an alpha channel, `opaque` forces a solid background, and `auto` lets the model decide from the prompt.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="quality">
        /// How much rendering effort the model spends. Lower tiers return sooner and cost less; `auto` lets the model choose, which it currently renders at `high`.<br/>
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
        /// <param name="aspectRatio">
        /// The requested output aspect ratio, for example "1:1", "16:9", or "9:16". Ignored when `resolution` is provided. Defaults to "1:1".
        /// </param>
        /// <param name="resolution">
        /// Exact output resolution, formatted as "WIDTHxHEIGHT", for example<br/>
        /// "2048x2048" or "1920x1088". When provided, this takes precedence<br/>
        /// over `aspect_ratio`. The dimensions must satisfy GPT Image 2.5 Flare<br/>
        /// constraints: each side is a multiple of 16, the largest side is at<br/>
        /// most 3840px, the long:short ratio is at most 3:1, and total pixels<br/>
        /// are between 655360 and 8294400 inclusive.
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageGptImage25FlareResponse> PostGenerateImageV2GptImage25FlareAsync(
            string prompt,
            bool? dryRun = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? imageAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? images = default,
            byte[]? mask = default,
            string? maskname = default,
            global::Ideogram.GenerateImageGptImage25FlareRequestBackground? background = default,
            global::Ideogram.GenerateImageGptImage25FlareRequestQuality? quality = default,
            int? numImages = default,
            int? seed = default,
            string? aspectRatio = default,
            string? resolution = default,
            bool? async = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}