
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
        /// The image to remix (max 50MB; JPEG, PNG, or WEBP). Multipart requests only. The image is used only for this request and is not saved to your account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The image to remix (max 50MB; JPEG, PNG, or WEBP). Multipart requests only. The image is used only for this request and is not saved to your account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// Optional. How closely the result should follow the source image, from 1 to 100. When omitted the selected model chooses its usual strength. Combining a weight with a `resolution` or `aspect_ratio` that changes the source's aspect ratio crops the source to the new shape; this is only available at the 1K tier and is rejected at 2K.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_weight")]
        public int? ImageWeight { get; set; }

        /// <summary>
        /// Description of what to exclude from the images. The prompt takes precedence over the negative prompt. Not every model uses it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// The requested output resolution, formatted as "WIDTHxHEIGHT" (for example "1280x800"). The output uses the closest supported resolution in the matching 1K or 2K tier. Omit `aspect_ratio` when supplying a resolution. If `resolution_tier` is also supplied, it must match the tier these dimensions fall in. Combining a shape-changing value with `image_weight` requires the 1K tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        /// The requested output aspect ratio. Omit it to keep the source image's shape. `auto` also keeps the source shape. Omit `resolution` when supplying a concrete value. Combining a shape-changing value with `image_weight` requires the 1K tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.IdeogramV4AspectRatioJsonConverter))]
        public global::Ideogram.IdeogramV4AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The output resolution tier. When omitted, the tier is inferred from `resolution`, or defaults to 1k. A color palette, style codes, style preset, or non-`auto` style type are only supported at 1k.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ToolRemixRequestResolutionTierJsonConverter))]
        public global::Ideogram.ToolRemixRequestResolutionTier? ResolutionTier { get; set; }

        /// <summary>
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `auto`. The selected model decides how to interpret it.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptModeJsonConverter))]
        public global::Ideogram.MagicPromptMode? MagicPrompt { get; set; }

        /// <summary>
        /// Optional. Only honored when the request uses a model that supports reproducible remixes; results from the default model are not reproducible. The response reports the seed used.<br/>
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
        /// A saved style to apply, by its URL-safe base64 collection id. Limits the request to a model that supports style references and requires the 1K resolution tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_collection_id")]
        public string? StyleReferenceCollectionId { get; set; }

        /// <summary>
        /// Optional URL-safe base64 version id of the saved style in `style_reference_collection_id`. Ignored without it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_collection_version_id")]
        public string? StyleReferenceCollectionVersionId { get; set; }

        /// <summary>
        /// A predefined style preset to apply. Limits the request to a model that supports it and requires the 1K resolution tier. Cannot be combined with style codes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.IdeogramV3StylePresetJsonConverter))]
        public global::Ideogram.IdeogramV3StylePreset? StylePreset { get; set; }

        /// <summary>
        /// A color palette to apply. Limits the request to a model that supports palettes and requires the 1K resolution tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_palette")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.IdeogramColorPaletteJsonConverter))]
        public global::Ideogram.IdeogramColorPalette? ColorPalette { get; set; }

        /// <summary>
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </summary>
        /// <example>[AAFF5733, 0133FF57, DE3357FF]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_codes")]
        public global::System.Collections.Generic.IList<string>? StyleCodes { get; set; }

        /// <summary>
        /// The style type to generate with. A value other than `auto` limits the request to a model that supports it and requires the 1K resolution tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.IdeogramV3StyleTypeJsonConverter))]
        public global::Ideogram.IdeogramV3StyleType? StyleType { get; set; }

        /// <summary>
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Optional. Run copyright detection on the generated images. Adds latency; flagged images are returned with `is_image_safe: false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_copyright_detection")]
        public bool? EnableCopyrightDetection { get; set; }

        /// <summary>
        /// When false (the default), the request waits until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` with the returned `generation_id` for the result.<br/>
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
        /// The image to remix (max 50MB; JPEG, PNG, or WEBP). Multipart requests only. The image is used only for this request and is not saved to your account.
        /// </param>
        /// <param name="imagename">
        /// The image to remix (max 50MB; JPEG, PNG, or WEBP). Multipart requests only. The image is used only for this request and is not saved to your account.
        /// </param>
        /// <param name="imageWeight">
        /// Optional. How closely the result should follow the source image, from 1 to 100. When omitted the selected model chooses its usual strength. Combining a weight with a `resolution` or `aspect_ratio` that changes the source's aspect ratio crops the source to the new shape; this is only available at the 1K tier and is rejected at 2K.
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from the images. The prompt takes precedence over the negative prompt. Not every model uses it.
        /// </param>
        /// <param name="resolution">
        /// The requested output resolution, formatted as "WIDTHxHEIGHT" (for example "1280x800"). The output uses the closest supported resolution in the matching 1K or 2K tier. Omit `aspect_ratio` when supplying a resolution. If `resolution_tier` is also supplied, it must match the tier these dimensions fall in. Combining a shape-changing value with `image_weight` requires the 1K tier.
        /// </param>
        /// <param name="aspectRatio">
        /// The requested output aspect ratio. Omit it to keep the source image's shape. `auto` also keeps the source shape. Omit `resolution` when supplying a concrete value. Combining a shape-changing value with `image_weight` requires the 1K tier.
        /// </param>
        /// <param name="resolutionTier">
        /// The output resolution tier. When omitted, the tier is inferred from `resolution`, or defaults to 1k. A color palette, style codes, style preset, or non-`auto` style type are only supported at 1k.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `auto`. The selected model decides how to interpret it.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="seed">
        /// Optional. Only honored when the request uses a model that supports reproducible remixes; results from the default model are not reproducible. The response reports the seed used.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="styleReferenceAssetIdentifiers">
        /// Existing upload or generated image assets whose style should guide the remix, by reference. Supplying style references restricts the server to a model that supports them and requires the 1K resolution tier. Ignored if `style_reference_collection_id` is also supplied.
        /// </param>
        /// <param name="styleReferenceCollectionId">
        /// A saved style to apply, by its URL-safe base64 collection id. Limits the request to a model that supports style references and requires the 1K resolution tier.
        /// </param>
        /// <param name="styleReferenceCollectionVersionId">
        /// Optional URL-safe base64 version id of the saved style in `style_reference_collection_id`. Ignored without it.
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset to apply. Limits the request to a model that supports it and requires the 1K resolution tier. Cannot be combined with style codes.
        /// </param>
        /// <param name="colorPalette">
        /// A color palette to apply. Limits the request to a model that supports palettes and requires the 1K resolution tier.
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </param>
        /// <param name="styleType">
        /// The style type to generate with. A value other than `auto` limits the request to a model that supports it and requires the 1K resolution tier.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
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
            global::Ideogram.IdeogramV4AspectRatio? aspectRatio,
            global::Ideogram.ToolRemixRequestResolutionTier? resolutionTier,
            global::Ideogram.MagicPromptMode? magicPrompt,
            int? seed,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? styleReferenceAssetIdentifiers,
            string? styleReferenceCollectionId,
            string? styleReferenceCollectionVersionId,
            global::Ideogram.IdeogramV3StylePreset? stylePreset,
            global::Ideogram.IdeogramColorPalette? colorPalette,
            global::System.Collections.Generic.IList<string>? styleCodes,
            global::Ideogram.IdeogramV3StyleType? styleType,
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