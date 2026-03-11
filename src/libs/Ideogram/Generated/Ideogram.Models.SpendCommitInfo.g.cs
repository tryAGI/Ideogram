
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"commit_start_time":"2000-01-23T04:56:07\u002B00:00","is_postpaid_commit":true,"commit_amount_spent":{"amount":1050,"currency_code":"USD"},"commit_amount":{"amount":1050,"currency_code":"USD"},"commit_end_time":"2000-01-23T04:56:07\u002B00:00"}
    /// </summary>
    public sealed partial class SpendCommitInfo
    {
        /// <summary>
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </summary>
        /// <example>{"amount":1050,"currency_code":"USD"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_amount_spent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Ideogram.Price CommitAmountSpent { get; set; } = default!;

        /// <summary>
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </summary>
        /// <example>{"amount":1050,"currency_code":"USD"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Ideogram.Price CommitAmount { get; set; } = default!;

        /// <summary>
        /// The start time of the commit period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime CommitStartTime { get; set; } = default!;

        /// <summary>
        /// The end time of the commit period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime CommitEndTime { get; set; } = default!;

        /// <summary>
        /// Whether the commit is postpaid (true) or prepaid (false)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_postpaid_commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool IsPostpaidCommit { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendCommitInfo" /> class.
        /// </summary>
        /// <param name="commitAmountSpent">
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </param>
        /// <param name="commitAmount">
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </param>
        /// <param name="commitStartTime">
        /// The start time of the commit period
        /// </param>
        /// <param name="commitEndTime">
        /// The end time of the commit period
        /// </param>
        /// <param name="isPostpaidCommit">
        /// Whether the commit is postpaid (true) or prepaid (false)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendCommitInfo(
            global::Ideogram.Price commitAmountSpent,
            global::Ideogram.Price commitAmount,
            global::System.DateTime commitStartTime,
            global::System.DateTime commitEndTime,
            bool isPostpaidCommit)
        {
            this.CommitAmountSpent = commitAmountSpent ?? throw new global::System.ArgumentNullException(nameof(commitAmountSpent));
            this.CommitAmount = commitAmount ?? throw new global::System.ArgumentNullException(nameof(commitAmount));
            this.CommitStartTime = commitStartTime;
            this.CommitEndTime = commitEndTime;
            this.IsPostpaidCommit = isPostpaidCommit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendCommitInfo" /> class.
        /// </summary>
        public SpendCommitInfo()
        {
        }
    }
}