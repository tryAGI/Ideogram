
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"start_time":"2000-01-23T04:56:07\u002B00:00","end_time":"2000-01-23T04:56:07\u002B00:00","line_items":[{"product":"ideogram_v4_generation","endpoint":"/v2/images/generate/ideogram-v4","cost_total":"84.00","user_email":"user_email","api_key":{"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"},"description":"Ideogram v4 Generation","billed_units":{"unit":"image","quantity":"2100","unit_price":"0.04"},"source":"api","currency_code":"USD","dimensions":{"key":"dimensions"}},{"product":"ideogram_v4_generation","endpoint":"/v2/images/generate/ideogram-v4","cost_total":"84.00","user_email":"user_email","api_key":{"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"},"description":"Ideogram v4 Generation","billed_units":{"unit":"image","quantity":"2100","unit_price":"0.04"},"source":"api","currency_code":"USD","dimensions":{"key":"dimensions"}}]}
    /// </summary>
    public sealed partial class AccountUsageBucket
    {
        /// <summary>
        /// Start of the bucket window (inclusive, UTC).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// End of the bucket window (exclusive, UTC).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// Usage billed in this window. Empty when nothing was billed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.AccountUsageLineItem> LineItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUsageBucket" /> class.
        /// </summary>
        /// <param name="startTime">
        /// Start of the bucket window (inclusive, UTC).
        /// </param>
        /// <param name="endTime">
        /// End of the bucket window (exclusive, UTC).
        /// </param>
        /// <param name="lineItems">
        /// Usage billed in this window. Empty when nothing was billed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountUsageBucket(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::System.Collections.Generic.IList<global::Ideogram.AccountUsageLineItem> lineItems)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.LineItems = lineItems ?? throw new global::System.ArgumentNullException(nameof(lineItems));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUsageBucket" /> class.
        /// </summary>
        public AccountUsageBucket()
        {
        }

    }
}