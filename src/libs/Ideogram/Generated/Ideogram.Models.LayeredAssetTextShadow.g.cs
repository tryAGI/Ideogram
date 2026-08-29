
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Single CSS shadow for V4 vector text. Used by text_shadows and box_shadow. offset_x, offset_y, and blur are in px.<br/>
    /// Example: {"color":"color","blur":0.2027123,"offset_x":9.301444,"offset_y":3.6160767}
    /// </summary>
    public sealed partial class LayeredAssetTextShadow
    {
        /// <summary>
        /// Shadow hex color. Accepts both 6-hex (#RRGGBB) and 8-hex<br/>
        /// (#RRGGBBAA) — the layered-design extractor emits alpha-included<br/>
        /// colors for semi-transparent shadows, and stripping alpha would<br/>
        /// lose real visual information. Aligned with the other text-layer<br/>
        /// color fields (stroke/border/gradient) which already accept 6,8.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Color { get; set; }

        /// <summary>
        /// Horizontal shadow offset in px.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset_x")]
        public float? OffsetX { get; set; }

        /// <summary>
        /// Vertical shadow offset in px.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset_y")]
        public float? OffsetY { get; set; }

        /// <summary>
        /// Shadow blur radius in px.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blur")]
        public float? Blur { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayeredAssetTextShadow" /> class.
        /// </summary>
        /// <param name="color">
        /// Shadow hex color. Accepts both 6-hex (#RRGGBB) and 8-hex<br/>
        /// (#RRGGBBAA) — the layered-design extractor emits alpha-included<br/>
        /// colors for semi-transparent shadows, and stripping alpha would<br/>
        /// lose real visual information. Aligned with the other text-layer<br/>
        /// color fields (stroke/border/gradient) which already accept 6,8.
        /// </param>
        /// <param name="offsetX">
        /// Horizontal shadow offset in px.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="offsetY">
        /// Vertical shadow offset in px.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="blur">
        /// Shadow blur radius in px.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayeredAssetTextShadow(
            string color,
            float? offsetX,
            float? offsetY,
            float? blur)
        {
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
            this.OffsetX = offsetX;
            this.OffsetY = offsetY;
            this.Blur = blur;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayeredAssetTextShadow" /> class.
        /// </summary>
        public LayeredAssetTextShadow()
        {
        }

    }
}