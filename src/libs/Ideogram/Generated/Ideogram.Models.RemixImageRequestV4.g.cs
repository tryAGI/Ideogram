
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemixImageRequestV4
    {
        /// <summary>
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// The text prompt that guides the remix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TextPrompt { get; set; }

        /// <summary>
        /// Optional. How strongly the output should resemble the input image. Higher values keep<br/>
        /// the input image's structure; lower values allow the prompt to drive the output more.<br/>
        /// When omitted, the weight is chosen automatically from the edit instruction; supplying<br/>
        /// a value overrides that automatic choice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_weight")]
        public int? ImageWeight { get; set; }

        /// <summary>
        /// The 1K and 2K resolutions supported for Ideogram 4.0 image generation.<br/>
        /// Example: 2048x2048
        /// </summary>
        /// <example>2048x2048</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ResolutionV4JsonConverter))]
        public global::Ideogram.ResolutionV4? Resolution { get; set; }

        /// <summary>
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.RenderingSpeedJsonConverter))]
        public global::Ideogram.RenderingSpeed? RenderingSpeed { get; set; }

        /// <summary>
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). See GenerateImageRequestV3 for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_copyright_detection")]
        public bool? EnableCopyrightDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixImageRequestV4" /> class.
        /// </summary>
        /// <param name="image">
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="textPrompt">
        /// The text prompt that guides the remix.
        /// </param>
        /// <param name="imageWeight">
        /// Optional. How strongly the output should resemble the input image. Higher values keep<br/>
        /// the input image's structure; lower values allow the prompt to drive the output more.<br/>
        /// When omitted, the weight is chosen automatically from the edit instruction; supplying<br/>
        /// a value overrides that automatic choice.
        /// </param>
        /// <param name="resolution">
        /// The 1K and 2K resolutions supported for Ideogram 4.0 image generation.<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). See GenerateImageRequestV3 for details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemixImageRequestV4(
            byte[] image,
            string imagename,
            string textPrompt,
            int? imageWeight,
            global::Ideogram.ResolutionV4? resolution,
            global::Ideogram.RenderingSpeed? renderingSpeed,
            bool? enableCopyrightDetection)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.TextPrompt = textPrompt ?? throw new global::System.ArgumentNullException(nameof(textPrompt));
            this.ImageWeight = imageWeight;
            this.Resolution = resolution;
            this.RenderingSpeed = renderingSpeed;
            this.EnableCopyrightDetection = enableCopyrightDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixImageRequestV4" /> class.
        /// </summary>
        public RemixImageRequestV4()
        {
        }

    }
}