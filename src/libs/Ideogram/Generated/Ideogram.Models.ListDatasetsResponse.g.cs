
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"datasets":[{"creation_time":"2000-01-23T04:56:07\u002B00:00","user_id":"user_id","dataset_id":"dataset_id","name":"name","cover_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}},{"creation_time":"2000-01-23T04:56:07\u002B00:00","user_id":"user_id","dataset_id":"dataset_id","name":"name","cover_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}}]}
    /// </summary>
    public sealed partial class ListDatasetsResponse
    {
        /// <summary>
        /// List of datasets for the authenticated user.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.Dataset> Datasets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDatasetsResponse" /> class.
        /// </summary>
        /// <param name="datasets">
        /// List of datasets for the authenticated user.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListDatasetsResponse(
            global::System.Collections.Generic.IList<global::Ideogram.Dataset> datasets)
        {
            this.Datasets = datasets ?? throw new global::System.ArgumentNullException(nameof(datasets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDatasetsResponse" /> class.
        /// </summary>
        public ListDatasetsResponse()
        {
        }
    }
}