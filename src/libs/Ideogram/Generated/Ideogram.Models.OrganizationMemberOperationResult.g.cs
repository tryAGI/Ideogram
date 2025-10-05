
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationMemberOperationResult
    {
        /// <summary>
        /// Whether the operation was successful for this member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// A message describing the outcome of the operation for this member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberOperationResult" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the operation was successful for this member
        /// </param>
        /// <param name="message">
        /// A message describing the outcome of the operation for this member
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationMemberOperationResult(
            bool success,
            string? message)
        {
            this.Success = success;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberOperationResult" /> class.
        /// </summary>
        public OrganizationMemberOperationResult()
        {
        }
    }
}