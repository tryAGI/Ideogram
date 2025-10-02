
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
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_amount_spent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Price CommitAmountSpent { get; set; }

        /// <summary>
        /// Represents a price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Price CommitAmount { get; set; }

        /// <summary>
        /// The start time of the commit period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CommitStartTime { get; set; }

        /// <summary>
        /// The end time of the commit period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CommitEndTime { get; set; }

        /// <summary>
        /// Whether the commit is postpaid (true) or prepaid (false)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_postpaid_commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPostpaidCommit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendCommitInfo" /> class.
        /// </summary>
        /// <param name="commitAmountSpent">
        /// Represents a price.
        /// </param>
        /// <param name="commitAmount">
        /// Represents a price.
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