
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"seed":12345,"prompt":"prompt","resolution":"1280x800","url":"https://ideogram.ai/api/images/ephemeral/xtdZiqPwRxqY1Y7NExFmzB.png?exp=1743867804\u0026sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89","is_image_safe":true}
    /// </summary>
    public sealed partial class ImageGenerationObjectV4
    {
        /// <summary>
        /// The direct link to the image generated.<br/>
        /// Example: https://ideogram.ai/api/images/ephemeral/xtdZiqPwRxqY1Y7NExFmzB.png?exp=1743867804&amp;sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89
        /// </summary>
        /// <example>https://ideogram.ai/api/images/ephemeral/xtdZiqPwRxqY1Y7NExFmzB.png?exp=1743867804&amp;sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The prompt used for the generation. This may be different from the original prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The resolutions supported for Ideogram 4.0.<br/>
        /// Example: 1280x800
        /// </summary>
        /// <example>1280x800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ResolutionV4JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.ResolutionV4 Resolution { get; set; }

        /// <summary>
        /// Whether this request passes safety checks. If false, the url field will be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_image_safe")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsImageSafe { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationObjectV4" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt used for the generation. This may be different from the original prompt.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 4.0.<br/>
        /// Example: 1280x800
        /// </param>
        /// <param name="isImageSafe">
        /// Whether this request passes safety checks. If false, the url field will be empty.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="url">
        /// The direct link to the image generated.<br/>
        /// Example: https://ideogram.ai/api/images/ephemeral/xtdZiqPwRxqY1Y7NExFmzB.png?exp=1743867804&amp;sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationObjectV4(
            string prompt,
            global::Ideogram.ResolutionV4 resolution,
            bool isImageSafe,
            int seed,
            string? url)
        {
            this.Url = url;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Resolution = resolution;
            this.IsImageSafe = isImageSafe;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationObjectV4" /> class.
        /// </summary>
        public ImageGenerationObjectV4()
        {
        }
    }
}