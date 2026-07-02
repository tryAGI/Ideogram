
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveBackgroundImageObject
    {
        /// <summary>
        /// The direct link to the foreground image. Empty when the image fails safety checks.<br/>
        /// Example: https://ideogram.ai/api/images/ephemeral/xtdZiqPwRxqY1Y7NExFmzB.png?exp=1743867804&amp;sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89
        /// </summary>
        /// <example>https://ideogram.ai/api/images/ephemeral/xtdZiqPwRxqY1Y7NExFmzB.png?exp=1743867804&amp;sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Whether the foreground image passes safety checks. If false, the url field will be empty.
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
        /// Initializes a new instance of the <see cref="RemoveBackgroundImageObject" /> class.
        /// </summary>
        /// <param name="isImageSafe">
        /// Whether the foreground image passes safety checks. If false, the url field will be empty.
        /// </param>
        /// <param name="url">
        /// The direct link to the foreground image. Empty when the image fails safety checks.<br/>
        /// Example: https://ideogram.ai/api/images/ephemeral/xtdZiqPwRxqY1Y7NExFmzB.png?exp=1743867804&amp;sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveBackgroundImageObject(
            bool isImageSafe,
            string? url)
        {
            this.Url = url;
            this.IsImageSafe = isImageSafe;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveBackgroundImageObject" /> class.
        /// </summary>
        public RemoveBackgroundImageObject()
        {
        }

    }
}