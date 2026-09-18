
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"logo_style":"3d","flat_silhouette_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"private":true,"webhook_url":"https://api.example.com/webhooks/ideogram","source_mode":"shoe_swatch","logo_specification_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"design_variant":"split_coverage","style_source_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"geometry_hero_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"quality":null}
    /// </summary>
    public sealed partial class SwanSLogoDesignRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.SwanSLogoDesignRequestLogoStyleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.SwanSLogoDesignRequestLogoStyle LogoStyle { get; set; }

        /// <summary>
        /// Use a shoe color swatch or an uploaded logo reference as the style source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.SwanSLogoDesignRequestSourceModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.SwanSLogoDesignRequestSourceMode SourceMode { get; set; }

        /// <summary>
        /// Required for 3D user_reference designs. Omit for other designs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("design_variant")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.SwanSLogoDesignRequestDesignVariantJsonConverter))]
        public global::Ideogram.SwanSLogoDesignRequestDesignVariant? DesignVariant { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_source_asset_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AssetIdentifier StyleSourceAssetIdentifier { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("geometry_hero_asset_identifier")]
        public global::Ideogram.AssetIdentifier? GeometryHeroAssetIdentifier { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_specification_asset_identifier")]
        public global::Ideogram.AssetIdentifier? LogoSpecificationAssetIdentifier { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("flat_silhouette_asset_identifier")]
        public global::Ideogram.AssetIdentifier? FlatSilhouetteAssetIdentifier { get; set; }

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
        /// Initializes a new instance of the <see cref="SwanSLogoDesignRequest" /> class.
        /// </summary>
        /// <param name="logoStyle"></param>
        /// <param name="sourceMode">
        /// Use a shoe color swatch or an uploaded logo reference as the style source.
        /// </param>
        /// <param name="styleSourceAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="designVariant">
        /// Required for 3D user_reference designs. Omit for other designs.
        /// </param>
        /// <param name="geometryHeroAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="logoSpecificationAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="flatSilhouetteAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
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
        public SwanSLogoDesignRequest(
            global::Ideogram.SwanSLogoDesignRequestLogoStyle logoStyle,
            global::Ideogram.SwanSLogoDesignRequestSourceMode sourceMode,
            global::Ideogram.AssetIdentifier styleSourceAssetIdentifier,
            global::Ideogram.SwanSLogoDesignRequestDesignVariant? designVariant,
            global::Ideogram.AssetIdentifier? geometryHeroAssetIdentifier,
            global::Ideogram.AssetIdentifier? logoSpecificationAssetIdentifier,
            global::Ideogram.AssetIdentifier? flatSilhouetteAssetIdentifier,
            global::Ideogram.GptImage2Quality? quality,
            bool? @private,
            string? webhookUrl)
        {
            this.LogoStyle = logoStyle;
            this.SourceMode = sourceMode;
            this.DesignVariant = designVariant;
            this.StyleSourceAssetIdentifier = styleSourceAssetIdentifier ?? throw new global::System.ArgumentNullException(nameof(styleSourceAssetIdentifier));
            this.GeometryHeroAssetIdentifier = geometryHeroAssetIdentifier;
            this.LogoSpecificationAssetIdentifier = logoSpecificationAssetIdentifier;
            this.FlatSilhouetteAssetIdentifier = flatSilhouetteAssetIdentifier;
            this.Quality = quality;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwanSLogoDesignRequest" /> class.
        /// </summary>
        public SwanSLogoDesignRequest()
        {
        }

    }
}