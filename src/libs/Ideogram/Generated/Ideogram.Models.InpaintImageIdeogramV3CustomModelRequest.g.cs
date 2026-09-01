
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Supply the source image and mask as either `AssetIdentifier` references<br/>
    /// or raw bytes. At least one form of each input is required; references<br/>
    /// take priority over bytes when both are supplied.
    /// </summary>
    public sealed partial class InpaintImageIdeogramV3CustomModelRequest
    {
        /// <summary>
        /// The prompt describing the repainted result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The custom model URI returned by the custom-model API, in the form `model/&lt;model_name&gt;/version/&lt;version_name&gt;`. The authenticated user or organization must have access to the model.<br/>
        /// Example: model/my-custom-model/version/1
        /// </summary>
        /// <example>model/my-custom-model/version/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_model_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomModelUri { get; set; }

        /// <summary>
        /// The source image asset to repaint. Takes priority over `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// The source image to repaint (max size 25MB), as JPEG, PNG, or WEBP bytes. Multipart requests only; ignored when `image_asset_identifier` is supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The source image to repaint (max size 25MB), as JPEG, PNG, or WEBP bytes. Multipart requests only; ignored when `image_asset_identifier` is supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// A black-and-white mask asset the same size as the source image. Black marks the region to repaint. Takes priority over `mask`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_asset_identifier")]
        public global::Ideogram.AssetIdentifier? MaskAssetIdentifier { get; set; }

        /// <summary>
        /// A black-and-white mask the same size as the source image, as JPEG, PNG, or WEBP bytes. Black marks the region to repaint. Multipart requests only; ignored when `mask_asset_identifier` is supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public byte[]? Mask { get; set; }

        /// <summary>
        /// A black-and-white mask the same size as the source image, as JPEG, PNG, or WEBP bytes. Black marks the region to repaint. Multipart requests only; ignored when `mask_asset_identifier` is supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskname")]
        public string? Maskname { get; set; }

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
        /// The rendering speed to use. When omitted, the server chooses a speed supported by the selected custom model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.InpaintImageIdeogramV3CustomModelRequestRenderingSpeedJsonConverter))]
        public global::Ideogram.InpaintImageIdeogramV3CustomModelRequestRenderingSpeed? RenderingSpeed { get; set; }

        /// <summary>
        /// A predefined style preset. Cannot be combined with style codes or style references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.StylePresetV3JsonConverter))]
        public global::Ideogram.StylePresetV3? StylePreset { get; set; }

        /// <summary>
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </summary>
        /// <example>[AAFF5733, 0133FF57, DE3357FF]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_codes")]
        public global::System.Collections.Generic.IList<string>? StyleCodes { get; set; }

        /// <summary>
        /// A saved style, by its URL-safe base64 collection id. Takes priority over asset identifiers and raw style reference images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_collection_id")]
        public string? StyleReferenceCollectionId { get; set; }

        /// <summary>
        /// Optional URL-safe base64 version id for the saved style. Ignored without `style_reference_collection_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_collection_version_id")]
        public string? StyleReferenceCollectionVersionId { get; set; }

        /// <summary>
        /// Existing upload or generated image assets to use as style references. Takes priority over raw style reference images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? StyleReferenceAssetIdentifiers { get; set; }

        /// <summary>
        /// Images to use as style references (max 10, max size 25MB each), as JPEG, PNG, or WEBP bytes. Multipart requests only; ignored if a collection or asset identifiers are supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? StyleReferenceImages { get; set; }

        /// <summary>
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images return `is_image_safe: false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_copyright_detection")]
        public bool? EnableCopyrightDetection { get; set; }

        /// <summary>
        /// When false, block until the images are ready. When true, return after dispatch and poll `GET /v1/generations/{generation_id}`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public bool? Async { get; set; }

        /// <summary>
        /// When true or omitted, the output is kept private to your account. Set to false to publish it. Enterprise accounts always generate privately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// A collection you can write to, by its URL-safe base64 collection id. Completed images are added to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_collection_id")]
        public string? TargetCollectionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InpaintImageIdeogramV3CustomModelRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt describing the repainted result.
        /// </param>
        /// <param name="customModelUri">
        /// The custom model URI returned by the custom-model API, in the form `model/&lt;model_name&gt;/version/&lt;version_name&gt;`. The authenticated user or organization must have access to the model.<br/>
        /// Example: model/my-custom-model/version/1
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// The source image asset to repaint. Takes priority over `image`.
        /// </param>
        /// <param name="image">
        /// The source image to repaint (max size 25MB), as JPEG, PNG, or WEBP bytes. Multipart requests only; ignored when `image_asset_identifier` is supplied.
        /// </param>
        /// <param name="imagename">
        /// The source image to repaint (max size 25MB), as JPEG, PNG, or WEBP bytes. Multipart requests only; ignored when `image_asset_identifier` is supplied.
        /// </param>
        /// <param name="maskAssetIdentifier">
        /// A black-and-white mask asset the same size as the source image. Black marks the region to repaint. Takes priority over `mask`.
        /// </param>
        /// <param name="mask">
        /// A black-and-white mask the same size as the source image, as JPEG, PNG, or WEBP bytes. Black marks the region to repaint. Multipart requests only; ignored when `mask_asset_identifier` is supplied.
        /// </param>
        /// <param name="maskname">
        /// A black-and-white mask the same size as the source image, as JPEG, PNG, or WEBP bytes. Black marks the region to repaint. Multipart requests only; ignored when `mask_asset_identifier` is supplied.
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
        /// The rendering speed to use. When omitted, the server chooses a speed supported by the selected custom model.
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset. Cannot be combined with style codes or style references.
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </param>
        /// <param name="styleReferenceCollectionId">
        /// A saved style, by its URL-safe base64 collection id. Takes priority over asset identifiers and raw style reference images.
        /// </param>
        /// <param name="styleReferenceCollectionVersionId">
        /// Optional URL-safe base64 version id for the saved style. Ignored without `style_reference_collection_id`.
        /// </param>
        /// <param name="styleReferenceAssetIdentifiers">
        /// Existing upload or generated image assets to use as style references. Takes priority over raw style reference images.
        /// </param>
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max size 25MB each), as JPEG, PNG, or WEBP bytes. Multipart requests only; ignored if a collection or asset identifiers are supplied.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images return `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false, block until the images are ready. When true, return after dispatch and poll `GET /v1/generations/{generation_id}`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="private">
        /// When true or omitted, the output is kept private to your account. Set to false to publish it. Enterprise accounts always generate privately.
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. Completed images are added to it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InpaintImageIdeogramV3CustomModelRequest(
            string prompt,
            string customModelUri,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            byte[]? image,
            string? imagename,
            global::Ideogram.AssetIdentifier? maskAssetIdentifier,
            byte[]? mask,
            string? maskname,
            global::Ideogram.MagicPromptOption? magicPrompt,
            int? numImages,
            int? seed,
            global::Ideogram.InpaintImageIdeogramV3CustomModelRequestRenderingSpeed? renderingSpeed,
            global::Ideogram.StylePresetV3? stylePreset,
            global::System.Collections.Generic.IList<string>? styleCodes,
            string? styleReferenceCollectionId,
            string? styleReferenceCollectionVersionId,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? styleReferenceAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages,
            bool? enableCopyrightDetection,
            bool? async,
            bool? @private,
            string? targetCollectionId)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.CustomModelUri = customModelUri ?? throw new global::System.ArgumentNullException(nameof(customModelUri));
            this.ImageAssetIdentifier = imageAssetIdentifier;
            this.Image = image;
            this.Imagename = imagename;
            this.MaskAssetIdentifier = maskAssetIdentifier;
            this.Mask = mask;
            this.Maskname = maskname;
            this.MagicPrompt = magicPrompt;
            this.NumImages = numImages;
            this.Seed = seed;
            this.RenderingSpeed = renderingSpeed;
            this.StylePreset = stylePreset;
            this.StyleCodes = styleCodes;
            this.StyleReferenceCollectionId = styleReferenceCollectionId;
            this.StyleReferenceCollectionVersionId = styleReferenceCollectionVersionId;
            this.StyleReferenceAssetIdentifiers = styleReferenceAssetIdentifiers;
            this.StyleReferenceImages = styleReferenceImages;
            this.EnableCopyrightDetection = enableCopyrightDetection;
            this.Async = async;
            this.Private = @private;
            this.TargetCollectionId = targetCollectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InpaintImageIdeogramV3CustomModelRequest" /> class.
        /// </summary>
        public InpaintImageIdeogramV3CustomModelRequest()
        {
        }

    }
}