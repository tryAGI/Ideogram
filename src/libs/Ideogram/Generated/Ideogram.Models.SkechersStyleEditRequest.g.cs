
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"base_description":"base_description","aspect_ratio":61,"private":true,"reference_asset_identifiers":[{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}],"webhook_url":"https://api.example.com/webhooks/ideogram","base_generation_size":"2k","base_asset_identifier":"","reference_descriptions":["reference_descriptions","reference_descriptions","reference_descriptions","reference_descriptions","reference_descriptions"],"resolved_instruction":"resolved_instruction","num_images":0}
    /// </summary>
    public sealed partial class SkechersStyleEditRequest
    {
        /// <summary>
        /// Image to edit, used as image 1 and the output canvas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_asset_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AssetIdentifier BaseAssetIdentifier { get; set; }

        /// <summary>
        /// Ordered reference images, numbered from image 2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? ReferenceAssetIdentifiers { get; set; }

        /// <summary>
        /// Edit instructions with known image mentions resolved to image numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResolvedInstruction { get; set; }

        /// <summary>
        /// Optional description of the selected base image or named view.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_description")]
        public string? BaseDescription { get; set; }

        /// <summary>
        /// One nonempty description per reference image, in the same order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_descriptions")]
        public global::System.Collections.Generic.IList<string>? ReferenceDescriptions { get; set; }

        /// <summary>
        /// Output ratio. When omitted, derive the nearest supported ratio from the base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.SkechersStyleEditRequestAspectRatioJsonConverter))]
        public global::Ideogram.SkechersStyleEditRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Output resolution tier; corresponds to the app's low, medium, and high settings.<br/>
        /// Default Value: 2k
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_generation_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.SkechersStyleEditRequestBaseGenerationSizeJsonConverter))]
        public global::Ideogram.SkechersStyleEditRequestBaseGenerationSize? BaseGenerationSize { get; set; }

        /// <summary>
        /// Number of edited images to create.<br/>
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
        /// Initializes a new instance of the <see cref="SkechersStyleEditRequest" /> class.
        /// </summary>
        /// <param name="baseAssetIdentifier">
        /// Image to edit, used as image 1 and the output canvas.
        /// </param>
        /// <param name="resolvedInstruction">
        /// Edit instructions with known image mentions resolved to image numbers.
        /// </param>
        /// <param name="referenceAssetIdentifiers">
        /// Ordered reference images, numbered from image 2.
        /// </param>
        /// <param name="baseDescription">
        /// Optional description of the selected base image or named view.
        /// </param>
        /// <param name="referenceDescriptions">
        /// One nonempty description per reference image, in the same order.
        /// </param>
        /// <param name="aspectRatio">
        /// Output ratio. When omitted, derive the nearest supported ratio from the base.
        /// </param>
        /// <param name="baseGenerationSize">
        /// Output resolution tier; corresponds to the app's low, medium, and high settings.<br/>
        /// Default Value: 2k
        /// </param>
        /// <param name="numImages">
        /// Number of edited images to create.<br/>
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
        public SkechersStyleEditRequest(
            global::Ideogram.AssetIdentifier baseAssetIdentifier,
            string resolvedInstruction,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceAssetIdentifiers,
            string? baseDescription,
            global::System.Collections.Generic.IList<string>? referenceDescriptions,
            global::Ideogram.SkechersStyleEditRequestAspectRatio? aspectRatio,
            global::Ideogram.SkechersStyleEditRequestBaseGenerationSize? baseGenerationSize,
            int? numImages,
            bool? @private,
            string? webhookUrl)
        {
            this.BaseAssetIdentifier = baseAssetIdentifier ?? throw new global::System.ArgumentNullException(nameof(baseAssetIdentifier));
            this.ReferenceAssetIdentifiers = referenceAssetIdentifiers;
            this.ResolvedInstruction = resolvedInstruction ?? throw new global::System.ArgumentNullException(nameof(resolvedInstruction));
            this.BaseDescription = baseDescription;
            this.ReferenceDescriptions = referenceDescriptions;
            this.AspectRatio = aspectRatio;
            this.BaseGenerationSize = baseGenerationSize;
            this.NumImages = numImages;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkechersStyleEditRequest" /> class.
        /// </summary>
        public SkechersStyleEditRequest()
        {
        }

    }
}