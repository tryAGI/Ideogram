
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageGenerationObjectV3
    {
        /// <summary>
        /// The direct link to the image generated.<br/>
        /// Example: https://ideogram.ai/api/images/ephemeral/xtdZiqPwRxqY1Y7NExFmzB.png?exp=1743867804&amp;sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89
        /// </summary>
        /// <example>https://ideogram.ai/api/images/ephemeral/xtdZiqPwRxqY1Y7NExFmzB.png?exp=1743867804&amp;sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The prompt used for the generation. This may be different from the original prompt.<br/>
        /// Example: A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there's an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.
        /// </summary>
        /// <example>A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there's an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The resolutions supported for model version V_3.<br/>
        /// Example: 1280x800
        /// </summary>
        /// <example>1280x800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ResolutionV3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.ResolutionV3 Resolution { get; set; }

        /// <summary>
        /// Whether this request passes safety checks. If false, the url field will be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_image_safe")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsImageSafe { get; set; }

        /// <summary>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seed { get; set; }

        /// <summary>
        /// The style type to generate with.<br/>
        /// Example: GENERAL
        /// </summary>
        /// <example>GENERAL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.StyleTypeV3JsonConverter))]
        public global::Ideogram.StyleTypeV3? StyleType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationObjectV3" /> class.
        /// </summary>
        /// <param name="url">
        /// The direct link to the image generated.<br/>
        /// Example: https://ideogram.ai/api/images/ephemeral/xtdZiqPwRxqY1Y7NExFmzB.png?exp=1743867804&amp;sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89
        /// </param>
        /// <param name="prompt">
        /// The prompt used for the generation. This may be different from the original prompt.<br/>
        /// Example: A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there's an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for model version V_3.<br/>
        /// Example: 1280x800
        /// </param>
        /// <param name="isImageSafe">
        /// Whether this request passes safety checks. If false, the url field will be empty.
        /// </param>
        /// <param name="seed">
        /// Example: 12345
        /// </param>
        /// <param name="styleType">
        /// The style type to generate with.<br/>
        /// Example: GENERAL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationObjectV3(
            string prompt,
            global::Ideogram.ResolutionV3 resolution,
            bool isImageSafe,
            int seed,
            string? url,
            global::Ideogram.StyleTypeV3? styleType)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Resolution = resolution;
            this.IsImageSafe = isImageSafe;
            this.Seed = seed;
            this.Url = url;
            this.StyleType = styleType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationObjectV3" /> class.
        /// </summary>
        public ImageGenerationObjectV3()
        {
        }
    }
}