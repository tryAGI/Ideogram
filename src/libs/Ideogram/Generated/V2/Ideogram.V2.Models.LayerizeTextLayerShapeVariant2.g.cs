
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// LayerizeTextPath variant
    /// </summary>
    public sealed partial class LayerizeTextLayerShapeVariant2
    {
        /// <summary>
        /// Discriminator value: path
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizeTextLayerShapeVariant2TypeJsonConverter))]
        public global::Ideogram.V2.LayerizeTextLayerShapeVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizePoint> Points { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lean")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Lean { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeTextLayerShapeVariant2" /> class.
        /// </summary>
        /// <param name="points"></param>
        /// <param name="lean"></param>
        /// <param name="type">
        /// Discriminator value: path
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeTextLayerShapeVariant2(
            global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizePoint> points,
            double lean,
            global::Ideogram.V2.LayerizeTextLayerShapeVariant2Type type)
        {
            this.Type = type;
            this.Points = points ?? throw new global::System.ArgumentNullException(nameof(points));
            this.Lean = lean;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeTextLayerShapeVariant2" /> class.
        /// </summary>
        public LayerizeTextLayerShapeVariant2()
        {
        }

    }
}