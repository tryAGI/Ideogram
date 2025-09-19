
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A response for batch magic prompt job results.
    /// </summary>
    public sealed partial class InternalBatchResultsResponse
    {
        /// <summary>
        /// The status of the batch generation job.<br/>
        /// Example: COMPLETE
        /// </summary>
        /// <example>COMPLETE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobStatus { get; set; }

        /// <summary>
        /// The batch generation results, with each entry containing a prompt and its corresponding image URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Ideogram.InternalBatchResultsResponseResultsInner>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalBatchResultsResponse" /> class.
        /// </summary>
        /// <param name="jobStatus">
        /// The status of the batch generation job.<br/>
        /// Example: COMPLETE
        /// </param>
        /// <param name="results">
        /// The batch generation results, with each entry containing a prompt and its corresponding image URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternalBatchResultsResponse(
            string jobStatus,
            global::System.Collections.Generic.IList<global::Ideogram.InternalBatchResultsResponseResultsInner>? results)
        {
            this.JobStatus = jobStatus ?? throw new global::System.ArgumentNullException(nameof(jobStatus));
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalBatchResultsResponse" /> class.
        /// </summary>
        public InternalBatchResultsResponse()
        {
        }
    }
}