
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EditWorkflowPostModelPoseVariantsRequest
    {
        /// <summary>
        /// Fashion image to edit (max size 50MB). JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO formats are supported. Multipart<br/>
        /// requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] SourceImage { get; set; }

        /// <summary>
        /// Fashion image to edit (max size 50MB). JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO formats are supported. Multipart<br/>
        /// requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceImagename { get; set; }

        /// <summary>
        /// Plain-language pose or camera direction, such as a front-facing<br/>
        /// catalog stance or right-facing walking profile.
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
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ModelPoseVariantsQualityJsonConverter))]
        public global::Ideogram.ModelPoseVariantsQuality? Quality { get; set; }

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
        /// Initializes a new instance of the <see cref="EditWorkflowPostModelPoseVariantsRequest" /> class.
        /// </summary>
        /// <param name="sourceImage">
        /// Fashion image to edit (max size 50MB). JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO formats are supported. Multipart<br/>
        /// requests only.
        /// </param>
        /// <param name="sourceImagename">
        /// Fashion image to edit (max size 50MB). JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO formats are supported. Multipart<br/>
        /// requests only.
        /// </param>
        /// <param name="instruction">
        /// Plain-language pose or camera direction, such as a front-facing<br/>
        /// catalog stance or right-facing walking profile.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. When omitted, the nearest supported ratio is<br/>
        /// derived from the source image. Supported values are `1:1`, `3:4`,<br/>
        /// `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
        /// </param>
        /// <param name="numImages">
        /// Number of pose variants to create.<br/>
        /// Default Value: 1
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
        public EditWorkflowPostModelPoseVariantsRequest(
            byte[] sourceImage,
            string sourceImagename,
            string instruction,
            string? aspectRatio,
            global::Ideogram.ModelPoseVariantsQuality? quality,
            int? seed,
            int? numImages,
            string? webhookUrl)
        {
            this.SourceImage = sourceImage ?? throw new global::System.ArgumentNullException(nameof(sourceImage));
            this.SourceImagename = sourceImagename ?? throw new global::System.ArgumentNullException(nameof(sourceImagename));
            this.Instruction = instruction ?? throw new global::System.ArgumentNullException(nameof(instruction));
            this.AspectRatio = aspectRatio;
            this.Quality = quality;
            this.Seed = seed;
            this.NumImages = numImages;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditWorkflowPostModelPoseVariantsRequest" /> class.
        /// </summary>
        public EditWorkflowPostModelPoseVariantsRequest()
        {
        }

    }
}