
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A generation request rejected by an account or usage limit.<br/>
    /// Example: {"reject_reason":null,"error":"error"}
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationErrorResponse(
            string error,
            global::Ideogram.GenerationRejectReason rejectReason)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RejectReason = rejectReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationErrorResponse" /> class.
        /// </summary>
        public GenerationErrorResponse()
        {
        }

    }
}