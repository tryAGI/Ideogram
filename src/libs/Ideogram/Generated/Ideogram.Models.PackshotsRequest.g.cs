
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"product_asset_identifiers":[{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}],"view":"FRONT"}
    /// </summary>
    public sealed partial class PackshotsRequest
    {
        /// <summary>
        /// Ordered uploaded or generated product images. Their product color,<br/>
        /// construction, materials, logos, proportions, and distinguishing<br/>
        /// details guide every output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_asset_identifiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier> ProductAssetIdentifiers { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_asset_identifier")]
        public global::Ideogram.AssetIdentifier? StyleReferenceAssetIdentifier { get; set; }

        /// <summary>
        /// Product view to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.PackshotViewJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.PackshotView View { get; set; }

        /// <summary>
        /// Optional art direction for the studio background, lighting,<br/>
        /// framing, and presentation. Product fidelity rules always take<br/>
        /// precedence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public string? Instruction { get; set; }

        /// <summary>
        /// Aspect ratio for every generated image. Supported values are<br/>
        /// `1:1`, `3:4`, `4:3`, `16:9`, and `9:16`.
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
        /// Initializes a new instance of the <see cref="PackshotsRequest" /> class.
        /// </summary>
        /// <param name="productAssetIdentifiers">
        /// Ordered uploaded or generated product images. Their product color,<br/>
        /// construction, materials, logos, proportions, and distinguishing<br/>
        /// details guide every output.
        /// </param>
        /// <param name="view">
        /// Product view to generate.
        /// </param>
        /// <param name="styleReferenceAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="instruction">
        /// Optional art direction for the studio background, lighting,<br/>
        /// framing, and presentation. Product fidelity rules always take<br/>
        /// precedence.
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio for every generated image. Supported values are<br/>
        /// `1:1`, `3:4`, `4:3`, `16:9`, and `9:16`.
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
        public PackshotsRequest(
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier> productAssetIdentifiers,
            global::Ideogram.PackshotView view,
            global::Ideogram.AssetIdentifier? styleReferenceAssetIdentifier,
            string? instruction,
            string? aspectRatio,
            global::Ideogram.GptImage2Quality? quality,
            bool? @private,
            string? webhookUrl)
        {
            this.ProductAssetIdentifiers = productAssetIdentifiers ?? throw new global::System.ArgumentNullException(nameof(productAssetIdentifiers));
            this.StyleReferenceAssetIdentifier = styleReferenceAssetIdentifier;
            this.View = view;
            this.Instruction = instruction;
            this.AspectRatio = aspectRatio;
            this.Quality = quality;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PackshotsRequest" /> class.
        /// </summary>
        public PackshotsRequest()
        {
        }

    }
}