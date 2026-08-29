
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"aspect_ratio":"aspect_ratio","private":true,"webhook_url":"https://api.example.com/webhooks/ideogram","category":"dresses","num_shoots":1,"product_asset_identifiers":[{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}]}
    /// </summary>
    public sealed partial class LookbookRequest
    {
        /// <summary>
        /// Product images whose appearance must be preserved in the generated looks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_asset_identifiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier> ProductAssetIdentifiers { get; set; }

        /// <summary>
        /// Selects the category-specific Lookbook presentation reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.LookbookRequestCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.LookbookRequestCategory Category { get; set; }

        /// <summary>
        /// The aspect ratio of each generated 2x2 composite before it is split into images. Defaults to `1:1` when omitted. Supported values are `1:1`, `3:4`, and `9:16`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// Number of four-image lookbook shoots to create.<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_shoots")]
        public int? NumShoots { get; set; }

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
        /// Initializes a new instance of the <see cref="LookbookRequest" /> class.
        /// </summary>
        /// <param name="productAssetIdentifiers">
        /// Product images whose appearance must be preserved in the generated looks.
        /// </param>
        /// <param name="category">
        /// Selects the category-specific Lookbook presentation reference.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of each generated 2x2 composite before it is split into images. Defaults to `1:1` when omitted. Supported values are `1:1`, `3:4`, and `9:16`.
        /// </param>
        /// <param name="numShoots">
        /// Number of four-image lookbook shoots to create.<br/>
        /// Default Value: 3
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
        public LookbookRequest(
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier> productAssetIdentifiers,
            global::Ideogram.LookbookRequestCategory category,
            string? aspectRatio,
            int? numShoots,
            bool? @private,
            string? webhookUrl)
        {
            this.ProductAssetIdentifiers = productAssetIdentifiers ?? throw new global::System.ArgumentNullException(nameof(productAssetIdentifiers));
            this.Category = category;
            this.AspectRatio = aspectRatio;
            this.NumShoots = numShoots;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LookbookRequest" /> class.
        /// </summary>
        public LookbookRequest()
        {
        }

    }
}