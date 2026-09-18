#nullable enable

namespace Ideogram
{
    public partial interface IImagesGenerateClient
    {
        /// <summary>
        /// Generate images with GPT Image 2.5 Flare, from a text prompt or by editing source images<br/>
        /// Generate one or more images with GPT Image 2.5 Flare — the fast<br/>
        /// variant of GPT Image 2.5, optimized for speed at quality comparable<br/>
        /// to GPT Image 2. The prompt is consumed by the model directly, without<br/>
        /// rewriting.<br/>
        /// Supplying source images turns the request into an edit: the model<br/>
        /// applies the prompt to the sources. Provide them either as<br/>
        /// `image_asset_identifiers` references (images already stored with<br/>
        /// Ideogram) or as raw `images` bytes (multipart requests only) — if both<br/>
        /// are supplied, the references win and the bytes are ignored. Without<br/>
        /// source images the prompt alone drives the generation.<br/>
        /// The output size follows `resolution` when provided, otherwise the<br/>
        /// closest size the model supports for `aspect_ratio`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageGptImage25FlareResponse> PostGenerateImageV2GptImage25FlareAsync(

            global::Ideogram.GenerateImageGptImage25FlareRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate images with GPT Image 2.5 Flare, from a text prompt or by editing source images<br/>
        /// Generate one or more images with GPT Image 2.5 Flare — the fast<br/>
        /// variant of GPT Image 2.5, optimized for speed at quality comparable<br/>
        /// to GPT Image 2. The prompt is consumed by the model directly, without<br/>
        /// rewriting.<br/>
        /// Supplying source images turns the request into an edit: the model<br/>
        /// applies the prompt to the sources. Provide them either as<br/>
        /// `image_asset_identifiers` references (images already stored with<br/>
        /// Ideogram) or as raw `images` bytes (multipart requests only) — if both<br/>
        /// are supplied, the references win and the bytes are ignored. Without<br/>
        /// source images the prompt alone drives the generation.<br/>
        /// The output size follows `resolution` when provided, otherwise the<br/>
        /// closest size the model supports for `aspect_ratio`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateImageGptImage25FlareResponse>> PostGenerateImageV2GptImage25FlareAsResponseAsync(

            global::Ideogram.GenerateImageGptImage25FlareRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate images with GPT Image 2.5 Flare, from a text prompt or by editing source images<br/>
        /// Generate one or more images with GPT Image 2.5 Flare — the fast<br/>
        /// variant of GPT Image 2.5, optimized for speed at quality comparable<br/>
        /// to GPT Image 2. The prompt is consumed by the model directly, without<br/>
        /// rewriting.<br/>
        /// Supplying source images turns the request into an edit: the model<br/>
        /// applies the prompt to the sources. Provide them either as<br/>
        /// `image_asset_identifiers` references (images already stored with<br/>
        /// Ideogram) or as raw `images` bytes (multipart requests only) — if both<br/>
        /// are supplied, the references win and the bytes are ignored. Without<br/>
        /// source images the prompt alone drives the generation.<br/>
        /// The output size follows `resolution` when provided, otherwise the<br/>
        /// closest size the model supports for `aspect_ratio`.<br/>
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
        /// The source images to edit (max 16, max size 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifiers` is also supplied.
        /// </param>
        /// <param name="mask">
        /// An optional mask applied to the first source image, as raw bytes (multipart requests only; JPEG, PNG, or WEBP, max 25MB). Fully transparent mask pixels mark the areas to edit; the mask must have the same dimensions as the first source image. Requires source images uploaded as raw `images` bytes in the same request; masks cannot be combined with `image_asset_identifiers`.
        /// </param>
        /// <param name="maskname">
        /// An optional mask applied to the first source image, as raw bytes (multipart requests only; JPEG, PNG, or WEBP, max 25MB). Fully transparent mask pixels mark the areas to edit; the mask must have the same dimensions as the first source image. Requires source images uploaded as raw `images` bytes in the same request; masks cannot be combined with `image_asset_identifiers`.
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