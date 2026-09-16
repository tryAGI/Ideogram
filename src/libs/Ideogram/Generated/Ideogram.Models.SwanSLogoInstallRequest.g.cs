
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"logo_style":"3d","aspect_ratio":"aspect_ratio","private":true,"webhook_url":"https://api.example.com/webhooks/ideogram","logo_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"logo_specification_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"shoe_asset_identifiers":[{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}],"num_images":0,"quality":null}
    /// </summary>
    public sealed partial class SwanSLogoInstallRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.SwanSLogoInstallRequestLogoStyleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.SwanSLogoInstallRequestLogoStyle LogoStyle { get; set; }

        /// <summary>
        /// Ordered shoe views, primary view first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shoe_asset_identifiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier> ShoeAssetIdentifiers { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_asset_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AssetIdentifier LogoAssetIdentifier { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_specification_asset_identifier")]
        public global::Ideogram.AssetIdentifier? LogoSpecificationAssetIdentifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AspectRatio { get; set; }

        /// <summary>
        /// Number of images to create.<br/>
        /// Default Value: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GptImage2QualityJsonConverter))]
        public global::Ideogram.GptImage2Quality? Quality { get; set; }

        /// <summary>
        /// When true or omitted, keep outputs private. Enterprise accounts always generate privately.
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
        /// Initializes a new instance of the <see cref="SwanSLogoInstallRequest" /> class.
        /// </summary>
        /// <param name="logoStyle"></param>
        /// <param name="shoeAssetIdentifiers">
        /// Ordered shoe views, primary view first.
        /// </param>
        /// <param name="logoAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="aspectRatio"></param>
        /// <param name="logoSpecificationAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="numImages">
        /// Number of images to create.<br/>
        /// Default Value: 4
        /// </param>
        /// <param name="quality">
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </param>
        /// <param name="private">
        /// When true or omitted, keep outputs private. Enterprise accounts always generate privately.
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
        public SwanSLogoInstallRequest(
            global::Ideogram.SwanSLogoInstallRequestLogoStyle logoStyle,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier> shoeAssetIdentifiers,
            global::Ideogram.AssetIdentifier logoAssetIdentifier,
            string aspectRatio,
            global::Ideogram.AssetIdentifier? logoSpecificationAssetIdentifier,
            int? numImages,
            global::Ideogram.GptImage2Quality? quality,
            bool? @private,
            string? webhookUrl)
        {
            this.LogoStyle = logoStyle;
            this.ShoeAssetIdentifiers = shoeAssetIdentifiers ?? throw new global::System.ArgumentNullException(nameof(shoeAssetIdentifiers));
            this.LogoAssetIdentifier = logoAssetIdentifier ?? throw new global::System.ArgumentNullException(nameof(logoAssetIdentifier));
            this.LogoSpecificationAssetIdentifier = logoSpecificationAssetIdentifier;
            this.AspectRatio = aspectRatio ?? throw new global::System.ArgumentNullException(nameof(aspectRatio));
            this.NumImages = numImages;
            this.Quality = quality;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwanSLogoInstallRequest" /> class.
        /// </summary>
        public SwanSLogoInstallRequest()
        {
        }

    }
}