
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Exactly one source is normally supplied. Use `source_asset_identifier` for an existing asset or multipart `source_image` bytes. When both are present, `source_asset_identifier` takes precedence.
    /// </summary>
    public sealed partial class PreciseMaskedEditRequest
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_asset_identifier")]
        public global::Ideogram.AssetIdentifier? SourceAssetIdentifier { get; set; }

        /// <summary>
        /// Raw source image bytes. Supported formats and the 50 MB limit match the image upload API. Available only with `multipart/form-data`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_image")]
        public byte[]? SourceImage { get; set; }

        /// <summary>
        /// Raw source image bytes. Supported formats and the 50 MB limit match the image upload API. Available only with `multipart/form-data`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_imagename")]
        public string? SourceImagename { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_asset_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AssetIdentifier MaskAssetIdentifier { get; set; }

        /// <summary>
        /// Optional assets that show the desired appearance of the masked edit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? ReferenceAssetIdentifiers { get; set; }

        /// <summary>
        /// Plain-language description of what to change inside the mask.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instruction { get; set; }

        /// <summary>
        /// Optional seed for repeatable results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Number of edited images to create.<br/>
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
        /// When true, decoded pixels outside the mask are copied from the<br/>
        /// source image into the final result. When false, the final result is<br/>
        /// the model's full edited image.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_unmasked_pixels")]
        public bool? PreserveUnmaskedPixels { get; set; }

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
        /// Initializes a new instance of the <see cref="PreciseMaskedEditRequest" /> class.
        /// </summary>
        /// <param name="maskAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="instruction">
        /// Plain-language description of what to change inside the mask.
        /// </param>
        /// <param name="sourceAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="sourceImage">
        /// Raw source image bytes. Supported formats and the 50 MB limit match the image upload API. Available only with `multipart/form-data`.
        /// </param>
        /// <param name="sourceImagename">
        /// Raw source image bytes. Supported formats and the 50 MB limit match the image upload API. Available only with `multipart/form-data`.
        /// </param>
        /// <param name="referenceAssetIdentifiers">
        /// Optional assets that show the desired appearance of the masked edit.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
        /// </param>
        /// <param name="numImages">
        /// Number of edited images to create.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="private">
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
        /// </param>
        /// <param name="preserveUnmaskedPixels">
        /// When true, decoded pixels outside the mask are copied from the<br/>
        /// source image into the final result. When false, the final result is<br/>
        /// the model's full edited image.<br/>
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
        /// private and loopback hosts and the cloud metadata service are rejected.<br/>
        /// Example: https://api.example.com/webhooks/ideogram
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreciseMaskedEditRequest(
            global::Ideogram.AssetIdentifier maskAssetIdentifier,
            string instruction,
            global::Ideogram.AssetIdentifier? sourceAssetIdentifier,
            byte[]? sourceImage,
            string? sourceImagename,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceAssetIdentifiers,
            int? seed,
            int? numImages,
            bool? @private,
            bool? preserveUnmaskedPixels,
            string? webhookUrl)
        {
            this.SourceAssetIdentifier = sourceAssetIdentifier;
            this.SourceImage = sourceImage;
            this.SourceImagename = sourceImagename;
            this.MaskAssetIdentifier = maskAssetIdentifier ?? throw new global::System.ArgumentNullException(nameof(maskAssetIdentifier));
            this.ReferenceAssetIdentifiers = referenceAssetIdentifiers;
            this.Instruction = instruction ?? throw new global::System.ArgumentNullException(nameof(instruction));
            this.Seed = seed;
            this.NumImages = numImages;
            this.Private = @private;
            this.PreserveUnmaskedPixels = preserveUnmaskedPixels;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreciseMaskedEditRequest" /> class.
        /// </summary>
        public PreciseMaskedEditRequest()
        {
        }

    }
}