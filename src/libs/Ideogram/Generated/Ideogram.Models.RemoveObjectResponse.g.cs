
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The response containing the image with the masked object removed.<br/>
    /// Image links are available for a limited period of time; if you would like to keep the image, you must download it.<br/>
    /// Example: {"created":"2000-01-23T04:56:07\u002B00:00","data":[{"url":"https://ideogram.ai/api/images/ephemeral/xtdZiqPwRxqY1Y7NExFmzB.png?exp=1743867804\u0026sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89","is_image_safe":true}]}
    /// </summary>
    public sealed partial class RemoveObjectResponse
    {
        /// <summary>
        /// The time the request was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// A list containing the single edited image. The endpoint always returns exactly one entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.RemoveObjectImageObject> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveObjectResponse" /> class.
        /// </summary>
        /// <param name="created">
        /// The time the request was created.
        /// </param>
        /// <param name="data">
        /// A list containing the single edited image. The endpoint always returns exactly one entry.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveObjectResponse(
            global::System.DateTime created,
            global::System.Collections.Generic.IList<global::Ideogram.RemoveObjectImageObject> data)
        {
            this.Created = created;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveObjectResponse" /> class.
        /// </summary>
        public RemoveObjectResponse()
        {
        }

    }
}