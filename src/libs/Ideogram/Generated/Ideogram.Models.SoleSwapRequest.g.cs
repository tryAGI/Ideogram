
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"aspect_ratio":"aspect_ratio","private":true,"seed":12345,"webhook_url":"https://api.example.com/webhooks/ideogram","base_generation_size":"2k","base_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"instruction":"instruction","num_images":0,"upper_asset_identifiers":[{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}],"quality":null}
    /// </summary>
    public sealed partial class SoleSwapRequest
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_asset_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AssetIdentifier BaseAssetIdentifier { get; set; }

        /// <summary>
        /// Ordered upper-donor references. Put the primary upper view first, then additional angles of the same upper to transfer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upper_asset_identifiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier> UpperAssetIdentifiers { get; set; }

        /// <summary>
        /// Optional additional direction for the sole swap.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public string? Instruction { get; set; }

        /// <summary>
        /// Output aspect ratio. When omitted, the closest supported ratio is derived from the sole-donor base image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// Output resolution tier. Defaults to 2k.<br/>
        /// Default Value: 2k
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_generation_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.SoleSwapRequestBaseGenerationSizeJsonConverter))]
        public global::Ideogram.SoleSwapRequestBaseGenerationSize? BaseGenerationSize { get; set; }

        /// <summary>
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GptImage2QualityJsonConverter))]
        public global::Ideogram.GptImage2Quality? Quality { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Number of sole-swap images to create.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

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
        /// Initializes a new instance of the <see cref="SoleSwapRequest" /> class.
        /// </summary>
        /// <param name="baseAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="upperAssetIdentifiers">
        /// Ordered upper-donor references. Put the primary upper view first, then additional angles of the same upper to transfer.
        /// </param>
        /// <param name="instruction">
        /// Optional additional direction for the sole swap.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. When omitted, the closest supported ratio is derived from the sole-donor base image.
        /// </param>
        /// <param name="baseGenerationSize">
        /// Output resolution tier. Defaults to 2k.<br/>
        /// Default Value: 2k
        /// </param>
        /// <param name="quality">
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="numImages">
        /// Number of sole-swap images to create.<br/>
        /// Default Value: 1
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
        public SoleSwapRequest(
            global::Ideogram.AssetIdentifier baseAssetIdentifier,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier> upperAssetIdentifiers,
            string? instruction,
            string? aspectRatio,
            global::Ideogram.SoleSwapRequestBaseGenerationSize? baseGenerationSize,
            global::Ideogram.GptImage2Quality? quality,
            int? seed,
            int? numImages,
            bool? @private,
            string? webhookUrl)
        {
            this.BaseAssetIdentifier = baseAssetIdentifier ?? throw new global::System.ArgumentNullException(nameof(baseAssetIdentifier));
            this.UpperAssetIdentifiers = upperAssetIdentifiers ?? throw new global::System.ArgumentNullException(nameof(upperAssetIdentifiers));
            this.Instruction = instruction;
            this.AspectRatio = aspectRatio;
            this.BaseGenerationSize = baseGenerationSize;
            this.Quality = quality;
            this.Seed = seed;
            this.NumImages = numImages;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SoleSwapRequest" /> class.
        /// </summary>
        public SoleSwapRequest()
        {
        }

    }
}