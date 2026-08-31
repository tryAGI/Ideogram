
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Supply exactly one of `image_asset_identifier` or multipart `image`<br/>
    /// bytes. The prompt describes only the desired new background; the<br/>
    /// foreground subject is detected and preserved automatically.
    /// </summary>
    public sealed partial class ReplaceBackgroundRequest
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// Raw source-image bytes. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP,<br/>
        /// TIFF, and MPO are supported, up to 50 MB. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// Raw source-image bytes. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP,<br/>
        /// TIFF, and MPO are supported, up to 50 MB. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// Plain-language description of the desired new background.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The generation quality level. Defaults to `HIGH`.<br/>
        /// Default Value: HIGH
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GptImage2QualityJsonConverter))]
        public global::Ideogram.GptImage2Quality? Quality { get; set; }

        /// <summary>
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// If true, the user is requesting private generation. If omitted,<br/>
        /// this defaults to the user's plan entitlement. Enterprise<br/>
        /// generations are always private.
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
        /// Initializes a new instance of the <see cref="ReplaceBackgroundRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Plain-language description of the desired new background.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// Raw source-image bytes. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP,<br/>
        /// TIFF, and MPO are supported, up to 50 MB. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// Raw source-image bytes. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP,<br/>
        /// TIFF, and MPO are supported, up to 50 MB. Multipart requests only.
        /// </param>
        /// <param name="quality">
        /// The generation quality level. Defaults to `HIGH`.<br/>
        /// Default Value: HIGH
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="private">
        /// If true, the user is requesting private generation. If omitted,<br/>
        /// this defaults to the user's plan entitlement. Enterprise<br/>
        /// generations are always private.
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
        public ReplaceBackgroundRequest(
            string prompt,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            byte[]? image,
            string? imagename,
            global::Ideogram.GptImage2Quality? quality,
            int? numImages,
            bool? @private,
            string? webhookUrl)
        {
            this.ImageAssetIdentifier = imageAssetIdentifier;
            this.Image = image;
            this.Imagename = imagename;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Quality = quality;
            this.NumImages = numImages;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceBackgroundRequest" /> class.
        /// </summary>
        public ReplaceBackgroundRequest()
        {
        }

    }
}