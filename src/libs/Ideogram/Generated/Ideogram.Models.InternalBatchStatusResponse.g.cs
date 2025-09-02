
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A response for batch magic prompt job status.
    /// </summary>
    public sealed partial class InternalBatchStatusResponse
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
        /// The URL to the TFRecord file in Google Cloud Storage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tfrecord_url")]
        public string? TfrecordUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalBatchStatusResponse" /> class.
        /// </summary>
        /// <param name="jobStatus">
        /// The status of the batch generation job.<br/>
        /// Example: COMPLETE
        /// </param>
        /// <param name="tfrecordUrl">
        /// The URL to the TFRecord file in Google Cloud Storage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternalBatchStatusResponse(
            string jobStatus,
            string? tfrecordUrl)
        {
            this.JobStatus = jobStatus ?? throw new global::System.ArgumentNullException(nameof(jobStatus));
            this.TfrecordUrl = tfrecordUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalBatchStatusResponse" /> class.
        /// </summary>
        public InternalBatchStatusResponse()
        {
        }
    }
}