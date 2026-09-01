
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Supply the source image and the mask each as either an<br/>
    /// `AssetIdentifier` reference or (multipart requests only) raw image<br/>
    /// bytes; at least one form of each is required. Supply the character as<br/>
    /// a saved character collection, as asset identifiers, or (multipart<br/>
    /// requests only) as raw image bytes. Exactly one character is supported<br/>
    /// per request; when more than one form of an input is given, the<br/>
    /// stronger form is used as documented on each field.
    /// </summary>
    public sealed partial class InpaintImageIdeogramV3CharacterRequest
    {
        /// <summary>
        /// The prompt describing the repainted result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// The source image to repaint (max size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifier` is also supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The source image to repaint (max size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifier` is also supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_asset_identifier")]
        public global::Ideogram.AssetIdentifier? MaskAssetIdentifier { get; set; }

        /// <summary>
        /// A black-and-white mask the same size as the source image, as raw bytes. Black marks the region to repaint; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `mask_asset_identifier` is also supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public byte[]? Mask { get; set; }

        /// <summary>
        /// A black-and-white mask the same size as the source image, as raw bytes. Black marks the region to repaint; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `mask_asset_identifier` is also supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskname")]
        public string? Maskname { get; set; }

        /// <summary>
        /// A saved character to feature, by its URL-safe base64 collection id. Takes priority over `character_reference_asset_identifiers` and `character_reference_images` if more than one is supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_reference_collection_id")]
        public string? CharacterReferenceCollectionId { get; set; }

        /// <summary>
        /// Optional URL-safe base64 version id pinning a specific version of the `character_reference_collection_id` collection. Ignored without it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_reference_collection_version_id")]
        public string? CharacterReferenceCollectionVersionId { get; set; }

        /// <summary>
        /// An existing upload or generated image asset to use as the character reference, by reference. Takes priority over `character_reference_images` if both are supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_reference_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? CharacterReferenceAssetIdentifiers { get; set; }

        /// <summary>
        /// An image to use as the character reference (max size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if a character collection or asset identifier is also supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? CharacterReferenceImages { get; set; }

        /// <summary>
        /// Optional grayscale mask for the uploaded character reference image, the same size as that image, marking where the character is. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; applies only with `character_reference_images`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_reference_mask")]
        public byte[]? CharacterReferenceMask { get; set; }

        /// <summary>
        /// Optional grayscale mask for the uploaded character reference image, the same size as that image, marking where the character is. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; applies only with `character_reference_images`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_reference_maskname")]
        public string? CharacterReferenceMaskname { get; set; }

        /// <summary>
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `AUTO`.<br/>
        /// Default Value: AUTO
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptOptionJsonConverter))]
        public global::Ideogram.MagicPromptOption? MagicPrompt { get; set; }

        /// <summary>
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.InpaintImageIdeogramV3CharacterRequestRenderingSpeedJsonConverter))]
        public global::Ideogram.InpaintImageIdeogramV3CharacterRequestRenderingSpeed? RenderingSpeed { get; set; }

        /// <summary>
        /// The style type to repaint the character with. Defaults to `AUTO`. `REALISTIC` and `FICTION` are supported for character-only requests; style codes or style references require `AUTO`.<br/>
        /// Default Value: AUTO
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.InpaintImageIdeogramV3CharacterRequestStyleTypeJsonConverter))]
        public global::Ideogram.InpaintImageIdeogramV3CharacterRequestStyleType? StyleType { get; set; }

        /// <summary>
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </summary>
        /// <example>[AAFF5733, 0133FF57, DE3357FF]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_codes")]
        public global::System.Collections.Generic.IList<string>? StyleCodes { get; set; }

        /// <summary>
        /// A saved style to apply, by its URL-safe base64 collection id. Takes priority over `style_reference_asset_identifiers` and `style_reference_images` if more than one is supplied. Cannot be combined with `style_codes`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_collection_id")]
        public string? StyleReferenceCollectionId { get; set; }

        /// <summary>
        /// Optional URL-safe base64 version id pinning a specific version of the `style_reference_collection_id` collection. Ignored without it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_collection_version_id")]
        public string? StyleReferenceCollectionVersionId { get; set; }

        /// <summary>
        /// Existing upload or generated image assets to use as style references, by reference. Takes priority over `style_reference_images` if both are supplied. Cannot be combined with `style_codes`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? StyleReferenceAssetIdentifiers { get; set; }

        /// <summary>
        /// Images to use as style references (max 10, max size 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if a style reference collection or asset identifiers are also supplied. Cannot be combined with `style_codes`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? StyleReferenceImages { get; set; }

        /// <summary>
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_copyright_detection")]
        public bool? EnableCopyrightDetection { get; set; }

        /// <summary>
        /// When false (the default), the request blocks until the repainted images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public bool? Async { get; set; }

        /// <summary>
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.<br/>
        /// Example: https://api.example.com/webhooks/ideogram
        /// </summary>
        /// <example>https://api.example.com/webhooks/ideogram</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// A collection you can write to, by its URL-safe base64 collection id. The output images are added to it when the request completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_collection_id")]
        public string? TargetCollectionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InpaintImageIdeogramV3CharacterRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InpaintImageIdeogramV3CharacterRequest(
            string prompt,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            byte[]? image,
            string? imagename,
            global::Ideogram.AssetIdentifier? maskAssetIdentifier,
            byte[]? mask,
            string? maskname,
            string? characterReferenceCollectionId,
            string? characterReferenceCollectionVersionId,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? characterReferenceAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? characterReferenceImages,
            byte[]? characterReferenceMask,
            string? characterReferenceMaskname,
            global::Ideogram.MagicPromptOption? magicPrompt,
            int? numImages,
            int? seed,
            global::Ideogram.InpaintImageIdeogramV3CharacterRequestRenderingSpeed? renderingSpeed,
            global::Ideogram.InpaintImageIdeogramV3CharacterRequestStyleType? styleType,
            global::System.Collections.Generic.IList<string>? styleCodes,
            string? styleReferenceCollectionId,
            string? styleReferenceCollectionVersionId,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? styleReferenceAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages,
            bool? enableCopyrightDetection,
            bool? async,
            string? webhookUrl,
            bool? @private,
            string? targetCollectionId)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ImageAssetIdentifier = imageAssetIdentifier;
            this.Image = image;
            this.Imagename = imagename;
            this.MaskAssetIdentifier = maskAssetIdentifier;
            this.Mask = mask;
            this.Maskname = maskname;
            this.CharacterReferenceCollectionId = characterReferenceCollectionId;
            this.CharacterReferenceCollectionVersionId = characterReferenceCollectionVersionId;
            this.CharacterReferenceAssetIdentifiers = characterReferenceAssetIdentifiers;
            this.CharacterReferenceImages = characterReferenceImages;
            this.CharacterReferenceMask = characterReferenceMask;
            this.CharacterReferenceMaskname = characterReferenceMaskname;
            this.MagicPrompt = magicPrompt;
            this.NumImages = numImages;
            this.Seed = seed;
            this.RenderingSpeed = renderingSpeed;
            this.StyleType = styleType;
            this.StyleCodes = styleCodes;
            this.StyleReferenceCollectionId = styleReferenceCollectionId;
            this.StyleReferenceCollectionVersionId = styleReferenceCollectionVersionId;
            this.StyleReferenceAssetIdentifiers = styleReferenceAssetIdentifiers;
            this.StyleReferenceImages = styleReferenceImages;
            this.EnableCopyrightDetection = enableCopyrightDetection;
            this.Async = async;
            this.WebhookUrl = webhookUrl;
            this.Private = @private;
            this.TargetCollectionId = targetCollectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InpaintImageIdeogramV3CharacterRequest" /> class.
        /// </summary>
        public InpaintImageIdeogramV3CharacterRequest()
        {
        }

    }
}