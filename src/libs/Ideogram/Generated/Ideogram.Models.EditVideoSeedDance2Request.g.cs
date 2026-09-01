
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Request body for a Seedance 2.0 video edit. `video_asset_identifier`<br/>
    /// names the video being edited and `start_frame_time`/`end_frame_time` mark<br/>
    /// the span of it the generated clip replaces. The two `is_*_included` flags<br/>
    /// anchor the generated clip on the span's own end frames; at least one must<br/>
    /// be anchored.<br/>
    /// Example: {"duration":5,"private":true,"end_frame_time":"","is_end_frame_included":false,"webhook_url":"https://api.example.com/webhooks/ideogram","video_asset_identifier":"","target_collection_id":"target_collection_id","generate_audio":false,"is_start_frame_included":true,"prompt":"The camera pushes in as the dancer turns towards the light.","resolution":"","start_frame_time":""}
    /// </summary>
    public sealed partial class EditVideoSeedDance2Request
    {
        /// <summary>
        /// A reference to a video already stored with Ideogram to take the frames from. Only video assets are accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_asset_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AssetIdentifier VideoAssetIdentifier { get; set; }

        /// <summary>
        /// Where the replaced span of the source video begins. Everything before it is kept as-is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_frame_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float StartFrameTime { get; set; }

        /// <summary>
        /// Whether the generated clip is anchored on the frame already at `start_frame_time`, so it opens on the footage it replaces. Set it to false to anchor on the end frame alone, in which case `is_end_frame_included` must be true.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_start_frame_included")]
        public bool? IsStartFrameIncluded { get; set; }

        /// <summary>
        /// Where the replaced span of the source video ends; must come after `start_frame_time`. Everything from here on is kept as-is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_frame_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float EndFrameTime { get; set; }

        /// <summary>
        /// Whether the generated clip is anchored on the frame at `end_frame_time`, so it lands on the footage that follows the span.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_end_frame_included")]
        public bool? IsEndFrameIncluded { get; set; }

        /// <summary>
        /// A natural-language prompt describing what the replaced span should show.<br/>
        /// Example: The camera pushes in as the dancer turns towards the light.
        /// </summary>
        /// <example>The camera pushes in as the dancer turns towards the light.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The resolution tier the replaced span is generated at. The clip is then scaled to the source video's own frame, so this affects the detail generated rather than the edited video's dimensions.
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
        /// Initializes a new instance of the <see cref="EditVideoSeedDance2Request" /> class.
        /// </summary>
        /// <param name="videoAssetIdentifier">
        /// A reference to a video already stored with Ideogram to take the frames from. Only video assets are accepted.
        /// </param>
        /// <param name="startFrameTime">
        /// Where the replaced span of the source video begins. Everything before it is kept as-is.
        /// </param>
        /// <param name="endFrameTime">
        /// Where the replaced span of the source video ends; must come after `start_frame_time`. Everything from here on is kept as-is.
        /// </param>
        /// <param name="prompt">
        /// A natural-language prompt describing what the replaced span should show.<br/>
        /// Example: The camera pushes in as the dancer turns towards the light.
        /// </param>
        /// <param name="isStartFrameIncluded">
        /// Whether the generated clip is anchored on the frame already at `start_frame_time`, so it opens on the footage it replaces. Set it to false to anchor on the end frame alone, in which case `is_end_frame_included` must be true.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="isEndFrameIncluded">
        /// Whether the generated clip is anchored on the frame at `end_frame_time`, so it lands on the footage that follows the span.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="resolution">
        /// The resolution tier the replaced span is generated at. The clip is then scaled to the source video's own frame, so this affects the detail generated rather than the edited video's dimensions.
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
        public EditVideoSeedDance2Request(
            global::Ideogram.AssetIdentifier videoAssetIdentifier,
            float startFrameTime,
            float endFrameTime,
            string prompt,
            bool? isStartFrameIncluded,
            bool? isEndFrameIncluded,
            global::Ideogram.SeedDance2Resolution? resolution,
            int? duration,
            bool? generateAudio,
            string? webhookUrl,
            bool? @private,
            string? targetCollectionId)
        {
            this.VideoAssetIdentifier = videoAssetIdentifier ?? throw new global::System.ArgumentNullException(nameof(videoAssetIdentifier));
            this.StartFrameTime = startFrameTime;
            this.IsStartFrameIncluded = isStartFrameIncluded;
            this.EndFrameTime = endFrameTime;
            this.IsEndFrameIncluded = isEndFrameIncluded;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Resolution = resolution;
            this.Duration = duration;
            this.GenerateAudio = generateAudio;
            this.WebhookUrl = webhookUrl;
            this.Private = @private;
            this.TargetCollectionId = targetCollectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditVideoSeedDance2Request" /> class.
        /// </summary>
        public EditVideoSeedDance2Request()
        {
        }

    }
}