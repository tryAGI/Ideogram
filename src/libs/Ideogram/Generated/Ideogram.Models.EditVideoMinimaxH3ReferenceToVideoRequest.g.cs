
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Request body for MiniMax H3 reference-to-video. The prompt addresses<br/>
    /// references by position — `Image 1`, `Video 1`, and so on. Reference<br/>
    /// images arrive either as `reference_image_asset_identifiers` or<br/>
    /// (multipart requests only) as raw `reference_images` bytes, never both.<br/>
    /// Reference videos arrive only as<br/>
    /// `reference_video_asset_identifiers`, which must reference videos<br/>
    /// generated with Ideogram. Every reference is optional.
    /// </summary>
    public sealed partial class EditVideoMinimaxH3ReferenceToVideoRequest
    {
        /// <summary>
        /// A natural-language prompt describing the video to produce. Reference media is addressed by position, as in "Image 1 walks toward the camera with the motion of Video 1".<br/>
        /// Example: Image 1 walks through the snowy forest at dawn.
        /// </summary>
        /// <example>Image 1 walks through the snowy forest at dawn.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Images already stored with Ideogram to use as references, by reference, in prompt order. Cannot be combined with `reference_images`. Only image assets are accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? ReferenceImageAssetIdentifiers { get; set; }

        /// <summary>
        /// Images to use as references (max size 50MB each), as raw bytes, in prompt order; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. Cannot be combined with `reference_image_asset_identifiers`. The bytes are used for this request only and are not stored as an asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? ReferenceImages { get; set; }

        /// <summary>
        /// Videos generated with Ideogram to use as motion references, by reference, in prompt order. Each clip must be between 2 and 15 seconds long, and the clips must total no more than 15 seconds. Raw video uploads are not accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_video_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? ReferenceVideoAssetIdentifiers { get; set; }

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
        /// How much the model may rewrite the prompt before generating. `disabled`<br/>
        /// uses the prompt as written; the other modes trade latency for a richer<br/>
        /// rewrite.<br/>
        /// Default Value: balanced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_expansion_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MinimaxH3PromptExpansionModeJsonConverter))]
        public global::Ideogram.MinimaxH3PromptExpansionMode? PromptExpansionMode { get; set; }

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
        /// A collection you can write to, by its URL-safe base64 collection id. The output videos are added to it when the request completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_collection_id")]
        public string? TargetCollectionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditVideoMinimaxH3ReferenceToVideoRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A natural-language prompt describing the video to produce. Reference media is addressed by position, as in "Image 1 walks toward the camera with the motion of Video 1".<br/>
        /// Example: Image 1 walks through the snowy forest at dawn.
        /// </param>
        /// <param name="referenceImageAssetIdentifiers">
        /// Images already stored with Ideogram to use as references, by reference, in prompt order. Cannot be combined with `reference_images`. Only image assets are accepted.
        /// </param>
        /// <param name="referenceImages">
        /// Images to use as references (max size 50MB each), as raw bytes, in prompt order; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. Cannot be combined with `reference_image_asset_identifiers`. The bytes are used for this request only and are not stored as an asset.
        /// </param>
        /// <param name="referenceVideoAssetIdentifiers">
        /// Videos generated with Ideogram to use as motion references, by reference, in prompt order. Each clip must be between 2 and 15 seconds long, and the clips must total no more than 15 seconds. Raw video uploads are not accepted.
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
        /// <param name="promptExpansionMode">
        /// How much the model may rewrite the prompt before generating. `disabled`<br/>
        /// uses the prompt as written; the other modes trade latency for a richer<br/>
        /// rewrite.<br/>
        /// Default Value: balanced
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
        /// A collection you can write to, by its URL-safe base64 collection id. The output videos are added to it when the request completes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditVideoMinimaxH3ReferenceToVideoRequest(
            string prompt,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceImageAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? referenceImages,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceVideoAssetIdentifiers,
            global::Ideogram.MinimaxH3AspectRatio? aspectRatio,
            global::Ideogram.MinimaxH3Resolution? resolution,
            int? duration,
            global::Ideogram.MinimaxH3PromptExpansionMode? promptExpansionMode,
            string? webhookUrl,
            bool? @private,
            string? targetCollectionId)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ReferenceImageAssetIdentifiers = referenceImageAssetIdentifiers;
            this.ReferenceImages = referenceImages;
            this.ReferenceVideoAssetIdentifiers = referenceVideoAssetIdentifiers;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Duration = duration;
            this.PromptExpansionMode = promptExpansionMode;
            this.WebhookUrl = webhookUrl;
            this.Private = @private;
            this.TargetCollectionId = targetCollectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditVideoMinimaxH3ReferenceToVideoRequest" /> class.
        /// </summary>
        public EditVideoMinimaxH3ReferenceToVideoRequest()
        {
        }

    }
}