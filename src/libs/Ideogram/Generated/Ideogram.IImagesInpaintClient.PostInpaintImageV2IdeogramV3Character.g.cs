#nullable enable

namespace Ideogram
{
    public partial interface IImagesInpaintClient
    {
        /// <summary>
        /// Repaint a masked region with a consistent character with Ideogram 3.0<br/>
        /// Repaint the masked region of a source image so it features a<br/>
        /// consistent character, with Ideogram 3.0. For each of the source image<br/>
        /// and the mask, supply either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier` / `mask_asset_identifier`) or the raw image<br/>
        /// bytes directly (`image` / `mask`, multipart requests only). If both a<br/>
        /// reference and bytes are supplied for the same input, the reference<br/>
        /// wins and the bytes are ignored.<br/>
        /// Supply the character as a saved character<br/>
        /// (`character_reference_collection_id`), as<br/>
        /// `character_reference_asset_identifiers` references (an image already<br/>
        /// stored with Ideogram), or as raw `character_reference_images` bytes<br/>
        /// (multipart requests only, with an optional<br/>
        /// `character_reference_mask` marking where the character is in the<br/>
        /// reference). If more than one form is supplied, the collection wins<br/>
        /// over the identifiers, and the identifiers win over the bytes.<br/>
        /// Optional style controls may be combined with the character when<br/>
        /// `style_type` is `AUTO`. Supply either style codes or style references.<br/>
        /// Supply style references as a saved style<br/>
        /// (`style_reference_collection_id`), as<br/>
        /// `style_reference_asset_identifiers` references, or as raw<br/>
        /// `style_reference_images` bytes (multipart requests only). If more than<br/>
        /// one reference form is supplied, the collection wins over the<br/>
        /// identifiers, and the identifiers win over the bytes. API-key callers<br/>
        /// also need access to the style-with-character API rollout.<br/>
        /// The output matches the size of the source image (snapped to the<br/>
        /// nearest resolution the model renders). By default the request blocks<br/>
        /// until the images are ready and returns them in `data`. Set `async` to<br/>
        /// true to return immediately after the request is accepted, then poll<br/>
        /// for completion and results with `GET /v1/generations/{generation_id}`<br/>
        /// using the returned `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.InpaintImageIdeogramV3CharacterResponse> PostInpaintImageV2IdeogramV3CharacterAsync(

            global::Ideogram.InpaintImageIdeogramV3CharacterRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Repaint a masked region with a consistent character with Ideogram 3.0<br/>
        /// Repaint the masked region of a source image so it features a<br/>
        /// consistent character, with Ideogram 3.0. For each of the source image<br/>
        /// and the mask, supply either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier` / `mask_asset_identifier`) or the raw image<br/>
        /// bytes directly (`image` / `mask`, multipart requests only). If both a<br/>
        /// reference and bytes are supplied for the same input, the reference<br/>
        /// wins and the bytes are ignored.<br/>
        /// Supply the character as a saved character<br/>
        /// (`character_reference_collection_id`), as<br/>
        /// `character_reference_asset_identifiers` references (an image already<br/>
        /// stored with Ideogram), or as raw `character_reference_images` bytes<br/>
        /// (multipart requests only, with an optional<br/>
        /// `character_reference_mask` marking where the character is in the<br/>
        /// reference). If more than one form is supplied, the collection wins<br/>
        /// over the identifiers, and the identifiers win over the bytes.<br/>
        /// Optional style controls may be combined with the character when<br/>
        /// `style_type` is `AUTO`. Supply either style codes or style references.<br/>
        /// Supply style references as a saved style<br/>
        /// (`style_reference_collection_id`), as<br/>
        /// `style_reference_asset_identifiers` references, or as raw<br/>
        /// `style_reference_images` bytes (multipart requests only). If more than<br/>
        /// one reference form is supplied, the collection wins over the<br/>
        /// identifiers, and the identifiers win over the bytes. API-key callers<br/>
        /// also need access to the style-with-character API rollout.<br/>
        /// The output matches the size of the source image (snapped to the<br/>
        /// nearest resolution the model renders). By default the request blocks<br/>
        /// until the images are ready and returns them in `data`. Set `async` to<br/>
        /// true to return immediately after the request is accepted, then poll<br/>
        /// for completion and results with `GET /v1/generations/{generation_id}`<br/>
        /// using the returned `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.InpaintImageIdeogramV3CharacterResponse>> PostInpaintImageV2IdeogramV3CharacterAsResponseAsync(

            global::Ideogram.InpaintImageIdeogramV3CharacterRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Repaint a masked region with a consistent character with Ideogram 3.0<br/>
        /// Repaint the masked region of a source image so it features a<br/>
        /// consistent character, with Ideogram 3.0. For each of the source image<br/>
        /// and the mask, supply either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier` / `mask_asset_identifier`) or the raw image<br/>
        /// bytes directly (`image` / `mask`, multipart requests only). If both a<br/>
        /// reference and bytes are supplied for the same input, the reference<br/>
        /// wins and the bytes are ignored.<br/>
        /// Supply the character as a saved character<br/>
        /// (`character_reference_collection_id`), as<br/>
        /// `character_reference_asset_identifiers` references (an image already<br/>
        /// stored with Ideogram), or as raw `character_reference_images` bytes<br/>
        /// (multipart requests only, with an optional<br/>
        /// `character_reference_mask` marking where the character is in the<br/>
        /// reference). If more than one form is supplied, the collection wins<br/>
        /// over the identifiers, and the identifiers win over the bytes.<br/>
        /// Optional style controls may be combined with the character when<br/>
        /// `style_type` is `AUTO`. Supply either style codes or style references.<br/>
        /// Supply style references as a saved style<br/>
        /// (`style_reference_collection_id`), as<br/>
        /// `style_reference_asset_identifiers` references, or as raw<br/>
        /// `style_reference_images` bytes (multipart requests only). If more than<br/>
        /// one reference form is supplied, the collection wins over the<br/>
        /// identifiers, and the identifiers win over the bytes. API-key callers<br/>
        /// also need access to the style-with-character API rollout.<br/>
        /// The output matches the size of the source image (snapped to the<br/>
        /// nearest resolution the model renders). By default the request blocks<br/>
        /// until the images are ready and returns them in `data`. Set `async` to<br/>
        /// true to return immediately after the request is accepted, then poll<br/>
        /// for completion and results with `GET /v1/generations/{generation_id}`<br/>
        /// using the returned `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="prompt">
        /// The prompt describing the repainted result.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The source image to repaint (max size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifier` is also supplied.
        /// </param>
        /// <param name="imagename">
        /// The source image to repaint (max size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifier` is also supplied.
        /// </param>
        /// <param name="maskAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="mask">
        /// A black-and-white mask the same size as the source image, as raw bytes. Black marks the region to repaint; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `mask_asset_identifier` is also supplied.
        /// </param>
        /// <param name="maskname">
        /// A black-and-white mask the same size as the source image, as raw bytes. Black marks the region to repaint; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `mask_asset_identifier` is also supplied.
        /// </param>
        /// <param name="characterReferenceCollectionId">
        /// A saved character to feature, by its URL-safe base64 collection id. Takes priority over `character_reference_asset_identifiers` and `character_reference_images` if more than one is supplied.
        /// </param>
        /// <param name="characterReferenceCollectionVersionId">
        /// Optional URL-safe base64 version id pinning a specific version of the `character_reference_collection_id` collection. Ignored without it.
        /// </param>
        /// <param name="characterReferenceAssetIdentifiers">
        /// An existing upload or generated image asset to use as the character reference, by reference. Takes priority over `character_reference_images` if both are supplied.
        /// </param>
        /// <param name="characterReferenceImages">
        /// An image to use as the character reference (max size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if a character collection or asset identifier is also supplied.
        /// </param>
        /// <param name="characterReferenceMask">
        /// Optional grayscale mask for the uploaded character reference image, the same size as that image, marking where the character is. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; applies only with `character_reference_images`.
        /// </param>
        /// <param name="characterReferenceMaskname">
        /// Optional grayscale mask for the uploaded character reference image, the same size as that image, marking where the character is. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; applies only with `character_reference_images`.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `AUTO`.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="styleType">
        /// The style type to repaint the character with. Defaults to `AUTO`. `REALISTIC` and `FICTION` are supported for character-only requests; style codes or style references require `AUTO`.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </param>
        /// <param name="styleReferenceCollectionId">
        /// A saved style to apply, by its URL-safe base64 collection id. Takes priority over `style_reference_asset_identifiers` and `style_reference_images` if more than one is supplied. Cannot be combined with `style_codes`.
        /// </param>
        /// <param name="styleReferenceCollectionVersionId">
        /// Optional URL-safe base64 version id pinning a specific version of the `style_reference_collection_id` collection. Ignored without it.
        /// </param>
        /// <param name="styleReferenceAssetIdentifiers">
        /// Existing upload or generated image assets to use as style references, by reference. Takes priority over `style_reference_images` if both are supplied. Cannot be combined with `style_codes`.
        /// </param>
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max size 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if a style reference collection or asset identifiers are also supplied. Cannot be combined with `style_codes`.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request blocks until the repainted images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.InpaintImageIdeogramV3CharacterResponse> PostInpaintImageV2IdeogramV3CharacterAsync(
            string prompt,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            global::Ideogram.AssetIdentifier? maskAssetIdentifier = default,
            byte[]? mask = default,
            string? maskname = default,
            string? characterReferenceCollectionId = default,
            string? characterReferenceCollectionVersionId = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? characterReferenceAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? characterReferenceImages = default,
            byte[]? characterReferenceMask = default,
            string? characterReferenceMaskname = default,
            global::Ideogram.MagicPromptOption? magicPrompt = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.InpaintImageIdeogramV3CharacterRequestRenderingSpeed? renderingSpeed = default,
            global::Ideogram.InpaintImageIdeogramV3CharacterRequestStyleType? styleType = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
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