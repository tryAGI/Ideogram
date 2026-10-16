
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolReplaceBackgroundIdeogram45Request
    {
        /// <summary>
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Its longer side may be at most the<br/>
        /// model's maximum aspect ratio times its shorter side; a more extreme<br/>
        /// proportion is rejected with a 400 that states the allowed range.<br/>
        /// Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Its longer side may be at most the<br/>
        /// model's maximum aspect ratio times its shorter side; a more extreme<br/>
        /// proportion is rejected with a 400 that states the allowed range.<br/>
        /// Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// A photo of the setting the new background should match. Its people<br/>
        /// are not copied. It is held to the same aspect-ratio limit as<br/>
        /// `image`. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_reference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] BackgroundReference { get; set; }

        /// <summary>
        /// A photo of the setting the new background should match. Its people<br/>
        /// are not copied. It is held to the same aspect-ratio limit as<br/>
        /// `image`. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_referencename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BackgroundReferencename { get; set; }

        /// <summary>
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Whether to keep the result private. When omitted, the result is<br/>
        /// private. Enterprise generations are always private.
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
        /// Initializes a new instance of the <see cref="ToolReplaceBackgroundIdeogram45Request" /> class.
        /// </summary>
        /// <param name="image">
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Its longer side may be at most the<br/>
        /// model's maximum aspect ratio times its shorter side; a more extreme<br/>
        /// proportion is rejected with a 400 that states the allowed range.<br/>
        /// Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Its longer side may be at most the<br/>
        /// model's maximum aspect ratio times its shorter side; a more extreme<br/>
        /// proportion is rejected with a 400 that states the allowed range.<br/>
        /// Multipart requests only.
        /// </param>
        /// <param name="backgroundReference">
        /// A photo of the setting the new background should match. Its people<br/>
        /// are not copied. It is held to the same aspect-ratio limit as<br/>
        /// `image`. Multipart requests only.
        /// </param>
        /// <param name="backgroundReferencename">
        /// A photo of the setting the new background should match. Its people<br/>
        /// are not copied. It is held to the same aspect-ratio limit as<br/>
        /// `image`. Multipart requests only.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="private">
        /// Whether to keep the result private. When omitted, the result is<br/>
        /// private. Enterprise generations are always private.
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
        public ToolReplaceBackgroundIdeogram45Request(
            byte[] image,
            string imagename,
            byte[] backgroundReference,
            string backgroundReferencename,
            int? numImages,
            bool? @private,
            string? webhookUrl)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.BackgroundReference = backgroundReference ?? throw new global::System.ArgumentNullException(nameof(backgroundReference));
            this.BackgroundReferencename = backgroundReferencename ?? throw new global::System.ArgumentNullException(nameof(backgroundReferencename));
            this.NumImages = numImages;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolReplaceBackgroundIdeogram45Request" /> class.
        /// </summary>
        public ToolReplaceBackgroundIdeogram45Request()
        {
        }

    }
}