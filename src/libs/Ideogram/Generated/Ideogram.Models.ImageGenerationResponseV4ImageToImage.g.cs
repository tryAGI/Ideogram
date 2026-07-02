
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The response which contains information about the generated image-to-image output, including the download link.<br/>
    /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.<br/>
    /// Example: {"data":[{"seed":12345,"prompt":"prompt","resolution":"1024x1024","url":"https://ideogram.ai/api/images/ephemeral/xtdZiqPwRxqY1Y7NExFmzB.png?exp=1743867804\u0026sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89","is_image_safe":true},{"seed":12345,"prompt":"prompt","resolution":"1024x1024","url":"https://ideogram.ai/api/images/ephemeral/xtdZiqPwRxqY1Y7NExFmzB.png?exp=1743867804\u0026sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89","is_image_safe":true}],"created":"2000-01-23T04:56:07\u002B00:00","response_type":"url"}
    /// </summary>
    public sealed partial class ImageGenerationResponseV4ImageToImage
    {
        /// <summary>
        /// Always "url" for this shape.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ImageGenerationResponseV4ImageToImageResponseTypeJsonConverter))]
        public global::Ideogram.ImageGenerationResponseV4ImageToImageResponseType? ResponseType { get; set; }

        /// <summary>
        /// The time the request was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// A list of ImageObjects that contain the generated image(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.ImageGenerationObjectV4ImageToImage> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponseV4ImageToImage" /> class.
        /// </summary>
        /// <param name="created">
        /// The time the request was created.
        /// </param>
        /// <param name="data">
        /// A list of ImageObjects that contain the generated image(s).
        /// </param>
        /// <param name="responseType">
        /// Always "url" for this shape.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationResponseV4ImageToImage(
            global::System.DateTime created,
            global::System.Collections.Generic.IList<global::Ideogram.ImageGenerationObjectV4ImageToImage> data,
            global::Ideogram.ImageGenerationResponseV4ImageToImageResponseType? responseType)
        {
            this.ResponseType = responseType;
            this.Created = created;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponseV4ImageToImage" /> class.
        /// </summary>
        public ImageGenerationResponseV4ImageToImage()
        {
        }

    }
}