
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Provide exactly one of `source_asset_identifier` or `source_image`.<br/>
    /// A pose reference can supplement the required instruction but cannot<br/>
    /// replace it. The edit is full-frame; scene preservation is best effort.
    /// </summary>
    public sealed partial class ModelPoseVariantsRequest
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_asset_identifier")]
        public global::Ideogram.AssetIdentifier? SourceAssetIdentifier { get; set; }

        /// <summary>
        /// Fashion image to edit (max size 50MB), as raw bytes. JPEG, PNG,<br/>
        /// WEBP, HEIF, AVIF, GIF, BMP, TIFF, and MPO formats are supported.<br/>
        /// Multipart requests only. Provide exactly one of<br/>
        /// `source_asset_identifier` or `source_image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_image")]
        public byte[]? SourceImage { get; set; }

        /// <summary>
        /// Fashion image to edit (max size 50MB), as raw bytes. JPEG, PNG,<br/>
        /// WEBP, HEIF, AVIF, GIF, BMP, TIFF, and MPO formats are supported.<br/>
        /// Multipart requests only. Provide exactly one of<br/>
        /// `source_asset_identifier` or `source_image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_imagename")]
        public string? SourceImagename { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pose_reference_asset_identifier")]
        public global::Ideogram.AssetIdentifier? PoseReferenceAssetIdentifier { get; set; }

        /// <summary>
        /// Required plain-language pose or camera direction, such as a<br/>
        /// front-facing catalog stance or right-facing walking profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instruction { get; set; }

        /// <summary>
        /// Output aspect ratio. When omitted, the nearest supported ratio is<br/>
        /// derived from the source image. Supported values are `1:1`, `3:4`,<br/>
        /// `4:3`, `16:9`, and `9:16`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GptImage2QualityJsonConverter))]
        public global::Ideogram.GptImage2Quality? Quality { get; set; }

        /// <summary>
        /// Optional seed for repeatable results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Number of pose variants to create.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPoseVariantsRequest" /> class.
        /// </summary>
        /// <param name="instruction">
        /// Required plain-language pose or camera direction, such as a<br/>
        /// front-facing catalog stance or right-facing walking profile.
        /// </param>
        /// <param name="sourceAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="sourceImage">
        /// Fashion image to edit (max size 50MB), as raw bytes. JPEG, PNG,<br/>
        /// WEBP, HEIF, AVIF, GIF, BMP, TIFF, and MPO formats are supported.<br/>
        /// Multipart requests only. Provide exactly one of<br/>
        /// `source_asset_identifier` or `source_image`.
        /// </param>
        /// <param name="sourceImagename">
        /// Fashion image to edit (max size 50MB), as raw bytes. JPEG, PNG,<br/>
        /// WEBP, HEIF, AVIF, GIF, BMP, TIFF, and MPO formats are supported.<br/>
        /// Multipart requests only. Provide exactly one of<br/>
        /// `source_asset_identifier` or `source_image`.
        /// </param>
        /// <param name="poseReferenceAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. When omitted, the nearest supported ratio is<br/>
        /// derived from the source image. Supported values are `1:1`, `3:4`,<br/>
        /// `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
        /// </param>
        /// <param name="numImages">
        /// Number of pose variants to create.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="private">
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPoseVariantsRequest(
            string instruction,
            global::Ideogram.AssetIdentifier? sourceAssetIdentifier,
            byte[]? sourceImage,
            string? sourceImagename,
            global::Ideogram.AssetIdentifier? poseReferenceAssetIdentifier,
            string? aspectRatio,
            global::Ideogram.GptImage2Quality? quality,
            int? seed,
            int? numImages,
            bool? @private,
            string? webhookUrl)
        {
            this.SourceAssetIdentifier = sourceAssetIdentifier;
            this.SourceImage = sourceImage;
            this.SourceImagename = sourceImagename;
            this.PoseReferenceAssetIdentifier = poseReferenceAssetIdentifier;
            this.Instruction = instruction ?? throw new global::System.ArgumentNullException(nameof(instruction));
            this.AspectRatio = aspectRatio;
            this.Quality = quality;
            this.Seed = seed;
            this.NumImages = numImages;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPoseVariantsRequest" /> class.
        /// </summary>
        public ModelPoseVariantsRequest()
        {
        }

    }
}