
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EditWorkflowPostMaterialSwapRequest
    {
        /// <summary>
        /// The product photo to edit (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The product photo to edit (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

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
        /// Initializes a new instance of the <see cref="EditWorkflowPostMaterialSwapRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The product photo to edit (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The product photo to edit (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
        /// </param>
        /// <param name="masks">
        /// Masks marking the regions to change (max 4, max size 25MB each).<br/>
        /// JPEG, PNG, and WEBP formats are supported. Every mask must have the<br/>
        /// same pixel dimensions as the product photo. White pixels mark the<br/>
        /// region to change and black pixels are preserved; alpha-only masks<br/>
        /// also work (opaque = change, transparent = preserve).
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
        public EditWorkflowPostMaterialSwapRequest(
            byte[] image,
            string imagename,
            global::System.Collections.Generic.IList<byte[]>? masks,
            global::System.Collections.Generic.IList<byte[]>? materials,
            string? aspectRatio,
            global::Ideogram.MaterialSwapQuality? quality,
            string? webhookUrl)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Masks = masks;
            this.Materials = materials;
            this.AspectRatio = aspectRatio;
            this.Quality = quality;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditWorkflowPostMaterialSwapRequest" /> class.
        /// </summary>
        public EditWorkflowPostMaterialSwapRequest()
        {
        }

    }
}