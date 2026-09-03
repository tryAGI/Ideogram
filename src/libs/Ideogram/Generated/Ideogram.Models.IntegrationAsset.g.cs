
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"delivery":"","media_type":"media_type","external_ref":"external_ref","width":1,"label":"label","height":1}
    /// </summary>
    public sealed partial class IntegrationAsset
    {
        /// <summary>
        /// Opaque signed reference to this external asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalRef { get; set; }

        /// <summary>
        /// Short-lived link for fetching this asset's media bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.IntegrationAssetDelivery Delivery { get; set; }

        /// <summary>
        /// Human-readable asset label supplied by the integration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Asset media type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaType { get; set; }

        /// <summary>
        /// Pixel width when supplied by the integration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Pixel height when supplied by the integration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationAsset" /> class.
        /// </summary>
        /// <param name="externalRef">
        /// Opaque signed reference to this external asset.
        /// </param>
        /// <param name="delivery">
        /// Short-lived link for fetching this asset's media bytes.
        /// </param>
        /// <param name="label">
        /// Human-readable asset label supplied by the integration.
        /// </param>
        /// <param name="mediaType">
        /// Asset media type.
        /// </param>
        /// <param name="width">
        /// Pixel width when supplied by the integration.
        /// </param>
        /// <param name="height">
        /// Pixel height when supplied by the integration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationAsset(
            string externalRef,
            global::Ideogram.IntegrationAssetDelivery delivery,
            string label,
            string mediaType,
            int? width,
            int? height)
        {
            this.ExternalRef = externalRef ?? throw new global::System.ArgumentNullException(nameof(externalRef));
            this.Delivery = delivery ?? throw new global::System.ArgumentNullException(nameof(delivery));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.MediaType = mediaType ?? throw new global::System.ArgumentNullException(nameof(mediaType));
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationAsset" /> class.
        /// </summary>
        public IntegrationAsset()
        {
        }

    }
}