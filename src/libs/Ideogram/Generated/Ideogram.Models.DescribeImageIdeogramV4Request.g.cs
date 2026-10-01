
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A request to describe one image. Upload the image as `image` using<br/>
    /// `multipart/form-data`.
    /// </summary>
    public sealed partial class DescribeImageIdeogramV4Request
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// The image to describe (max 10MB). JPEG, PNG, and WebP are supported. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The image to describe (max 10MB). JPEG, PNG, and WebP are supported. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// Whether to include bounding boxes for the subjects and text in the returned `json_prompt`. Defaults to true, so the prompt preserves the layout of the described image.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_bbox")]
        public bool? IncludeBbox { get; set; }

        /// <summary>
        /// Whether to include a free-form style description in the returned `json_prompt`. Defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_style_descriptions")]
        public bool? IncludeStyleDescriptions { get; set; }

        /// <summary>
        /// Whether to include free-form tags in the returned `json_prompt`. Defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_tags")]
        public bool? IncludeTags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeImageIdeogramV4Request" /> class.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The image to describe (max 10MB). JPEG, PNG, and WebP are supported. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The image to describe (max 10MB). JPEG, PNG, and WebP are supported. Multipart requests only.
        /// </param>
        /// <param name="includeBbox">
        /// Whether to include bounding boxes for the subjects and text in the returned `json_prompt`. Defaults to true, so the prompt preserves the layout of the described image.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeStyleDescriptions">
        /// Whether to include a free-form style description in the returned `json_prompt`. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTags">
        /// Whether to include free-form tags in the returned `json_prompt`. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DescribeImageIdeogramV4Request(
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            byte[]? image,
            string? imagename,
            bool? includeBbox,
            bool? includeStyleDescriptions,
            bool? includeTags)
        {
            this.ImageAssetIdentifier = imageAssetIdentifier;
            this.Image = image;
            this.Imagename = imagename;
            this.IncludeBbox = includeBbox;
            this.IncludeStyleDescriptions = includeStyleDescriptions;
            this.IncludeTags = includeTags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeImageIdeogramV4Request" /> class.
        /// </summary>
        public DescribeImageIdeogramV4Request()
        {
        }

    }
}