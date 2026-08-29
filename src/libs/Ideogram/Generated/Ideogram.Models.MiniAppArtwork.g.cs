
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Artwork URLs used to present a mini-app in the app catalog.
    /// </summary>
    public sealed partial class MiniAppArtwork
    {
        /// <summary>
        /// Square mini-app icon URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Cover image or video URL used when no card artwork is available. Video URL paths must end in .mp4 or .webm.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover")]
        public string? Cover { get; set; }

        /// <summary>
        /// Preferred app catalog image or video thumbnail URL. Video URL paths must end in .mp4 or .webm.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("card")]
        public string? Card { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MiniAppArtwork" /> class.
        /// </summary>
        /// <param name="icon">
        /// Square mini-app icon URL.
        /// </param>
        /// <param name="cover">
        /// Cover image or video URL used when no card artwork is available. Video URL paths must end in .mp4 or .webm.
        /// </param>
        /// <param name="card">
        /// Preferred app catalog image or video thumbnail URL. Video URL paths must end in .mp4 or .webm.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MiniAppArtwork(
            string? icon,
            string? cover,
            string? card)
        {
            this.Icon = icon;
            this.Cover = cover;
            this.Card = card;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MiniAppArtwork" /> class.
        /// </summary>
        public MiniAppArtwork()
        {
        }

    }
}