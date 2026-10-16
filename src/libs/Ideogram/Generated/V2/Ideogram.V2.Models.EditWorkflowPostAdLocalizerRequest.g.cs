
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EditWorkflowPostAdLocalizerRequest
    {
        /// <summary>
        /// The source ad to localize (max size 25MB). Its layout, logos, brand<br/>
        /// type, and product are preserved, and the output keeps its shape, so<br/>
        /// no size or aspect ratio is needed. JPEG, PNG, and WEBP formats are<br/>
        /// supported. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The source ad to localize (max size 25MB). Its layout, logos, brand<br/>
        /// type, and product are preserved, and the output keeps its shape, so<br/>
        /// no size or aspect ratio is needed. JPEG, PNG, and WEBP formats are<br/>
        /// supported. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// The target language for the copy. Arabic is rendered right-to-left. Each request covers one language; send one request per language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage Language { get; set; }

        /// <summary>
        /// Pre-approved wording, one `original =&gt; replacement` mapping per line. Each mapping names the text element showing `original` and sets it to `replacement`, placed character for character rather than translated. Any text element not listed is left as it is in the source. When omitted, all visible marketing copy is translated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exact_copy")]
        public string? ExactCopy { get; set; }

        /// <summary>
        /// Optional additional direction for the localization, for example "keep the badge in English". Anything it explicitly asks to change takes priority over the preservation rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.AdLocalizerQualityJsonConverter))]
        public global::Ideogram.V2.AdLocalizerQuality? Quality { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Number of localized variations to create for this language.<br/>
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
        /// Initializes a new instance of the <see cref="EditWorkflowPostAdLocalizerRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The source ad to localize (max size 25MB). Its layout, logos, brand<br/>
        /// type, and product are preserved, and the output keeps its shape, so<br/>
        /// no size or aspect ratio is needed. JPEG, PNG, and WEBP formats are<br/>
        /// supported. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source ad to localize (max size 25MB). Its layout, logos, brand<br/>
        /// type, and product are preserved, and the output keeps its shape, so<br/>
        /// no size or aspect ratio is needed. JPEG, PNG, and WEBP formats are<br/>
        /// supported. Multipart requests only.
        /// </param>
        /// <param name="language">
        /// The target language for the copy. Arabic is rendered right-to-left. Each request covers one language; send one request per language.
        /// </param>
        /// <param name="exactCopy">
        /// Pre-approved wording, one `original =&gt; replacement` mapping per line. Each mapping names the text element showing `original` and sets it to `replacement`, placed character for character rather than translated. Any text element not listed is left as it is in the source. When omitted, all visible marketing copy is translated.
        /// </param>
        /// <param name="prompt">
        /// Optional additional direction for the localization, for example "keep the badge in English". Anything it explicitly asks to change takes priority over the preservation rules.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="numImages">
        /// Number of localized variations to create for this language.<br/>
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
        public EditWorkflowPostAdLocalizerRequest(
            byte[] image,
            string imagename,
            global::Ideogram.V2.V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage language,
            string? exactCopy,
            string? prompt,
            global::Ideogram.V2.AdLocalizerQuality? quality,
            int? seed,
            int? numImages,
            string? webhookUrl)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Language = language;
            this.ExactCopy = exactCopy;
            this.Prompt = prompt;
            this.Quality = quality;
            this.Seed = seed;
            this.NumImages = numImages;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditWorkflowPostAdLocalizerRequest" /> class.
        /// </summary>
        public EditWorkflowPostAdLocalizerRequest()
        {
        }

    }
}