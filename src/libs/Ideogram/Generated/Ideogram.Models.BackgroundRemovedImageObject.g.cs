
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BackgroundRemovedImageObject
    {
        /// <summary>
        /// Direct link to the foreground PNG. Empty when the output fails safety checks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Whether the foreground image passed safety checks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_image_safe")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsImageSafe { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundRemovedImageObject" /> class.
        /// </summary>
        /// <param name="isImageSafe">
        /// Whether the foreground image passed safety checks.
        /// </param>
        /// <param name="url">
        /// Direct link to the foreground PNG. Empty when the output fails safety checks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundRemovedImageObject(
            bool isImageSafe,
            string? url)
        {
            this.Url = url;
            this.IsImageSafe = isImageSafe;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundRemovedImageObject" /> class.
        /// </summary>
        public BackgroundRemovedImageObject()
        {
        }

    }
}