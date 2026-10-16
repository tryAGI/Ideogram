
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReframeIdeogramV3Request
    {
        /// <summary>
        /// The JPEG, PNG, or WEBP image to reframe (max 25MB). Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The JPEG, PNG, or WEBP image to reframe (max 25MB). Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// The resolutions supported for Ideogram 3.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ResolutionV3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.ResolutionV3 Resolution { get; set; }

        /// <summary>
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.V2ImageReframeIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter))]
        public global::Ideogram.V2ImageReframeIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? RenderingSpeed { get; set; }

        /// <summary>
        /// A predefined style preset that applies a specific artistic style to the generated image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.IdeogramV3StylePresetJsonConverter))]
        public global::Ideogram.IdeogramV3StylePreset? StylePreset { get; set; }

        /// <summary>
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_palette")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.IdeogramColorPaletteJsonConverter))]
        public global::Ideogram.IdeogramColorPalette? ColorPalette { get; set; }

        /// <summary>
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_codes")]
        public global::System.Collections.Generic.IList<string>? StyleCodes { get; set; }

        /// <summary>
        /// JPEG, PNG, or WEBP style reference images (max 10, max 25MB each). Multipart requests only. Cannot be combined with `style_preset` or `style_codes`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? StyleReferenceImages { get; set; }

        /// <summary>
        /// Return immediately instead of waiting for reframed images.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public bool? Async { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReframeIdeogramV3Request" /> class.
        /// </summary>
        /// <param name="image">
        /// The JPEG, PNG, or WEBP image to reframe (max 25MB). Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The JPEG, PNG, or WEBP image to reframe (max 25MB). Multipart requests only.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="renderingSpeed">
        /// Default Value: default
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset that applies a specific artistic style to the generated image.
        /// </param>
        /// <param name="colorPalette">
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members).
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.
        /// </param>
        /// <param name="styleReferenceImages">
        /// JPEG, PNG, or WEBP style reference images (max 10, max 25MB each). Multipart requests only. Cannot be combined with `style_preset` or `style_codes`.
        /// </param>
        /// <param name="async">
        /// Return immediately instead of waiting for reframed images.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReframeIdeogramV3Request(
            byte[] image,
            string imagename,
            global::Ideogram.ResolutionV3 resolution,
            int? numImages,
            int? seed,
            global::Ideogram.V2ImageReframeIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed,
            global::Ideogram.IdeogramV3StylePreset? stylePreset,
            global::Ideogram.IdeogramColorPalette? colorPalette,
            global::System.Collections.Generic.IList<string>? styleCodes,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages,
            bool? async)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Resolution = resolution;
            this.NumImages = numImages;
            this.Seed = seed;
            this.RenderingSpeed = renderingSpeed;
            this.StylePreset = stylePreset;
            this.ColorPalette = colorPalette;
            this.StyleCodes = styleCodes;
            this.StyleReferenceImages = styleReferenceImages;
            this.Async = async;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReframeIdeogramV3Request" /> class.
        /// </summary>
        public ReframeIdeogramV3Request()
        {
        }

    }
}