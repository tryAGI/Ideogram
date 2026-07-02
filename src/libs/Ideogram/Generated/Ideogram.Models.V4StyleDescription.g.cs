
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Optional style description supplied alongside a V4 JSON prompt.<br/>
    /// Example: {"photo":"photo","art_style":"art_style","medium":"medium","aesthetics":"aesthetics","lighting":"lighting","color_palette":["#FFD700","#FFD700"]}
    /// </summary>
    public sealed partial class V4StyleDescription
    {
        /// <summary>
        /// Aesthetic notes (mood, vibe, references).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aesthetics")]
        public string? Aesthetics { get; set; }

        /// <summary>
        /// Optional art-style hint (e.g., illustration, oil painting).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("art_style")]
        public string? ArtStyle { get; set; }

        /// <summary>
        /// Lighting description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lighting")]
        public string? Lighting { get; set; }

        /// <summary>
        /// Medium description (e.g., photograph, digital art).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium")]
        public string? Medium { get; set; }

        /// <summary>
        /// Optional photographic style notes (e.g., lens, film stock).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photo")]
        public string? Photo { get; set; }

        /// <summary>
        /// Optional list of hex color strings (e.g. "#FFD700") that bias the<br/>
        /// Ideogram 4.0 output toward this palette. Applied as a soft color bias,<br/>
        /// not an exact per-pixel lock.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_palette")]
        public global::System.Collections.Generic.IList<string>? ColorPalette { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V4StyleDescription" /> class.
        /// </summary>
        /// <param name="aesthetics">
        /// Aesthetic notes (mood, vibe, references).
        /// </param>
        /// <param name="artStyle">
        /// Optional art-style hint (e.g., illustration, oil painting).
        /// </param>
        /// <param name="lighting">
        /// Lighting description.
        /// </param>
        /// <param name="medium">
        /// Medium description (e.g., photograph, digital art).
        /// </param>
        /// <param name="photo">
        /// Optional photographic style notes (e.g., lens, film stock).
        /// </param>
        /// <param name="colorPalette">
        /// Optional list of hex color strings (e.g. "#FFD700") that bias the<br/>
        /// Ideogram 4.0 output toward this palette. Applied as a soft color bias,<br/>
        /// not an exact per-pixel lock.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V4StyleDescription(
            string? aesthetics,
            string? artStyle,
            string? lighting,
            string? medium,
            string? photo,
            global::System.Collections.Generic.IList<string>? colorPalette)
        {
            this.Aesthetics = aesthetics;
            this.ArtStyle = artStyle;
            this.Lighting = lighting;
            this.Medium = medium;
            this.Photo = photo;
            this.ColorPalette = colorPalette;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V4StyleDescription" /> class.
        /// </summary>
        public V4StyleDescription()
        {
        }

    }
}