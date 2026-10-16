#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// Inpaint a consistent character with Ideogram 3.0<br/>
        /// Repaint the masked region of a source image with Ideogram 3.0 so it<br/>
        /// features a consistent character. Upload the source `image`, its<br/>
        /// `mask`, and a `character_reference_images` image (or use a saved<br/>
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
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.InpaintImageIdeogramV3CharacterResponse> CreateImageInpaintIdeogram3CharacterAsync(

            global::Ideogram.V2.ImagesInpaintPostInpaintImageV2IdeogramV3CharacterRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Inpaint a consistent character with Ideogram 3.0<br/>
        /// Repaint the masked region of a source image with Ideogram 3.0 so it<br/>
        /// features a consistent character. Upload the source `image`, its<br/>
        /// `mask`, and a `character_reference_images` image (or use a saved<br/>
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
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.InpaintImageIdeogramV3CharacterResponse>> CreateImageInpaintIdeogram3CharacterAsResponseAsync(

            global::Ideogram.V2.ImagesInpaintPostInpaintImageV2IdeogramV3CharacterRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Inpaint a consistent character with Ideogram 3.0<br/>
        /// Repaint the masked region of a source image with Ideogram 3.0 so it<br/>
        /// features a consistent character. Upload the source `image`, its<br/>
        /// `mask`, and a `character_reference_images` image (or use a saved<br/>
        /// character) using `multipart/form-data`.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The prompt describing the repainted result.
        /// </param>
        /// <param name="image">
        /// The source image to repaint (max 25MB). JPEG, PNG, and WEBP are supported. Multipart requests only. The output matches its size, snapped to the nearest supported resolution.
        /// </param>
        /// <param name="imagename">
        /// The source image to repaint (max 25MB). JPEG, PNG, and WEBP are supported. Multipart requests only. The output matches its size, snapped to the nearest supported resolution.
        /// </param>
        /// <param name="mask">
        /// A black-and-white mask the same size as the source image. Black marks the region to repaint. JPEG, PNG, and WEBP are supported. Multipart requests only.
        /// </param>
        /// <param name="maskname">
        /// A black-and-white mask the same size as the source image. Black marks the region to repaint. JPEG, PNG, and WEBP are supported. Multipart requests only.
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
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="styleType">
        /// The style type to repaint the character with. Defaults to `auto`. `realistic` and `fiction` are supported for character-only requests; style codes or style references (not both) require `auto`. For API-key callers, combining a style with a character requires that feature to be enabled for their account.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.
        /// </param>
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max 25MB each). JPEG, PNG, and WEBP are supported. Cannot be combined with `style_codes`.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request waits until the repainted images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v2/generations/{generation_id}` using the returned `generation_id`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.V2.InpaintImageIdeogramV3CharacterResponse> CreateImageInpaintIdeogram3CharacterAsync(
            string prompt,
            byte[] image,
            string imagename,
            byte[] mask,
            string maskname,
            global::System.Collections.Generic.IList<byte[]> characterReferenceImages,
            bool? dryRun = default,
            byte[]? characterReferenceMask = default,
            string? characterReferenceMaskname = default,
            global::Ideogram.V2.MagicPromptMode? magicPrompt = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.V2.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed = default,
            global::Ideogram.V2.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType? styleType = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Inpaint a consistent character with Ideogram 3.0<br/>
        /// Repaint the masked region of a source image with Ideogram 3.0 so it<br/>
        /// features a consistent character. Upload the source `image`, its<br/>
        /// `mask`, and a `character_reference_images` image (or use a saved<br/>
        /// character) using `multipart/form-data`.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The prompt describing the repainted result.
        /// </param>
        /// <param name="image">
        /// The source image to repaint (max 25MB). JPEG, PNG, and WEBP are supported. Multipart requests only. The output matches its size, snapped to the nearest supported resolution.
        /// </param>
        /// <param name="imagename">
        /// The source image to repaint (max 25MB). JPEG, PNG, and WEBP are supported. Multipart requests only. The output matches its size, snapped to the nearest supported resolution.
        /// </param>
        /// <param name="mask">
        /// A black-and-white mask the same size as the source image. Black marks the region to repaint. JPEG, PNG, and WEBP are supported. Multipart requests only.
        /// </param>
        /// <param name="maskname">
        /// A black-and-white mask the same size as the source image. Black marks the region to repaint. JPEG, PNG, and WEBP are supported. Multipart requests only.
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
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="styleType">
        /// The style type to repaint the character with. Defaults to `auto`. `realistic` and `fiction` are supported for character-only requests; style codes or style references (not both) require `auto`. For API-key callers, combining a style with a character requires that feature to be enabled for their account.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.
        /// </param>
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max 25MB each). JPEG, PNG, and WEBP are supported. Cannot be combined with `style_codes`.
        /// </param>
        /// <param name="styleReferenceImagesFileNames">
        /// Optional file names to use for the multipart 'style_reference_images' file parts.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request waits until the repainted images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v2/generations/{generation_id}` using the returned `generation_id`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.V2.InpaintImageIdeogramV3CharacterResponse> CreateImageInpaintIdeogram3CharacterAsync(
            string prompt,
            global::System.IO.Stream image,
            string imagename,
            global::System.IO.Stream mask,
            string maskname,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> characterReferenceImages,
            bool? dryRun = default,
            global::System.Collections.Generic.IReadOnlyList<string>? characterReferenceImagesFileNames = default,
            global::System.IO.Stream? characterReferenceMask = default,
            string? characterReferenceMaskname = default,
            global::Ideogram.V2.MagicPromptMode? magicPrompt = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.V2.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed = default,
            global::Ideogram.V2.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType? styleType = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? styleReferenceImages = default,
            global::System.Collections.Generic.IReadOnlyList<string>? styleReferenceImagesFileNames = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Inpaint a consistent character with Ideogram 3.0<br/>
        /// Repaint the masked region of a source image with Ideogram 3.0 so it<br/>
        /// features a consistent character. Upload the source `image`, its<br/>
        /// `mask`, and a `character_reference_images` image (or use a saved<br/>
        /// character) using `multipart/form-data`.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The prompt describing the repainted result.
        /// </param>
        /// <param name="image">
        /// The source image to repaint (max 25MB). JPEG, PNG, and WEBP are supported. Multipart requests only. The output matches its size, snapped to the nearest supported resolution.
        /// </param>
        /// <param name="imagename">
        /// The source image to repaint (max 25MB). JPEG, PNG, and WEBP are supported. Multipart requests only. The output matches its size, snapped to the nearest supported resolution.
        /// </param>
        /// <param name="mask">
        /// A black-and-white mask the same size as the source image. Black marks the region to repaint. JPEG, PNG, and WEBP are supported. Multipart requests only.
        /// </param>
        /// <param name="maskname">
        /// A black-and-white mask the same size as the source image. Black marks the region to repaint. JPEG, PNG, and WEBP are supported. Multipart requests only.
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
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="styleType">
        /// The style type to repaint the character with. Defaults to `auto`. `realistic` and `fiction` are supported for character-only requests; style codes or style references (not both) require `auto`. For API-key callers, combining a style with a character requires that feature to be enabled for their account.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.
        /// </param>
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max 25MB each). JPEG, PNG, and WEBP are supported. Cannot be combined with `style_codes`.
        /// </param>
        /// <param name="styleReferenceImagesFileNames">
        /// Optional file names to use for the multipart 'style_reference_images' file parts.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request waits until the repainted images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v2/generations/{generation_id}` using the returned `generation_id`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.InpaintImageIdeogramV3CharacterResponse>> CreateImageInpaintIdeogram3CharacterAsResponseAsync(
            string prompt,
            global::System.IO.Stream image,
            string imagename,
            global::System.IO.Stream mask,
            string maskname,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> characterReferenceImages,
            bool? dryRun = default,
            global::System.Collections.Generic.IReadOnlyList<string>? characterReferenceImagesFileNames = default,
            global::System.IO.Stream? characterReferenceMask = default,
            string? characterReferenceMaskname = default,
            global::Ideogram.V2.MagicPromptMode? magicPrompt = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.V2.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed = default,
            global::Ideogram.V2.V2ImageInpaintIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType? styleType = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? styleReferenceImages = default,
            global::System.Collections.Generic.IReadOnlyList<string>? styleReferenceImagesFileNames = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}