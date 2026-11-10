
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// TextLayerizerResultObject variant
    /// </summary>
    public sealed partial class GenerationResponseDataInnerVariant6
    {
        /// <summary>
        /// Discriminator value: layerized_design.generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerVariant6ObjectTypeJsonConverter))]
        public global::Ideogram.V2.GenerationResponseDataInnerVariant6ObjectType ObjectType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_image_safe")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsImageSafe { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seed { get; set; }

        /// <summary>
        /// Signed composite image URL on results created before schema version 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Url { get; set; }

        /// <summary>
        /// Signed text-free base URL on results created before schema version 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_image_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? BaseImageUrl { get; set; }

        /// <summary>
        /// Canvas resolution on results created before schema version 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Resolution { get; set; }

        /// <summary>
        /// Text regions on results created before schema version 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_blocks")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizedTextBlock>? TextBlocks { get; set; }

        /// <summary>
        /// Artwork layers on results created before schema version 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_layers")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizedImageLayer>? ImageLayers { get; set; }

        /// <summary>
        /// URL-safe base64 ID of the editable layered asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layered_asset_id")]
        public string? LayeredAssetId { get; set; }

        /// <summary>
        /// URL-safe base64 ID to pass to `GET /v2/design/html/{layerize_id}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layerize_id")]
        public string? LayerizeId { get; set; }

        /// <summary>
        /// Original editable document; URLs are added when served and are never stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public global::Ideogram.V2.LayerizeDocument? Document { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponseDataInnerVariant6" /> class.
        /// </summary>
        /// <param name="isImageSafe"></param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="objectType">
        /// Discriminator value: layerized_design.generation
        /// </param>
        /// <param name="layeredAssetId">
        /// URL-safe base64 ID of the editable layered asset.
        /// </param>
        /// <param name="layerizeId">
        /// URL-safe base64 ID to pass to `GET /v2/design/html/{layerize_id}`.
        /// </param>
        /// <param name="document">
        /// Original editable document; URLs are added when served and are never stored.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationResponseDataInnerVariant6(
            bool isImageSafe,
            int seed,
            global::Ideogram.V2.GenerationResponseDataInnerVariant6ObjectType objectType,
            string? layeredAssetId,
            string? layerizeId,
            global::Ideogram.V2.LayerizeDocument? document)
        {
            this.ObjectType = objectType;
            this.IsImageSafe = isImageSafe;
            this.Seed = seed;
            this.LayeredAssetId = layeredAssetId;
            this.LayerizeId = layerizeId;
            this.Document = document;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponseDataInnerVariant6" /> class.
        /// </summary>
        public GenerationResponseDataInnerVariant6()
        {
        }

    }
}