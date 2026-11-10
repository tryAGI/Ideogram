
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// LayerizeTextEnvelope variant
    /// </summary>
    public sealed partial class LayerizeTextLayerShapeVariant3
    {
        /// <summary>
        /// Discriminator value: envelope
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizeTextLayerShapeVariant3TypeJsonConverter))]
        public global::Ideogram.V2.LayerizeTextLayerShapeVariant3Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizePoint> Top { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizePoint> Bottom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeTextLayerShapeVariant3" /> class.
        /// </summary>
        /// <param name="top"></param>
        /// <param name="bottom"></param>
        /// <param name="type">
        /// Discriminator value: envelope
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeTextLayerShapeVariant3(
            global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizePoint> top,
            global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizePoint> bottom,
            global::Ideogram.V2.LayerizeTextLayerShapeVariant3Type type)
        {
            this.Type = type;
            this.Top = top ?? throw new global::System.ArgumentNullException(nameof(top));
            this.Bottom = bottom ?? throw new global::System.ArgumentNullException(nameof(bottom));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeTextLayerShapeVariant3" /> class.
        /// </summary>
        public LayerizeTextLayerShapeVariant3()
        {
        }

    }
}