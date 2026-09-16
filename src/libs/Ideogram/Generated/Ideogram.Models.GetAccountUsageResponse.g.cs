
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"buckets":[{"start_time":"2000-01-23T04:56:07\u002B00:00","end_time":"2000-01-23T04:56:07\u002B00:00","line_items":[{"product":"ideogram_v4_generation","endpoint":"/v2/image/generate/ideogram-v4","cost_total":"84.00","user_email":"user_email","api_key":{"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"},"description":"Ideogram v4 Generation","billed_units":{"unit":"image","quantity":"2100","unit_price":"0.04"},"source":"api","currency_code":"USD","dimensions":{"key":"dimensions"}},{"product":"ideogram_v4_generation","endpoint":"/v2/image/generate/ideogram-v4","cost_total":"84.00","user_email":"user_email","api_key":{"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"},"description":"Ideogram v4 Generation","billed_units":{"unit":"image","quantity":"2100","unit_price":"0.04"},"source":"api","currency_code":"USD","dimensions":{"key":"dimensions"}}]},{"start_time":"2000-01-23T04:56:07\u002B00:00","end_time":"2000-01-23T04:56:07\u002B00:00","line_items":[{"product":"ideogram_v4_generation","endpoint":"/v2/image/generate/ideogram-v4","cost_total":"84.00","user_email":"user_email","api_key":{"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"},"description":"Ideogram v4 Generation","billed_units":{"unit":"image","quantity":"2100","unit_price":"0.04"},"source":"api","currency_code":"USD","dimensions":{"key":"dimensions"}},{"product":"ideogram_v4_generation","endpoint":"/v2/image/generate/ideogram-v4","cost_total":"84.00","user_email":"user_email","api_key":{"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"},"description":"Ideogram v4 Generation","billed_units":{"unit":"image","quantity":"2100","unit_price":"0.04"},"source":"api","currency_code":"USD","dimensions":{"key":"dimensions"}}]}]}
    /// </summary>
    public sealed partial class GetAccountUsageResponse
    {
        /// <summary>
        /// Dense, chronological buckets covering the requested range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buckets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.AccountUsageBucket> Buckets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountUsageResponse" /> class.
        /// </summary>
        /// <param name="buckets">
        /// Dense, chronological buckets covering the requested range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAccountUsageResponse(
            global::System.Collections.Generic.IList<global::Ideogram.AccountUsageBucket> buckets)
        {
            this.Buckets = buckets ?? throw new global::System.ArgumentNullException(nameof(buckets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountUsageResponse" /> class.
        /// </summary>
        public GetAccountUsageResponse()
        {
        }

    }
}