
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// A box in the checked image's own pixels.
    /// </summary>
    public sealed partial class ImageJudgmentBox
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x0")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X0 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y0")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Y0 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x1")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X1 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y1")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Y1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageJudgmentBox" /> class.
        /// </summary>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageJudgmentBox(
            int x0,
            int y0,
            int x1,
            int y1)
        {
            this.X0 = x0;
            this.Y0 = y0;
            this.X1 = x1;
            this.Y1 = y1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageJudgmentBox" /> class.
        /// </summary>
        public ImageJudgmentBox()
        {
        }

    }
}