
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LayerizeFont
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("family")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Family { get; set; }

        /// <summary>
        /// Font URL added when served; never stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_px")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SizePx { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Weight { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizeFontStyleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.LayerizeFontStyle Style { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("horizontal_scale")]
        public double? HorizontalScale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeFont" /> class.
        /// </summary>
        /// <param name="family"></param>
        /// <param name="sizePx"></param>
        /// <param name="weight"></param>
        /// <param name="style"></param>
        /// <param name="fileUrl">
        /// Font URL added when served; never stored.
        /// </param>
        /// <param name="horizontalScale">
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeFont(
            string family,
            double sizePx,
            int weight,
            global::Ideogram.V2.LayerizeFontStyle style,
            string? fileUrl,
            double? horizontalScale)
        {
            this.Family = family ?? throw new global::System.ArgumentNullException(nameof(family));
            this.FileUrl = fileUrl;
            this.SizePx = sizePx;
            this.Weight = weight;
            this.Style = style;
            this.HorizontalScale = horizontalScale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeFont" /> class.
        /// </summary>
        public LayerizeFont()
        {
        }

    }
}