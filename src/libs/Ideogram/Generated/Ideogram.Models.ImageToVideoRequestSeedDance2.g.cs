
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Request body for the Seedance 2.0 image-to-video endpoint. Provide the<br/>
    /// first frame with exactly one of `image` or `image_asset_id`.
    /// </summary>
    public sealed partial class ImageToVideoRequestSeedDance2
    {
        /// <summary>
        /// The first-frame image binary (max 25MB); only JPEG, WebP and PNG<br/>
        /// formats are supported. Provide this or `image_asset_id`, not both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The first-frame image binary (max 25MB); only JPEG, WebP and PNG<br/>
        /// formats are supported. Provide this or `image_asset_id`, not both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// A reference to an existing Ideogram asset you own to use as the first<br/>
        /// frame, in place of uploading `image`. Only image assets (an uploaded<br/>
        /// image or a generated image) are accepted. Provide this or `image`,<br/>
        /// not both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_id")]
        public global::Ideogram.AssetIdentifier? ImageAssetId { get; set; }

        /// <summary>
        /// A natural-language prompt describing how the first frame should animate.<br/>
        /// Example: The camera slowly pans right as the waves roll in.
        /// </summary>
        /// <example>The camera slowly pans right as the waves roll in.</example>
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
        /// Initializes a new instance of the <see cref="ImageToVideoRequestSeedDance2" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A natural-language prompt describing how the first frame should animate.<br/>
        /// Example: The camera slowly pans right as the waves roll in.
        /// </param>
        /// <param name="image">
        /// The first-frame image binary (max 25MB); only JPEG, WebP and PNG<br/>
        /// formats are supported. Provide this or `image_asset_id`, not both.
        /// </param>
        /// <param name="imagename">
        /// The first-frame image binary (max 25MB); only JPEG, WebP and PNG<br/>
        /// formats are supported. Provide this or `image_asset_id`, not both.
        /// </param>
        /// <param name="imageAssetId">
        /// A reference to an existing Ideogram asset you own to use as the first<br/>
        /// frame, in place of uploading `image`. Only image assets (an uploaded<br/>
        /// image or a generated image) are accepted. Provide this or `image`,<br/>
        /// not both.
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
        public ImageToVideoRequestSeedDance2(
            string prompt,
            byte[]? image,
            string? imagename,
            global::Ideogram.AssetIdentifier? imageAssetId,
            global::Ideogram.SeedDance2AspectRatio? aspectRatio,
            global::Ideogram.SeedDance2Resolution? resolution,
            int? duration,
            int? numVideos,
            bool? generateAudio)
        {
            this.Image = image;
            this.Imagename = imagename;
            this.ImageAssetId = imageAssetId;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Duration = duration;
            this.NumVideos = numVideos;
            this.GenerateAudio = generateAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToVideoRequestSeedDance2" /> class.
        /// </summary>
        public ImageToVideoRequestSeedDance2()
        {
        }

    }
}