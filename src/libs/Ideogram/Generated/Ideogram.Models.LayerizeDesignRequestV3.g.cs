
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LayerizeDesignRequestV3
    {
        /// <summary>
        /// The flat graphic image to process for text detection and correction. The image should be in JPEG, PNG or WebP format (max size 10MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flat_graphic_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] FlatGraphicImage { get; set; }

        /// <summary>
        /// The flat graphic image to process for text detection and correction. The image should be in JPEG, PNG or WebP format (max size 10MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flat_graphic_imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FlatGraphicImagename { get; set; }

        /// <summary>
        /// An optional prompt to describe the image. If not provided, a prompt will be auto-generated from the image via captioning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Custom font file for H1 (heading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_file_h1")]
        public byte[]? FontFileH1 { get; set; }

        /// <summary>
        /// Custom font file for H1 (heading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_file_h1name")]
        public string? FontFileH1name { get; set; }

        /// <summary>
        /// Font name from the available font library for H1 text. Ignored if font_file_h1 is provided.<br/>
        /// Example: Ubuntu-Bold.ttf
        /// </summary>
        /// <example>Ubuntu-Bold.ttf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_name_h1")]
        public string? FontNameH1 { get; set; }

        /// <summary>
        /// Custom font file for H2 (subheading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_file_h2")]
        public byte[]? FontFileH2 { get; set; }

        /// <summary>
        /// Custom font file for H2 (subheading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_file_h2name")]
        public string? FontFileH2name { get; set; }

        /// <summary>
        /// Font name from the available font library for H2 text. Ignored if font_file_h2 is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_name_h2")]
        public string? FontNameH2 { get; set; }

        /// <summary>
        /// Custom font file for body text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_file_body")]
        public byte[]? FontFileBody { get; set; }

        /// <summary>
        /// Custom font file for body text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_file_bodyname")]
        public string? FontFileBodyname { get; set; }

        /// <summary>
        /// Font name from the available font library for body text. Ignored if font_file_body is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_name_body")]
        public string? FontNameBody { get; set; }

        /// <summary>
        /// Custom font file for small/caption text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_small.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_file_small")]
        public byte[]? FontFileSmall { get; set; }

        /// <summary>
        /// Custom font file for small/caption text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_small.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_file_smallname")]
        public string? FontFileSmallname { get; set; }

        /// <summary>
        /// Font name from the available font library for small text. Ignored if font_file_small is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_name_small")]
        public string? FontNameSmall { get; set; }

        /// <summary>
        /// A set of asset images (e.g., logos, icons) to use as references for detection and replacement (maximum 10 images). The images should be in JPEG, PNG or WebP format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_asset_images")]
        public global::System.Collections.Generic.IList<byte[]>? ReferenceAssetImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeDesignRequestV3" /> class.
        /// </summary>
        /// <param name="flatGraphicImage">
        /// The flat graphic image to process for text detection and correction. The image should be in JPEG, PNG or WebP format (max size 10MB).
        /// </param>
        /// <param name="flatGraphicImagename">
        /// The flat graphic image to process for text detection and correction. The image should be in JPEG, PNG or WebP format (max size 10MB).
        /// </param>
        /// <param name="prompt">
        /// An optional prompt to describe the image. If not provided, a prompt will be auto-generated from the image via captioning.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="fontFileH1">
        /// Custom font file for H1 (heading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h1.
        /// </param>
        /// <param name="fontFileH1name">
        /// Custom font file for H1 (heading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h1.
        /// </param>
        /// <param name="fontNameH1">
        /// Font name from the available font library for H1 text. Ignored if font_file_h1 is provided.<br/>
        /// Example: Ubuntu-Bold.ttf
        /// </param>
        /// <param name="fontFileH2">
        /// Custom font file for H2 (subheading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h2.
        /// </param>
        /// <param name="fontFileH2name">
        /// Custom font file for H2 (subheading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h2.
        /// </param>
        /// <param name="fontNameH2">
        /// Font name from the available font library for H2 text. Ignored if font_file_h2 is provided.
        /// </param>
        /// <param name="fontFileBody">
        /// Custom font file for body text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_body.
        /// </param>
        /// <param name="fontFileBodyname">
        /// Custom font file for body text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_body.
        /// </param>
        /// <param name="fontNameBody">
        /// Font name from the available font library for body text. Ignored if font_file_body is provided.
        /// </param>
        /// <param name="fontFileSmall">
        /// Custom font file for small/caption text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_small.
        /// </param>
        /// <param name="fontFileSmallname">
        /// Custom font file for small/caption text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_small.
        /// </param>
        /// <param name="fontNameSmall">
        /// Font name from the available font library for small text. Ignored if font_file_small is provided.
        /// </param>
        /// <param name="referenceAssetImages">
        /// A set of asset images (e.g., logos, icons) to use as references for detection and replacement (maximum 10 images). The images should be in JPEG, PNG or WebP format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeDesignRequestV3(
            byte[] flatGraphicImage,
            string flatGraphicImagename,
            string? prompt,
            int? seed,
            byte[]? fontFileH1,
            string? fontFileH1name,
            string? fontNameH1,
            byte[]? fontFileH2,
            string? fontFileH2name,
            string? fontNameH2,
            byte[]? fontFileBody,
            string? fontFileBodyname,
            string? fontNameBody,
            byte[]? fontFileSmall,
            string? fontFileSmallname,
            string? fontNameSmall,
            global::System.Collections.Generic.IList<byte[]>? referenceAssetImages)
        {
            this.FlatGraphicImage = flatGraphicImage ?? throw new global::System.ArgumentNullException(nameof(flatGraphicImage));
            this.FlatGraphicImagename = flatGraphicImagename ?? throw new global::System.ArgumentNullException(nameof(flatGraphicImagename));
            this.Prompt = prompt;
            this.Seed = seed;
            this.FontFileH1 = fontFileH1;
            this.FontFileH1name = fontFileH1name;
            this.FontNameH1 = fontNameH1;
            this.FontFileH2 = fontFileH2;
            this.FontFileH2name = fontFileH2name;
            this.FontNameH2 = fontNameH2;
            this.FontFileBody = fontFileBody;
            this.FontFileBodyname = fontFileBodyname;
            this.FontNameBody = fontNameBody;
            this.FontFileSmall = fontFileSmall;
            this.FontFileSmallname = fontFileSmallname;
            this.FontNameSmall = fontNameSmall;
            this.ReferenceAssetImages = referenceAssetImages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeDesignRequestV3" /> class.
        /// </summary>
        public LayerizeDesignRequestV3()
        {
        }
    }
}