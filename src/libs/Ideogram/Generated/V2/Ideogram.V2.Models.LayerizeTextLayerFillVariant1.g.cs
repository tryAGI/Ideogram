
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// LayerizeSolidFill variant
    /// </summary>
    public sealed partial class LayerizeTextLayerFillVariant1
    {
        /// <summary>
        /// Discriminator value: solid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizeTextLayerFillVariant1TypeJsonConverter))]
        public global::Ideogram.V2.LayerizeTextLayerFillVariant1Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeTextLayerFillVariant1" /> class.
        /// </summary>
        /// <param name="color"></param>
        /// <param name="type">
        /// Discriminator value: solid
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeTextLayerFillVariant1(
            string color,
            global::Ideogram.V2.LayerizeTextLayerFillVariant1Type type)
        {
            this.Type = type;
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeTextLayerFillVariant1" /> class.
        /// </summary>
        public LayerizeTextLayerFillVariant1()
        {
        }

    }
}