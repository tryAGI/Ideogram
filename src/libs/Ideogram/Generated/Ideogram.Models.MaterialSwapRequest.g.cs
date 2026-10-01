
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Upload the product photo as `image`, up to 4 `masks`, and either one<br/>
    /// entry in `materials` for all masks or one per mask, paired by<br/>
    /// position. For a single region, send one mask and one material.
    /// </summary>
    public sealed partial class MaterialSwapRequest
    {
        /// <summary>
        /// The product photo to edit, by reference. Everything outside the<br/>
        /// masked region is preserved. Provide exactly one of<br/>
        /// `image_asset_identifier` or `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// The product photo to edit (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The product photo to edit (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
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
        /// Masks marking the regions to change (max 4, max size 25MB each).<br/>
        /// JPEG, PNG, and WEBP formats are supported. Every mask must have the<br/>
        /// same pixel dimensions as the product photo. White pixels mark the<br/>
        /// region to change and black pixels are preserved; alpha-only masks<br/>
        /// also work (opaque = change, transparent = preserve).
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
        /// Material reference images (max size 25MB each). JPEG, PNG, and WEBP<br/>
        /// formats are supported. Only their material (color, texture, pattern<br/>
        /// scale, and orientation) is applied to the masked regions. Send one<br/>
        /// material for every mask, or exactly one per mask, paired by<br/>
        /// position.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("materials")]
        public global::System.Collections.Generic.IList<byte[]>? Materials { get; set; }

        /// <summary>
        /// Output aspect ratio. Defaults to the product photo's aspect ratio,<br/>
        /// which keeps the original framing. A different ratio extends the<br/>
        /// scene to fill the new shape rather than cropping, so part of the<br/>
        /// frame is newly generated. Supported values are `1:1`, `3:4`,<br/>
        /// `4:3`, `16:9`, and `9:16`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MaterialSwapQualityJsonConverter))]
        public global::Ideogram.MaterialSwapQuality? Quality { get; set; }

        /// <summary>
        /// A collection you can write to, by its URL-safe base64 collection id. Completed outputs are added to it automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_collection_id")]
        public string? TargetCollectionId { get; set; }

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
        /// The product photo to edit, by reference. Everything outside the<br/>
        /// masked region is preserved. Provide exactly one of<br/>
        /// `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="image">
        /// The product photo to edit (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The product photo to edit (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
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
        /// Masks marking the regions to change (max 4, max size 25MB each).<br/>
        /// JPEG, PNG, and WEBP formats are supported. Every mask must have the<br/>
        /// same pixel dimensions as the product photo. White pixels mark the<br/>
        /// region to change and black pixels are preserved; alpha-only masks<br/>
        /// also work (opaque = change, transparent = preserve).
        /// </param>
        /// <param name="materialAssetIdentifiers">
        /// The material reference images, by reference. Only their material —<br/>
        /// color, texture, pattern scale, and orientation — is applied to the<br/>
        /// masked regions. Send one material, which every mask takes, or<br/>
        /// exactly one per mask paired by position. Provide exactly one of<br/>
        /// `material_asset_identifiers` or `materials`.
        /// </param>
        /// <param name="materials">
        /// Material reference images (max size 25MB each). JPEG, PNG, and WEBP<br/>
        /// formats are supported. Only their material (color, texture, pattern<br/>
        /// scale, and orientation) is applied to the masked regions. Send one<br/>
        /// material for every mask, or exactly one per mask, paired by<br/>
        /// position.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Defaults to the product photo's aspect ratio,<br/>
        /// which keeps the original framing. A different ratio extends the<br/>
        /// scene to fill the new shape rather than cropping, so part of the<br/>
        /// frame is newly generated. Supported values are `1:1`, `3:4`,<br/>
        /// `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. Completed outputs are added to it automatically.
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
            global::Ideogram.MaterialSwapQuality? quality,
            string? targetCollectionId,
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
            this.TargetCollectionId = targetCollectionId;
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