#nullable enable

namespace Ideogram
{
    public partial interface IImagesRemixClient
    {
        /// <summary>
        /// Remix with Ideogram 3.0<br/>
        /// Transform an existing image with Ideogram 3.0, guided by a text<br/>
        /// prompt. Upload the source `image` using `multipart/form-data`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.RemixImageIdeogramV3Response> PostRemixImageV2IdeogramV3Async(

            global::Ideogram.RemixImageIdeogramV3Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix with Ideogram 3.0<br/>
        /// Transform an existing image with Ideogram 3.0, guided by a text<br/>
        /// prompt. Upload the source `image` using `multipart/form-data`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.RemixImageIdeogramV3Response>> PostRemixImageV2IdeogramV3AsResponseAsync(

            global::Ideogram.RemixImageIdeogramV3Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix with Ideogram 3.0<br/>
        /// Transform an existing image with Ideogram 3.0, guided by a text<br/>
        /// prompt. Upload the source `image` using `multipart/form-data`.<br/>
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
        /// The existing upload or generated image to transform. Supply this or `image`, never both. Omit `resolution` and `aspect_ratio` to keep its shape; a different requested shape center-crops the source to fit first.
        /// </param>
        /// <param name="image">
        /// The image to transform (max 50MB). JPEG, PNG, and WEBP are supported. Multipart requests only. The uploaded image is saved to your account as the remix's source. Omit `resolution` and `aspect_ratio` to keep its shape; a different requested shape center-crops the source to fit first.
        /// </param>
        /// <param name="imagename">
        /// The image to transform (max 50MB). JPEG, PNG, and WEBP are supported. Multipart requests only. The uploaded image is saved to your account as the remix's source. Omit `resolution` and `aspect_ratio` to keep its shape; a different requested shape center-crops the source to fit first.
        /// </param>
        /// <param name="imageWeight">
        /// Optional. How closely the result should follow the source image, from 1 to 100. When omitted the server chooses a value from your prompt, which is the usual case.
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from the images. Descriptions in the prompt take precedence over descriptions in the negative prompt.
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
        /// The aspect ratio to use for image generation, which determines the image's resolution. Cannot be used in conjunction with resolution. Defaults to 1x1.
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
        /// A predefined style preset to apply to the remixed images. Cannot be combined with style codes or style references.
        /// </param>
        /// <param name="styleReferenceCollectionId">
        /// A saved style to apply, by its URL-safe base64 collection id. Cannot be combined with `style_reference_images`.
        /// </param>
        /// <param name="styleReferenceCollectionVersionId">
        /// Optional URL-safe base64 version id pinning a specific version of the `style_reference_collection_id` collection. Ignored without it.
        /// </param>
        /// <param name="styleReferenceAssetIdentifiers">
        /// Existing upload or generated image assets to use as style references, by reference. Cannot be combined with `style_reference_collection_id` or `style_reference_images`.
        /// </param>
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max 25MB each). JPEG, PNG, and WEBP are supported.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request waits until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v2/generations/{generation_id}` using the returned `generation_id`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.RemixImageIdeogramV3Response> PostRemixImageV2IdeogramV3Async(
            string prompt,
            bool? dryRun = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            int? imageWeight = default,
            string? negativePrompt = default,
            int? seed = default,
            global::Ideogram.ResolutionV3? resolution = default,
            global::Ideogram.AspectRatioV3? aspectRatio = default,
            global::Ideogram.RemixImageIdeogramV3RequestRenderingSpeed? renderingSpeed = default,
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