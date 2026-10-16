
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A single generated video returned by the generation polling endpoint.
    /// </summary>
    public sealed partial class GenerationResponseDataInnerVariant4
    {
        /// <summary>
        /// Discriminator value: video.generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerVariant4ObjectTypeJsonConverter))]
        public global::Ideogram.GenerationResponseDataInnerVariant4ObjectType ObjectType { get; set; }

        /// <summary>
        /// The generated video's asset ID. Use it with asset_type RESPONSE in video_asset_identifier for a follow-up video edit. This is distinct from the generation ID used for polling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// The direct link to the generated video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The prompt used for the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The resolution tier of the generated video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resolution { get; set; }

        /// <summary>
        /// The actual aspect ratio of the produced video, formatted as "{width}:{height}".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AspectRatio { get; set; }

        /// <summary>
        /// The actual measured length of the produced video in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponseDataInnerVariant4" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt used for the generation.
        /// </param>
        /// <param name="resolution">
        /// The resolution tier of the generated video.
        /// </param>
        /// <param name="aspectRatio">
        /// The actual aspect ratio of the produced video, formatted as "{width}:{height}".
        /// </param>
        /// <param name="duration">
        /// The actual measured length of the produced video in seconds.
        /// </param>
        /// <param name="objectType">
        /// Discriminator value: video.generation
        /// </param>
        /// <param name="assetId">
        /// The generated video's asset ID. Use it with asset_type RESPONSE in video_asset_identifier for a follow-up video edit. This is distinct from the generation ID used for polling.
        /// </param>
        /// <param name="url">
        /// The direct link to the generated video.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationResponseDataInnerVariant4(
            string prompt,
            string resolution,
            string aspectRatio,
            int duration,
            global::Ideogram.GenerationResponseDataInnerVariant4ObjectType objectType,
            string? assetId,
            string? url)
        {
            this.ObjectType = objectType;
            this.AssetId = assetId;
            this.Url = url;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Resolution = resolution ?? throw new global::System.ArgumentNullException(nameof(resolution));
            this.AspectRatio = aspectRatio ?? throw new global::System.ArgumentNullException(nameof(aspectRatio));
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponseDataInnerVariant4" /> class.
        /// </summary>
        public GenerationResponseDataInnerVariant4()
        {
        }

    }
}