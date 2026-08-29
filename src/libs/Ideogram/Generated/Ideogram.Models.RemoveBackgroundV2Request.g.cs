
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Supply exactly one image source. `image` is available only in multipart requests; `image_asset_identifier` accepts an existing upload or generated image that is readable in the active organization.
    /// </summary>
    public sealed partial class RemoveBackgroundV2Request
    {
        /// <summary>
        /// Raw JPEG, PNG, or WebP image bytes (max 25MB). Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// Raw JPEG, PNG, or WebP image bytes (max 25MB). Multipart requests only.
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
        /// Whether to keep the result out of the public gallery. When omitted,<br/>
        /// Firebase Bearer and Mini App callers inherit their plan entitlement.<br/>
        /// Enterprise generations are always private. API keys use their bound<br/>
        /// organization and otherwise default to public when no subscription<br/>
        /// entitlement is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// When false (the default), wait for and return the foreground image. When true, return after acceptance and poll `GET /v1/generations/{generation_id}`.<br/>
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
        /// Raw JPEG, PNG, or WebP image bytes (max 25MB). Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// Raw JPEG, PNG, or WebP image bytes (max 25MB). Multipart requests only.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="private">
        /// Whether to keep the result out of the public gallery. When omitted,<br/>
        /// Firebase Bearer and Mini App callers inherit their plan entitlement.<br/>
        /// Enterprise generations are always private. API keys use their bound<br/>
        /// organization and otherwise default to public when no subscription<br/>
        /// entitlement is available.
        /// </param>
        /// <param name="async">
        /// When false (the default), wait for and return the foreground image. When true, return after acceptance and poll `GET /v1/generations/{generation_id}`.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveBackgroundV2Request(
            byte[]? image,
            string? imagename,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            bool? @private,
            bool? async)
        {
            this.Image = image;
            this.Imagename = imagename;
            this.ImageAssetIdentifier = imageAssetIdentifier;
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