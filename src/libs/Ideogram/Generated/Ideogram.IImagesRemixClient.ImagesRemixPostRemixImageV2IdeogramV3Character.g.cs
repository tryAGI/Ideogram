#nullable enable

namespace Ideogram
{
    public partial interface IImagesRemixClient
    {
        /// <summary>
        /// Remix a consistent character with Ideogram 3.0<br/>
        /// Transform an existing image with Ideogram 3.0 so it features a<br/>
        /// consistent character, guided by a text prompt. Upload the source<br/>
        /// `image` and a `character_reference_images` image (or use a saved<br/>
        /// character) using `multipart/form-data`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.RemixImageIdeogramV3CharacterResponse> ImagesRemixPostRemixImageV2IdeogramV3CharacterAsync(

            global::Ideogram.ImagesRemixPostRemixImageV2IdeogramV3CharacterRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix a consistent character with Ideogram 3.0<br/>
        /// Transform an existing image with Ideogram 3.0 so it features a<br/>
        /// consistent character, guided by a text prompt. Upload the source<br/>
        /// `image` and a `character_reference_images` image (or use a saved<br/>
        /// character) using `multipart/form-data`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.RemixImageIdeogramV3CharacterResponse>> ImagesRemixPostRemixImageV2IdeogramV3CharacterAsResponseAsync(

            global::Ideogram.ImagesRemixPostRemixImageV2IdeogramV3CharacterRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix a consistent character with Ideogram 3.0<br/>
        /// Transform an existing image with Ideogram 3.0 so it features a<br/>
        /// consistent character, guided by a text prompt. Upload the source<br/>
        /// `image` and a `character_reference_images` image (or use a saved<br/>
        /// character) using `multipart/form-data`.<br/>
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
        /// <param name="characterReferenceImages">
        /// An image to use as the character reference (max 25MB). JPEG, PNG, and WEBP are supported.
        /// </param>
        /// <param name="characterReferenceMask">
        /// Optional grayscale mask for the character reference image, the same size as that image, marking where the character is. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; cannot be combined with `character_reference_collection_id`.
        /// </param>
        /// <param name="characterReferenceMaskname">
        /// Optional grayscale mask for the character reference image, the same size as that image, marking where the character is. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; cannot be combined with `character_reference_collection_id`.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Cannot be combined with resolution. Generation defaults to 1x1; remix keeps the source ratio when both fields are omitted.
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
        /// The style type to remix the character with. Defaults to `auto`.<br/>
        /// Default Value: auto
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
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.RemixImageIdeogramV3CharacterResponse> ImagesRemixPostRemixImageV2IdeogramV3CharacterAsync(
            string prompt,
            byte[] image,
            string imagename,
            global::System.Collections.Generic.IList<byte[]> characterReferenceImages,
            bool? dryRun = default,
            int? imageWeight = default,
            string? negativePrompt = default,
            byte[]? characterReferenceMask = default,
            string? characterReferenceMaskname = default,
            int? seed = default,
            global::Ideogram.ResolutionV3? resolution = default,
            global::Ideogram.AspectRatioV3? aspectRatio = default,
            global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed = default,
            global::Ideogram.MagicPromptMode? magicPrompt = default,
            int? numImages = default,
            global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType? styleType = default,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remix a consistent character with Ideogram 3.0<br/>
        /// Transform an existing image with Ideogram 3.0 so it features a<br/>
        /// consistent character, guided by a text prompt. Upload the source<br/>
        /// `image` and a `character_reference_images` image (or use a saved<br/>
        /// character) using `multipart/form-data`.<br/>
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
        /// <param name="characterReferenceImages">
        /// An image to use as the character reference (max 25MB). JPEG, PNG, and WEBP are supported.
        /// </param>
        /// <param name="characterReferenceImagesFileNames">
        /// Optional file names to use for the multipart 'character_reference_images' file parts.
        /// </param>
        /// <param name="characterReferenceMask">
        /// Optional grayscale mask for the character reference image, the same size as that image, marking where the character is. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; cannot be combined with `character_reference_collection_id`.
        /// </param>
        /// <param name="characterReferenceMaskname">
        /// Optional grayscale mask for the character reference image, the same size as that image, marking where the character is. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; cannot be combined with `character_reference_collection_id`.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Cannot be combined with resolution. Generation defaults to 1x1; remix keeps the source ratio when both fields are omitted.
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
        /// The style type to remix the character with. Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max 25MB each). JPEG, PNG, and WEBP are supported.
        /// </param>
        /// <param name="styleReferenceImagesFileNames">
        /// Optional file names to use for the multipart 'style_reference_images' file parts.
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
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.RemixImageIdeogramV3CharacterResponse> ImagesRemixPostRemixImageV2IdeogramV3CharacterAsync(
            string prompt,
            global::System.IO.Stream image,
            string imagename,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> characterReferenceImages,
            bool? dryRun = default,
            int? imageWeight = default,
            string? negativePrompt = default,
            global::System.Collections.Generic.IReadOnlyList<string>? characterReferenceImagesFileNames = default,
            global::System.IO.Stream? characterReferenceMask = default,
            string? characterReferenceMaskname = default,
            int? seed = default,
            global::Ideogram.ResolutionV3? resolution = default,
            global::Ideogram.AspectRatioV3? aspectRatio = default,
            global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed = default,
            global::Ideogram.MagicPromptMode? magicPrompt = default,
            int? numImages = default,
            global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType? styleType = default,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? styleReferenceImages = default,
            global::System.Collections.Generic.IReadOnlyList<string>? styleReferenceImagesFileNames = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix a consistent character with Ideogram 3.0<br/>
        /// Transform an existing image with Ideogram 3.0 so it features a<br/>
        /// consistent character, guided by a text prompt. Upload the source<br/>
        /// `image` and a `character_reference_images` image (or use a saved<br/>
        /// character) using `multipart/form-data`.<br/>
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
        /// <param name="characterReferenceImages">
        /// An image to use as the character reference (max 25MB). JPEG, PNG, and WEBP are supported.
        /// </param>
        /// <param name="characterReferenceImagesFileNames">
        /// Optional file names to use for the multipart 'character_reference_images' file parts.
        /// </param>
        /// <param name="characterReferenceMask">
        /// Optional grayscale mask for the character reference image, the same size as that image, marking where the character is. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; cannot be combined with `character_reference_collection_id`.
        /// </param>
        /// <param name="characterReferenceMaskname">
        /// Optional grayscale mask for the character reference image, the same size as that image, marking where the character is. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; cannot be combined with `character_reference_collection_id`.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Cannot be combined with resolution. Generation defaults to 1x1; remix keeps the source ratio when both fields are omitted.
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
        /// The style type to remix the character with. Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max 25MB each). JPEG, PNG, and WEBP are supported.
        /// </param>
        /// <param name="styleReferenceImagesFileNames">
        /// Optional file names to use for the multipart 'style_reference_images' file parts.
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
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.RemixImageIdeogramV3CharacterResponse>> ImagesRemixPostRemixImageV2IdeogramV3CharacterAsResponseAsync(
            string prompt,
            global::System.IO.Stream image,
            string imagename,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> characterReferenceImages,
            bool? dryRun = default,
            int? imageWeight = default,
            string? negativePrompt = default,
            global::System.Collections.Generic.IReadOnlyList<string>? characterReferenceImagesFileNames = default,
            global::System.IO.Stream? characterReferenceMask = default,
            string? characterReferenceMaskname = default,
            int? seed = default,
            global::Ideogram.ResolutionV3? resolution = default,
            global::Ideogram.AspectRatioV3? aspectRatio = default,
            global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed = default,
            global::Ideogram.MagicPromptMode? magicPrompt = default,
            int? numImages = default,
            global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType? styleType = default,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? styleReferenceImages = default,
            global::System.Collections.Generic.IReadOnlyList<string>? styleReferenceImagesFileNames = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}