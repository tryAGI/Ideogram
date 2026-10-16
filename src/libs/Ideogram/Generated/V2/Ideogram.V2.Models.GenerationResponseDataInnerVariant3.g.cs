
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// A single generated image. Model-agnostic shape returned by the generation polling endpoint.
    /// </summary>
    public sealed partial class GenerationResponseDataInnerVariant3
    {
        /// <summary>
        /// Discriminator value: image.generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerVariant3ObjectTypeJsonConverter))]
        public global::Ideogram.V2.GenerationResponseDataInnerVariant3ObjectType ObjectType { get; set; }

        /// <summary>
        /// The direct link to the image generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The prompt used for the generation. This may be different from the original prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The resolution of the generated image, formatted as "{width}x{height}".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resolution { get; set; }

        /// <summary>
        /// Whether this image passes safety checks. If false, the url field will be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_image_safe")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsImageSafe { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponseDataInnerVariant3" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt used for the generation. This may be different from the original prompt.
        /// </param>
        /// <param name="resolution">
        /// The resolution of the generated image, formatted as "{width}x{height}".
        /// </param>
        /// <param name="isImageSafe">
        /// Whether this image passes safety checks. If false, the url field will be empty.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="objectType">
        /// Discriminator value: image.generation
        /// </param>
        /// <param name="url">
        /// The direct link to the image generated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationResponseDataInnerVariant3(
            string prompt,
            string resolution,
            bool isImageSafe,
            int seed,
            global::Ideogram.V2.GenerationResponseDataInnerVariant3ObjectType objectType,
            string? url)
        {
            this.ObjectType = objectType;
            this.Url = url;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Resolution = resolution ?? throw new global::System.ArgumentNullException(nameof(resolution));
            this.IsImageSafe = isImageSafe;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponseDataInnerVariant3" /> class.
        /// </summary>
        public GenerationResponseDataInnerVariant3()
        {
        }

    }
}