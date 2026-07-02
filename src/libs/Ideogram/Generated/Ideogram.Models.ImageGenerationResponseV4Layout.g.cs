
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The response which contains information about the generated layout-to-image output, including the download link.<br/>
    /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
    /// </summary>
    public sealed partial class ImageGenerationResponseV4Layout
    {
        /// <summary>
        /// Discriminator for the postGenerateDesignV4 oneOf response. Always "url" for this shape.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ImageGenerationResponseV4LayoutResponseTypeJsonConverter))]
        public global::Ideogram.ImageGenerationResponseV4LayoutResponseType? ResponseType { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Ideogram.ImageGenerationObjectV4Layout> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponseV4Layout" /> class.
        /// </summary>
        /// <param name="created">
        /// The time the request was created.
        /// </param>
        /// <param name="data">
        /// A list of ImageObjects that contain the generated image(s).
        /// </param>
        /// <param name="responseType">
        /// Discriminator for the postGenerateDesignV4 oneOf response. Always "url" for this shape.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationResponseV4Layout(
            global::System.DateTime created,
            global::System.Collections.Generic.IList<global::Ideogram.ImageGenerationObjectV4Layout> data,
            global::Ideogram.ImageGenerationResponseV4LayoutResponseType? responseType)
        {
            this.ResponseType = responseType;
            this.Created = created;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponseV4Layout" /> class.
        /// </summary>
        public ImageGenerationResponseV4Layout()
        {
        }

    }
}