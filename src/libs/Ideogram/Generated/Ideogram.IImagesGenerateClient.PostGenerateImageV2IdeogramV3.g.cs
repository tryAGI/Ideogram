#nullable enable

namespace Ideogram
{
    public partial interface IImagesGenerateClient
    {
        /// <summary>
        /// Generate with Ideogram 3.0<br/>
        /// Generate images from a text prompt with Ideogram 3.0. Optional style<br/>
        /// controls include style codes, a style preset, a color palette, and style<br/>
        /// references (uploaded `style_reference_images`). Returns<br/>
        /// results directly by default; set `async` or supply a `webhook_url` to<br/>
        /// get a `generation_id` and poll `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageIdeogramV3Response> PostGenerateImageV2IdeogramV3Async(

            global::Ideogram.GenerateImageIdeogramV3Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with Ideogram 3.0<br/>
        /// Generate images from a text prompt with Ideogram 3.0. Optional style<br/>
        /// controls include style codes, a style preset, a color palette, and style<br/>
        /// references (uploaded `style_reference_images`). Returns<br/>
        /// results directly by default; set `async` or supply a `webhook_url` to<br/>
        /// get a `generation_id` and poll `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateImageIdeogramV3Response>> PostGenerateImageV2IdeogramV3AsResponseAsync(

            global::Ideogram.GenerateImageIdeogramV3Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with Ideogram 3.0<br/>
        /// Generate images from a text prompt with Ideogram 3.0. Optional style<br/>
        /// controls include style codes, a style preset, a color palette, and style<br/>
        /// references (uploaded `style_reference_images`). Returns<br/>
        /// results directly by default; set `async` or supply a `webhook_url` to<br/>
        /// get a `generation_id` and poll `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The prompt to generate images from.
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from the images. The prompt takes precedence over the negative prompt.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.<br/>
        /// Example: 1280x800
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio for an Ideogram 3.x or 2.x generation. `auto` lets the<br/>
        /// model select a ratio from the prompt; any other value pins the ratio.<br/>
        /// Cannot be combined with `resolution`. Omitting the field is not `auto`:<br/>
        /// it uses `1x1`.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="colorPalette">
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members).
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </param>
        /// <param name="styleType">
        /// The style type to generate with.<br/>
        /// Default Value: general<br/>
        /// Example: general
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset to apply to the generated images. Cannot be combined with style codes or style references.
        /// </param>
        /// <param name="styleReferenceCollectionId">
        /// A saved style to apply, by its URL-safe base64 collection id. Cannot be combined with `style_reference_images`.
        /// </param>
        /// <param name="styleReferenceCollectionVersionId">
        /// Optional URL-safe base64 version id of the saved style in `style_reference_collection_id`. Ignored without it.
        /// </param>
        /// <param name="styleReferenceAssetIdentifiers">
        /// Existing upload or generated image assets to use as style references, by reference. Cannot be combined with `style_reference_collection_id` or `style_reference_images`.
        /// </param>
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max 25MB each; JPEG, PNG, or WEBP).
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageIdeogramV3Response> PostGenerateImageV2IdeogramV3Async(
            string prompt,
            bool? dryRun = default,
            string? negativePrompt = default,
            int? seed = default,
            global::Ideogram.ResolutionV3? resolution = default,
            global::Ideogram.IdeogramV3AspectRatio? aspectRatio = default,
            global::Ideogram.GenerateImageIdeogramV3RequestRenderingSpeed? renderingSpeed = default,
            global::Ideogram.MagicPromptMode? magicPrompt = default,
            int? numImages = default,
            global::Ideogram.IdeogramColorPalette? colorPalette = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::Ideogram.IdeogramV3StyleType? styleType = default,
            global::Ideogram.IdeogramV3StylePreset? stylePreset = default,
            string? styleReferenceCollectionId = default,
            string? styleReferenceCollectionVersionId = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? styleReferenceAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}