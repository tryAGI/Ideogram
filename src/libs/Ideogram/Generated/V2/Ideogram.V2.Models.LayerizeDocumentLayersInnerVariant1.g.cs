
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// LayerizeImageLayer variant
    /// </summary>
    public sealed partial class LayerizeDocumentLayersInnerVariant1
    {
        /// <summary>
        /// Discriminator value: image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizeDocumentLayersInnerVariant1TypeJsonConverter))]
        public global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("box")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.LayerizeBox Box { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotation")]
        public double? Rotation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.LayerizeImageSource Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeDocumentLayersInnerVariant1" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="box"></param>
        /// <param name="image"></param>
        /// <param name="type">
        /// Discriminator value: image
        /// </param>
        /// <param name="rotation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeDocumentLayersInnerVariant1(
            string id,
            global::Ideogram.V2.LayerizeBox box,
            global::Ideogram.V2.LayerizeImageSource image,
            global::Ideogram.V2.LayerizeDocumentLayersInnerVariant1Type type,
            double? rotation)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Box = box ?? throw new global::System.ArgumentNullException(nameof(box));
            this.Rotation = rotation;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeDocumentLayersInnerVariant1" /> class.
        /// </summary>
        public LayerizeDocumentLayersInnerVariant1()
        {
        }

    }
}