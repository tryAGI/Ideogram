
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagesUpscalePostUpscaleImageTopazBloom2Request
    {
        /// <summary>
        /// The source image to upscale, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The source image to upscale, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// How much to enlarge the source image: 2x, 4x, or 8x its original width and height. Rejected when the output would exceed 8192px on either side.<br/>
        /// Default Value: x2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscale_factor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter))]
        public global::Ideogram.V2.V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor? UpscaleFactor { get; set; }

        /// <summary>
        /// An optional prompt guiding the detail the model regenerates while enlarging the image. Leave empty to enhance the source image as-is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// How strongly the model reinterprets the source while enlarging it, from 1 (most faithful) to 9 (most creative).<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creativity")]
        public int? Creativity { get; set; }

        /// <summary>
        /// When true (the default), the output keeps the source image's colors. Set to false to let the model adjust colors while enhancing.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_preservation")]
        public bool? ColorPreservation { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// When false (the default), the request blocks until the upscaled image is ready and returns it in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` for the result.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public bool? Async { get; set; }

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
        /// Initializes a new instance of the <see cref="ImagesUpscalePostUpscaleImageTopazBloom2Request" /> class.
        /// </summary>
        /// <param name="image">
        /// The source image to upscale, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </param>
        /// <param name="imagename">
        /// The source image to upscale, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </param>
        /// <param name="upscaleFactor">
        /// How much to enlarge the source image: 2x, 4x, or 8x its original width and height. Rejected when the output would exceed 8192px on either side.<br/>
        /// Default Value: x2
        /// </param>
        /// <param name="prompt">
        /// An optional prompt guiding the detail the model regenerates while enlarging the image. Leave empty to enhance the source image as-is.
        /// </param>
        /// <param name="creativity">
        /// How strongly the model reinterprets the source while enlarging it, from 1 (most faithful) to 9 (most creative).<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="colorPreservation">
        /// When true (the default), the output keeps the source image's colors. Set to false to let the model adjust colors while enhancing.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request blocks until the upscaled image is ready and returns it in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` for the result.<br/>
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
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagesUpscalePostUpscaleImageTopazBloom2Request(
            byte[] image,
            string imagename,
            global::Ideogram.V2.V2ImageUpscaleTopazBloom2PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor? upscaleFactor,
            string? prompt,
            int? creativity,
            bool? colorPreservation,
            int? seed,
            bool? async,
            string? webhookUrl)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.UpscaleFactor = upscaleFactor;
            this.Prompt = prompt;
            this.Creativity = creativity;
            this.ColorPreservation = colorPreservation;
            this.Seed = seed;
            this.Async = async;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesUpscalePostUpscaleImageTopazBloom2Request" /> class.
        /// </summary>
        public ImagesUpscalePostUpscaleImageTopazBloom2Request()
        {
        }

    }
}