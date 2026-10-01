
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"duration":8,"target_collection_id":"target_collection_id","image_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"quality":null}
    /// </summary>
    public sealed partial class LivingImageRequest
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AssetIdentifier ImageAssetIdentifier { get; set; }

        /// <summary>
        /// The output resolution tier. `standard` renders at 768P; `high` renders at 2K. Higher tiers cost more.<br/>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.LivingImageQualityJsonConverter))]
        public global::Ideogram.LivingImageQuality? Quality { get; set; }

        /// <summary>
        /// The length of the generated video in seconds.<br/>
        /// Default Value: 8<br/>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// A collection you can write to, by its URL-safe base64 collection id. The output video is added to it when the request completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_collection_id")]
        public string? TargetCollectionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LivingImageRequest" /> class.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="quality">
        /// The output resolution tier. `standard` renders at 768P; `high` renders at 2K. Higher tiers cost more.<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="duration">
        /// The length of the generated video in seconds.<br/>
        /// Default Value: 8<br/>
        /// Example: 8
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. The output video is added to it when the request completes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LivingImageRequest(
            global::Ideogram.AssetIdentifier imageAssetIdentifier,
            global::Ideogram.LivingImageQuality? quality,
            int? duration,
            string? targetCollectionId)
        {
            this.ImageAssetIdentifier = imageAssetIdentifier ?? throw new global::System.ArgumentNullException(nameof(imageAssetIdentifier));
            this.Quality = quality;
            this.Duration = duration;
            this.TargetCollectionId = targetCollectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LivingImageRequest" /> class.
        /// </summary>
        public LivingImageRequest()
        {
        }

    }
}