
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"mode":null,"aspect_ratio":"aspect_ratio","private":true,"webhook_url":"https://api.example.com/webhooks/ideogram","instruction":"instruction","source_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"num_images":0,"product_asset_identifiers":[{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}],"quality":null}
    /// </summary>
    public sealed partial class SwapProductRequest
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_asset_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AssetIdentifier SourceAssetIdentifier { get; set; }

        /// <summary>
        /// Ordered footwear references, following the source advertisement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_asset_identifiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier> ProductAssetIdentifiers { get; set; }

        /// <summary>
        /// Replace the footwear or match its colorway to the references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.SwapProductModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.SwapProductMode Mode { get; set; }

        /// <summary>
        /// Optional edits that take precedence over the default preservation guidance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public string? Instruction { get; set; }

        /// <summary>
        /// Output aspect ratio. Defaults to the closest supported ratio to the source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// Number of images to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.SwapProductQualityJsonConverter))]
        public global::Ideogram.SwapProductQuality? Quality { get; set; }

        /// <summary>
        /// Results are private by default. Set false to request public results.<br/>
        /// Enterprise accounts always generate privately.
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
        /// Initializes a new instance of the <see cref="SwapProductRequest" /> class.
        /// </summary>
        /// <param name="sourceAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="productAssetIdentifiers">
        /// Ordered footwear references, following the source advertisement.
        /// </param>
        /// <param name="mode">
        /// Replace the footwear or match its colorway to the references.
        /// </param>
        /// <param name="instruction">
        /// Optional edits that take precedence over the default preservation guidance.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Defaults to the closest supported ratio to the source.
        /// </param>
        /// <param name="numImages">
        /// Number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="private">
        /// Results are private by default. Set false to request public results.<br/>
        /// Enterprise accounts always generate privately.
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
        public SwapProductRequest(
            global::Ideogram.AssetIdentifier sourceAssetIdentifier,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier> productAssetIdentifiers,
            global::Ideogram.SwapProductMode mode,
            string? instruction,
            string? aspectRatio,
            int? numImages,
            global::Ideogram.SwapProductQuality? quality,
            bool? @private,
            string? webhookUrl)
        {
            this.SourceAssetIdentifier = sourceAssetIdentifier ?? throw new global::System.ArgumentNullException(nameof(sourceAssetIdentifier));
            this.ProductAssetIdentifiers = productAssetIdentifiers ?? throw new global::System.ArgumentNullException(nameof(productAssetIdentifiers));
            this.Mode = mode;
            this.Instruction = instruction;
            this.AspectRatio = aspectRatio;
            this.NumImages = numImages;
            this.Quality = quality;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwapProductRequest" /> class.
        /// </summary>
        public SwapProductRequest()
        {
        }

    }
}