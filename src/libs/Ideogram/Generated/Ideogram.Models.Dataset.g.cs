
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A dataset for organizing assets.<br/>
    /// Example: {"collection_id":"collection_id","creation_time":"2000-01-23T04:56:07\u002B00:00","user_id":"user_id","name":"name","cover_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"sharing":[{"updated_time":"2000-01-23T04:56:07\u002B00:00","organization":{"role":null,"publishing_disabled":true,"organization_id":"organization_id","name":"name","avatar":{"avatar_url":"avatar_url"},"type":null},"permission":null,"user":{"badge":"badge","subscription_plan_id":"subscription_plan_id","display_handle":"display_handle","user_id":"user_id","photo_url":"photo_url"}},{"updated_time":"2000-01-23T04:56:07\u002B00:00","organization":{"role":null,"publishing_disabled":true,"organization_id":"organization_id","name":"name","avatar":{"avatar_url":"avatar_url"},"type":null},"permission":null,"user":{"badge":"badge","subscription_plan_id":"subscription_plan_id","display_handle":"display_handle","user_id":"user_id","photo_url":"photo_url"}}]}
    /// </summary>
    public sealed partial class Dataset
    {
        /// <summary>
        /// Unique identifier for the collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionId { get; set; }

        /// <summary>
        /// Display name of the collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// ID of the user who owns this collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// When the collection was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreationTime { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_asset_identifier")]
        public global::Ideogram.AssetIdentifier? CoverAssetIdentifier { get; set; }

        /// <summary>
        /// Sharing details for this collection including the owner entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharing")]
        public global::System.Collections.Generic.IList<global::Ideogram.SharingInfo>? Sharing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        /// <param name="collectionId">
        /// Unique identifier for the collection.
        /// </param>
        /// <param name="name">
        /// Display name of the collection.
        /// </param>
        /// <param name="userId">
        /// ID of the user who owns this collection.
        /// </param>
        /// <param name="creationTime">
        /// When the collection was created.
        /// </param>
        /// <param name="coverAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="sharing">
        /// Sharing details for this collection including the owner entry.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Dataset(
            string collectionId,
            string name,
            string userId,
            global::System.DateTime creationTime,
            global::Ideogram.AssetIdentifier? coverAssetIdentifier,
            global::System.Collections.Generic.IList<global::Ideogram.SharingInfo>? sharing)
        {
            this.CollectionId = collectionId ?? throw new global::System.ArgumentNullException(nameof(collectionId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.CreationTime = creationTime;
            this.CoverAssetIdentifier = coverAssetIdentifier;
            this.Sharing = sharing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        public Dataset()
        {
        }
    }
}