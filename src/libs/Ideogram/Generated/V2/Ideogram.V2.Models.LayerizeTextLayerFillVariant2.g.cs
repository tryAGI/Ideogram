
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// LayerizeGradientFill variant
    /// </summary>
    public sealed partial class LayerizeTextLayerFillVariant2
    {
        /// <summary>
        /// Discriminator value: gradient
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizeTextLayerFillVariant2TypeJsonConverter))]
        public global::Ideogram.V2.LayerizeTextLayerFillVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("angle_deg")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AngleDeg { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stops")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizeGradientStop> Stops { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeTextLayerFillVariant2" /> class.
        /// </summary>
        /// <param name="angleDeg"></param>
        /// <param name="stops"></param>
        /// <param name="type">
        /// Discriminator value: gradient
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeTextLayerFillVariant2(
            double angleDeg,
            global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizeGradientStop> stops,
            global::Ideogram.V2.LayerizeTextLayerFillVariant2Type type)
        {
            this.Type = type;
            this.AngleDeg = angleDeg;
            this.Stops = stops ?? throw new global::System.ArgumentNullException(nameof(stops));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeTextLayerFillVariant2" /> class.
        /// </summary>
        public LayerizeTextLayerFillVariant2()
        {
        }

    }
}