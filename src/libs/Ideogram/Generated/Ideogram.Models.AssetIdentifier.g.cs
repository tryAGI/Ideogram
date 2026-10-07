
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// An identifier for an ideogram asset.<br/>
    /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
    /// </summary>
    public sealed partial class AssetIdentifier
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AssetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AssetType AssetType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssetId { get; set; }

        /// <summary>
        /// Optional collection from which this asset was selected as a generation reference. Records usage attribution; does not grant access to the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_id")]
        public string? CollectionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetIdentifier" /> class.
        /// </summary>
        /// <param name="assetType"></param>
        /// <param name="assetId"></param>
        /// <param name="collectionId">
        /// Optional collection from which this asset was selected as a generation reference. Records usage attribution; does not grant access to the asset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetIdentifier(
            global::Ideogram.AssetType assetType,
            string assetId,
            string? collectionId)
        {
            this.AssetType = assetType;
            this.AssetId = assetId ?? throw new global::System.ArgumentNullException(nameof(assetId));
            this.CollectionId = collectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetIdentifier" /> class.
        /// </summary>
        public AssetIdentifier()
        {
        }

    }
}