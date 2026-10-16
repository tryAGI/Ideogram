
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoGeneratePostGenerateVideoSeedDance25ReferenceToVideoRequest
    {
        /// <summary>
        /// A natural-language prompt describing the video to produce. Refer to references by position, as in "[Image1] walks toward the camera".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Reference images, in prompt order. Common formats such as JPEG, PNG, and WEBP are supported, up to 50MB each. Multipart requests only. Uploaded images are used for this request only and are not stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? ReferenceImages { get; set; }

        /// <summary>
        /// MP3 or WAV audio references, in prompt order. Multipart requests only. Each file must be at most 15 MB and between 2 and 30 seconds long, with a combined duration of at most 30 seconds. Requires at least one reference image. Audio is used for this request only and is not saved to your library.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_audios")]
        public global::System.Collections.Generic.IList<byte[]>? ReferenceAudios { get; set; }

        /// <summary>
        /// The aspect ratio of the generated video. `auto` lets the model choose the<br/>
        /// most suitable ratio from the prompt; any other value pins the ratio.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.SeedDance2AspectRatioJsonConverter))]
        public global::Ideogram.V2.SeedDance2AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The resolution tier of the generated video.<br/>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.SeedDance25ResolutionJsonConverter))]
        public global::Ideogram.V2.SeedDance25Resolution? Resolution { get; set; }

        /// <summary>
        /// The length of the generated video in seconds. When omitted, the model<br/>
        /// picks the best duration for the prompt ("auto").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Whether to generate an audio track for the video. Audio roughly<br/>
        /// doubles the provider cost and is subject to stricter output moderation.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_audio")]
        public bool? GenerateAudio { get; set; }

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
        /// Initializes a new instance of the <see cref="VideoGeneratePostGenerateVideoSeedDance25ReferenceToVideoRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A natural-language prompt describing the video to produce. Refer to references by position, as in "[Image1] walks toward the camera".
        /// </param>
        /// <param name="referenceImages">
        /// Reference images, in prompt order. Common formats such as JPEG, PNG, and WEBP are supported, up to 50MB each. Multipart requests only. Uploaded images are used for this request only and are not stored.
        /// </param>
        /// <param name="referenceAudios">
        /// MP3 or WAV audio references, in prompt order. Multipart requests only. Each file must be at most 15 MB and between 2 and 30 seconds long, with a combined duration of at most 30 seconds. Requires at least one reference image. Audio is used for this request only and is not saved to your library.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generated video. `auto` lets the model choose the<br/>
        /// most suitable ratio from the prompt; any other value pins the ratio.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="resolution">
        /// The resolution tier of the generated video.<br/>
        /// Default Value: 720p
        /// </param>
        /// <param name="duration">
        /// The length of the generated video in seconds. When omitted, the model<br/>
        /// picks the best duration for the prompt ("auto").
        /// </param>
        /// <param name="generateAudio">
        /// Whether to generate an audio track for the video. Audio roughly<br/>
        /// doubles the provider cost and is subject to stricter output moderation.<br/>
        /// Default Value: false
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
        public VideoGeneratePostGenerateVideoSeedDance25ReferenceToVideoRequest(
            string prompt,
            global::System.Collections.Generic.IList<byte[]>? referenceImages,
            global::System.Collections.Generic.IList<byte[]>? referenceAudios,
            global::Ideogram.V2.SeedDance2AspectRatio? aspectRatio,
            global::Ideogram.V2.SeedDance25Resolution? resolution,
            int? duration,
            bool? generateAudio,
            string? webhookUrl)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ReferenceImages = referenceImages;
            this.ReferenceAudios = referenceAudios;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Duration = duration;
            this.GenerateAudio = generateAudio;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGeneratePostGenerateVideoSeedDance25ReferenceToVideoRequest" /> class.
        /// </summary>
        public VideoGeneratePostGenerateVideoSeedDance25ReferenceToVideoRequest()
        {
        }

    }
}