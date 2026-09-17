
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Response returned by `POST /v2/image/describe/ideogram-3`.<br/>
    /// Example: {"description_id":"description_id","created":"2000-01-23T04:56:07\u002B00:00","descriptions":[{"text":"text"},{"text":"text"}]}
    /// </summary>
    public sealed partial class DescribeImageIdeogramV3Response
    {
        /// <summary>
        /// URL-safe base64 ID of the description that was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DescriptionId { get; set; }

        /// <summary>
        /// The time the request was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// The generated description(s) for the provided image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.GeneratedDescription> Descriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeImageIdeogramV3Response" /> class.
        /// </summary>
        /// <param name="descriptionId">
        /// URL-safe base64 ID of the description that was created.
        /// </param>
        /// <param name="created">
        /// The time the request was created.
        /// </param>
        /// <param name="descriptions">
        /// The generated description(s) for the provided image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DescribeImageIdeogramV3Response(
            string descriptionId,
            global::System.DateTime created,
            global::System.Collections.Generic.IList<global::Ideogram.GeneratedDescription> descriptions)
        {
            this.DescriptionId = descriptionId ?? throw new global::System.ArgumentNullException(nameof(descriptionId));
            this.Created = created;
            this.Descriptions = descriptions ?? throw new global::System.ArgumentNullException(nameof(descriptions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeImageIdeogramV3Response" /> class.
        /// </summary>
        public DescribeImageIdeogramV3Response()
        {
        }

    }
}