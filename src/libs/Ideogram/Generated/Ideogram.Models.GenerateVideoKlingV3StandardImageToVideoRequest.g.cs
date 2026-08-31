
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Request body for Kling v3 Standard image-to-video generation. Supply the<br/>
    /// first frame either as an `image_asset_identifier` reference or<br/>
    /// (multipart requests only) as raw `image` bytes. Exactly one source is<br/>
    /// required. An optional final frame may be supplied the same way, with<br/>
    /// `end_image_asset_identifier` or `end_image`, to generate a transition<br/>
    /// between the two stills.
    /// </summary>
    public sealed partial class GenerateVideoKlingV3StandardImageToVideoRequest
    {
        /// <summary>
        /// A reference to an image already stored with Ideogram to use as the first frame, in place of uploading `image`. Only image assets are accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// The first-frame image to animate (max size 50MB), as raw bytes; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. The bytes are used for this request only and are not stored as an asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The first-frame image to animate (max size 50MB), as raw bytes; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. The bytes are used for this request only and are not stored as an asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// An optional final frame, as a reference to an image already stored with Ideogram. When supplied, the generated video transitions from the first frame to this one. Only image assets are accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? EndImageAssetIdentifier { get; set; }

        /// <summary>
        /// An optional final frame (max size 50MB), as raw bytes; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. When supplied, the generated video transitions from the first frame to this one. The bytes are used for this request only and are not stored as an asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_image")]
        public byte[]? EndImage { get; set; }

        /// <summary>
        /// An optional final frame (max size 50MB), as raw bytes; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. When supplied, the generated video transitions from the first frame to this one. The bytes are used for this request only and are not stored as an asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_imagename")]
        public string? EndImagename { get; set; }

        /// <summary>
        /// A natural-language prompt describing how the first frame should animate.<br/>
        /// Example: The camera slowly pans right as the waves roll in.
        /// </summary>
        /// <example>The camera slowly pans right as the waves roll in.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Description of what to keep out of the video. Descriptions in the prompt take precedence over descriptions in the negative prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// The length of the generated video in seconds. Defaults to 5 seconds<br/>
        /// when omitted.<br/>
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
        /// How the prompt is staged. `customize` follows the prompt as written;<br/>
        /// `intelligent` lets the model break the prompt into its own shots.<br/>
        /// Default Value: customize
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shot_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.KlingV3ShotTypeJsonConverter))]
        public global::Ideogram.KlingV3ShotType? ShotType { get; set; }

        /// <summary>
        /// How closely the video follows the prompt, from 0 to 1. Lower values<br/>
        /// leave the model more freedom. Defaults to 0.5 when omitted.<br/>
        /// Example: 0.5F
        /// </summary>
        /// <example>0.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cfg_scale")]
        public float? CfgScale { get; set; }

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
        /// Initializes a new instance of the <see cref="GenerateVideoKlingV3StandardImageToVideoRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A natural-language prompt describing how the first frame should animate.<br/>
        /// Example: The camera slowly pans right as the waves roll in.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// A reference to an image already stored with Ideogram to use as the first frame, in place of uploading `image`. Only image assets are accepted.
        /// </param>
        /// <param name="image">
        /// The first-frame image to animate (max size 50MB), as raw bytes; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. The bytes are used for this request only and are not stored as an asset.
        /// </param>
        /// <param name="imagename">
        /// The first-frame image to animate (max size 50MB), as raw bytes; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. The bytes are used for this request only and are not stored as an asset.
        /// </param>
        /// <param name="endImageAssetIdentifier">
        /// An optional final frame, as a reference to an image already stored with Ideogram. When supplied, the generated video transitions from the first frame to this one. Only image assets are accepted.
        /// </param>
        /// <param name="endImage">
        /// An optional final frame (max size 50MB), as raw bytes; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. When supplied, the generated video transitions from the first frame to this one. The bytes are used for this request only and are not stored as an asset.
        /// </param>
        /// <param name="endImagename">
        /// An optional final frame (max size 50MB), as raw bytes; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. When supplied, the generated video transitions from the first frame to this one. The bytes are used for this request only and are not stored as an asset.
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to keep out of the video. Descriptions in the prompt take precedence over descriptions in the negative prompt.
        /// </param>
        /// <param name="duration">
        /// The length of the generated video in seconds. Defaults to 5 seconds<br/>
        /// when omitted.<br/>
        /// Example: 5
        /// </param>
        /// <param name="generateAudio">
        /// Whether to generate an audio track for the video. Audio roughly<br/>
        /// doubles the provider cost and is subject to stricter output moderation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="shotType">
        /// How the prompt is staged. `customize` follows the prompt as written;<br/>
        /// `intelligent` lets the model break the prompt into its own shots.<br/>
        /// Default Value: customize
        /// </param>
        /// <param name="cfgScale">
        /// How closely the video follows the prompt, from 0 to 1. Lower values<br/>
        /// leave the model more freedom. Defaults to 0.5 when omitted.<br/>
        /// Example: 0.5F
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
        public GenerateVideoKlingV3StandardImageToVideoRequest(
            string prompt,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            byte[]? image,
            string? imagename,
            global::Ideogram.AssetIdentifier? endImageAssetIdentifier,
            byte[]? endImage,
            string? endImagename,
            string? negativePrompt,
            int? duration,
            bool? generateAudio,
            global::Ideogram.KlingV3ShotType? shotType,
            float? cfgScale,
            string? webhookUrl,
            bool? @private,
            string? targetCollectionId)
        {
            this.ImageAssetIdentifier = imageAssetIdentifier;
            this.Image = image;
            this.Imagename = imagename;
            this.EndImageAssetIdentifier = endImageAssetIdentifier;
            this.EndImage = endImage;
            this.EndImagename = endImagename;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NegativePrompt = negativePrompt;
            this.Duration = duration;
            this.GenerateAudio = generateAudio;
            this.ShotType = shotType;
            this.CfgScale = cfgScale;
            this.WebhookUrl = webhookUrl;
            this.Private = @private;
            this.TargetCollectionId = targetCollectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoKlingV3StandardImageToVideoRequest" /> class.
        /// </summary>
        public GenerateVideoKlingV3StandardImageToVideoRequest()
        {
        }

    }
}