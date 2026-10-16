
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagesUpscalePostUpscaleImageTopazWonder35Request
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter))]
        public global::Ideogram.V2.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor? UpscaleFactor { get; set; }

        /// <summary>
        /// How strongly the generative model reconstructs detail while upscaling. Lower values stay closer to the source image; higher values produce a more enhanced result.<br/>
        /// Default Value: high
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhancement_strength")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrengthJsonConverter))]
        public global::Ideogram.V2.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength? EnhancementStrength { get; set; }

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
        /// Initializes a new instance of the <see cref="ImagesUpscalePostUpscaleImageTopazWonder35Request" /> class.
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
        /// <param name="enhancementStrength">
        /// How strongly the generative model reconstructs detail while upscaling. Lower values stay closer to the source image; higher values produce a more enhanced result.<br/>
        /// Default Value: high
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
        public ImagesUpscalePostUpscaleImageTopazWonder35Request(
            byte[] image,
            string imagename,
            global::Ideogram.V2.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaUpscaleFactor? upscaleFactor,
            global::Ideogram.V2.V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength? enhancementStrength,
            int? seed,
            bool? async,
            string? webhookUrl)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.UpscaleFactor = upscaleFactor;
            this.EnhancementStrength = enhancementStrength;
            this.Seed = seed;
            this.Async = async;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesUpscalePostUpscaleImageTopazWonder35Request" /> class.
        /// </summary>
        public ImagesUpscalePostUpscaleImageTopazWonder35Request()
        {
        }

    }
}