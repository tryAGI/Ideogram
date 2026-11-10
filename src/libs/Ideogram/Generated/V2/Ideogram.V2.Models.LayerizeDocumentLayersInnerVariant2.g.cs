
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// LayerizeTextLayer variant
    /// </summary>
    public sealed partial class LayerizeDocumentLayersInnerVariant2
    {
        /// <summary>
        /// Discriminator value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizeDocumentLayersInnerVariant2TypeJsonConverter))]
        public global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2Type Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        public global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizeTextSpan>? Spans { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.LayerizeFont Font { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.LayerizeTextLayout Layout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shape")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizeTextLayerShapeJsonConverter))]
        public global::Ideogram.V2.LayerizeTextLayerShape? Shape { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fill")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizeTextLayerFillJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.LayerizeTextLayerFill Fill { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strokes")]
        public global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizeStroke>? Strokes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadows")]
        public global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizeShadow>? Shadows { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blend_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendModeJsonConverter))]
        public global::Ideogram.V2.LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode? BlendMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeDocumentLayersInnerVariant2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="box"></param>
        /// <param name="text"></param>
        /// <param name="font"></param>
        /// <param name="layout"></param>
        /// <param name="fill"></param>
        /// <param name="type">
        /// Discriminator value: text
        /// </param>
        /// <param name="rotation"></param>
        /// <param name="spans"></param>
        /// <param name="shape"></param>
        /// <param name="strokes"></param>
        /// <param name="shadows"></param>
        /// <param name="opacity"></param>
        /// <param name="blendMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeDocumentLayersInnerVariant2(
            string id,
            global::Ideogram.V2.LayerizeBox box,
            string text,
            global::Ideogram.V2.LayerizeFont font,
            global::Ideogram.V2.LayerizeTextLayout layout,
            global::Ideogram.V2.LayerizeTextLayerFill fill,
            global::Ideogram.V2.LayerizeDocumentLayersInnerVariant2Type type,
            double? rotation,
            global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizeTextSpan>? spans,
            global::Ideogram.V2.LayerizeTextLayerShape? shape,
            global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizeStroke>? strokes,
            global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizeShadow>? shadows,
            double? opacity,
            global::Ideogram.V2.LayerizeDocumentLayersInnerDiscriminatorMappingTextBlendMode? blendMode)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Box = box ?? throw new global::System.ArgumentNullException(nameof(box));
            this.Rotation = rotation;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Spans = spans;
            this.Font = font ?? throw new global::System.ArgumentNullException(nameof(font));
            this.Layout = layout ?? throw new global::System.ArgumentNullException(nameof(layout));
            this.Shape = shape;
            this.Fill = fill;
            this.Strokes = strokes;
            this.Shadows = shadows;
            this.Opacity = opacity;
            this.BlendMode = blendMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeDocumentLayersInnerVariant2" /> class.
        /// </summary>
        public LayerizeDocumentLayersInnerVariant2()
        {
        }

    }
}