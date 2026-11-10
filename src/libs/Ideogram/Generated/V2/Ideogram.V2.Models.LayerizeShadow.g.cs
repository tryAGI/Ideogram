
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LayerizeShadow
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset_x_px")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OffsetXPx { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset_y_px")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OffsetYPx { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blur_px")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BlurPx { get; set; }

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
        /// Initializes a new instance of the <see cref="LayerizeShadow" /> class.
        /// </summary>
        /// <param name="offsetXPx"></param>
        /// <param name="offsetYPx"></param>
        /// <param name="blurPx"></param>
        /// <param name="color"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeShadow(
            double offsetXPx,
            double offsetYPx,
            double blurPx,
            string color)
        {
            this.OffsetXPx = offsetXPx;
            this.OffsetYPx = offsetYPx;
            this.BlurPx = blurPx;
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeShadow" /> class.
        /// </summary>
        public LayerizeShadow()
        {
        }

    }
}