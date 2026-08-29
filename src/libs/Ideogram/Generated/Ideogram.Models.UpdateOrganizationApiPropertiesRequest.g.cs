
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Partial update for an organization's API-only properties. Only fields explicitly present are written; unset fields preserve their current value.<br/>
    /// Example: {"copyright_detection_enabled":true}
    /// </summary>
    public sealed partial class UpdateOrganizationApiPropertiesRequest
    {
        /// <summary>
        /// Toggle post-generation Hive likeness + logo detection for this organization. See ApiProfile.copyright_detection_enabled for behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copyright_detection_enabled")]
        public bool? CopyrightDetectionEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationApiPropertiesRequest" /> class.
        /// </summary>
        /// <param name="copyrightDetectionEnabled">
        /// Toggle post-generation Hive likeness + logo detection for this organization. See ApiProfile.copyright_detection_enabled for behavior.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOrganizationApiPropertiesRequest(
            bool? copyrightDetectionEnabled)
        {
            this.CopyrightDetectionEnabled = copyrightDetectionEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationApiPropertiesRequest" /> class.
        /// </summary>
        public UpdateOrganizationApiPropertiesRequest()
        {
        }

    }
}