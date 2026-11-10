
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LayerizeContainerStyle
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_color")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("border_radius_px")]
        public double? BorderRadiusPx { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("border")]
        public global::System.Collections.Generic.Dictionary<string, global::Ideogram.V2.LayerizeBorderSide>? Border { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("box_shadow")]
        public global::Ideogram.V2.LayerizeShadow? BoxShadow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeContainerStyle" /> class.
        /// </summary>
        /// <param name="backgroundColor"></param>
        /// <param name="opacity"></param>
        /// <param name="borderRadiusPx"></param>
        /// <param name="border"></param>
        /// <param name="boxShadow"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeContainerStyle(
            string? backgroundColor,
            double? opacity,
            double? borderRadiusPx,
            global::System.Collections.Generic.Dictionary<string, global::Ideogram.V2.LayerizeBorderSide>? border,
            global::Ideogram.V2.LayerizeShadow? boxShadow)
        {
            this.BackgroundColor = backgroundColor;
            this.Opacity = opacity;
            this.BorderRadiusPx = borderRadiusPx;
            this.Border = border;
            this.BoxShadow = boxShadow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeContainerStyle" /> class.
        /// </summary>
        public LayerizeContainerStyle()
        {
        }

    }
}