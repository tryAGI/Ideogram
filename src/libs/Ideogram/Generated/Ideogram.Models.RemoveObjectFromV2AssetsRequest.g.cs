
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Supply the source image and the mask each as either an `AssetIdentifier`<br/>
    /// reference or (multipart requests only) raw image bytes. At least one of<br/>
    /// `image_asset_identifier` / `image` is required, and likewise at least one of<br/>
    /// `mask_asset_identifier` / `mask`; if both a reference and bytes are given for<br/>
    /// the same input, the reference is used and the bytes are ignored.
    /// </summary>
    public sealed partial class RemoveObjectFromV2AssetsRequest
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// The source image to remove an object from (max size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifier` is also supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The source image to remove an object from (max size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifier` is also supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_asset_identifier")]
        public global::Ideogram.AssetIdentifier? MaskAssetIdentifier { get; set; }

        /// <summary>
        /// A binary mask the same size as the image, as raw bytes; white (&gt;= 128) marks the region to remove. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `mask_asset_identifier` is also supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public byte[]? Mask { get; set; }

        /// <summary>
        /// A binary mask the same size as the image, as raw bytes; white (&gt;= 128) marks the region to remove. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `mask_asset_identifier` is also supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskname")]
        public string? Maskname { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Whether to store resulting generation assets on Ideogram. Defaults to `false` for<br/>
        /// API developers; first-party mini-apps should pass `true`. Reserved in the schema for<br/>
        /// an upcoming storage-control rollout — currently accepted but not yet enforced.<br/>
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
        /// Initializes a new instance of the <see cref="RemoveObjectFromV2AssetsRequest" /> class.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The source image to remove an object from (max size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifier` is also supplied.
        /// </param>
        /// <param name="imagename">
        /// The source image to remove an object from (max size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifier` is also supplied.
        /// </param>
        /// <param name="maskAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="mask">
        /// A binary mask the same size as the image, as raw bytes; white (&gt;= 128) marks the region to remove. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `mask_asset_identifier` is also supplied.
        /// </param>
        /// <param name="maskname">
        /// A binary mask the same size as the image, as raw bytes; white (&gt;= 128) marks the region to remove. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `mask_asset_identifier` is also supplied.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="storeAssets">
        /// Whether to store resulting generation assets on Ideogram. Defaults to `false` for<br/>
        /// API developers; first-party mini-apps should pass `true`. Reserved in the schema for<br/>
        /// an upcoming storage-control rollout — currently accepted but not yet enforced.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveObjectFromV2AssetsRequest(
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            byte[]? image,
            string? imagename,
            global::Ideogram.AssetIdentifier? maskAssetIdentifier,
            byte[]? mask,
            string? maskname,
            int? seed,
            bool? storeAssets)
        {
            this.ImageAssetIdentifier = imageAssetIdentifier;
            this.Image = image;
            this.Imagename = imagename;
            this.MaskAssetIdentifier = maskAssetIdentifier;
            this.Mask = mask;
            this.Maskname = maskname;
            this.Seed = seed;
            this.StoreAssets = storeAssets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveObjectFromV2AssetsRequest" /> class.
        /// </summary>
        public RemoveObjectFromV2AssetsRequest()
        {
        }

    }
}