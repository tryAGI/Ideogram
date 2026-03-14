
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"datasets":[{"collection_id":"collection_id","creation_time":"2000-01-23T04:56:07\u002B00:00","user_id":"user_id","name":"name","cover_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"sharing":[{"updated_time":"2000-01-23T04:56:07\u002B00:00","organization":{"role":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","publishing_disabled":true,"organization_id":"organization_id","name":"name","avatar":{"avatar_url":"avatar_url"},"type":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"},"permission":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","user":{"badge":"badge","subscription_plan_id":"subscription_plan_id","display_handle":"display_handle","user_id":"user_id","photo_url":"photo_url"}},{"updated_time":"2000-01-23T04:56:07\u002B00:00","organization":{"role":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","publishing_disabled":true,"organization_id":"organization_id","name":"name","avatar":{"avatar_url":"avatar_url"},"type":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"},"permission":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","user":{"badge":"badge","subscription_plan_id":"subscription_plan_id","display_handle":"display_handle","user_id":"user_id","photo_url":"photo_url"}}]},{"collection_id":"collection_id","creation_time":"2000-01-23T04:56:07\u002B00:00","user_id":"user_id","name":"name","cover_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"sharing":[{"updated_time":"2000-01-23T04:56:07\u002B00:00","organization":{"role":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","publishing_disabled":true,"organization_id":"organization_id","name":"name","avatar":{"avatar_url":"avatar_url"},"type":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"},"permission":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","user":{"badge":"badge","subscription_plan_id":"subscription_plan_id","display_handle":"display_handle","user_id":"user_id","photo_url":"photo_url"}},{"updated_time":"2000-01-23T04:56:07\u002B00:00","organization":{"role":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","publishing_disabled":true,"organization_id":"organization_id","name":"name","avatar":{"avatar_url":"avatar_url"},"type":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"},"permission":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","user":{"badge":"badge","subscription_plan_id":"subscription_plan_id","display_handle":"display_handle","user_id":"user_id","photo_url":"photo_url"}}]}]}
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