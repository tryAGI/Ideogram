
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolRemixRequest
    {
        /// <summary>
        /// The prompt that guides the remix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The existing upload or generated image to transform. Supply this or `image`, never both. Omit `resolution` and `aspect_ratio` to keep its shape.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// The image to transform (max size 50MB), as raw bytes; only JPEG, PNG and WEBP are supported. Multipart requests only. Supply this or `image_asset_identifier`, never both. The bytes are staged for this generation request and are not added to your account's image assets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The image to transform (max size 50MB), as raw bytes; only JPEG, PNG and WEBP are supported. Multipart requests only. Supply this or `image_asset_identifier`, never both. The bytes are staged for this generation request and are not added to your account's image assets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// Optional. How closely the result should follow the source image, from 1 to 100. When omitted the selected model chooses its usual strength. Combining a weight with a `resolution` or `aspect_ratio` that changes the source's aspect ratio requires the 1K tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_weight")]
        public int? ImageWeight { get; set; }

        /// <summary>
        /// Description of what to exclude from the images. Descriptions in the prompt take precedence over descriptions in the negative prompt. Not every model consults it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// The requested output resolution, formatted as "WIDTHxHEIGHT" (for example "1280x800"). The output is served at the closest resolution the selected model supports in the corresponding 1K or 2K tier. Omit `aspect_ratio` when supplying a resolution. If `resolution_tier` is also supplied, it must match the tier implied by these dimensions. Combining a shape-changing value with `image_weight` requires the 1K tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        /// The requested output aspect ratio. Omit it to keep the source image's shape. `AUTO` also keeps the source shape. Omit `resolution` when supplying a concrete value. Combining a shape-changing value with `image_weight` requires the 1K tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AspectRatioV4JsonConverter))]
        public global::Ideogram.AspectRatioV4? AspectRatio { get; set; }

        /// <summary>
        /// The output resolution tier. Influences which model serves the request. When omitted, the tier is inferred from `resolution`, or defaults to 1K when no exact resolution is supplied. Inputs that restrict the server's model choice (style references, saved styles, a color palette, style codes, a style preset, or a non-`AUTO` style type) currently support only 1K AUTO remixes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ToolRemixRequestResolutionTierJsonConverter))]
        public global::Ideogram.ToolRemixRequestResolutionTier? ResolutionTier { get; set; }

        /// <summary>
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `AUTO`. The selected model decides how to interpret it.<br/>
        /// Default Value: AUTO
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptOptionJsonConverter))]
        public global::Ideogram.MagicPromptOption? MagicPrompt { get; set; }

        /// <summary>
        /// Optional. Honored when the server selects the model that supports deterministic remixes; the default model synthesizes its own prompt, so results are not reproducible there. The response reports the seed used.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Existing upload or generated image assets whose style should guide the remix, by reference. Supplying style references restricts the server to a model that supports them and requires the 1K resolution tier. Ignored if `style_reference_collection_id` is also supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? StyleReferenceAssetIdentifiers { get; set; }

        /// <summary>
        /// A saved style to apply, by its URL-safe base64 collection id. Takes priority over `style_reference_asset_identifiers`. Restricts the server to a model that supports style references and requires the 1K resolution tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_collection_id")]
        public string? StyleReferenceCollectionId { get; set; }

        /// <summary>
        /// Optional URL-safe base64 version id pinning a specific version of the `style_reference_collection_id` collection. Ignored without it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_collection_version_id")]
        public string? StyleReferenceCollectionVersionId { get; set; }

        /// <summary>
        /// A predefined style preset to apply. Restricts the server to a model that supports it and requires the 1K resolution tier. Cannot be combined with style codes or style references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.StylePresetV3JsonConverter))]
        public global::Ideogram.StylePresetV3? StylePreset { get; set; }

        /// <summary>
        /// A color palette to apply. Restricts the server to a model that supports palettes and requires the 1K resolution tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_palette")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ColorPaletteWithPresetNameOrMembersJsonConverter))]
        public global::Ideogram.ColorPaletteWithPresetNameOrMembers? ColorPalette { get; set; }

        /// <summary>
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </summary>
        /// <example>[AAFF5733, 0133FF57, DE3357FF]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_codes")]
        public global::System.Collections.Generic.IList<string>? StyleCodes { get; set; }

        /// <summary>
        /// The style type to generate with. A value other than `AUTO` restricts the server to a model that supports it and requires the 1K resolution tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.StyleTypeV3JsonConverter))]
        public global::Ideogram.StyleTypeV3? StyleType { get; set; }

        /// <summary>
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_copyright_detection")]
        public bool? EnableCopyrightDetection { get; set; }

        /// <summary>
        /// When false (the default), the request blocks until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
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
        /// Whether the generated images should be kept private. Omitted or true keeps them private. False publishes them unless the caller's plan always generates privately.
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
        /// Initializes a new instance of the <see cref="ToolRemixRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt that guides the remix.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// The existing upload or generated image to transform. Supply this or `image`, never both. Omit `resolution` and `aspect_ratio` to keep its shape.
        /// </param>
        /// <param name="image">
        /// The image to transform (max size 50MB), as raw bytes; only JPEG, PNG and WEBP are supported. Multipart requests only. Supply this or `image_asset_identifier`, never both. The bytes are staged for this generation request and are not added to your account's image assets.
        /// </param>
        /// <param name="imagename">
        /// The image to transform (max size 50MB), as raw bytes; only JPEG, PNG and WEBP are supported. Multipart requests only. Supply this or `image_asset_identifier`, never both. The bytes are staged for this generation request and are not added to your account's image assets.
        /// </param>
        /// <param name="imageWeight">
        /// Optional. How closely the result should follow the source image, from 1 to 100. When omitted the selected model chooses its usual strength. Combining a weight with a `resolution` or `aspect_ratio` that changes the source's aspect ratio requires the 1K tier.
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from the images. Descriptions in the prompt take precedence over descriptions in the negative prompt. Not every model consults it.
        /// </param>
        /// <param name="resolution">
        /// The requested output resolution, formatted as "WIDTHxHEIGHT" (for example "1280x800"). The output is served at the closest resolution the selected model supports in the corresponding 1K or 2K tier. Omit `aspect_ratio` when supplying a resolution. If `resolution_tier` is also supplied, it must match the tier implied by these dimensions. Combining a shape-changing value with `image_weight` requires the 1K tier.
        /// </param>
        /// <param name="aspectRatio">
        /// The requested output aspect ratio. Omit it to keep the source image's shape. `AUTO` also keeps the source shape. Omit `resolution` when supplying a concrete value. Combining a shape-changing value with `image_weight` requires the 1K tier.
        /// </param>
        /// <param name="resolutionTier">
        /// The output resolution tier. Influences which model serves the request. When omitted, the tier is inferred from `resolution`, or defaults to 1K when no exact resolution is supplied. Inputs that restrict the server's model choice (style references, saved styles, a color palette, style codes, a style preset, or a non-`AUTO` style type) currently support only 1K AUTO remixes.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `AUTO`. The selected model decides how to interpret it.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="seed">
        /// Optional. Honored when the server selects the model that supports deterministic remixes; the default model synthesizes its own prompt, so results are not reproducible there. The response reports the seed used.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="styleReferenceAssetIdentifiers">
        /// Existing upload or generated image assets whose style should guide the remix, by reference. Supplying style references restricts the server to a model that supports them and requires the 1K resolution tier. Ignored if `style_reference_collection_id` is also supplied.
        /// </param>
        /// <param name="styleReferenceCollectionId">
        /// A saved style to apply, by its URL-safe base64 collection id. Takes priority over `style_reference_asset_identifiers`. Restricts the server to a model that supports style references and requires the 1K resolution tier.
        /// </param>
        /// <param name="styleReferenceCollectionVersionId">
        /// Optional URL-safe base64 version id pinning a specific version of the `style_reference_collection_id` collection. Ignored without it.
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset to apply. Restricts the server to a model that supports it and requires the 1K resolution tier. Cannot be combined with style codes or style references.
        /// </param>
        /// <param name="colorPalette">
        /// A color palette to apply. Restricts the server to a model that supports palettes and requires the 1K resolution tier.
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </param>
        /// <param name="styleType">
        /// The style type to generate with. A value other than `AUTO` restricts the server to a model that supports it and requires the 1K resolution tier.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
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
        /// Whether the generated images should be kept private. Omitted or true keeps them private. False publishes them unless the caller's plan always generates privately.
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. The output images are added to it when the request completes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolRemixRequest(
            string prompt,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            byte[]? image,
            string? imagename,
            int? imageWeight,
            string? negativePrompt,
            string? resolution,
            global::Ideogram.AspectRatioV4? aspectRatio,
            global::Ideogram.ToolRemixRequestResolutionTier? resolutionTier,
            global::Ideogram.MagicPromptOption? magicPrompt,
            int? seed,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? styleReferenceAssetIdentifiers,
            string? styleReferenceCollectionId,
            string? styleReferenceCollectionVersionId,
            global::Ideogram.StylePresetV3? stylePreset,
            global::Ideogram.ColorPaletteWithPresetNameOrMembers? colorPalette,
            global::System.Collections.Generic.IList<string>? styleCodes,
            global::Ideogram.StyleTypeV3? styleType,
            int? numImages,
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
            this.ImageWeight = imageWeight;
            this.NegativePrompt = negativePrompt;
            this.Resolution = resolution;
            this.AspectRatio = aspectRatio;
            this.ResolutionTier = resolutionTier;
            this.MagicPrompt = magicPrompt;
            this.Seed = seed;
            this.StyleReferenceAssetIdentifiers = styleReferenceAssetIdentifiers;
            this.StyleReferenceCollectionId = styleReferenceCollectionId;
            this.StyleReferenceCollectionVersionId = styleReferenceCollectionVersionId;
            this.StylePreset = stylePreset;
            this.ColorPalette = colorPalette;
            this.StyleCodes = styleCodes;
            this.StyleType = styleType;
            this.NumImages = numImages;
            this.EnableCopyrightDetection = enableCopyrightDetection;
            this.Async = async;
            this.WebhookUrl = webhookUrl;
            this.Private = @private;
            this.TargetCollectionId = targetCollectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRemixRequest" /> class.
        /// </summary>
        public ToolRemixRequest()
        {
        }

    }
}