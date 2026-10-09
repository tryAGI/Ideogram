#nullable enable

namespace Ideogram
{
    public partial interface IImagesGenerateClient
    {
        /// <summary>
        /// Generate with Ideogram 4.5<br/>
        /// Generate images with Ideogram 4.5 from a natural-language or structured<br/>
        /// JSON prompt. Optionally upload source images as `images` using<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageIdeogram45Response> PostGenerateImageV2Ideogram45Async(

            global::Ideogram.GenerateImageIdeogram45Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with Ideogram 4.5<br/>
        /// Generate images with Ideogram 4.5 from a natural-language or structured<br/>
        /// JSON prompt. Optionally upload source images as `images` using<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateImageIdeogram45Response>> PostGenerateImageV2Ideogram45AsResponseAsync(

            global::Ideogram.GenerateImageIdeogram45Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with Ideogram 4.5<br/>
        /// Generate images with Ideogram 4.5 from a natural-language or structured<br/>
        /// JSON prompt. Optionally upload source images as `images` using<br/>
        /// `multipart/form-data` to edit them with the prompt. Returns results<br/>
        /// directly by default; set `async` or supply a `webhook_url` to get a<br/>
        /// `generation_id` and poll `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The prompt to generate images from, or the edit instruction when<br/>
        /// source images are supplied. Natural language or a structured<br/>
        /// Ideogram 4.0 JSON prompt.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls how a natural-language prompt is prepared. `auto` (the<br/>
        /// default) and `on` rewrite and expand the prompt before generation.<br/>
        /// `off` keeps your wording and only converts it into a structured<br/>
        /// prompt. A valid structured JSON prompt skips magic prompt unless<br/>
        /// `magic_prompt` is `on`. With source images, every mode converts<br/>
        /// the edit instruction into a structured edit prompt.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="imageAssetIdentifiers">
        /// Existing upload or generated image assets to transform, by reference. Takes priority over `images` if both are supplied. The first source is the primary image; any further sources are additional references. Supplying sources turns the request into an image-to-image transform.
        /// </param>
        /// <param name="images">
        /// Optional source images to edit (max 5, max 25MB each; JPEG, PNG, or WEBP). The first image is the one being edited; any others are extra references. Multipart requests only.
        /// </param>
        /// <param name="mask">
        /// An optional mask that limits the edit to part of the first source image (max 25MB; JPEG, PNG, or WEBP). Multipart requests only. Black marks the area to edit and white the area to keep; values in between are rounded to the nearer of the two. The mask must have the same width and height as the first source image and contain both black and white areas. A masked request can include at most three other source images. With a mask, the output is always the first source image's own size, so `size` cannot be set.
        /// </param>
        /// <param name="maskname">
        /// An optional mask that limits the edit to part of the first source image (max 25MB; JPEG, PNG, or WEBP). Multipart requests only. Black marks the area to edit and white the area to keep; values in between are rounded to the nearer of the two. The mask must have the same width and height as the first source image and contain both black and white areas. A masked request can include at most three other source images. With a mask, the output is always the first source image's own size, so `size` cannot be set.
        /// </param>
        /// <param name="size">
        /// The output size: "auto", "source" or an exact "WIDTHxHEIGHT".<br/>
        /// Without source images, an exact size must be one of the supported<br/>
        /// 1K/2K presets (for example 1024x1024, 2048x2048 or 1440x2880);<br/>
        /// "auto" or omitted picks a supported size based on the prompt.<br/>
        /// "source" is rejected.<br/>
        /// With source images, "auto" (the default) picks a supported 2K size<br/>
        /// based on the source images and the prompt, and "source" returns the<br/>
        /// output at the first source image's own width and height (scaled<br/>
        /// down, keeping its proportions, if it is too large for the model).<br/>
        /// Every source image's aspect ratio must be between 1:6 and 6:1.<br/>
        /// An exact size must have both sides a multiple of 32 and at least<br/>
        /// 256px, a total of at most 2048x2048 pixels, and an aspect ratio of<br/>
        /// at most 6:1. With source images, an exact size reshapes the source<br/>
        /// to it.<br/>
        /// Pricing is tiered by the resolved output pixels: up to 1024x1024<br/>
        /// bills as 1K, above that as 2K. An "auto" size bills as 2K.<br/>
        /// Default Value: auto<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="background">
        /// The output background. `transparent` returns images with an alpha channel, `opaque` returns a solid one, and `auto` decides for you.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="quality">
        /// The rendering quality to use. Higher quality takes longer and costs more. Defaults to `medium` with source images and `high` without. `very_low`, the fastest and cheapest, requires source images.
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageIdeogram45Response> PostGenerateImageV2Ideogram45Async(
            string prompt,
            bool? dryRun = default,
            global::Ideogram.MagicPromptMode? magicPrompt = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? imageAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? images = default,
            byte[]? mask = default,
            string? maskname = default,
            string? size = default,
            global::Ideogram.GenerateImageIdeogram45RequestBackground? background = default,
            global::Ideogram.GenerateImageIdeogram45RequestQuality? quality = default,
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