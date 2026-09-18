
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"duration":5,"target_collection_id":"target_collection_id","image_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"product_description":"product_description","resolution":null,"direction":null}
    /// </summary>
    public sealed partial class Product360VideoRequest
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
        /// Direction the product rotates around its vertical axis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.Product360VideoDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Product360VideoDirection Direction { get; set; }

        /// <summary>
        /// Optional factual description of the product in the source image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_description")]
        public string? ProductDescription { get; set; }

        /// <summary>
        /// The resolution tier of the generated video.<br/>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.SeedDance25ResolutionJsonConverter))]
        public global::Ideogram.SeedDance25Resolution? Resolution { get; set; }

        /// <summary>
        /// The length of the generated video in seconds. When omitted, the model<br/>
        /// picks the best duration for the prompt ("auto").<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
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
        /// Initializes a new instance of the <see cref="Product360VideoRequest" /> class.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="direction">
        /// Direction the product rotates around its vertical axis.
        /// </param>
        /// <param name="productDescription">
        /// Optional factual description of the product in the source image.
        /// </param>
        /// <param name="resolution">
        /// The resolution tier of the generated video.<br/>
        /// Default Value: 720p
        /// </param>
        /// <param name="duration">
        /// The length of the generated video in seconds. When omitted, the model<br/>
        /// picks the best duration for the prompt ("auto").<br/>
        /// Example: 5
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. The output video is added to it when the request completes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Product360VideoRequest(
            global::Ideogram.AssetIdentifier imageAssetIdentifier,
            global::Ideogram.Product360VideoDirection direction,
            string? productDescription,
            global::Ideogram.SeedDance25Resolution? resolution,
            int? duration,
            string? targetCollectionId)
        {
            this.ImageAssetIdentifier = imageAssetIdentifier ?? throw new global::System.ArgumentNullException(nameof(imageAssetIdentifier));
            this.Direction = direction;
            this.ProductDescription = productDescription;
            this.Resolution = resolution;
            this.Duration = duration;
            this.TargetCollectionId = targetCollectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product360VideoRequest" /> class.
        /// </summary>
        public Product360VideoRequest()
        {
        }

    }
}