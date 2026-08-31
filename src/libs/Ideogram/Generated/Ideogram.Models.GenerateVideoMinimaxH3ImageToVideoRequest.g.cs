
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Request body for MiniMax H3 image-to-video generation. Supply the first<br/>
    /// frame either as an `image_asset_identifier` reference or (multipart<br/>
    /// requests only) as raw `image` bytes. Exactly one source is required. An<br/>
    /// optional final frame may be supplied the same way, with<br/>
    /// `end_image_asset_identifier` or `end_image`, to generate a transition<br/>
    /// between the two stills.
    /// </summary>
    public sealed partial class GenerateVideoMinimaxH3ImageToVideoRequest
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
        /// Initializes a new instance of the <see cref="GenerateVideoMinimaxH3ImageToVideoRequest" /> class.
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
        public GenerateVideoMinimaxH3ImageToVideoRequest(
            string prompt,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            byte[]? image,
            string? imagename,
            global::Ideogram.AssetIdentifier? endImageAssetIdentifier,
            byte[]? endImage,
            string? endImagename,
            global::Ideogram.MinimaxH3Resolution? resolution,
            int? duration,
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
            this.Resolution = resolution;
            this.Duration = duration;
            this.WebhookUrl = webhookUrl;
            this.Private = @private;
            this.TargetCollectionId = targetCollectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoMinimaxH3ImageToVideoRequest" /> class.
        /// </summary>
        public GenerateVideoMinimaxH3ImageToVideoRequest()
        {
        }

    }
}