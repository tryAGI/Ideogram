
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReframeImageRequestV3
    {
        /// <summary>
        /// The image being reframed; only JPEG, WebP and PNG formats are supported at this time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] ImageFile { get; set; }

        /// <summary>
        /// The image being reframed; only JPEG, WebP and PNG formats are supported at this time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageFilename { get; set; }

        /// <summary>
        /// The resolutions supported for model version V_3.<br/>
        /// Example: 1280x800
        /// </summary>
        /// <example>1280x800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ResolutionV3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.ResolutionV3 Resolution { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The rendering speed to use.<br/>
        /// Default Value: BALANCED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.RenderingSpeedJsonConverter))]
        public global::Ideogram.RenderingSpeed? RenderingSpeed { get; set; }

        /// <summary>
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members). Not supported by V_1, V_1_TURBO, V_2A and V_2A_TURBO models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_palette")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ColorPaletteWithPresetNameOrMembersJsonConverter))]
        public global::Ideogram.ColorPaletteWithPresetNameOrMembers? ColorPalette { get; set; }

        /// <summary>
        /// A list of 8 character hexadecimal codes representing the style of the image. Cannot be used in conjunction with style_reference_images or style_type.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </summary>
        /// <example>[AAFF5733, 0133FF57, DE3357FF]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_codes")]
        public global::System.Collections.Generic.IList<string>? StyleCodes { get; set; }

        /// <summary>
        /// A set of images to use as style references. The images should be in JPEG, PNG or WebP format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? StyleReferenceImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReframeImageRequestV3" /> class.
        /// </summary>
        /// <param name="imageFile">
        /// The image being reframed; only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imageFilename">
        /// The image being reframed; only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for model version V_3.<br/>
        /// Example: 1280x800
        /// </param>
        /// <param name="numImages">
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Example: 12345
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: BALANCED
        /// </param>
        /// <param name="colorPalette">
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members). Not supported by V_1, V_1_TURBO, V_2A and V_2A_TURBO models.
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8 character hexadecimal codes representing the style of the image. Cannot be used in conjunction with style_reference_images or style_type.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </param>
        /// <param name="styleReferenceImages">
        /// A set of images to use as style references. The images should be in JPEG, PNG or WebP format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReframeImageRequestV3(
            byte[] imageFile,
            string imageFilename,
            global::Ideogram.ResolutionV3 resolution,
            int? numImages,
            int? seed,
            global::Ideogram.RenderingSpeed? renderingSpeed,
            global::Ideogram.ColorPaletteWithPresetNameOrMembers? colorPalette,
            global::System.Collections.Generic.IList<string>? styleCodes,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages)
        {
            this.ImageFile = imageFile ?? throw new global::System.ArgumentNullException(nameof(imageFile));
            this.ImageFilename = imageFilename ?? throw new global::System.ArgumentNullException(nameof(imageFilename));
            this.Resolution = resolution;
            this.NumImages = numImages;
            this.Seed = seed;
            this.RenderingSpeed = renderingSpeed;
            this.ColorPalette = colorPalette;
            this.StyleCodes = styleCodes;
            this.StyleReferenceImages = styleReferenceImages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReframeImageRequestV3" /> class.
        /// </summary>
        public ReframeImageRequestV3()
        {
        }
    }
}