
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// LayerizeContainerLayer variant
    /// </summary>
    public sealed partial class LayerizeDocumentLayersInnerVariant3
    {
        /// <summary>
        /// Discriminator value: container
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizeDocumentLayersInnerVariant3TypeJsonConverter))]
        public global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3Type Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.LayerizeContainerStyle Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeDocumentLayersInnerVariant3" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="box"></param>
        /// <param name="style"></param>
        /// <param name="type">
        /// Discriminator value: container
        /// </param>
        /// <param name="rotation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeDocumentLayersInnerVariant3(
            string id,
            global::Ideogram.V2.LayerizeBox box,
            global::Ideogram.V2.LayerizeContainerStyle style,
            global::Ideogram.V2.LayerizeDocumentLayersInnerVariant3Type type,
            double? rotation)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Box = box ?? throw new global::System.ArgumentNullException(nameof(box));
            this.Rotation = rotation;
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeDocumentLayersInnerVariant3" /> class.
        /// </summary>
        public LayerizeDocumentLayersInnerVariant3()
        {
        }

    }
}