
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// An image result that does not expose its prompt or seed.
    /// </summary>
    public sealed partial class GenerationResponseDataInnerVariant1
    {
        /// <summary>
        /// Discriminator value: image.without-prompt-or-seed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerVariant1ObjectTypeJsonConverter))]
        public global::Ideogram.V2.GenerationResponseDataInnerVariant1ObjectType ObjectType { get; set; }

        /// <summary>
        /// The direct link to the reframed image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The exact dimensions of the reframed image, formatted as "{width}x{height}".
        /// </summary>
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
        /// Initializes a new instance of the <see cref="GenerationResponseDataInnerVariant1" /> class.
        /// </summary>
        /// <param name="resolution">
        /// The exact dimensions of the reframed image, formatted as "{width}x{height}".
        /// </param>
        /// <param name="isImageSafe">
        /// Whether this image passes safety checks. If false, the url field is empty.
        /// </param>
        /// <param name="objectType">
        /// Discriminator value: image.without-prompt-or-seed
        /// </param>
        /// <param name="url">
        /// The direct link to the reframed image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationResponseDataInnerVariant1(
            string resolution,
            bool isImageSafe,
            global::Ideogram.V2.GenerationResponseDataInnerVariant1ObjectType objectType,
            string? url)
        {
            this.ObjectType = objectType;
            this.Url = url;
            this.Resolution = resolution ?? throw new global::System.ArgumentNullException(nameof(resolution));
            this.IsImageSafe = isImageSafe;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponseDataInnerVariant1" /> class.
        /// </summary>
        public GenerationResponseDataInnerVariant1()
        {
        }

    }
}