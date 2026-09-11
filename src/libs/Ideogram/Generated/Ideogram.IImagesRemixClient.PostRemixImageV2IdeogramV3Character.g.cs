#nullable enable

namespace Ideogram
{
    public partial interface IImagesRemixClient
    {
        /// <summary>
        /// Remix an existing image with Ideogram 3.0, featuring a consistent character<br/>
        /// Transform an existing image with Ideogram 3.0, guided by a text<br/>
        /// prompt and featuring a consistent character. Supply the source either<br/>
        /// as an `image_asset_identifier` reference (an image already stored<br/>
        /// with Ideogram) or as raw `image` bytes (multipart requests only).<br/>
        /// Supplying both is rejected rather than one being ignored.<br/>
        /// `image_weight` controls how closely the result follows the source;<br/>
        /// when omitted the server picks a value from your prompt.<br/>
        /// Supply the character as a saved character<br/>
        /// (`character_reference_collection_id`), as<br/>
        /// `character_reference_asset_identifiers` references, or as raw<br/>
        /// `character_reference_images` bytes (multipart requests only, with an<br/>
        /// optional `character_reference_mask` marking where the character is in<br/>
        /// the reference). If more than one form is supplied, the collection<br/>
        /// wins over the identifiers, and the identifiers win over the bytes.<br/>
        /// Omit `resolution` and `aspect_ratio` to keep the source image's<br/>
        /// shape. If you request a different shape, the source is center-cropped<br/>
        /// to fit it first, and whatever falls outside the new shape is<br/>
        /// discarded.<br/>
        /// Style references may be supplied as a saved style<br/>
        /// (`style_reference_collection_id`), as<br/>
        /// `style_reference_asset_identifiers` references, or as raw<br/>
        /// `style_reference_images` bytes, with the same precedence as the<br/>
        /// character forms.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.RemixImageIdeogramV3CharacterResponse> PostRemixImageV2IdeogramV3CharacterAsync(

            global::Ideogram.RemixImageIdeogramV3CharacterRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix an existing image with Ideogram 3.0, featuring a consistent character<br/>
        /// Transform an existing image with Ideogram 3.0, guided by a text<br/>
        /// prompt and featuring a consistent character. Supply the source either<br/>
        /// as an `image_asset_identifier` reference (an image already stored<br/>
        /// with Ideogram) or as raw `image` bytes (multipart requests only).<br/>
        /// Supplying both is rejected rather than one being ignored.<br/>
        /// `image_weight` controls how closely the result follows the source;<br/>
        /// when omitted the server picks a value from your prompt.<br/>
        /// Supply the character as a saved character<br/>
        /// (`character_reference_collection_id`), as<br/>
        /// `character_reference_asset_identifiers` references, or as raw<br/>
        /// `character_reference_images` bytes (multipart requests only, with an<br/>
        /// optional `character_reference_mask` marking where the character is in<br/>
        /// the reference). If more than one form is supplied, the collection<br/>
        /// wins over the identifiers, and the identifiers win over the bytes.<br/>
        /// Omit `resolution` and `aspect_ratio` to keep the source image's<br/>
        /// shape. If you request a different shape, the source is center-cropped<br/>
        /// to fit it first, and whatever falls outside the new shape is<br/>
        /// discarded.<br/>
        /// Style references may be supplied as a saved style<br/>
        /// (`style_reference_collection_id`), as<br/>
        /// `style_reference_asset_identifiers` references, or as raw<br/>
        /// `style_reference_images` bytes, with the same precedence as the<br/>
        /// character forms.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.RemixImageIdeogramV3CharacterResponse>> PostRemixImageV2IdeogramV3CharacterAsResponseAsync(

            global::Ideogram.RemixImageIdeogramV3CharacterRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix an existing image with Ideogram 3.0, featuring a consistent character<br/>
        /// Transform an existing image with Ideogram 3.0, guided by a text<br/>
        /// prompt and featuring a consistent character. Supply the source either<br/>
        /// as an `image_asset_identifier` reference (an image already stored<br/>
        /// with Ideogram) or as raw `image` bytes (multipart requests only).<br/>
        /// Supplying both is rejected rather than one being ignored.<br/>
        /// `image_weight` controls how closely the result follows the source;<br/>
        /// when omitted the server picks a value from your prompt.<br/>
        /// Supply the character as a saved character<br/>
        /// (`character_reference_collection_id`), as<br/>
        /// `character_reference_asset_identifiers` references, or as raw<br/>
        /// `character_reference_images` bytes (multipart requests only, with an<br/>
        /// optional `character_reference_mask` marking where the character is in<br/>
        /// the reference). If more than one form is supplied, the collection<br/>
        /// wins over the identifiers, and the identifiers win over the bytes.<br/>
        /// Omit `resolution` and `aspect_ratio` to keep the source image's<br/>
        /// shape. If you request a different shape, the source is center-cropped<br/>
        /// to fit it first, and whatever falls outside the new shape is<br/>
        /// discarded.<br/>
        /// Style references may be supplied as a saved style<br/>
        /// (`style_reference_collection_id`), as<br/>
        /// `style_reference_asset_identifiers` references, or as raw<br/>
        /// `style_reference_images` bytes, with the same precedence as the<br/>
        /// character forms.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="prompt">
        /// The prompt that guides the remix.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// The existing upload or generated image to transform. Supply this or `image`, never both. Omit `resolution` and `aspect_ratio` to keep its shape; a different requested shape center-crops the source to fit first.
        /// </param>
        /// <param name="image">
        /// The image to transform (max size 50MB), as raw bytes; only JPEG, PNG and WEBP are supported. Multipart requests only. Supply this or `image_asset_identifier`, never both. The bytes are stored as a new image asset in your account, since the remix keeps a durable link to its source image.
        /// </param>
        /// <param name="imagename">
        /// The image to transform (max size 50MB), as raw bytes; only JPEG, PNG and WEBP are supported. Multipart requests only. Supply this or `image_asset_identifier`, never both. The bytes are stored as a new image asset in your account, since the remix keeps a durable link to its source image.
        /// </param>
        /// <param name="imageWeight">
        /// Optional. How closely the result should follow the source image, from 1 to 100. When omitted the server chooses a value from your prompt, which is the usual case.
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from the images. Descriptions in the prompt take precedence over descriptions in the negative prompt.
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
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `AUTO`.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="styleType">
        /// The style type to remix the character with. Defaults to `AUTO`.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="styleReferenceCollectionId">
        /// A saved style to apply, by its URL-safe base64 collection id. Takes priority over `style_reference_asset_identifiers` and `style_reference_images` if more than one is supplied.
        /// </param>
        /// <param name="styleReferenceCollectionVersionId">
        /// Optional URL-safe base64 version id pinning a specific version of the `style_reference_collection_id` collection. Ignored without it.
        /// </param>
        /// <param name="styleReferenceAssetIdentifiers">
        /// Existing upload or generated image assets to use as style references, by reference. Takes priority over `style_reference_images` if both are supplied.
        /// </param>
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max size 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if a style reference collection or asset identifiers are also supplied.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
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
        global::System.Threading.Tasks.Task<global::Ideogram.RemixImageIdeogramV3CharacterResponse> PostRemixImageV2IdeogramV3CharacterAsync(
            string prompt,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            int? imageWeight = default,
            string? negativePrompt = default,
            string? characterReferenceCollectionId = default,
            string? characterReferenceCollectionVersionId = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? characterReferenceAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? characterReferenceImages = default,
            byte[]? characterReferenceMask = default,
            string? characterReferenceMaskname = default,
            int? seed = default,
            global::Ideogram.ResolutionV3? resolution = default,
            global::Ideogram.AspectRatioV3? aspectRatio = default,
            global::Ideogram.RemixImageIdeogramV3CharacterRequestRenderingSpeed? renderingSpeed = default,
            global::Ideogram.MagicPromptOption? magicPrompt = default,
            int? numImages = default,
            global::Ideogram.RemixImageIdeogramV3CharacterRequestStyleType? styleType = default,
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