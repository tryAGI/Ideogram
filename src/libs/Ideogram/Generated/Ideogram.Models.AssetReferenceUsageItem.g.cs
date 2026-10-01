
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"request_count":1}
    /// </summary>
    public sealed partial class AssetReferenceUsageItem
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AssetIdentifier AssetIdentifier { get; set; }

        /// <summary>
        /// Completed organization requests using the asset as an edit input within the requested range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long RequestCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetReferenceUsageItem" /> class.
        /// </summary>
        /// <param name="assetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="requestCount">
        /// Completed organization requests using the asset as an edit input within the requested range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetReferenceUsageItem(
            global::Ideogram.AssetIdentifier assetIdentifier,
            long requestCount)
        {
            this.AssetIdentifier = assetIdentifier ?? throw new global::System.ArgumentNullException(nameof(assetIdentifier));
            this.RequestCount = requestCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetReferenceUsageItem" /> class.
        /// </summary>
        public AssetReferenceUsageItem()
        {
        }

    }
}