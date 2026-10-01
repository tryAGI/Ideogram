
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Request body for Seedance 2.0 reference-to-video. Upload<br/>
    /// `reference_images` (at least one is required) and optional<br/>
    /// `reference_audios` using `multipart/form-data`. The prompt refers to<br/>
    /// them by position: `@Image1`, `@Audio1`, and so on.
    /// </summary>
    public sealed partial class GenerateVideoSeedDance2ReferenceToVideoRequest
    {
        /// <summary>
        /// A natural-language prompt describing the video to produce. Refer to references by position, as in "@Image1 walks toward the camera".<br/>
        /// Example: @Image1 walks through the snowy forest at dawn.
        /// </summary>
        /// <example>@Image1 walks through the snowy forest at dawn.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Images already stored with Ideogram to use as references, by reference, in prompt order. Cannot be combined with `reference_images`. Only image assets are accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? ReferenceImageAssetIdentifiers { get; set; }

        /// <summary>
        /// Reference images, in prompt order. Common formats such as JPEG, PNG, and WEBP are supported, up to 50MB each. Multipart requests only. Uploaded images are used for this request only and are not stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? ReferenceImages { get; set; }

        /// <summary>
        /// Uploaded or generated videos to use as references, by reference, in prompt order. Each clip must be between 2 and 15 seconds long, and the clips must total no more than 15 seconds. Upload video files first and pass their asset identifiers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_video_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? ReferenceVideoAssetIdentifiers { get; set; }

        /// <summary>
        /// MP3 or WAV audio references, in prompt order. Multipart requests only. Each file must be at most 15 MB and between 2 and 15 seconds long, with a combined duration of at most 15 seconds. Requires at least one reference image. Audio is used for this request only and is not saved to your library.
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.SeedDance2ResolutionJsonConverter))]
        public global::Ideogram.SeedDance2Resolution? Resolution { get; set; }

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
        /// Initializes a new instance of the <see cref="GenerateVideoSeedDance2ReferenceToVideoRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A natural-language prompt describing the video to produce. Refer to references by position, as in "@Image1 walks toward the camera".<br/>
        /// Example: @Image1 walks through the snowy forest at dawn.
        /// </param>
        /// <param name="referenceImageAssetIdentifiers">
        /// Images already stored with Ideogram to use as references, by reference, in prompt order. Cannot be combined with `reference_images`. Only image assets are accepted.
        /// </param>
        /// <param name="referenceImages">
        /// Reference images, in prompt order. Common formats such as JPEG, PNG, and WEBP are supported, up to 50MB each. Multipart requests only. Uploaded images are used for this request only and are not stored.
        /// </param>
        /// <param name="referenceVideoAssetIdentifiers">
        /// Uploaded or generated videos to use as references, by reference, in prompt order. Each clip must be between 2 and 15 seconds long, and the clips must total no more than 15 seconds. Upload video files first and pass their asset identifiers.
        /// </param>
        /// <param name="referenceAudios">
        /// MP3 or WAV audio references, in prompt order. Multipart requests only. Each file must be at most 15 MB and between 2 and 15 seconds long, with a combined duration of at most 15 seconds. Requires at least one reference image. Audio is used for this request only and is not saved to your library.
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
        public GenerateVideoSeedDance2ReferenceToVideoRequest(
            string prompt,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceImageAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? referenceImages,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceVideoAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? referenceAudios,
            global::Ideogram.SeedDance2AspectRatio? aspectRatio,
            global::Ideogram.SeedDance2Resolution? resolution,
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
        /// Initializes a new instance of the <see cref="GenerateVideoSeedDance2ReferenceToVideoRequest" /> class.
        /// </summary>
        public GenerateVideoSeedDance2ReferenceToVideoRequest()
        {
        }

    }
}