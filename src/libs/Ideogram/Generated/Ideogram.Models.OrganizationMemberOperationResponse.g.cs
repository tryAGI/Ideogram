
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationMemberOperationResponse
    {
        /// <summary>
        /// List of results for each member operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.OrganizationMemberOperationResult> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberOperationResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// List of results for each member operation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationMemberOperationResponse(
            global::System.Collections.Generic.IList<global::Ideogram.OrganizationMemberOperationResult> results)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberOperationResponse" /> class.
        /// </summary>
        public OrganizationMemberOperationResponse()
        {
        }
    }
}