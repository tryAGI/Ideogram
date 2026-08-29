
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// An image result that does not expose its prompt or seed.
    /// </summary>
    public sealed partial class ImageObjectWithoutPromptOrSeed
    {
        /// <summary>
        /// Discriminator marking this entry as an image result without prompt or seed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ImageObjectWithoutPromptOrSeedObjectTypeJsonConverter))]
        public global::Ideogram.ImageObjectWithoutPromptOrSeedObjectType ObjectType { get; set; }

        /// <summary>
        /// The direct link to the reframed image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The base64url-encoded identifier of the generated image asset. Present for safe workflow-owned outputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// The exact dimensions of the reframed image, formatted as "{width}x{height}".<br/>
        /// Example: 1920x1080
        /// </summary>
        /// <example>1920x1080</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resolution { get; set; }

        /// <summary>
        /// Whether this image passes safety checks. If false, the url field is empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_image_safe")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsImageSafe { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageObjectWithoutPromptOrSeed" /> class.
        /// </summary>
        /// <param name="resolution">
        /// The exact dimensions of the reframed image, formatted as "{width}x{height}".<br/>
        /// Example: 1920x1080
        /// </param>
        /// <param name="isImageSafe">
        /// Whether this image passes safety checks. If false, the url field is empty.
        /// </param>
        /// <param name="objectType">
        /// Discriminator marking this entry as an image result without prompt or seed.
        /// </param>
        /// <param name="url">
        /// The direct link to the reframed image.
        /// </param>
        /// <param name="assetId">
        /// The base64url-encoded identifier of the generated image asset. Present for safe workflow-owned outputs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageObjectWithoutPromptOrSeed(
            string resolution,
            bool isImageSafe,
            global::Ideogram.ImageObjectWithoutPromptOrSeedObjectType objectType,
            string? url,
            string? assetId)
        {
            this.ObjectType = objectType;
            this.Url = url;
            this.AssetId = assetId;
            this.Resolution = resolution ?? throw new global::System.ArgumentNullException(nameof(resolution));
            this.IsImageSafe = isImageSafe;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageObjectWithoutPromptOrSeed" /> class.
        /// </summary>
        public ImageObjectWithoutPromptOrSeed()
        {
        }

    }
}