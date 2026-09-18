
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Request body for Seedance 2.5 reference-to-video. The prompt<br/>
    /// addresses references by position — `[Image1]`,<br/>
    /// `[Video1]`, and so on. Reference images arrive either<br/>
    /// as `reference_image_asset_identifiers` or (multipart requests only) as<br/>
    /// raw `reference_images` bytes, never both. Reference videos arrive only<br/>
    /// as `reference_video_asset_identifiers`, which may reference uploaded or<br/>
    /// generated videos. At least one reference image or video is<br/>
    /// required.
    /// </summary>
    public sealed partial class GenerateVideoSeedDance25ReferenceToVideoRequest
    {
        /// <summary>
        /// A natural-language prompt describing the video to produce. Reference media is addressed by position, as in "[Image1] walks toward the camera with the motion of [Video1]".<br/>
        /// Example: [Image1] walks through the snowy forest at dawn.
        /// </summary>
        /// <example>[Image1] walks through the snowy forest at dawn.</example>
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
        /// Uploaded or generated videos to use as references, by reference, in prompt order. Each clip must be between 2 and 30 seconds long, and the clips must total no more than 30 seconds. Upload video files first and pass their asset identifiers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_video_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? ReferenceVideoAssetIdentifiers { get; set; }

        /// <summary>
        /// MP3 or WAV audio references, in prompt order. Multipart requests only. Each file must be at most 15 MB and between 2 and 30 seconds; combined duration must not exceed 30 seconds. At least one reference image or video is required. Audio is used for this generation only and is not saved to your library.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_audios")]
        public global::System.Collections.Generic.IList<byte[]>? ReferenceAudios { get; set; }

        /// <summary>
        /// The aspect ratio of the generated video. `AUTO` lets the model choose the<br/>
        /// most suitable ratio from the prompt; any other value pins the ratio.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.SeedDance2AspectRatioJsonConverter))]
        public global::Ideogram.SeedDance2AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The resolution tier of the generated video.<br/>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.SeedDance25ResolutionJsonConverter))]
        public global::Ideogram.SeedDance25Resolution? Resolution { get; set; }

        /// <summary>
        /// The length of the generated video in seconds. When omitted, the model<br/>
        /// picks the best duration for the prompt ("auto").<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
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
        /// Initializes a new instance of the <see cref="GenerateVideoSeedDance25ReferenceToVideoRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A natural-language prompt describing the video to produce. Reference media is addressed by position, as in "[Image1] walks toward the camera with the motion of [Video1]".<br/>
        /// Example: [Image1] walks through the snowy forest at dawn.
        /// </param>
        /// <param name="referenceImageAssetIdentifiers">
        /// Images already stored with Ideogram to use as references, by reference, in prompt order. Cannot be combined with `reference_images`. Only image assets are accepted.
        /// </param>
        /// <param name="referenceImages">
        /// Images to use as references (max size 50MB each), as raw bytes, in prompt order; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. Cannot be combined with `reference_image_asset_identifiers`. The bytes are used for this request only and are not stored as an asset.
        /// </param>
        /// <param name="referenceVideoAssetIdentifiers">
        /// Uploaded or generated videos to use as references, by reference, in prompt order. Each clip must be between 2 and 30 seconds long, and the clips must total no more than 30 seconds. Upload video files first and pass their asset identifiers.
        /// </param>
        /// <param name="referenceAudios">
        /// MP3 or WAV audio references, in prompt order. Multipart requests only. Each file must be at most 15 MB and between 2 and 30 seconds; combined duration must not exceed 30 seconds. At least one reference image or video is required. Audio is used for this generation only and is not saved to your library.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generated video. `AUTO` lets the model choose the<br/>
        /// most suitable ratio from the prompt; any other value pins the ratio.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="resolution">
        /// The resolution tier of the generated video.<br/>
        /// Default Value: 720p
        /// </param>
        /// <param name="duration">
        /// The length of the generated video in seconds. When omitted, the model<br/>
        /// picks the best duration for the prompt ("auto").<br/>
        /// Example: 5
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
        public GenerateVideoSeedDance25ReferenceToVideoRequest(
            string prompt,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceImageAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? referenceImages,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceVideoAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? referenceAudios,
            global::Ideogram.SeedDance2AspectRatio? aspectRatio,
            global::Ideogram.SeedDance25Resolution? resolution,
            int? duration,
            bool? generateAudio,
            string? webhookUrl,
            bool? @private,
            string? targetCollectionId)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ReferenceImageAssetIdentifiers = referenceImageAssetIdentifiers;
            this.ReferenceImages = referenceImages;
            this.ReferenceVideoAssetIdentifiers = referenceVideoAssetIdentifiers;
            this.ReferenceAudios = referenceAudios;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Duration = duration;
            this.GenerateAudio = generateAudio;
            this.WebhookUrl = webhookUrl;
            this.Private = @private;
            this.TargetCollectionId = targetCollectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoSeedDance25ReferenceToVideoRequest" /> class.
        /// </summary>
        public GenerateVideoSeedDance25ReferenceToVideoRequest()
        {
        }

    }
}