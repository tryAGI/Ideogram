
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EditWorkflowPostSketchToRenderRequest
    {
        /// <summary>
        /// The fashion sketch to render, up to 50 MB. JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO are supported. Multipart requests<br/>
        /// only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sketch_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] SketchImage { get; set; }

        /// <summary>
        /// The fashion sketch to render, up to 50 MB. JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO are supported. Multipart requests<br/>
        /// only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sketch_imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SketchImagename { get; set; }

        /// <summary>
        /// Material and rendering direction, plus any construction or design<br/>
        /// details that are not legible in the sketch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instruction { get; set; }

        /// <summary>
        /// Aspect ratio of each output image. Defaults to `1:1` when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.SketchToRenderQualityJsonConverter))]
        public global::Ideogram.V2.SketchToRenderQuality? Quality { get; set; }

        /// <summary>
        /// Optional seed for repeatable results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Number of product renders to create.<br/>
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
        /// Initializes a new instance of the <see cref="EditWorkflowPostSketchToRenderRequest" /> class.
        /// </summary>
        /// <param name="sketchImage">
        /// The fashion sketch to render, up to 50 MB. JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO are supported. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="sketchImagename">
        /// The fashion sketch to render, up to 50 MB. JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO are supported. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="instruction">
        /// Material and rendering direction, plus any construction or design<br/>
        /// details that are not legible in the sketch.
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of each output image. Defaults to `1:1` when omitted.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
        /// </param>
        /// <param name="numImages">
        /// Number of product renders to create.<br/>
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
        public EditWorkflowPostSketchToRenderRequest(
            byte[] sketchImage,
            string sketchImagename,
            string instruction,
            string? aspectRatio,
            global::Ideogram.V2.SketchToRenderQuality? quality,
            int? seed,
            int? numImages,
            string? webhookUrl)
        {
            this.SketchImage = sketchImage ?? throw new global::System.ArgumentNullException(nameof(sketchImage));
            this.SketchImagename = sketchImagename ?? throw new global::System.ArgumentNullException(nameof(sketchImagename));
            this.Instruction = instruction ?? throw new global::System.ArgumentNullException(nameof(instruction));
            this.AspectRatio = aspectRatio;
            this.Quality = quality;
            this.Seed = seed;
            this.NumImages = numImages;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditWorkflowPostSketchToRenderRequest" /> class.
        /// </summary>
        public EditWorkflowPostSketchToRenderRequest()
        {
        }

    }
}