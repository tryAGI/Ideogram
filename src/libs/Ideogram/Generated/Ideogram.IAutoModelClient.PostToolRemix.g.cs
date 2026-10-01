#nullable enable

namespace Ideogram
{
    public partial interface IAutoModelClient
    {
        /// <summary>
        /// Remix with automatic model selection<br/>
        /// Remix an image guided by a text prompt, with Ideogram choosing the<br/>
        /// model. Upload the source image as `image` using `multipart/form-data`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.ToolRemixResponse> PostToolRemixAsync(

            global::Ideogram.ToolRemixRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix with automatic model selection<br/>
        /// Remix an image guided by a text prompt, with Ideogram choosing the<br/>
        /// model. Upload the source image as `image` using `multipart/form-data`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ToolRemixResponse>> PostToolRemixAsResponseAsync(

            global::Ideogram.ToolRemixRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix with automatic model selection<br/>
        /// Remix an image guided by a text prompt, with Ideogram choosing the<br/>
        /// model. Upload the source image as `image` using `multipart/form-data`.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The prompt that guides the remix.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// The existing upload or generated image to transform. Supply this or `image`, never both. Omit `resolution` and `aspect_ratio` to keep its shape.
        /// </param>
        /// <param name="image">
        /// The image to remix (max 50MB; JPEG, PNG, or WEBP). Multipart requests only. The image is used only for this request and is not saved to your account.
        /// </param>
        /// <param name="imagename">
        /// The image to remix (max 50MB; JPEG, PNG, or WEBP). Multipart requests only. The image is used only for this request and is not saved to your account.
        /// </param>
        /// <param name="imageWeight">
        /// Optional. How closely the result should follow the source image, from 1 to 100. When omitted the selected model chooses its usual strength. Combining a weight with a `resolution` or `aspect_ratio` that changes the source's aspect ratio crops the source to the new shape; this is only available at the 1K tier and is rejected at 2K.
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from the images. The prompt takes precedence over the negative prompt. Not every model uses it.
        /// </param>
        /// <param name="resolution">
        /// The requested output resolution, formatted as "WIDTHxHEIGHT" (for example "1280x800"). The output uses the closest supported resolution in the matching 1K or 2K tier. Omit `aspect_ratio` when supplying a resolution. If `resolution_tier` is also supplied, it must match the tier these dimensions fall in. Combining a shape-changing value with `image_weight` requires the 1K tier.
        /// </param>
        /// <param name="aspectRatio">
        /// The requested output aspect ratio. Omit it to keep the source image's shape. `auto` also keeps the source shape. Omit `resolution` when supplying a concrete value. Combining a shape-changing value with `image_weight` requires the 1K tier.
        /// </param>
        /// <param name="resolutionTier">
        /// The output resolution tier. When omitted, the tier is inferred from `resolution`, or defaults to 1k. A color palette, style codes, style preset, or non-`auto` style type are only supported at 1k.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `auto`. The selected model decides how to interpret it.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="seed">
        /// Optional. Only honored when the request uses a model that supports reproducible remixes; results from the default model are not reproducible. The response reports the seed used.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="styleReferenceAssetIdentifiers">
        /// Existing upload or generated image assets whose style should guide the remix, by reference. Supplying style references restricts the server to a model that supports them and requires the 1K resolution tier. Ignored if `style_reference_collection_id` is also supplied.
        /// </param>
        /// <param name="styleReferenceCollectionId">
        /// A saved style to apply, by its URL-safe base64 collection id. Limits the request to a model that supports style references and requires the 1K resolution tier.
        /// </param>
        /// <param name="styleReferenceCollectionVersionId">
        /// Optional URL-safe base64 version id of the saved style in `style_reference_collection_id`. Ignored without it.
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset to apply. Limits the request to a model that supports it and requires the 1K resolution tier. Cannot be combined with style codes.
        /// </param>
        /// <param name="colorPalette">
        /// A color palette to apply. Limits the request to a model that supports palettes and requires the 1K resolution tier.
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </param>
        /// <param name="styleType">
        /// The style type to generate with. A value other than `auto` limits the request to a model that supports it and requires the 1K resolution tier.
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
        /// Whether the generated images should be kept private. Omitted or true keeps them private. False publishes them unless the caller's plan always generates privately.
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. The output images are added to it when the request completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ToolRemixResponse> PostToolRemixAsync(
            string prompt,
            bool? dryRun = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            int? imageWeight = default,
            string? negativePrompt = default,
            string? resolution = default,
            global::Ideogram.IdeogramV4AspectRatio? aspectRatio = default,
            global::Ideogram.ToolRemixRequestResolutionTier? resolutionTier = default,
            global::Ideogram.MagicPromptMode? magicPrompt = default,
            int? seed = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? styleReferenceAssetIdentifiers = default,
            string? styleReferenceCollectionId = default,
            string? styleReferenceCollectionVersionId = default,
            global::Ideogram.IdeogramV3StylePreset? stylePreset = default,
            global::Ideogram.IdeogramColorPalette? colorPalette = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::Ideogram.IdeogramV3StyleType? styleType = default,
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