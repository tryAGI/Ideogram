
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpendCommitInfoResponse
    {
        /// <summary>
        /// A list of spend commit information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.SpendCommitInfo> Commits { get; set; }

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