
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Upload the source `image` using `multipart/form-data`.
    /// </summary>
    public sealed partial class RemoveBackgroundV2Request
    {
        /// <summary>
        /// The source image. JPEG, PNG, or WebP, up to 25MB. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The source image. JPEG, PNG, or WebP, up to 25MB. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// A collection you can write to, by its URL-safe base64 collection id. Completed outputs are added to it automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_collection_id")]
        public string? TargetCollectionId { get; set; }

        /// <summary>
        /// Whether to keep the result out of the public gallery. When omitted,<br/>
        /// defaults to your plan's setting, or public if your plan has none.<br/>
        /// Enterprise generations are always private.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// When false (the default), wait for and return the foreground image. When true, return as soon as the request is accepted; poll `GET /v2/generations/{generation_id}` for the result.<br/>
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
        /// Initializes a new instance of the <see cref="RemoveBackgroundV2Request" /> class.
        /// </summary>
        /// <param name="image">
        /// The source image. JPEG, PNG, or WebP, up to 25MB. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image. JPEG, PNG, or WebP, up to 25MB. Multipart requests only.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. Completed outputs are added to it automatically.
        /// </param>
        /// <param name="private">
        /// Whether to keep the result out of the public gallery. When omitted,<br/>
        /// defaults to your plan's setting, or public if your plan has none.<br/>
        /// Enterprise generations are always private.
        /// </param>
        /// <param name="async">
        /// When false (the default), wait for and return the foreground image. When true, return as soon as the request is accepted; poll `GET /v2/generations/{generation_id}` for the result.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveBackgroundV2Request(
            byte[]? image,
            string? imagename,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            string? targetCollectionId,
            bool? @private,
            bool? async)
        {
            this.Image = image;
            this.Imagename = imagename;
            this.ImageAssetIdentifier = imageAssetIdentifier;
            this.TargetCollectionId = targetCollectionId;
            this.Private = @private;
            this.Async = async;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveBackgroundV2Request" /> class.
        /// </summary>
        public RemoveBackgroundV2Request()
        {
        }

    }
}