
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerateSvgGptImage26FlareRequest
    {
        /// <summary>
        /// What the SVG should show, passed to the model as written.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The output aspect ratio, for example "1:1", "16:9", or "9:16". "auto" (the default) lets the model choose a shape that suits the prompt. The long:short ratio is at most 3:1.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// How much rendering effort GPT Image 2.6 Flare spends on the image the SVG is drawn from. Lower tiers return sooner and cost less; `auto` lets the model choose, which it currently renders at `high`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.GenerateSvgGptImage26FlareRequestQualityJsonConverter))]
        public global::Ideogram.V2.GenerateSvgGptImage26FlareRequestQuality? Quality { get; set; }

        /// <summary>
        /// How much the model plans before it renders, separate from `quality`. Lower levels return sooner.<br/>
        /// Default Value: high
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.GenerateSvgGptImage26FlareRequestThinkingLevelJsonConverter))]
        public global::Ideogram.V2.GenerateSvgGptImage26FlareRequestThinkingLevel? ThinkingLevel { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Outputs are private by default. Enterprise outputs are always private.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// URL-safe base64 ID of a writable destination collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_collection_id")]
        public string? TargetCollectionId { get; set; }

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
        /// Initializes a new instance of the <see cref="GenerateSvgGptImage26FlareRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// What the SVG should show, passed to the model as written.
        /// </param>
        /// <param name="aspectRatio">
        /// The output aspect ratio, for example "1:1", "16:9", or "9:16". "auto" (the default) lets the model choose a shape that suits the prompt. The long:short ratio is at most 3:1.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="quality">
        /// How much rendering effort GPT Image 2.6 Flare spends on the image the SVG is drawn from. Lower tiers return sooner and cost less; `auto` lets the model choose, which it currently renders at `high`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="thinkingLevel">
        /// How much the model plans before it renders, separate from `quality`. Lower levels return sooner.<br/>
        /// Default Value: high
        /// </param>
        /// <param name="numImages">
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="private">
        /// Outputs are private by default. Enterprise outputs are always private.
        /// </param>
        /// <param name="targetCollectionId">
        /// URL-safe base64 ID of a writable destination collection.
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
        public GenerateSvgGptImage26FlareRequest(
            string prompt,
            string? aspectRatio,
            global::Ideogram.V2.GenerateSvgGptImage26FlareRequestQuality? quality,
            global::Ideogram.V2.GenerateSvgGptImage26FlareRequestThinkingLevel? thinkingLevel,
            int? numImages,
            int? seed,
            bool? @private,
            string? targetCollectionId,
            string? webhookUrl)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.AspectRatio = aspectRatio;
            this.Quality = quality;
            this.ThinkingLevel = thinkingLevel;
            this.NumImages = numImages;
            this.Seed = seed;
            this.Private = @private;
            this.TargetCollectionId = targetCollectionId;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSvgGptImage26FlareRequest" /> class.
        /// </summary>
        public GenerateSvgGptImage26FlareRequest()
        {
        }

    }
}