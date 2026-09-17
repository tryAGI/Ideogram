
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Supply the source image either as an `image_asset_identifier`<br/>
    /// reference or (multipart requests only) as raw `image` bytes. Provide<br/>
    /// exactly one of the two forms; supplying both, or neither, is rejected<br/>
    /// with a 400.
    /// </summary>
    public sealed partial class DescribeImageIdeogramV3Request
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// The image to describe (max size 10MB), as raw bytes; only JPEG, PNG, and WebP formats are supported. Multipart requests only. Provide exactly one of `image_asset_identifier` or `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The image to describe (max size 10MB), as raw bytes; only JPEG, PNG, and WebP formats are supported. Multipart requests only. Provide exactly one of `image_asset_identifier` or `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeImageIdeogramV3Request" /> class.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The image to describe (max size 10MB), as raw bytes; only JPEG, PNG, and WebP formats are supported. Multipart requests only. Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="imagename">
        /// The image to describe (max size 10MB), as raw bytes; only JPEG, PNG, and WebP formats are supported. Multipart requests only. Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DescribeImageIdeogramV3Request(
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            byte[]? image,
            string? imagename)
        {
            this.ImageAssetIdentifier = imageAssetIdentifier;
            this.Image = image;
            this.Imagename = imagename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeImageIdeogramV3Request" /> class.
        /// </summary>
        public DescribeImageIdeogramV3Request()
        {
        }

    }
}