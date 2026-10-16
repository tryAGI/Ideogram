
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolReplaceBackgroundIdeogramV3Request
    {
        /// <summary>
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Multipart requests only.<br/>
        /// The longer side must be at most 3 times the shorter side; wider<br/>
        /// aspect ratios are rejected with a 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Multipart requests only.<br/>
        /// The longer side must be at most 3 times the shorter side; wider<br/>
        /// aspect ratios are rejected with a 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// Plain-language description of the desired new background.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The rendering speed to use.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.V2ImageReplaceBackgroundIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter))]
        public global::Ideogram.V2.V2ImageReplaceBackgroundIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? RenderingSpeed { get; set; }

        /// <summary>
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Whether to keep the result private. When omitted, defaults to your<br/>
        /// plan's setting. Enterprise generations are always private.
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
        /// Initializes a new instance of the <see cref="ToolReplaceBackgroundIdeogramV3Request" /> class.
        /// </summary>
        /// <param name="image">
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Multipart requests only.<br/>
        /// The longer side must be at most 3 times the shorter side; wider<br/>
        /// aspect ratios are rejected with a 400.
        /// </param>
        /// <param name="imagename">
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Multipart requests only.<br/>
        /// The longer side must be at most 3 times the shorter side; wider<br/>
        /// aspect ratios are rejected with a 400.
        /// </param>
        /// <param name="prompt">
        /// Plain-language description of the desired new background.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="private">
        /// Whether to keep the result private. When omitted, defaults to your<br/>
        /// plan's setting. Enterprise generations are always private.
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
        public ToolReplaceBackgroundIdeogramV3Request(
            byte[] image,
            string imagename,
            string prompt,
            global::Ideogram.V2.V2ImageReplaceBackgroundIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed,
            int? numImages,
            bool? @private,
            string? webhookUrl)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.RenderingSpeed = renderingSpeed;
            this.NumImages = numImages;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolReplaceBackgroundIdeogramV3Request" /> class.
        /// </summary>
        public ToolReplaceBackgroundIdeogramV3Request()
        {
        }

    }
}