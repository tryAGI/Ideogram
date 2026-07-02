
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"label":"Live production environment"}
    /// </summary>
    public sealed partial class PatchApiKeyRequest
    {
        /// <summary>
        /// New label for the API key. Pass null (or omit) to clear the existing label.<br/>
        /// Example: Live production environment
        /// </summary>
        /// <example>Live production environment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchApiKeyRequest" /> class.
        /// </summary>
        /// <param name="label">
        /// New label for the API key. Pass null (or omit) to clear the existing label.<br/>
        /// Example: Live production environment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchApiKeyRequest(
            string? label)
        {
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchApiKeyRequest" /> class.
        /// </summary>
        public PatchApiKeyRequest()
        {
        }

    }
}