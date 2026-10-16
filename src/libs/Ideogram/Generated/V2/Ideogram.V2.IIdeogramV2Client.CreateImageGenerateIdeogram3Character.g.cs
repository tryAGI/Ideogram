#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
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
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.GenerateImageIdeogramV3CharacterResponse> CreateImageGenerateIdeogram3CharacterAsync(

            global::Ideogram.V2.ImagesGeneratePostGenerateImageV2IdeogramV3CharacterRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
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
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.GenerateImageIdeogramV3CharacterResponse>> CreateImageGenerateIdeogram3CharacterAsResponseAsync(

            global::Ideogram.V2.ImagesGeneratePostGenerateImageV2IdeogramV3CharacterRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="characterReferenceImages">
        /// An image of the character to feature (max 25MB; JPEG, PNG, or WEBP).
        /// </param>
        /// <param name="characterReferenceMask">
        /// Optional grayscale mask marking where the character is in the character reference image, at the same size as that image (JPEG, PNG, or WEBP). Multipart requests only.
        /// </param>
        /// <param name="characterReferenceMaskname">
        /// Optional grayscale mask marking where the character is in the character reference image, at the same size as that image (JPEG, PNG, or WEBP). Multipart requests only.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.
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
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.GenerateImageIdeogramV3CharacterResponse> CreateImageGenerateIdeogram3CharacterAsync(
            string prompt,
            global::System.Collections.Generic.IList<byte[]> characterReferenceImages,
            bool? dryRun = default,
            string? negativePrompt = default,
            byte[]? characterReferenceMask = default,
            string? characterReferenceMaskname = default,
            int? seed = default,
            global::Ideogram.V2.ResolutionV3? resolution = default,
            global::Ideogram.V2.IdeogramV3AspectRatio? aspectRatio = default,
            global::Ideogram.V2.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed = default,
            global::Ideogram.V2.MagicPromptMode? magicPrompt = default,
            int? numImages = default,
            global::Ideogram.V2.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType? styleType = default,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="characterReferenceImages">
        /// An image of the character to feature (max 25MB; JPEG, PNG, or WEBP).
        /// </param>
        /// <param name="characterReferenceImagesFileNames">
        /// Optional file names to use for the multipart 'character_reference_images' file parts.
        /// </param>
        /// <param name="characterReferenceMask">
        /// Optional grayscale mask marking where the character is in the character reference image, at the same size as that image (JPEG, PNG, or WEBP). Multipart requests only.
        /// </param>
        /// <param name="characterReferenceMaskname">
        /// Optional grayscale mask marking where the character is in the character reference image, at the same size as that image (JPEG, PNG, or WEBP). Multipart requests only.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.
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
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max 25MB each; JPEG, PNG, or WEBP).
        /// </param>
        /// <param name="styleReferenceImagesFileNames">
        /// Optional file names to use for the multipart 'style_reference_images' file parts.
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
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.GenerateImageIdeogramV3CharacterResponse> CreateImageGenerateIdeogram3CharacterAsync(
            string prompt,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> characterReferenceImages,
            bool? dryRun = default,
            string? negativePrompt = default,
            global::System.Collections.Generic.IReadOnlyList<string>? characterReferenceImagesFileNames = default,
            global::System.IO.Stream? characterReferenceMask = default,
            string? characterReferenceMaskname = default,
            int? seed = default,
            global::Ideogram.V2.ResolutionV3? resolution = default,
            global::Ideogram.V2.IdeogramV3AspectRatio? aspectRatio = default,
            global::Ideogram.V2.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed = default,
            global::Ideogram.V2.MagicPromptMode? magicPrompt = default,
            int? numImages = default,
            global::Ideogram.V2.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType? styleType = default,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? styleReferenceImages = default,
            global::System.Collections.Generic.IReadOnlyList<string>? styleReferenceImagesFileNames = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="characterReferenceImages">
        /// An image of the character to feature (max 25MB; JPEG, PNG, or WEBP).
        /// </param>
        /// <param name="characterReferenceImagesFileNames">
        /// Optional file names to use for the multipart 'character_reference_images' file parts.
        /// </param>
        /// <param name="characterReferenceMask">
        /// Optional grayscale mask marking where the character is in the character reference image, at the same size as that image (JPEG, PNG, or WEBP). Multipart requests only.
        /// </param>
        /// <param name="characterReferenceMaskname">
        /// Optional grayscale mask marking where the character is in the character reference image, at the same size as that image (JPEG, PNG, or WEBP). Multipart requests only.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.
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
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max 25MB each; JPEG, PNG, or WEBP).
        /// </param>
        /// <param name="styleReferenceImagesFileNames">
        /// Optional file names to use for the multipart 'style_reference_images' file parts.
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
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.GenerateImageIdeogramV3CharacterResponse>> CreateImageGenerateIdeogram3CharacterAsResponseAsync(
            string prompt,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> characterReferenceImages,
            bool? dryRun = default,
            string? negativePrompt = default,
            global::System.Collections.Generic.IReadOnlyList<string>? characterReferenceImagesFileNames = default,
            global::System.IO.Stream? characterReferenceMask = default,
            string? characterReferenceMaskname = default,
            int? seed = default,
            global::Ideogram.V2.ResolutionV3? resolution = default,
            global::Ideogram.V2.IdeogramV3AspectRatio? aspectRatio = default,
            global::Ideogram.V2.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed = default,
            global::Ideogram.V2.MagicPromptMode? magicPrompt = default,
            int? numImages = default,
            global::Ideogram.V2.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType? styleType = default,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? styleReferenceImages = default,
            global::System.Collections.Generic.IReadOnlyList<string>? styleReferenceImagesFileNames = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}