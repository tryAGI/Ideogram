
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Supply exactly one of `sketch_asset_identifier` or multipart<br/>
    /// `sketch_image` bytes. The entire source is transformed from an<br/>
    /// illustration into a photograph; masks are not accepted.
    /// </summary>
    public sealed partial class SketchToRenderRequest
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sketch_asset_identifier")]
        public global::Ideogram.AssetIdentifier? SketchAssetIdentifier { get; set; }

        /// <summary>
        /// Raw fashion-sketch bytes. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP,<br/>
        /// TIFF, and MPO are supported, up to 50 MB. Multipart requests only.<br/>
        /// Mutually exclusive with `sketch_asset_identifier`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sketch_image")]
        public byte[]? SketchImage { get; set; }

        /// <summary>
        /// Raw fashion-sketch bytes. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP,<br/>
        /// TIFF, and MPO are supported, up to 50 MB. Multipart requests only.<br/>
        /// Mutually exclusive with `sketch_asset_identifier`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sketch_imagename")]
        public string? SketchImagename { get; set; }

        /// <summary>
        /// Required material and rendering direction, plus any construction<br/>
        /// or design details that are not legible in the sketch.
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
        /// Number of product renders to create.<br/>
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
        /// Initializes a new instance of the <see cref="SketchToRenderRequest" /> class.
        /// </summary>
        /// <param name="instruction">
        /// Required material and rendering direction, plus any construction<br/>
        /// or design details that are not legible in the sketch.
        /// </param>
        /// <param name="sketchAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="sketchImage">
        /// Raw fashion-sketch bytes. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP,<br/>
        /// TIFF, and MPO are supported, up to 50 MB. Multipart requests only.<br/>
        /// Mutually exclusive with `sketch_asset_identifier`.
        /// </param>
        /// <param name="sketchImagename">
        /// Raw fashion-sketch bytes. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP,<br/>
        /// TIFF, and MPO are supported, up to 50 MB. Multipart requests only.<br/>
        /// Mutually exclusive with `sketch_asset_identifier`.
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of each output image. Defaults to `1:1` when omitted.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
        /// </param>
        /// <param name="numImages">
        /// Number of product renders to create.<br/>
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
        public SketchToRenderRequest(
            string instruction,
            global::Ideogram.AssetIdentifier? sketchAssetIdentifier,
            byte[]? sketchImage,
            string? sketchImagename,
            string? aspectRatio,
            global::Ideogram.GptImage2Quality? quality,
            int? seed,
            int? numImages,
            bool? @private,
            string? webhookUrl)
        {
            this.SketchAssetIdentifier = sketchAssetIdentifier;
            this.SketchImage = sketchImage;
            this.SketchImagename = sketchImagename;
            this.Instruction = instruction ?? throw new global::System.ArgumentNullException(nameof(instruction));
            this.AspectRatio = aspectRatio;
            this.Quality = quality;
            this.Seed = seed;
            this.NumImages = numImages;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SketchToRenderRequest" /> class.
        /// </summary>
        public SketchToRenderRequest()
        {
        }

    }
}