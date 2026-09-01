
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Supply the product photo as raw `image` bytes, and up to 4 masks with<br/>
    /// one color per mask; a single-region edit is a one-item `masks` list<br/>
    /// with a one-item `colors` list.
    /// </summary>
    public sealed partial class ColorwaysRequest
    {
        /// <summary>
        /// The product photo to recolor, by reference. Everything outside<br/>
        /// the masked region is preserved. Provide exactly one of<br/>
        /// `image_asset_identifier` or `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// The product photo to recolor (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The product photo to recolor (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// The masks marking the regions of the product photo to recolor, by<br/>
        /// reference, paired by position with `colors` (max 4). Every mask<br/>
        /// must have the same pixel dimensions as the product photo. White<br/>
        /// pixels mark the region to recolor; black pixels are preserved.<br/>
        /// Alpha-only masks are also supported: opaque pixels mark the<br/>
        /// region to recolor and transparent pixels are preserved. Provide<br/>
        /// exactly one of `mask_asset_identifiers` or `masks`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? MaskAssetIdentifiers { get; set; }

        /// <summary>
        /// The masks marking the regions of the product photo to recolor<br/>
        /// (max 4, max size 25MB each), as raw bytes, paired by position with<br/>
        /// `colors`; only JPEG, PNG, and WEBP formats are supported. Every<br/>
        /// mask must have the same pixel dimensions as the product photo.<br/>
        /// White pixels mark the region to recolor; black pixels are<br/>
        /// preserved. Alpha-only masks are also supported: opaque pixels<br/>
        /// mark the region to recolor and transparent pixels are preserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("masks")]
        public global::System.Collections.Generic.IList<byte[]>? Masks { get; set; }

        /// <summary>
        /// One target color per mask in `masks`, as six-digit hex codes like<br/>
        /// `#B3202C`, paired by position. The product's shape, construction,<br/>
        /// materials, prints, and logos are always preserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Colors { get; set; }

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
        /// Initializes a new instance of the <see cref="ColorwaysRequest" /> class.
        /// </summary>
        /// <param name="colors">
        /// One target color per mask in `masks`, as six-digit hex codes like<br/>
        /// `#B3202C`, paired by position. The product's shape, construction,<br/>
        /// materials, prints, and logos are always preserved.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// The product photo to recolor, by reference. Everything outside<br/>
        /// the masked region is preserved. Provide exactly one of<br/>
        /// `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="image">
        /// The product photo to recolor (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The product photo to recolor (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported.
        /// </param>
        /// <param name="maskAssetIdentifiers">
        /// The masks marking the regions of the product photo to recolor, by<br/>
        /// reference, paired by position with `colors` (max 4). Every mask<br/>
        /// must have the same pixel dimensions as the product photo. White<br/>
        /// pixels mark the region to recolor; black pixels are preserved.<br/>
        /// Alpha-only masks are also supported: opaque pixels mark the<br/>
        /// region to recolor and transparent pixels are preserved. Provide<br/>
        /// exactly one of `mask_asset_identifiers` or `masks`.
        /// </param>
        /// <param name="masks">
        /// The masks marking the regions of the product photo to recolor<br/>
        /// (max 4, max size 25MB each), as raw bytes, paired by position with<br/>
        /// `colors`; only JPEG, PNG, and WEBP formats are supported. Every<br/>
        /// mask must have the same pixel dimensions as the product photo.<br/>
        /// White pixels mark the region to recolor; black pixels are<br/>
        /// preserved. Alpha-only masks are also supported: opaque pixels<br/>
        /// mark the region to recolor and transparent pixels are preserved.
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
        public ColorwaysRequest(
            global::System.Collections.Generic.IList<string> colors,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            byte[]? image,
            string? imagename,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? maskAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? masks,
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
            this.Colors = colors ?? throw new global::System.ArgumentNullException(nameof(colors));
            this.AspectRatio = aspectRatio;
            this.Quality = quality;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorwaysRequest" /> class.
        /// </summary>
        public ColorwaysRequest()
        {
        }

    }
}