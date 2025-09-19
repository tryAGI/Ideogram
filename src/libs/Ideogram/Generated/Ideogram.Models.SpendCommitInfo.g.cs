
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpendCommitInfo
    {
        /// <summary>
        /// Represents a price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_spend_balance")]
        public global::Ideogram.Price? CommitSpendBalance { get; set; }

        /// <summary>
        /// Represents a price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_amount")]
        public global::Ideogram.Price? CommitAmount { get; set; }

        /// <summary>
        /// The start date of the commit period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_start_date")]
        public global::System.DateTime? CommitStartDate { get; set; }

        /// <summary>
        /// The end date of the commit period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_end_date")]
        public global::System.DateTime? CommitEndDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendCommitInfo" /> class.
        /// </summary>
        /// <param name="commitSpendBalance">
        /// Represents a price.
        /// </param>
        /// <param name="commitAmount">
        /// Represents a price.
        /// </param>
        /// <param name="commitStartDate">
        /// The start date of the commit period
        /// </param>
        /// <param name="commitEndDate">
        /// The end date of the commit period
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendCommitInfo(
            global::Ideogram.Price? commitSpendBalance,
            global::Ideogram.Price? commitAmount,
            global::System.DateTime? commitStartDate,
            global::System.DateTime? commitEndDate)
        {
            this.CommitSpendBalance = commitSpendBalance;
            this.CommitAmount = commitAmount;
            this.CommitStartDate = commitStartDate;
            this.CommitEndDate = commitEndDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendCommitInfo" /> class.
        /// </summary>
        public SpendCommitInfo()
        {
        }
    }
}