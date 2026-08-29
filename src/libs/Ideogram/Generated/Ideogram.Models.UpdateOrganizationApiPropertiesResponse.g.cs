
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"copyright_detection_enabled":true}
    /// </summary>
    public sealed partial class UpdateOrganizationApiPropertiesResponse
    {
        /// <summary>
        /// The setting after the update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copyright_detection_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CopyrightDetectionEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationApiPropertiesResponse" /> class.
        /// </summary>
        /// <param name="copyrightDetectionEnabled">
        /// The setting after the update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOrganizationApiPropertiesResponse(
            bool copyrightDetectionEnabled)
        {
            this.CopyrightDetectionEnabled = copyrightDetectionEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationApiPropertiesResponse" /> class.
        /// </summary>
        public UpdateOrganizationApiPropertiesResponse()
        {
        }

    }
}