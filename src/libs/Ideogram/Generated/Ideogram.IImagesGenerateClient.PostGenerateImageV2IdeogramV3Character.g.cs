#nullable enable

namespace Ideogram
{
    public partial interface IImagesGenerateClient
    {
        /// <summary>
        /// Generate a consistent character with Ideogram 3.0<br/>
        /// Generate images featuring a consistent character with Ideogram 3.0.<br/>
        /// Upload the character as `character_reference_images` using<br/>
        /// `multipart/form-data`. Returns<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageIdeogramV3CharacterResponse> PostGenerateImageV2IdeogramV3CharacterAsync(

            global::Ideogram.GenerateImageIdeogramV3CharacterRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a consistent character with Ideogram 3.0<br/>
        /// Generate images featuring a consistent character with Ideogram 3.0.<br/>
        /// Upload the character as `character_reference_images` using<br/>
        /// `multipart/form-data`. Returns<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateImageIdeogramV3CharacterResponse>> PostGenerateImageV2IdeogramV3CharacterAsResponseAsync(

            global::Ideogram.GenerateImageIdeogramV3CharacterRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a consistent character with Ideogram 3.0<br/>
        /// Generate images featuring a consistent character with Ideogram 3.0.<br/>
        /// Upload the character as `character_reference_images` using<br/>
        /// `multipart/form-data`. Returns<br/>
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
        /// <param name="characterReferenceCollectionId">
        /// A saved character to feature, by its URL-safe base64 collection id. Takes priority over `character_reference_images` if both are supplied.
        /// </param>
        /// <param name="characterReferenceCollectionVersionId">
        /// Optional URL-safe base64 version id of the saved character in `character_reference_collection_id`. Ignored without it.
        /// </param>
        /// <param name="characterReferenceAssetIdentifiers">
        /// An existing upload or generated image asset to use as the character reference, by reference. Takes priority over `character_reference_images` if both are supplied.
        /// </param>
        /// <param name="characterReferenceImages">
        /// An image of the character to feature (max 25MB; JPEG, PNG, or WEBP).
        /// </param>
        /// <param name="characterReferenceMask">
        /// Optional grayscale mask marking where the character is in the `character_reference_images` image, at the same size as that image (JPEG, PNG, or WEBP). Multipart requests only.
        /// </param>
        /// <param name="characterReferenceMaskname">
        /// Optional grayscale mask marking where the character is in the `character_reference_images` image, at the same size as that image (JPEG, PNG, or WEBP). Multipart requests only.
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
        /// <param name="styleType">
        /// The style type to generate the character with. Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="styleReferenceCollectionId">
        /// A saved style to apply, by its URL-safe base64 collection id. Takes priority over `style_reference_images` if both are supplied.
        /// </param>
        /// <param name="styleReferenceCollectionVersionId">
        /// Optional URL-safe base64 version id of the saved style in `style_reference_collection_id`. Ignored without it.
        /// </param>
        /// <param name="styleReferenceAssetIdentifiers">
        /// Existing upload or generated image assets to use as style references, by reference. Takes priority over `style_reference_images` if both are supplied.
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageIdeogramV3CharacterResponse> PostGenerateImageV2IdeogramV3CharacterAsync(
            string prompt,
            bool? dryRun = default,
            string? negativePrompt = default,
            string? characterReferenceCollectionId = default,
            string? characterReferenceCollectionVersionId = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? characterReferenceAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? characterReferenceImages = default,
            byte[]? characterReferenceMask = default,
            string? characterReferenceMaskname = default,
            int? seed = default,
            global::Ideogram.ResolutionV3? resolution = default,
            global::Ideogram.IdeogramV3AspectRatio? aspectRatio = default,
            global::Ideogram.GenerateImageIdeogramV3CharacterRequestRenderingSpeed? renderingSpeed = default,
            global::Ideogram.MagicPromptMode? magicPrompt = default,
            int? numImages = default,
            global::Ideogram.GenerateImageIdeogramV3CharacterRequestStyleType? styleType = default,
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