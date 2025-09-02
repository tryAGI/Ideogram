
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A response for batch magic prompt evalution containing relavent information for /internal/batch/status GET request to find out if the batch generation has completed.
    /// </summary>
    public sealed partial class InternalBatchResponse
    {
        /// <summary>
        /// The job id for the batch generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalBatchResponse" /> class.
        /// </summary>
        /// <param name="jobId">
        /// The job id for the batch generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternalBatchResponse(
            string jobId)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalBatchResponse" /> class.
        /// </summary>
        public InternalBatchResponse()
        {
        }
    }
}