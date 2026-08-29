
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A single generated video returned by the generation polling endpoint.<br/>
    /// Example: {"duration":5,"aspect_ratio":969,"object_type":"video.generation","prompt":"prompt","resolution":"720p","url":"https://ideogram.ai/assets/video/lossless/response/xtdZiqPwRxqY1Y7NExFmzB.mp4?exp=1743867804\u0026sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89"}
    /// </summary>
    public sealed partial class VideoObject
    {
        /// <summary>
        /// Discriminator marking this entry as a generated video in the polling endpoint's mixed data array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.VideoObjectObjectTypeJsonConverter))]
        public global::Ideogram.VideoObjectObjectType? ObjectType { get; set; }

        /// <summary>
        /// The direct link to the generated video.<br/>
        /// Example: https://ideogram.ai/assets/video/lossless/response/xtdZiqPwRxqY1Y7NExFmzB.mp4?exp=1743867804&amp;sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89
        /// </summary>
        /// <example>https://ideogram.ai/assets/video/lossless/response/xtdZiqPwRxqY1Y7NExFmzB.mp4?exp=1743867804&amp;sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The prompt used for the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The resolution tier of the generated video.<br/>
        /// Example: 720p
        /// </summary>
        /// <example>720p</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resolution { get; set; }

        /// <summary>
        /// The actual aspect ratio of the produced video, formatted as "{width}:{height}".<br/>
        /// Example: 969
        /// </summary>
        /// <example>969</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AspectRatio { get; set; }

        /// <summary>
        /// The actual measured length of the produced video in seconds.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoObject" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt used for the generation.
        /// </param>
        /// <param name="resolution">
        /// The resolution tier of the generated video.<br/>
        /// Example: 720p
        /// </param>
        /// <param name="aspectRatio">
        /// The actual aspect ratio of the produced video, formatted as "{width}:{height}".<br/>
        /// Example: 969
        /// </param>
        /// <param name="duration">
        /// The actual measured length of the produced video in seconds.<br/>
        /// Example: 5
        /// </param>
        /// <param name="objectType">
        /// Discriminator marking this entry as a generated video in the polling endpoint's mixed data array.
        /// </param>
        /// <param name="url">
        /// The direct link to the generated video.<br/>
        /// Example: https://ideogram.ai/assets/video/lossless/response/xtdZiqPwRxqY1Y7NExFmzB.mp4?exp=1743867804&amp;sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoObject(
            string prompt,
            string resolution,
            string aspectRatio,
            int duration,
            global::Ideogram.VideoObjectObjectType? objectType,
            string? url)
        {
            this.ObjectType = objectType;
            this.Url = url;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Resolution = resolution ?? throw new global::System.ArgumentNullException(nameof(resolution));
            this.AspectRatio = aspectRatio ?? throw new global::System.ArgumentNullException(nameof(aspectRatio));
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoObject" /> class.
        /// </summary>
        public VideoObject()
        {
        }

    }
}