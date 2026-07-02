
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"total_issued":{"amount":1050,"currency_code":"USD"},"total_expired":{"amount":1050,"currency_code":"USD"},"total_consumed":{"amount":1050,"currency_code":"USD"},"credit_grants":[{"effective_at":"effective_at","amount_consumed":{"amount":1050,"currency_code":"USD"},"expires_at":"expires_at","amount_available":{"amount":1050,"currency_code":"USD"},"grant_id":"grant_id","name":"name","amount_issued":{"amount":1050,"currency_code":"USD"}},{"effective_at":"effective_at","amount_consumed":{"amount":1050,"currency_code":"USD"},"expires_at":"expires_at","amount_available":{"amount":1050,"currency_code":"USD"},"grant_id":"grant_id","name":"name","amount_issued":{"amount":1050,"currency_code":"USD"}}]}
    /// </summary>
    public sealed partial class ManageApiCreditSummaryResponse
    {
        /// <summary>
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </summary>
        /// <example>{"amount":1050,"currency_code":"USD"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_consumed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Price TotalConsumed { get; set; }

        /// <summary>
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </summary>
        /// <example>{"amount":1050,"currency_code":"USD"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_expired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Price TotalExpired { get; set; }

        /// <summary>
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </summary>
        /// <example>{"amount":1050,"currency_code":"USD"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_issued")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Price TotalIssued { get; set; }

        /// <summary>
        /// Per-grant breakdown of the user's credit grants. Empty if Metronome is unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credit_grants")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.CreditGrant> CreditGrants { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageApiCreditSummaryResponse" /> class.
        /// </summary>
        /// <param name="totalConsumed">
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </param>
        /// <param name="totalExpired">
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </param>
        /// <param name="totalIssued">
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </param>
        /// <param name="creditGrants">
        /// Per-grant breakdown of the user's credit grants. Empty if Metronome is unavailable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManageApiCreditSummaryResponse(
            global::Ideogram.Price totalConsumed,
            global::Ideogram.Price totalExpired,
            global::Ideogram.Price totalIssued,
            global::System.Collections.Generic.IList<global::Ideogram.CreditGrant> creditGrants)
        {
            this.TotalConsumed = totalConsumed ?? throw new global::System.ArgumentNullException(nameof(totalConsumed));
            this.TotalExpired = totalExpired ?? throw new global::System.ArgumentNullException(nameof(totalExpired));
            this.TotalIssued = totalIssued ?? throw new global::System.ArgumentNullException(nameof(totalIssued));
            this.CreditGrants = creditGrants ?? throw new global::System.ArgumentNullException(nameof(creditGrants));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageApiCreditSummaryResponse" /> class.
        /// </summary>
        public ManageApiCreditSummaryResponse()
        {
        }

    }
}