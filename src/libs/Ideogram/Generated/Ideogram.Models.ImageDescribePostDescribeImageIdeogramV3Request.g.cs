
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageDescribePostDescribeImageIdeogramV3Request
    {
        /// <summary>
        /// The image to describe (max 10MB). JPEG, PNG, and WebP are supported. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The image to describe (max 10MB). JPEG, PNG, and WebP are supported. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDescribePostDescribeImageIdeogramV3Request" /> class.
        /// </summary>
        /// <param name="image">
        /// The image to describe (max 10MB). JPEG, PNG, and WebP are supported. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The image to describe (max 10MB). JPEG, PNG, and WebP are supported. Multipart requests only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageDescribePostDescribeImageIdeogramV3Request(
            byte[] image,
            string imagename)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDescribePostDescribeImageIdeogramV3Request" /> class.
        /// </summary>
        public ImageDescribePostDescribeImageIdeogramV3Request()
        {
        }

    }
}