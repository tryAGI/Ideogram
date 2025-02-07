
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The response which contains information about the generated image, including the download link.<br/>
    /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
    /// </summary>
    public sealed partial class GenerateImageResponse
    {
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
        public required global::System.Collections.Generic.IList<global::Ideogram.ImageObject> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageResponse" /> class.
        /// </summary>
        /// <param name="created">
        /// The time the request was created.
        /// </param>
        /// <param name="data">
        /// A list of ImageObjects that contain the generated image(s).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageResponse(
            global::System.DateTime created,
            global::System.Collections.Generic.IList<global::Ideogram.ImageObject> data)
        {
            this.Created = created;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageResponse" /> class.
        /// </summary>
        public GenerateImageResponse()
        {
        }
    }
}