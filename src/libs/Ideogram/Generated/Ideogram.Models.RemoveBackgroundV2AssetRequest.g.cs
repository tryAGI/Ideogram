
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// JSON request shape for processing an existing upload or generated image. Raw image bytes are accepted only through multipart form data.
    /// </summary>
    public sealed partial class RemoveBackgroundV2AssetRequest
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AssetIdentifier ImageAssetIdentifier { get; set; }

        /// <summary>
        /// Whether to keep the result out of the public gallery. Enterprise generations are always private.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// Return after acceptance and poll by generation ID when true.<br/>
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
        /// Initializes a new instance of the <see cref="RemoveBackgroundV2AssetRequest" /> class.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="private">
        /// Whether to keep the result out of the public gallery. Enterprise generations are always private.
        /// </param>
        /// <param name="async">
        /// Return after acceptance and poll by generation ID when true.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveBackgroundV2AssetRequest(
            global::Ideogram.AssetIdentifier imageAssetIdentifier,
            bool? @private,
            bool? async)
        {
            this.ImageAssetIdentifier = imageAssetIdentifier ?? throw new global::System.ArgumentNullException(nameof(imageAssetIdentifier));
            this.Private = @private;
            this.Async = async;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveBackgroundV2AssetRequest" /> class.
        /// </summary>
        public RemoveBackgroundV2AssetRequest()
        {
        }

    }
}