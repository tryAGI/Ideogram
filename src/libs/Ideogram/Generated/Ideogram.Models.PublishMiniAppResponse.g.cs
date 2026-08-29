
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Confirmation of a published mini-app catalog entry.<br/>
    /// Example: {"archived":true,"mini_app_id":"mini_app_id","requires_membership":true,"slug":"slug"}
    /// </summary>
    public sealed partial class PublishMiniAppResponse
    {
        /// <summary>
        /// Unique identifier of the published mini-app.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mini_app_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MiniAppId { get; set; }

        /// <summary>
        /// Unique, stable, URL-safe mini-app identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Whether the mini-app requires a membership to access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_membership")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequiresMembership { get; set; }

        /// <summary>
        /// Whether the mini-app is currently archived (hidden from the catalog).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Archived { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishMiniAppResponse" /> class.
        /// </summary>
        /// <param name="miniAppId">
        /// Unique identifier of the published mini-app.
        /// </param>
        /// <param name="slug">
        /// Unique, stable, URL-safe mini-app identifier.
        /// </param>
        /// <param name="requiresMembership">
        /// Whether the mini-app requires a membership to access.
        /// </param>
        /// <param name="archived">
        /// Whether the mini-app is currently archived (hidden from the catalog).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishMiniAppResponse(
            string miniAppId,
            string slug,
            bool requiresMembership,
            bool archived)
        {
            this.MiniAppId = miniAppId ?? throw new global::System.ArgumentNullException(nameof(miniAppId));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.RequiresMembership = requiresMembership;
            this.Archived = archived;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishMiniAppResponse" /> class.
        /// </summary>
        public PublishMiniAppResponse()
        {
        }

    }
}