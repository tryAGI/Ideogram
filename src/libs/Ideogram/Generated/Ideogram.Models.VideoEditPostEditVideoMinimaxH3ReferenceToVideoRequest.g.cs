
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoEditPostEditVideoMinimaxH3ReferenceToVideoRequest
    {
        /// <summary>
        /// A natural-language prompt describing the video to produce. Reference media is addressed by position, as in "Image 1 walks toward the camera with the motion of Video 1".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Images to use as references (max size 50MB each), as raw bytes, in prompt order; only common image formats such as JPEG, PNG, and WEBP are supported. Uploaded images are used for this request only and are not stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? ReferenceImages { get; set; }

        /// <summary>
        /// MP3 or WAV audio references, in prompt order as Audio 1, Audio 2, and Audio 3. Multipart uploads only; up to 15 MB per file and 2–15 seconds each. Audio and video references must total no more than 15 seconds. Requires a reference image or video. At most 12 references across images, videos, and audio. Used only for this request and not saved as assets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_audios")]
        public global::System.Collections.Generic.IList<byte[]>? ReferenceAudios { get; set; }

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
        /// Initializes a new instance of the <see cref="VideoEditPostEditVideoMinimaxH3ReferenceToVideoRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A natural-language prompt describing the video to produce. Reference media is addressed by position, as in "Image 1 walks toward the camera with the motion of Video 1".
        /// </param>
        /// <param name="referenceImages">
        /// Images to use as references (max size 50MB each), as raw bytes, in prompt order; only common image formats such as JPEG, PNG, and WEBP are supported. Uploaded images are used for this request only and are not stored.
        /// </param>
        /// <param name="referenceAudios">
        /// MP3 or WAV audio references, in prompt order as Audio 1, Audio 2, and Audio 3. Multipart uploads only; up to 15 MB per file and 2–15 seconds each. Audio and video references must total no more than 15 seconds. Requires a reference image or video. At most 12 references across images, videos, and audio. Used only for this request and not saved as assets.
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
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoEditPostEditVideoMinimaxH3ReferenceToVideoRequest(
            string prompt,
            global::System.Collections.Generic.IList<byte[]>? referenceImages,
            global::System.Collections.Generic.IList<byte[]>? referenceAudios,
            global::Ideogram.MinimaxH3AspectRatio? aspectRatio,
            global::Ideogram.MinimaxH3Resolution? resolution,
            int? duration,
            global::Ideogram.MinimaxH3PromptExpansionMode? promptExpansionMode,
            string? webhookUrl)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ReferenceImages = referenceImages;
            this.ReferenceAudios = referenceAudios;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Duration = duration;
            this.PromptExpansionMode = promptExpansionMode;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoEditPostEditVideoMinimaxH3ReferenceToVideoRequest" /> class.
        /// </summary>
        public VideoEditPostEditVideoMinimaxH3ReferenceToVideoRequest()
        {
        }

    }
}