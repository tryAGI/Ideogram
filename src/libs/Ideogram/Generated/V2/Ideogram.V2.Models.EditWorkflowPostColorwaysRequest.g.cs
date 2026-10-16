
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EditWorkflowPostColorwaysRequest
    {
        /// <summary>
        /// The product photo to recolor (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The product photo to recolor (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// Masks marking the regions to recolor (max 4, max size 25MB each),<br/>
        /// paired by position with `colors`. JPEG, PNG, and WEBP formats are<br/>
        /// supported. Every mask must have the same pixel dimensions as the<br/>
        /// product photo. White pixels mark the region to recolor and black<br/>
        /// pixels are preserved; alpha-only masks also work (opaque =<br/>
        /// recolor, transparent = preserve).
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.ColorwaysQualityJsonConverter))]
        public global::Ideogram.V2.ColorwaysQuality? Quality { get; set; }

        /// <summary>
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditWorkflowPostColorwaysRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The product photo to recolor (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The product photo to recolor (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
        /// </param>
        /// <param name="colors">
        /// One target color per mask in `masks`, as six-digit hex codes like<br/>
        /// `#B3202C`, paired by position. The product's shape, construction,<br/>
        /// materials, prints, and logos are always preserved.
        /// </param>
        /// <param name="masks">
        /// Masks marking the regions to recolor (max 4, max size 25MB each),<br/>
        /// paired by position with `colors`. JPEG, PNG, and WEBP formats are<br/>
        /// supported. Every mask must have the same pixel dimensions as the<br/>
        /// product photo. White pixels mark the region to recolor and black<br/>
        /// pixels are preserved; alpha-only masks also work (opaque =<br/>
        /// recolor, transparent = preserve).
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
        /// <param name="webhookUrl">
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditWorkflowPostColorwaysRequest(
            byte[] image,
            string imagename,
            global::System.Collections.Generic.IList<string> colors,
            global::System.Collections.Generic.IList<byte[]>? masks,
            string? aspectRatio,
            global::Ideogram.V2.ColorwaysQuality? quality,
            string? webhookUrl)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Masks = masks;
            this.Colors = colors ?? throw new global::System.ArgumentNullException(nameof(colors));
            this.AspectRatio = aspectRatio;
            this.Quality = quality;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditWorkflowPostColorwaysRequest" /> class.
        /// </summary>
        public EditWorkflowPostColorwaysRequest()
        {
        }

    }
}