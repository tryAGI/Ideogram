
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"assets":[{"delivery":"","media_type":"media_type","external_ref":"external_ref","width":1,"label":"label","height":1},{"delivery":"","media_type":"media_type","external_ref":"external_ref","width":1,"label":"label","height":1}]}
    /// </summary>
    public sealed partial class IntegrationAssetSearchResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.IntegrationAsset> Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationAssetSearchResponse" /> class.
        /// </summary>
        /// <param name="assets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationAssetSearchResponse(
            global::System.Collections.Generic.IList<global::Ideogram.IntegrationAsset> assets)
        {
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationAssetSearchResponse" /> class.
        /// </summary>
        public IntegrationAssetSearchResponse()
        {
        }

    }
}