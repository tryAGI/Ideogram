
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Provide exactly one of `source_asset_identifier` or multipart `source_image`, plus one to four ordered target-model references.
    /// </summary>
    public sealed partial class ModelSwapRequest
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_asset_identifier")]
        public global::Ideogram.AssetIdentifier? SourceAssetIdentifier { get; set; }

        /// <summary>
        /// Raw working-image bytes. Supported formats and the 50 MB limit match the image upload API. Available only with `multipart/form-data`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_image")]
        public byte[]? SourceImage { get; set; }

        /// <summary>
        /// Raw working-image bytes. Supported formats and the 50 MB limit match the image upload API. Available only with `multipart/form-data`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_imagename")]
        public string? SourceImagename { get; set; }

        /// <summary>
        /// Ordered target-model identity and angle references. These images supply only identity, hair, skin tone, and body proportions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_asset_identifiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier> ModelAssetIdentifiers { get; set; }

        /// <summary>
        /// Optional identity details that are not visible in the target-model references. This cannot override the source roles described above.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public string? Instruction { get; set; }

        /// <summary>
        /// Output aspect ratio. When omitted, the closest supported ratio is derived from the working image.
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
        /// Optional seed for repeatable results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Number of model-swap images to create.<br/>
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
        /// Initializes a new instance of the <see cref="ModelSwapRequest" /> class.
        /// </summary>
        /// <param name="modelAssetIdentifiers">
        /// Ordered target-model identity and angle references. These images supply only identity, hair, skin tone, and body proportions.
        /// </param>
        /// <param name="sourceAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="sourceImage">
        /// Raw working-image bytes. Supported formats and the 50 MB limit match the image upload API. Available only with `multipart/form-data`.
        /// </param>
        /// <param name="sourceImagename">
        /// Raw working-image bytes. Supported formats and the 50 MB limit match the image upload API. Available only with `multipart/form-data`.
        /// </param>
        /// <param name="instruction">
        /// Optional identity details that are not visible in the target-model references. This cannot override the source roles described above.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. When omitted, the closest supported ratio is derived from the working image.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
        /// </param>
        /// <param name="numImages">
        /// Number of model-swap images to create.<br/>
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
        public ModelSwapRequest(
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier> modelAssetIdentifiers,
            global::Ideogram.AssetIdentifier? sourceAssetIdentifier,
            byte[]? sourceImage,
            string? sourceImagename,
            string? instruction,
            string? aspectRatio,
            global::Ideogram.GptImage2Quality? quality,
            int? seed,
            int? numImages,
            bool? @private,
            string? webhookUrl)
        {
            this.SourceAssetIdentifier = sourceAssetIdentifier;
            this.SourceImage = sourceImage;
            this.SourceImagename = sourceImagename;
            this.ModelAssetIdentifiers = modelAssetIdentifiers ?? throw new global::System.ArgumentNullException(nameof(modelAssetIdentifiers));
            this.Instruction = instruction;
            this.AspectRatio = aspectRatio;
            this.Quality = quality;
            this.Seed = seed;
            this.NumImages = numImages;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSwapRequest" /> class.
        /// </summary>
        public ModelSwapRequest()
        {
        }

    }
}