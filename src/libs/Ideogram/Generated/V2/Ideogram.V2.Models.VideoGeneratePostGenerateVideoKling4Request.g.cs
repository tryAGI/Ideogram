
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoGeneratePostGenerateVideoKling4Request
    {
        /// <summary>
        /// A natural-language prompt describing the video to generate. Refer to references by position, as in "[Image1] walks toward the camera".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Images for the video to pass through, in timeline order, in a common format such as JPEG, PNG, or WEBP, up to 50MB each. The first opens the video and, with two or more, the last closes it. Multipart requests only. Uploaded images are used for this request only and are not stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frames")]
        public global::System.Collections.Generic.IList<byte[]>? Frames { get; set; }

        /// <summary>
        /// Reference images, in prompt order. Common formats such as JPEG, PNG, and WEBP are supported, up to 50MB each. Multipart requests only. Uploaded images are used for this request only and are not stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? ReferenceImages { get; set; }

        /// <summary>
        /// The aspect ratio of the generated video. Defaults to the ratio nearest the first frame's shape, or 16x9 without a first frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.Kling4AspectRatioJsonConverter))]
        public global::Ideogram.V2.Kling4AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The resolution tier of the generated video.<br/>
        /// Default Value: 1080p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.Kling4ResolutionJsonConverter))]
        public global::Ideogram.V2.Kling4Resolution? Resolution { get; set; }

        /// <summary>
        /// The length of the generated video in seconds.<br/>
        /// Default Value: 10
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
        /// Initializes a new instance of the <see cref="VideoGeneratePostGenerateVideoKling4Request" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A natural-language prompt describing the video to generate. Refer to references by position, as in "[Image1] walks toward the camera".
        /// </param>
        /// <param name="frames">
        /// Images for the video to pass through, in timeline order, in a common format such as JPEG, PNG, or WEBP, up to 50MB each. The first opens the video and, with two or more, the last closes it. Multipart requests only. Uploaded images are used for this request only and are not stored.
        /// </param>
        /// <param name="referenceImages">
        /// Reference images, in prompt order. Common formats such as JPEG, PNG, and WEBP are supported, up to 50MB each. Multipart requests only. Uploaded images are used for this request only and are not stored.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generated video. Defaults to the ratio nearest the first frame's shape, or 16x9 without a first frame.
        /// </param>
        /// <param name="resolution">
        /// The resolution tier of the generated video.<br/>
        /// Default Value: 1080p
        /// </param>
        /// <param name="duration">
        /// The length of the generated video in seconds.<br/>
        /// Default Value: 10
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
        public VideoGeneratePostGenerateVideoKling4Request(
            string prompt,
            global::System.Collections.Generic.IList<byte[]>? frames,
            global::System.Collections.Generic.IList<byte[]>? referenceImages,
            global::Ideogram.V2.Kling4AspectRatio? aspectRatio,
            global::Ideogram.V2.Kling4Resolution? resolution,
            int? duration,
            string? webhookUrl)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Frames = frames;
            this.ReferenceImages = referenceImages;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Duration = duration;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGeneratePostGenerateVideoKling4Request" /> class.
        /// </summary>
        public VideoGeneratePostGenerateVideoKling4Request()
        {
        }

    }
}