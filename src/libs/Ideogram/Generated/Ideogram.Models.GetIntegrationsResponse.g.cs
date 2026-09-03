
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"integration_types":[null,null]}
    /// </summary>
    public sealed partial class GetIntegrationsResponse
    {
        /// <summary>
        /// Distinct enabled integration types for the active organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.IntegrationType> IntegrationTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationsResponse" /> class.
        /// </summary>
        /// <param name="integrationTypes">
        /// Distinct enabled integration types for the active organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetIntegrationsResponse(
            global::System.Collections.Generic.IList<global::Ideogram.IntegrationType> integrationTypes)
        {
            this.IntegrationTypes = integrationTypes ?? throw new global::System.ArgumentNullException(nameof(integrationTypes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationsResponse" /> class.
        /// </summary>
        public GetIntegrationsResponse()
        {
        }

    }
}