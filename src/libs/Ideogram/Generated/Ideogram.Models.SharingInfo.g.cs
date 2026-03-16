
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"updated_time":"2000-01-23T04:56:07\u002B00:00","organization":{"role":null,"publishing_disabled":true,"organization_id":"organization_id","name":"name","avatar":{"avatar_url":"avatar_url"},"type":null},"permission":null,"user":{"badge":"badge","subscription_plan_id":"subscription_plan_id","display_handle":"display_handle","user_id":"user_id","photo_url":"photo_url"}}
    /// </summary>
    public sealed partial class SharingInfo
    {
        /// <summary>
        /// Permission level for the shared organization. OWNER is read-only and cannot be set via add/remove.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.SharingPermissionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.SharingPermission Permission { get; set; }

        /// <summary>
        /// When this sharing entry was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedTime { get; set; }

        /// <summary>
        /// An organization object<br/>
        /// Example: {"role":null,"publishing_disabled":true,"organization_id":"organization_id","name":"name","avatar":{"avatar_url":"avatar_url"},"type":null}
        /// </summary>
        /// <example>{"role":null,"publishing_disabled":true,"organization_id":"organization_id","name":"name","avatar":{"avatar_url":"avatar_url"},"type":null}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::Ideogram.OrganizationObject? Organization { get; set; }

        /// <summary>
        /// Example: {"badge":"badge","subscription_plan_id":"subscription_plan_id","display_handle":"display_handle","user_id":"user_id","photo_url":"photo_url"}
        /// </summary>
        /// <example>{"badge":"badge","subscription_plan_id":"subscription_plan_id","display_handle":"display_handle","user_id":"user_id","photo_url":"photo_url"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Ideogram.User? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharingInfo" /> class.
        /// </summary>
        /// <param name="permission">
        /// Permission level for the shared organization. OWNER is read-only and cannot be set via add/remove.
        /// </param>
        /// <param name="updatedTime">
        /// When this sharing entry was last updated.
        /// </param>
        /// <param name="organization">
        /// An organization object<br/>
        /// Example: {"role":null,"publishing_disabled":true,"organization_id":"organization_id","name":"name","avatar":{"avatar_url":"avatar_url"},"type":null}
        /// </param>
        /// <param name="user">
        /// Example: {"badge":"badge","subscription_plan_id":"subscription_plan_id","display_handle":"display_handle","user_id":"user_id","photo_url":"photo_url"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharingInfo(
            global::Ideogram.SharingPermission permission,
            global::System.DateTime updatedTime,
            global::Ideogram.OrganizationObject? organization,
            global::Ideogram.User? user)
        {
            this.Permission = permission;
            this.UpdatedTime = updatedTime;
            this.Organization = organization;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharingInfo" /> class.
        /// </summary>
        public SharingInfo()
        {
        }
    }
}