
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"commits":[{"commit_start_time":"2000-01-23T04:56:07.0000000\u002B00:00","is_postpaid_commit":true,"commit_amount_spent":{"amount":1050,"currency_code":"USD"},"commit_amount":{"amount":1050,"currency_code":"USD"},"commit_end_time":"2000-01-23T04:56:07.0000000\u002B00:00"},{"commit_start_time":"2000-01-23T04:56:07.0000000\u002B00:00","is_postpaid_commit":true,"commit_amount_spent":{"amount":1050,"currency_code":"USD"},"commit_amount":{"amount":1050,"currency_code":"USD"},"commit_end_time":"2000-01-23T04:56:07.0000000\u002B00:00"}]}
    /// </summary>
    public sealed partial class SpendCommitInfoResponse
    {
        /// <summary>
        /// A list of spend commit information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Ideogram.SpendCommitInfo> Commits { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendCommitInfoResponse" /> class.
        /// </summary>
        /// <param name="commits">
        /// A list of spend commit information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendCommitInfoResponse(
            global::System.Collections.Generic.IList<global::Ideogram.SpendCommitInfo> commits)
        {
            this.Commits = commits ?? throw new global::System.ArgumentNullException(nameof(commits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendCommitInfoResponse" /> class.
        /// </summary>
        public SpendCommitInfoResponse()
        {
        }
    }
}