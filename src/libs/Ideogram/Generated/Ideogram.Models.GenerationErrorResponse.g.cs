
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A generation request rejected by an account or usage limit.<br/>
    /// Example: {"max_inflight_requests":8,"task_completion_speed":"fast","reject_reason":null,"error":"error"}
    /// </summary>
    public sealed partial class GenerationErrorResponse
    {
        /// <summary>
        /// A message describing why the generation request was rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// The account or usage limit that rejected a generation request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GenerationRejectReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.GenerationRejectReason RejectReason { get; set; }

        /// <summary>
        /// How many generations the account may have in progress at once on<br/>
        /// the queue this request resolved to. Present when `reject_reason`<br/>
        /// is `inflight_limit`.<br/>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_inflight_requests")]
        public int? MaxInflightRequests { get; set; }

        /// <summary>
        /// The queue this request resolved to. Present when `reject_reason`<br/>
        /// is `inflight_limit`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_completion_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GenerationErrorResponseTaskCompletionSpeedJsonConverter))]
        public global::Ideogram.GenerationErrorResponseTaskCompletionSpeed? TaskCompletionSpeed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationErrorResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// A message describing why the generation request was rejected.
        /// </param>
        /// <param name="rejectReason">
        /// The account or usage limit that rejected a generation request.
        /// </param>
        /// <param name="maxInflightRequests">
        /// How many generations the account may have in progress at once on<br/>
        /// the queue this request resolved to. Present when `reject_reason`<br/>
        /// is `inflight_limit`.<br/>
        /// Example: 8
        /// </param>
        /// <param name="taskCompletionSpeed">
        /// The queue this request resolved to. Present when `reject_reason`<br/>
        /// is `inflight_limit`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationErrorResponse(
            string error,
            global::Ideogram.GenerationRejectReason rejectReason,
            int? maxInflightRequests,
            global::Ideogram.GenerationErrorResponseTaskCompletionSpeed? taskCompletionSpeed)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RejectReason = rejectReason;
            this.MaxInflightRequests = maxInflightRequests;
            this.TaskCompletionSpeed = taskCompletionSpeed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationErrorResponse" /> class.
        /// </summary>
        public GenerationErrorResponse()
        {
        }

    }
}