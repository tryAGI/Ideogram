
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Supply the product photo, the mask, and the material reference each as<br/>
    /// either an `AssetIdentifier` reference or (multipart requests only) raw<br/>
    /// image bytes; provide exactly one form per input. Supplying both forms<br/>
    /// of an input, or neither, is rejected with a 400.
    /// </summary>
    public sealed partial class MaterialSwapRequest
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// The product photo to edit (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Multipart requests only.<br/>
        /// Provide exactly one of `image_asset_identifier` or `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The product photo to edit (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Multipart requests only.<br/>
        /// Provide exactly one of `image_asset_identifier` or `image`.
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
        /// The mask marking the region of the product photo to change (max<br/>
        /// size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are<br/>
        /// supported. The mask must have the same pixel dimensions as the<br/>
        /// product photo. White pixels mark the region to change; black pixels<br/>
        /// are preserved. Alpha-only masks are also supported: opaque pixels<br/>
        /// mark the region to change and transparent pixels are preserved.<br/>
        /// Multipart requests only. Provide exactly one of<br/>
        /// `mask_asset_identifier` or `mask`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public byte[]? Mask { get; set; }

        /// <summary>
        /// The mask marking the region of the product photo to change (max<br/>
        /// size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are<br/>
        /// supported. The mask must have the same pixel dimensions as the<br/>
        /// product photo. White pixels mark the region to change; black pixels<br/>
        /// are preserved. Alpha-only masks are also supported: opaque pixels<br/>
        /// mark the region to change and transparent pixels are preserved.<br/>
        /// Multipart requests only. Provide exactly one of<br/>
        /// `mask_asset_identifier` or `mask`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskname")]
        public string? Maskname { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("material_asset_identifier")]
        public global::Ideogram.AssetIdentifier? MaterialAssetIdentifier { get; set; }

        /// <summary>
        /// The material reference image (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Only its material —<br/>
        /// color, texture, pattern scale, and orientation — is applied to the<br/>
        /// masked region. Multipart requests only. Provide exactly one of<br/>
        /// `material_asset_identifier` or `material`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("material")]
        public byte[]? Material { get; set; }

        /// <summary>
        /// The material reference image (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Only its material —<br/>
        /// color, texture, pattern scale, and orientation — is applied to the<br/>
        /// masked region. Multipart requests only. Provide exactly one of<br/>
        /// `material_asset_identifier` or `material`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("materialname")]
        public string? Materialname { get; set; }

        /// <summary>
        /// The aspect ratio of the generated image. Defaults to the aspect<br/>
        /// ratio of the product photo when omitted, which preserves the<br/>
        /// original framing exactly. When a different ratio is requested, the<br/>
        /// scene is extended to fill the new shape rather than cropped, so<br/>
        /// part of the frame is newly generated. Supported values are `1:1`,<br/>
        /// `3:4`, `4:3`, `16:9`, and `9:16`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GptImage2QualityJsonConverter))]
        public global::Ideogram.GptImage2Quality? Quality { get; set; }

        /// <summary>
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialSwapRequest" /> class.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The product photo to edit (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Multipart requests only.<br/>
        /// Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="imagename">
        /// The product photo to edit (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Multipart requests only.<br/>
        /// Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="maskAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="mask">
        /// The mask marking the region of the product photo to change (max<br/>
        /// size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are<br/>
        /// supported. The mask must have the same pixel dimensions as the<br/>
        /// product photo. White pixels mark the region to change; black pixels<br/>
        /// are preserved. Alpha-only masks are also supported: opaque pixels<br/>
        /// mark the region to change and transparent pixels are preserved.<br/>
        /// Multipart requests only. Provide exactly one of<br/>
        /// `mask_asset_identifier` or `mask`.
        /// </param>
        /// <param name="maskname">
        /// The mask marking the region of the product photo to change (max<br/>
        /// size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are<br/>
        /// supported. The mask must have the same pixel dimensions as the<br/>
        /// product photo. White pixels mark the region to change; black pixels<br/>
        /// are preserved. Alpha-only masks are also supported: opaque pixels<br/>
        /// mark the region to change and transparent pixels are preserved.<br/>
        /// Multipart requests only. Provide exactly one of<br/>
        /// `mask_asset_identifier` or `mask`.
        /// </param>
        /// <param name="materialAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="material">
        /// The material reference image (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Only its material —<br/>
        /// color, texture, pattern scale, and orientation — is applied to the<br/>
        /// masked region. Multipart requests only. Provide exactly one of<br/>
        /// `material_asset_identifier` or `material`.
        /// </param>
        /// <param name="materialname">
        /// The material reference image (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Only its material —<br/>
        /// color, texture, pattern scale, and orientation — is applied to the<br/>
        /// masked region. Multipart requests only. Provide exactly one of<br/>
        /// `material_asset_identifier` or `material`.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generated image. Defaults to the aspect<br/>
        /// ratio of the product photo when omitted, which preserves the<br/>
        /// original framing exactly. When a different ratio is requested, the<br/>
        /// scene is extended to fill the new shape rather than cropped, so<br/>
        /// part of the frame is newly generated. Supported values are `1:1`,<br/>
        /// `3:4`, `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </param>
        /// <param name="private">
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MaterialSwapRequest(
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            byte[]? image,
            string? imagename,
            global::Ideogram.AssetIdentifier? maskAssetIdentifier,
            byte[]? mask,
            string? maskname,
            global::Ideogram.AssetIdentifier? materialAssetIdentifier,
            byte[]? material,
            string? materialname,
            string? aspectRatio,
            global::Ideogram.GptImage2Quality? quality,
            bool? @private,
            string? webhookUrl)
        {
            this.ImageAssetIdentifier = imageAssetIdentifier;
            this.Image = image;
            this.Imagename = imagename;
            this.MaskAssetIdentifier = maskAssetIdentifier;
            this.Mask = mask;
            this.Maskname = maskname;
            this.MaterialAssetIdentifier = materialAssetIdentifier;
            this.Material = material;
            this.Materialname = materialname;
            this.AspectRatio = aspectRatio;
            this.Quality = quality;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialSwapRequest" /> class.
        /// </summary>
        public MaterialSwapRequest()
        {
        }

    }
}