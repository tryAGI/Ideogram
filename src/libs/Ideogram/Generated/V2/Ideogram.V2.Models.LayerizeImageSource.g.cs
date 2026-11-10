
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LayerizeImageSource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.LayerizeAssetIdentifier AssetIdentifier { get; set; }

        /// <summary>
        /// Expiring URL added when the response is served.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeImageSource" /> class.
        /// </summary>
        /// <param name="assetIdentifier"></param>
        /// <param name="url">
        /// Expiring URL added when the response is served.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeImageSource(
            global::Ideogram.V2.LayerizeAssetIdentifier assetIdentifier,
            string? url)
        {
            this.AssetIdentifier = assetIdentifier ?? throw new global::System.ArgumentNullException(nameof(assetIdentifier));
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeImageSource" /> class.
        /// </summary>
        public LayerizeImageSource()
        {
        }

    }
}