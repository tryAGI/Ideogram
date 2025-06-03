
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DescribeRequest
    {
        /// <summary>
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] ImageFile { get; set; }

        /// <summary>
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageFilename { get; set; }

        /// <summary>
        /// The model version to use for describing images. V_2 uses the current describe model, V_3 uses the new captioner model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("describe_model_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.DescribeModelVersionJsonConverter))]
        public global::Ideogram.DescribeModelVersion? DescribeModelVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeRequest" /> class.
        /// </summary>
        /// <param name="imageFile">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imageFilename">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="describeModelVersion">
        /// The model version to use for describing images. V_2 uses the current describe model, V_3 uses the new captioner model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DescribeRequest(
            byte[] imageFile,
            string imageFilename,
            global::Ideogram.DescribeModelVersion? describeModelVersion)
        {
            this.ImageFile = imageFile ?? throw new global::System.ArgumentNullException(nameof(imageFile));
            this.ImageFilename = imageFilename ?? throw new global::System.ArgumentNullException(nameof(imageFilename));
            this.DescribeModelVersion = describeModelVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeRequest" /> class.
        /// </summary>
        public DescribeRequest()
        {
        }
    }
}