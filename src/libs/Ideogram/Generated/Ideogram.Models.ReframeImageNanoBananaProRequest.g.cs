
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Supply exactly one source: `image_asset_identifier` for an existing<br/>
    /// Ideogram asset, or `image` for a raw upload. Supplying both or neither<br/>
    /// is rejected with a 400.
    /// </summary>
    public sealed partial class ReframeImageNanoBananaProRequest
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// The JPEG, PNG, or WEBP image to reframe (max 50MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The JPEG, PNG, or WEBP image to reframe (max 50MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// Aspect ratios Nano Banana Pro can reframe an image to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.NanoBananaProReframeAspectRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.NanoBananaProReframeAspectRatio AspectRatio { get; set; }

        /// <summary>
        /// The output resolution tier. The model sizes its output by tier at the requested aspect ratio; exact pixel dimensions cannot be requested.<br/>
        /// Default Value: 1K
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ReframeImageNanoBananaProRequestResolutionTierJsonConverter))]
        public global::Ideogram.ReframeImageNanoBananaProRequestResolutionTier? ResolutionTier { get; set; }

        /// <summary>
        /// API-key requests are always private. For bearer-authenticated<br/>
        /// requests, this controls whether the result is private; when<br/>
        /// omitted, it follows the caller's plan entitlement. Enterprise<br/>
        /// generations are always private.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// The number of output images to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReframeImageNanoBananaProRequest" /> class.
        /// </summary>
        /// <param name="aspectRatio">
        /// Aspect ratios Nano Banana Pro can reframe an image to.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The JPEG, PNG, or WEBP image to reframe (max 50MB).
        /// </param>
        /// <param name="imagename">
        /// The JPEG, PNG, or WEBP image to reframe (max 50MB).
        /// </param>
        /// <param name="resolutionTier">
        /// The output resolution tier. The model sizes its output by tier at the requested aspect ratio; exact pixel dimensions cannot be requested.<br/>
        /// Default Value: 1K
        /// </param>
        /// <param name="private">
        /// API-key requests are always private. For bearer-authenticated<br/>
        /// requests, this controls whether the result is private; when<br/>
        /// omitted, it follows the caller's plan entitlement. Enterprise<br/>
        /// generations are always private.
        /// </param>
        /// <param name="numImages">
        /// The number of output images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReframeImageNanoBananaProRequest(
            global::Ideogram.NanoBananaProReframeAspectRatio aspectRatio,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            byte[]? image,
            string? imagename,
            global::Ideogram.ReframeImageNanoBananaProRequestResolutionTier? resolutionTier,
            bool? @private,
            int? numImages,
            int? seed)
        {
            this.ImageAssetIdentifier = imageAssetIdentifier;
            this.Image = image;
            this.Imagename = imagename;
            this.AspectRatio = aspectRatio;
            this.ResolutionTier = resolutionTier;
            this.Private = @private;
            this.NumImages = numImages;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReframeImageNanoBananaProRequest" /> class.
        /// </summary>
        public ReframeImageNanoBananaProRequest()
        {
        }

    }
}