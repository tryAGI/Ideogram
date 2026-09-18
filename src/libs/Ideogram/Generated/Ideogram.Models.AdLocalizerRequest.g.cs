
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Supply the source advertisement as either an `AssetIdentifier` reference<br/>
    /// or (multipart requests only) raw image bytes; provide exactly one of the<br/>
    /// two forms. Supplying both, or neither, is rejected with a 400.
    /// </summary>
    public sealed partial class AdLocalizerRequest
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// The source advertisement to localize (max size 25MB), as raw bytes;<br/>
        /// only JPEG, PNG, and WEBP formats are supported. Multipart requests<br/>
        /// only. Provide exactly one of `image_asset_identifier` or `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The source advertisement to localize (max size 25MB), as raw bytes;<br/>
        /// only JPEG, PNG, and WEBP formats are supported. Multipart requests<br/>
        /// only. Provide exactly one of `image_asset_identifier` or `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// The target language the copy is rebuilt in. Arabic is rendered right-to-left.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AdLocalizerRequestLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AdLocalizerRequestLanguage Language { get; set; }

        /// <summary>
        /// Pre-approved wording, one `original =&gt; replacement` mapping per line. Each mapping names the text element showing `original` and sets it to `replacement`, placed character for character rather than translated. Any text element not listed is left as it is in the source. When omitted, all visible marketing copy is translated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exact_copy")]
        public string? ExactCopy { get; set; }

        /// <summary>
        /// Optional additional direction for the localization, for example "keep the badge in English". It takes priority over the preservation rules for anything it explicitly asks to change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GptImage2QualityJsonConverter))]
        public global::Ideogram.GptImage2Quality? Quality { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Number of localized variations to create for this language.<br/>
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
        /// Initializes a new instance of the <see cref="AdLocalizerRequest" /> class.
        /// </summary>
        /// <param name="language">
        /// The target language the copy is rebuilt in. Arabic is rendered right-to-left.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The source advertisement to localize (max size 25MB), as raw bytes;<br/>
        /// only JPEG, PNG, and WEBP formats are supported. Multipart requests<br/>
        /// only. Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="imagename">
        /// The source advertisement to localize (max size 25MB), as raw bytes;<br/>
        /// only JPEG, PNG, and WEBP formats are supported. Multipart requests<br/>
        /// only. Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="exactCopy">
        /// Pre-approved wording, one `original =&gt; replacement` mapping per line. Each mapping names the text element showing `original` and sets it to `replacement`, placed character for character rather than translated. Any text element not listed is left as it is in the source. When omitted, all visible marketing copy is translated.
        /// </param>
        /// <param name="prompt">
        /// Optional additional direction for the localization, for example "keep the badge in English". It takes priority over the preservation rules for anything it explicitly asks to change.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="numImages">
        /// Number of localized variations to create for this language.<br/>
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
        public AdLocalizerRequest(
            global::Ideogram.AdLocalizerRequestLanguage language,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            byte[]? image,
            string? imagename,
            string? exactCopy,
            string? prompt,
            global::Ideogram.GptImage2Quality? quality,
            int? seed,
            int? numImages,
            bool? @private,
            string? webhookUrl)
        {
            this.ImageAssetIdentifier = imageAssetIdentifier;
            this.Image = image;
            this.Imagename = imagename;
            this.Language = language;
            this.ExactCopy = exactCopy;
            this.Prompt = prompt;
            this.Quality = quality;
            this.Seed = seed;
            this.NumImages = numImages;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdLocalizerRequest" /> class.
        /// </summary>
        public AdLocalizerRequest()
        {
        }

    }
}