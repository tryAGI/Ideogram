
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Acknowledgement returned by the Seedance 2.0 video endpoints. The request<br/>
    /// is accepted for asynchronous processing, so `data` is always empty in this<br/>
    /// response; the generated video is retrieved by polling<br/>
    /// `/v1/generations/{generation_id}` or delivered to `webhook_url`.<br/>
    /// Example: {"data":[{"duration":5,"aspect_ratio":969,"object_type":"video.generation","prompt":"prompt","resolution":"720p","url":"https://ideogram.ai/assets/video/lossless/response/xtdZiqPwRxqY1Y7NExFmzB.mp4?exp=1743867804\u0026sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89"},{"duration":5,"aspect_ratio":969,"object_type":"video.generation","prompt":"prompt","resolution":"720p","url":"https://ideogram.ai/assets/video/lossless/response/xtdZiqPwRxqY1Y7NExFmzB.mp4?exp=1743867804\u0026sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89"}],"generation_id":"generation_id","created":"2000-01-23T04:56:07\u002B00:00"}
    /// </summary>
    public sealed partial class VideoGenerationResponse
    {
        /// <summary>
        /// URL-safe base64 ID of the accepted generation. Poll<br/>
        /// `/v1/generations/{generation_id}` with this id to retrieve the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// The time the request was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// Always empty for this asynchronous acknowledgement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.VideoObject> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationResponse" /> class.
        /// </summary>
        /// <param name="generationId">
        /// URL-safe base64 ID of the accepted generation. Poll<br/>
        /// `/v1/generations/{generation_id}` with this id to retrieve the result.
        /// </param>
        /// <param name="created">
        /// The time the request was created.
        /// </param>
        /// <param name="data">
        /// Always empty for this asynchronous acknowledgement.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoGenerationResponse(
            string generationId,
            global::System.DateTime created,
            global::System.Collections.Generic.IList<global::Ideogram.VideoObject> data)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Created = created;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationResponse" /> class.
        /// </summary>
        public VideoGenerationResponse()
        {
        }

    }
}