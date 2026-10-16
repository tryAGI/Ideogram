
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageDescribePostDescribeImageIdeogramV4Request
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
        /// Initializes a new instance of the <see cref="ImageDescribePostDescribeImageIdeogramV4Request" /> class.
        /// </summary>
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
        public ImageDescribePostDescribeImageIdeogramV4Request(
            byte[] image,
            string imagename,
            bool? includeBbox,
            bool? includeStyleDescriptions,
            bool? includeTags)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.IncludeBbox = includeBbox;
            this.IncludeStyleDescriptions = includeStyleDescriptions;
            this.IncludeTags = includeTags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDescribePostDescribeImageIdeogramV4Request" /> class.
        /// </summary>
        public ImageDescribePostDescribeImageIdeogramV4Request()
        {
        }

    }
}