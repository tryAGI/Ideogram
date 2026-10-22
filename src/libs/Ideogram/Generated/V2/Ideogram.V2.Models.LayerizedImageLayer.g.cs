
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// One transparent image layer of a layerized design, placed at its<br/>
    /// position on the design's canvas.
    /// </summary>
    public sealed partial class LayerizedImageLayer
    {
        /// <summary>
        /// Signed link to the layer as a transparent PNG, cropped to its visible pixels. Links are available for a limited period of time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Left edge of the layer on the design's canvas, in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X { get; set; }

        /// <summary>
        /// Top edge of the layer on the design's canvas, in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Y { get; set; }

        /// <summary>
        /// Width of the layer, in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// Height of the layer, in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizedImageLayer" /> class.
        /// </summary>
        /// <param name="url">
        /// Signed link to the layer as a transparent PNG, cropped to its visible pixels. Links are available for a limited period of time.
        /// </param>
        /// <param name="x">
        /// Left edge of the layer on the design's canvas, in pixels.
        /// </param>
        /// <param name="y">
        /// Top edge of the layer on the design's canvas, in pixels.
        /// </param>
        /// <param name="width">
        /// Width of the layer, in pixels.
        /// </param>
        /// <param name="height">
        /// Height of the layer, in pixels.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizedImageLayer(
            string url,
            int x,
            int y,
            int width,
            int height)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizedImageLayer" /> class.
        /// </summary>
        public LayerizedImageLayer()
        {
        }

    }
}