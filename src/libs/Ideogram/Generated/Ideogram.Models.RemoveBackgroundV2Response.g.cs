
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Synchronous requests include exactly one foreground image in `data`.<br/>
    /// Async requests omit `data`; poll with `generation_id` for completion.<br/>
    /// A slow synchronous failure that occurs after heartbeat streaming starts<br/>
    /// contains `error` and `status_code` instead of `generation_id`.<br/>
    /// Example: {"generation_id":"zm6IqQd4RPGnwA8gQYEL5Q","data":[{"url":"https://ideogram.ai/assets/foreground.png","is_image_safe":true}]}
    /// </summary>
    public sealed partial class RemoveBackgroundV2Response
    {
        /// <summary>
        /// URL-safe base64 ID accepted by the generation polling endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// The single foreground image. Present only for synchronous requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Ideogram.BackgroundRemovedImageObject>? Data { get; set; }

        /// <summary>
        /// Error message for a failure after heartbeat streaming starts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// HTTP status that would have been returned before streaming began.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveBackgroundV2Response" /> class.
        /// </summary>
        /// <param name="generationId">
        /// URL-safe base64 ID accepted by the generation polling endpoint.
        /// </param>
        /// <param name="data">
        /// The single foreground image. Present only for synchronous requests.
        /// </param>
        /// <param name="error">
        /// Error message for a failure after heartbeat streaming starts.
        /// </param>
        /// <param name="statusCode">
        /// HTTP status that would have been returned before streaming began.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveBackgroundV2Response(
            string? generationId,
            global::System.Collections.Generic.IList<global::Ideogram.BackgroundRemovedImageObject>? data,
            string? error,
            int? statusCode)
        {
            this.GenerationId = generationId;
            this.Data = data;
            this.Error = error;
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveBackgroundV2Response" /> class.
        /// </summary>
        public RemoveBackgroundV2Response()
        {
        }

    }
}