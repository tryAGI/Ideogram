
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Optional style description supplied alongside a V4 JSON prompt.
    /// </summary>
    public sealed partial class V4StyleDescription
    {
        /// <summary>
        /// Aesthetic notes (mood, vibe, references).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aesthetics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Aesthetics { get; set; }

        /// <summary>
        /// Optional art-style hint (e.g., illustration, oil painting).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("art_style")]
        public string? ArtStyle { get; set; }

        /// <summary>
        /// Lighting description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lighting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lighting { get; set; }

        /// <summary>
        /// Medium description (e.g., photograph, digital art).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Medium { get; set; }

        /// <summary>
        /// Optional photographic style notes (e.g., lens, film stock).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photo")]
        public string? Photo { get; set; }

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
        /// <param name="lighting">
        /// Lighting description.
        /// </param>
        /// <param name="medium">
        /// Medium description (e.g., photograph, digital art).
        /// </param>
        /// <param name="artStyle">
        /// Optional art-style hint (e.g., illustration, oil painting).
        /// </param>
        /// <param name="photo">
        /// Optional photographic style notes (e.g., lens, film stock).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V4StyleDescription(
            string aesthetics,
            string lighting,
            string medium,
            string? artStyle,
            string? photo)
        {
            this.Aesthetics = aesthetics ?? throw new global::System.ArgumentNullException(nameof(aesthetics));
            this.ArtStyle = artStyle;
            this.Lighting = lighting ?? throw new global::System.ArgumentNullException(nameof(lighting));
            this.Medium = medium ?? throw new global::System.ArgumentNullException(nameof(medium));
            this.Photo = photo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V4StyleDescription" /> class.
        /// </summary>
        public V4StyleDescription()
        {
        }

    }
}