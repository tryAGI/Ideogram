
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// SvgGenerationObject variant
    /// </summary>
    public sealed partial class GenerationResponseDataInnerVariant2
    {
        /// <summary>
        /// Discriminator value: svg.generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerVariant2ObjectTypeJsonConverter))]
        public global::Ideogram.V2.GenerationResponseDataInnerVariant2ObjectType ObjectType { get; set; }

        /// <summary>
        /// URL-safe base64 SVG asset ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssetId { get; set; }

        /// <summary>
        /// Signed download URL for the original SVG.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerDiscriminatorMappingSvgGenerationMimeTypeJsonConverter))]
        public global::Ideogram.V2.GenerationResponseDataInnerDiscriminatorMappingSvgGenerationMimeType MimeType { get; set; }

        /// <summary>
        /// Width of the output SVG canvas in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// Height of the output SVG canvas in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponseDataInnerVariant2" /> class.
        /// </summary>
        /// <param name="assetId">
        /// URL-safe base64 SVG asset ID.
        /// </param>
        /// <param name="url">
        /// Signed download URL for the original SVG.
        /// </param>
        /// <param name="width">
        /// Width of the output SVG canvas in pixels.
        /// </param>
        /// <param name="height">
        /// Height of the output SVG canvas in pixels.
        /// </param>
        /// <param name="objectType">
        /// Discriminator value: svg.generation
        /// </param>
        /// <param name="mimeType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationResponseDataInnerVariant2(
            string assetId,
            string url,
            int width,
            int height,
            global::Ideogram.V2.GenerationResponseDataInnerVariant2ObjectType objectType,
            global::Ideogram.V2.GenerationResponseDataInnerDiscriminatorMappingSvgGenerationMimeType mimeType)
        {
            this.ObjectType = objectType;
            this.AssetId = assetId ?? throw new global::System.ArgumentNullException(nameof(assetId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.MimeType = mimeType;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponseDataInnerVariant2" /> class.
        /// </summary>
        public GenerationResponseDataInnerVariant2()
        {
        }

    }
}