
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Supply the source image as raw `image` bytes and the target ad<br/>
    /// `resolution`.
    /// </summary>
    public sealed partial class ResizeAdImageRequest
    {
        /// <summary>
        /// The source image asset to reframe, by reference. Provide exactly one of `image_asset_identifier` or `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// The source image to reframe (max size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The source image to reframe (max size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// Target ad resolution, formatted as `WIDTHxHEIGHT`. Must be one of<br/>
        /// the supported ad resolutions listed above; any other value is<br/>
        /// rejected with a 400. Each returned image has exactly these pixel<br/>
        /// dimensions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ResizeAdImageRequestResolutionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.ResizeAdImageRequestResolution Resolution { get; set; }

        /// <summary>
        /// Optional edit instruction to apply while reframing, for example "remove the logo" or "put the price bottom-right".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Output quality tier. Higher tiers generally improve detail and may take longer to complete. Supported values are LOW, MEDIUM, and HIGH.<br/>
        /// Default Value: HIGH
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ResizeAdImageQualityJsonConverter))]
        public global::Ideogram.ResizeAdImageQuality? Quality { get; set; }

        /// <summary>
        /// The number of reframed variations to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Reserved for a future release: accepted for forward compatibility but not yet applied. Resulting assets are not stored to your account regardless of this value.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_assets")]
        public bool? StoreAssets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResizeAdImageRequest" /> class.
        /// </summary>
        /// <param name="resolution">
        /// Target ad resolution, formatted as `WIDTHxHEIGHT`. Must be one of<br/>
        /// the supported ad resolutions listed above; any other value is<br/>
        /// rejected with a 400. Each returned image has exactly these pixel<br/>
        /// dimensions.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// The source image asset to reframe, by reference. Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="image">
        /// The source image to reframe (max size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The source image to reframe (max size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are supported.
        /// </param>
        /// <param name="prompt">
        /// Optional edit instruction to apply while reframing, for example "remove the logo" or "put the price bottom-right".
        /// </param>
        /// <param name="quality">
        /// Output quality tier. Higher tiers generally improve detail and may take longer to complete. Supported values are LOW, MEDIUM, and HIGH.<br/>
        /// Default Value: HIGH
        /// </param>
        /// <param name="numImages">
        /// The number of reframed variations to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="storeAssets">
        /// Reserved for a future release: accepted for forward compatibility but not yet applied. Resulting assets are not stored to your account regardless of this value.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResizeAdImageRequest(
            global::Ideogram.ResizeAdImageRequestResolution resolution,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            byte[]? image,
            string? imagename,
            string? prompt,
            global::Ideogram.ResizeAdImageQuality? quality,
            int? numImages,
            bool? storeAssets)
        {
            this.ImageAssetIdentifier = imageAssetIdentifier;
            this.Image = image;
            this.Imagename = imagename;
            this.Resolution = resolution;
            this.Prompt = prompt;
            this.Quality = quality;
            this.NumImages = numImages;
            this.StoreAssets = storeAssets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResizeAdImageRequest" /> class.
        /// </summary>
        public ResizeAdImageRequest()
        {
        }

    }
}