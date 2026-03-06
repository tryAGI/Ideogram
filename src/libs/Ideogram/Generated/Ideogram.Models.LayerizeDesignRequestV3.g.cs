
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
        /// A font name from the available font library to use for text rendering. When provided, font matching is skipped and this font is used for all text layers. Cannot be used together with uploaded_font_file.<br/>
        /// Example: Ubuntu-Regular.ttf
        /// </summary>
        /// <example>Ubuntu-Regular.ttf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_font_file")]
        public string? RequestedFontFile { get; set; }

        /// <summary>
        /// A custom font file to use for text rendering. Supported formats are .ttf, .otf, .woff, and .woff2 (max size 5MB). When provided, font matching is skipped and this font is used for all text layers. Cannot be used together with requested_font_file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded_font_file")]
        public byte[]? UploadedFontFile { get; set; }

        /// <summary>
        /// A custom font file to use for text rendering. Supported formats are .ttf, .otf, .woff, and .woff2 (max size 5MB). When provided, font matching is skipped and this font is used for all text layers. Cannot be used together with requested_font_file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded_font_filename")]
        public string? UploadedFontFilename { get; set; }

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
        /// <param name="requestedFontFile">
        /// A font name from the available font library to use for text rendering. When provided, font matching is skipped and this font is used for all text layers. Cannot be used together with uploaded_font_file.<br/>
        /// Example: Ubuntu-Regular.ttf
        /// </param>
        /// <param name="uploadedFontFile">
        /// A custom font file to use for text rendering. Supported formats are .ttf, .otf, .woff, and .woff2 (max size 5MB). When provided, font matching is skipped and this font is used for all text layers. Cannot be used together with requested_font_file.
        /// </param>
        /// <param name="uploadedFontFilename">
        /// A custom font file to use for text rendering. Supported formats are .ttf, .otf, .woff, and .woff2 (max size 5MB). When provided, font matching is skipped and this font is used for all text layers. Cannot be used together with requested_font_file.
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
            string? requestedFontFile,
            byte[]? uploadedFontFile,
            string? uploadedFontFilename,
            global::System.Collections.Generic.IList<byte[]>? referenceAssetImages)
        {
            this.FlatGraphicImage = flatGraphicImage ?? throw new global::System.ArgumentNullException(nameof(flatGraphicImage));
            this.FlatGraphicImagename = flatGraphicImagename ?? throw new global::System.ArgumentNullException(nameof(flatGraphicImagename));
            this.Prompt = prompt;
            this.Seed = seed;
            this.RequestedFontFile = requestedFontFile;
            this.UploadedFontFile = uploadedFontFile;
            this.UploadedFontFilename = uploadedFontFilename;
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