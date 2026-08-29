
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Request body for the Seedance 2.0 text-to-video endpoint.<br/>
    /// Example: {"duration":5,"aspect_ratio":null,"num_videos":1,"generate_audio":false,"prompt":"A red fox running through a snowy forest at dawn.","resolution":null}
    /// </summary>
    public sealed partial class TextToVideoRequestSeedDance2
    {
        /// <summary>
        /// A natural-language prompt describing the video to generate.<br/>
        /// Example: A red fox running through a snowy forest at dawn.
        /// </summary>
        /// <example>A red fox running through a snowy forest at dawn.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The aspect ratio of the generated video. `AUTO` lets the model choose the<br/>
        /// most suitable ratio from the prompt; any other value pins the ratio.<br/>
        /// Default Value: AUTO
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.SeedDance2AspectRatioJsonConverter))]
        public global::Ideogram.SeedDance2AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The resolution tier of the generated video.<br/>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.SeedDance2ResolutionJsonConverter))]
        public global::Ideogram.SeedDance2Resolution? Resolution { get; set; }

        /// <summary>
        /// The length of the generated video in seconds. When omitted, the model<br/>
        /// picks the best duration for the prompt ("auto").<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// How many videos to generate for this request. Each video is generated<br/>
        /// and billed independently.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_videos")]
        public int? NumVideos { get; set; }

        /// <summary>
        /// Whether to generate an audio track for the video. Audio roughly<br/>
        /// doubles the provider cost and is subject to stricter output moderation.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_audio")]
        public bool? GenerateAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToVideoRequestSeedDance2" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A natural-language prompt describing the video to generate.<br/>
        /// Example: A red fox running through a snowy forest at dawn.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generated video. `AUTO` lets the model choose the<br/>
        /// most suitable ratio from the prompt; any other value pins the ratio.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="resolution">
        /// The resolution tier of the generated video.<br/>
        /// Default Value: 720p
        /// </param>
        /// <param name="duration">
        /// The length of the generated video in seconds. When omitted, the model<br/>
        /// picks the best duration for the prompt ("auto").<br/>
        /// Example: 5
        /// </param>
        /// <param name="numVideos">
        /// How many videos to generate for this request. Each video is generated<br/>
        /// and billed independently.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="generateAudio">
        /// Whether to generate an audio track for the video. Audio roughly<br/>
        /// doubles the provider cost and is subject to stricter output moderation.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToVideoRequestSeedDance2(
            string prompt,
            global::Ideogram.SeedDance2AspectRatio? aspectRatio,
            global::Ideogram.SeedDance2Resolution? resolution,
            int? duration,
            int? numVideos,
            bool? generateAudio)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Duration = duration;
            this.NumVideos = numVideos;
            this.GenerateAudio = generateAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToVideoRequestSeedDance2" /> class.
        /// </summary>
        public TextToVideoRequestSeedDance2()
        {
        }

    }
}