
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Request body for MiniMax H3 text-to-video generation.
    /// </summary>
    public sealed partial class GenerateVideoMinimaxH3TextToVideoRequest
    {
        /// <summary>
        /// A natural-language prompt describing the video to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The aspect ratio of the generated video.<br/>
        /// Default Value: 16x9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MinimaxH3AspectRatioJsonConverter))]
        public global::Ideogram.MinimaxH3AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The resolution tier of the generated video, spelled the way MiniMax<br/>
        /// spells it. `480P` and `768P` are generated natively; `2K` and `4K` are<br/>
        /// upscaled from a `768P` result.<br/>
        /// Higher tiers cost more.<br/>
        /// Default Value: 2K
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MinimaxH3ResolutionJsonConverter))]
        public global::Ideogram.MinimaxH3Resolution? Resolution { get; set; }

        /// <summary>
        /// The length of the generated video in seconds.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

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
        /// Initializes a new instance of the <see cref="GenerateVideoMinimaxH3TextToVideoRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A natural-language prompt describing the video to generate.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generated video.<br/>
        /// Default Value: 16x9
        /// </param>
        /// <param name="resolution">
        /// The resolution tier of the generated video, spelled the way MiniMax<br/>
        /// spells it. `480P` and `768P` are generated natively; `2K` and `4K` are<br/>
        /// upscaled from a `768P` result.<br/>
        /// Higher tiers cost more.<br/>
        /// Default Value: 2K
        /// </param>
        /// <param name="duration">
        /// The length of the generated video in seconds.<br/>
        /// Default Value: 5
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
        public GenerateVideoMinimaxH3TextToVideoRequest(
            string prompt,
            global::Ideogram.MinimaxH3AspectRatio? aspectRatio,
            global::Ideogram.MinimaxH3Resolution? resolution,
            int? duration,
            string? webhookUrl)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Duration = duration;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoMinimaxH3TextToVideoRequest" /> class.
        /// </summary>
        public GenerateVideoMinimaxH3TextToVideoRequest()
        {
        }

    }
}