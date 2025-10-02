
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetApiProfilesResponse
    {
        /// <summary>
        /// List of user's API profiles
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profiles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.ApiProfile> Profiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiProfilesResponse" /> class.
        /// </summary>
        /// <param name="profiles">
        /// List of user's API profiles
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetApiProfilesResponse(
            global::System.Collections.Generic.IList<global::Ideogram.ApiProfile> profiles)
        {
            this.Profiles = profiles ?? throw new global::System.ArgumentNullException(nameof(profiles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiProfilesResponse" /> class.
        /// </summary>
        public GetApiProfilesResponse()
        {
        }
    }
}