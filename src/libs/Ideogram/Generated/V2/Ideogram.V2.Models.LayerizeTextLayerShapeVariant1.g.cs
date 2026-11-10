
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// LayerizeTextArc variant
    /// </summary>
    public sealed partial class LayerizeTextLayerShapeVariant1
    {
        /// <summary>
        /// Discriminator value: arc
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizeTextLayerShapeVariant1TypeJsonConverter))]
        public global::Ideogram.V2.LayerizeTextLayerShapeVariant1Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("center_x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CenterX { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("center_y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CenterY { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("radius")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Radius { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middle_angle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MiddleAngle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inward")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Inward { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeTextLayerShapeVariant1" /> class.
        /// </summary>
        /// <param name="centerX"></param>
        /// <param name="centerY"></param>
        /// <param name="radius"></param>
        /// <param name="middleAngle"></param>
        /// <param name="inward"></param>
        /// <param name="type">
        /// Discriminator value: arc
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeTextLayerShapeVariant1(
            double centerX,
            double centerY,
            double radius,
            double middleAngle,
            bool inward,
            global::Ideogram.V2.LayerizeTextLayerShapeVariant1Type type)
        {
            this.Type = type;
            this.CenterX = centerX;
            this.CenterY = centerY;
            this.Radius = radius;
            this.MiddleAngle = middleAngle;
            this.Inward = inward;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeTextLayerShapeVariant1" /> class.
        /// </summary>
        public LayerizeTextLayerShapeVariant1()
        {
        }

    }
}