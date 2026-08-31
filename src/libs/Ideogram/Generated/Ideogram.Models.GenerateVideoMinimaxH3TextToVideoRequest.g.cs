
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Request body for MiniMax H3 text-to-video generation.<br/>
    /// Example: {"duration":5,"aspect_ratio":null,"private":true,"webhook_url":"https://api.example.com/webhooks/ideogram","target_collection_id":"target_collection_id","prompt":"A red fox running through a snowy forest at dawn.","resolution":null}
    /// </summary>
    public sealed partial class GenerateVideoMinimaxH3TextToVideoRequest
    {
        /// <summary>
        /// A natural-language prompt describing the video to generate.<br/>
        /// Example: A red fox running through a snowy forest at dawn.
        /// </summary>
        /// <example>A red fox running through a snowy forest at dawn.</example>
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
        /// The resolution tier of the generated video. `480p` and `768p` are<br/>
        /// generated natively; `2k` and `4k` are upscaled from a `768p` result.<br/>
        /// Higher tiers cost more.<br/>
        /// Default Value: 2k
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MinimaxH3ResolutionJsonConverter))]
        public global::Ideogram.MinimaxH3Resolution? Resolution { get; set; }

        /// <summary>
        /// The length of the generated video in seconds.<br/>
        /// Default Value: 5<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
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
        /// private and loopback hosts and the cloud metadata service are rejected.<br/>
        /// Example: https://api.example.com/webhooks/ideogram
        /// </summary>
        /// <example>https://api.example.com/webhooks/ideogram</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// A collection you can write to, by its URL-safe base64 collection id. The output video is added to it when the request completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_collection_id")]
        public string? TargetCollectionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoMinimaxH3TextToVideoRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A natural-language prompt describing the video to generate.<br/>
        /// Example: A red fox running through a snowy forest at dawn.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generated video.<br/>
        /// Default Value: 16x9
        /// </param>
        /// <param name="resolution">
        /// The resolution tier of the generated video. `480p` and `768p` are<br/>
        /// generated natively; `2k` and `4k` are upscaled from a `768p` result.<br/>
        /// Higher tiers cost more.<br/>
        /// Default Value: 2k
        /// </param>
        /// <param name="duration">
        /// The length of the generated video in seconds.<br/>
        /// Default Value: 5<br/>
        /// Example: 5
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
        /// <param name="private">
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. The output video is added to it when the request completes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateVideoMinimaxH3TextToVideoRequest(
            string prompt,
            global::Ideogram.MinimaxH3AspectRatio? aspectRatio,
            global::Ideogram.MinimaxH3Resolution? resolution,
            int? duration,
            string? webhookUrl,
            bool? @private,
            string? targetCollectionId)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Duration = duration;
            this.WebhookUrl = webhookUrl;
            this.Private = @private;
            this.TargetCollectionId = targetCollectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoMinimaxH3TextToVideoRequest" /> class.
        /// </summary>
        public GenerateVideoMinimaxH3TextToVideoRequest()
        {
        }

    }
}