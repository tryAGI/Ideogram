
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DescribeRequestV4
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
        /// When true (default), the response preserves bounding boxes on each<br/>
        /// element so the prompt can be pasted into `/v1/ideogram-v4/generate`<br/>
        /// as `json_prompt` and reproduce the source layout. Set to false to<br/>
        /// drop bounding boxes and let the sampler place elements freely.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_bbox")]
        public bool? IncludeBbox { get; set; }

        /// <summary>
        /// When false (default), the response omits `json_prompt.style_description`<br/>
        /// to match the contract used by `/v1/ideogram-v4/generate`'s `json_prompt`<br/>
        /// input. Set to true to surface the captioner's source-image style<br/>
        /// description in the response.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_style_descriptions")]
        public bool? IncludeStyleDescriptions { get; set; }

        /// <summary>
        /// When false (default), the response omits `json_prompt.tags` to match<br/>
        /// the contract used by `/v1/ideogram-v4/generate`'s `json_prompt`<br/>
        /// input. Set to true to surface the captioner's free-form tags on the<br/>
        /// response.<br/>
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
        /// Initializes a new instance of the <see cref="DescribeRequestV4" /> class.
        /// </summary>
        /// <param name="imageFile">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imageFilename">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="includeBbox">
        /// When true (default), the response preserves bounding boxes on each<br/>
        /// element so the prompt can be pasted into `/v1/ideogram-v4/generate`<br/>
        /// as `json_prompt` and reproduce the source layout. Set to false to<br/>
        /// drop bounding boxes and let the sampler place elements freely.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeStyleDescriptions">
        /// When false (default), the response omits `json_prompt.style_description`<br/>
        /// to match the contract used by `/v1/ideogram-v4/generate`'s `json_prompt`<br/>
        /// input. Set to true to surface the captioner's source-image style<br/>
        /// description in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTags">
        /// When false (default), the response omits `json_prompt.tags` to match<br/>
        /// the contract used by `/v1/ideogram-v4/generate`'s `json_prompt`<br/>
        /// input. Set to true to surface the captioner's free-form tags on the<br/>
        /// response.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DescribeRequestV4(
            byte[] imageFile,
            string imageFilename,
            bool? includeBbox,
            bool? includeStyleDescriptions,
            bool? includeTags)
        {
            this.ImageFile = imageFile ?? throw new global::System.ArgumentNullException(nameof(imageFile));
            this.ImageFilename = imageFilename ?? throw new global::System.ArgumentNullException(nameof(imageFilename));
            this.IncludeBbox = includeBbox;
            this.IncludeStyleDescriptions = includeStyleDescriptions;
            this.IncludeTags = includeTags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeRequestV4" /> class.
        /// </summary>
        public DescribeRequestV4()
        {
        }

    }
}