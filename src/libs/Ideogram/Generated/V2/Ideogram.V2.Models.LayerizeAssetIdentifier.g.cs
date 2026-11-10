
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LayerizeAssetIdentifier
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizeAssetIdentifierAssetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.LayerizeAssetIdentifierAssetType AssetType { get; set; }

        /// <summary>
        /// URL-safe base64 asset ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeAssetIdentifier" /> class.
        /// </summary>
        /// <param name="assetType"></param>
        /// <param name="assetId">
        /// URL-safe base64 asset ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeAssetIdentifier(
            global::Ideogram.V2.LayerizeAssetIdentifierAssetType assetType,
            string assetId)
        {
            this.AssetType = assetType;
            this.AssetId = assetId ?? throw new global::System.ArgumentNullException(nameof(assetId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeAssetIdentifier" /> class.
        /// </summary>
        public LayerizeAssetIdentifier()
        {
        }

    }
}