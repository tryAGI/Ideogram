
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EditWorkflowPostAdVariationsRequest
    {
        /// <summary>
        /// The source creative to vary (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported. Multipart requests only. Each output keeps<br/>
        /// the source's aspect ratio, capped at 3:1 between the long and short<br/>
        /// sides.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The source creative to vary (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported. Multipart requests only. Each output keeps<br/>
        /// the source's aspect ratio, capped at 3:1 between the long and short<br/>
        /// sides.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// The axis to vary. `people`<br/>
        /// replaces the people in the ad with different talent. `setting`<br/>
        /// moves the same subject and product to a different environment.<br/>
        /// `group_size` changes how many people appear. `scene` shifts the<br/>
        /// moment or occasion (time of day, season, or activity).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType VariationType { get; set; }

        /// <summary>
        /// Optional direction to steer the variation, for example "set it on a beach" or "make the models older". Anything it explicitly asks to change takes priority over the default preservation rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.AdVariationsQualityJsonConverter))]
        public global::Ideogram.V2.AdVariationsQuality? Quality { get; set; }

        /// <summary>
        /// The number of variations to generate along the requested axis.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

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
        /// Initializes a new instance of the <see cref="EditWorkflowPostAdVariationsRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The source creative to vary (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported. Multipart requests only. Each output keeps<br/>
        /// the source's aspect ratio, capped at 3:1 between the long and short<br/>
        /// sides.
        /// </param>
        /// <param name="imagename">
        /// The source creative to vary (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported. Multipart requests only. Each output keeps<br/>
        /// the source's aspect ratio, capped at 3:1 between the long and short<br/>
        /// sides.
        /// </param>
        /// <param name="variationType">
        /// The axis to vary. `people`<br/>
        /// replaces the people in the ad with different talent. `setting`<br/>
        /// moves the same subject and product to a different environment.<br/>
        /// `group_size` changes how many people appear. `scene` shifts the<br/>
        /// moment or occasion (time of day, season, or activity).
        /// </param>
        /// <param name="prompt">
        /// Optional direction to steer the variation, for example "set it on a beach" or "make the models older". Anything it explicitly asks to change takes priority over the default preservation rules.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="numImages">
        /// The number of variations to generate along the requested axis.<br/>
        /// Default Value: 1
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
        public EditWorkflowPostAdVariationsRequest(
            byte[] image,
            string imagename,
            global::Ideogram.V2.V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType variationType,
            string? prompt,
            global::Ideogram.V2.AdVariationsQuality? quality,
            int? numImages,
            string? webhookUrl)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.VariationType = variationType;
            this.Prompt = prompt;
            this.Quality = quality;
            this.NumImages = numImages;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditWorkflowPostAdVariationsRequest" /> class.
        /// </summary>
        public EditWorkflowPostAdVariationsRequest()
        {
        }

    }
}