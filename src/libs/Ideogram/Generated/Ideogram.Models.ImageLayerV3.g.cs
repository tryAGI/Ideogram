
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// An image layer (logo, brand asset, icon) for a layered image generation.<br/>
    /// Example: {"ref_id":"REF_0","x":7,"width":3,"y":9,"height":2}
    /// </summary>
    public sealed partial class ImageLayerV3
    {
        /// <summary>
        /// The x coordinate of the layer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X { get; set; }

        /// <summary>
        /// The y coordinate of the layer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Y { get; set; }

        /// <summary>
        /// The width of the layer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// The height of the layer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// Reference ID matching a provided reference image (e.g., "REF_0"), or -1 if no match.<br/>
        /// Example: REF_0
        /// </summary>
        /// <example>REF_0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref_id")]
        public string? RefId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageLayerV3" /> class.
        /// </summary>
        /// <param name="x">
        /// The x coordinate of the layer.
        /// </param>
        /// <param name="y">
        /// The y coordinate of the layer.
        /// </param>
        /// <param name="width">
        /// The width of the layer.
        /// </param>
        /// <param name="height">
        /// The height of the layer.
        /// </param>
        /// <param name="refId">
        /// Reference ID matching a provided reference image (e.g., "REF_0"), or -1 if no match.<br/>
        /// Example: REF_0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageLayerV3(
            int x,
            int y,
            int width,
            int height,
            string? refId)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.RefId = refId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageLayerV3" /> class.
        /// </summary>
        public ImageLayerV3()
        {
        }
    }
}