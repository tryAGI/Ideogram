
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Supply the product photo, the masks, and the material references each<br/>
    /// as either `AssetIdentifier` references or (multipart requests only) raw<br/>
    /// image bytes; provide exactly one form per input. Supplying both forms<br/>
    /// of an input, or neither, is rejected with a 400.<br/>
    /// Supply up to 4 masks, with either one material for all of them or one<br/>
    /// material per mask paired by position. A single-region edit is a one-item<br/>
    /// `masks` (or `mask_asset_identifiers`) list with a one-item material list.
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
        /// The masks marking the regions of the product photo to change, by<br/>
        /// reference (max 4). Every mask must have the same pixel dimensions<br/>
        /// as the product photo. White pixels mark the region to change; black<br/>
        /// pixels are preserved. Alpha-only masks are also supported: opaque<br/>
        /// pixels mark the region to change and transparent pixels are<br/>
        /// preserved. Provide exactly one of `mask_asset_identifiers` or<br/>
        /// `masks`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? MaskAssetIdentifiers { get; set; }

        /// <summary>
        /// The masks marking the regions of the product photo to change (max<br/>
        /// 4, max size 25MB each), as raw bytes; only JPEG, PNG, and WEBP<br/>
        /// formats are supported. Every mask must have the same pixel<br/>
        /// dimensions as the product photo, and follows the same pixel rules<br/>
        /// as `mask_asset_identifiers`. Multipart requests only. Provide<br/>
        /// exactly one of `mask_asset_identifiers` or `masks`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("masks")]
        public global::System.Collections.Generic.IList<byte[]>? Masks { get; set; }

        /// <summary>
        /// The material reference images, by reference. Only their material —<br/>
        /// color, texture, pattern scale, and orientation — is applied to the<br/>
        /// masked regions. Send one material, which every mask takes, or<br/>
        /// exactly one per mask paired by position. Provide exactly one of<br/>
        /// `material_asset_identifiers` or `materials`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("material_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? MaterialAssetIdentifiers { get; set; }

        /// <summary>
        /// The material reference images (max size 25MB each), as raw bytes;<br/>
        /// only JPEG, PNG, and WEBP formats are supported. Only their material<br/>
        /// — color, texture, pattern scale, and orientation — is applied to<br/>
        /// the masked regions. Send one material, which every mask takes, or<br/>
        /// exactly one per mask paired by position. Multipart requests only.<br/>
        /// Provide exactly one of `material_asset_identifiers` or `materials`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("materials")]
        public global::System.Collections.Generic.IList<byte[]>? Materials { get; set; }

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
        /// <param name="maskAssetIdentifiers">
        /// The masks marking the regions of the product photo to change, by<br/>
        /// reference (max 4). Every mask must have the same pixel dimensions<br/>
        /// as the product photo. White pixels mark the region to change; black<br/>
        /// pixels are preserved. Alpha-only masks are also supported: opaque<br/>
        /// pixels mark the region to change and transparent pixels are<br/>
        /// preserved. Provide exactly one of `mask_asset_identifiers` or<br/>
        /// `masks`.
        /// </param>
        /// <param name="masks">
        /// The masks marking the regions of the product photo to change (max<br/>
        /// 4, max size 25MB each), as raw bytes; only JPEG, PNG, and WEBP<br/>
        /// formats are supported. Every mask must have the same pixel<br/>
        /// dimensions as the product photo, and follows the same pixel rules<br/>
        /// as `mask_asset_identifiers`. Multipart requests only. Provide<br/>
        /// exactly one of `mask_asset_identifiers` or `masks`.
        /// </param>
        /// <param name="materialAssetIdentifiers">
        /// The material reference images, by reference. Only their material —<br/>
        /// color, texture, pattern scale, and orientation — is applied to the<br/>
        /// masked regions. Send one material, which every mask takes, or<br/>
        /// exactly one per mask paired by position. Provide exactly one of<br/>
        /// `material_asset_identifiers` or `materials`.
        /// </param>
        /// <param name="materials">
        /// The material reference images (max size 25MB each), as raw bytes;<br/>
        /// only JPEG, PNG, and WEBP formats are supported. Only their material<br/>
        /// — color, texture, pattern scale, and orientation — is applied to<br/>
        /// the masked regions. Send one material, which every mask takes, or<br/>
        /// exactly one per mask paired by position. Multipart requests only.<br/>
        /// Provide exactly one of `material_asset_identifiers` or `materials`.
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
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? maskAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? masks,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? materialAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? materials,
            string? aspectRatio,
            global::Ideogram.GptImage2Quality? quality,
            bool? @private,
            string? webhookUrl)
        {
            this.ImageAssetIdentifier = imageAssetIdentifier;
            this.Image = image;
            this.Imagename = imagename;
            this.MaskAssetIdentifiers = maskAssetIdentifiers;
            this.Masks = masks;
            this.MaterialAssetIdentifiers = materialAssetIdentifiers;
            this.Materials = materials;
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