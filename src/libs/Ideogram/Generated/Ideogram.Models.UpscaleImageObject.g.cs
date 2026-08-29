
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// One upscaled output image.<br/>
    /// Example: {"seed":12345,"resolution":"2048x2048","url":"https://openapi-generator.tech","is_image_safe":true}
    /// </summary>
    public sealed partial class UpscaleImageObject
    {
        /// <summary>
        /// The direct link to the upscaled image. Empty when the image did not pass safety checks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The resolution of the upscaled image, formatted as "WIDTHxHEIGHT".<br/>
        /// Example: 2048x2048
        /// </summary>
        /// <example>2048x2048</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resolution { get; set; }

        /// <summary>
        /// Whether the image passed safety checks. If false, `url` is empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_image_safe")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsImageSafe { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpscaleImageObject" /> class.
        /// </summary>
        /// <param name="resolution">
        /// The resolution of the upscaled image, formatted as "WIDTHxHEIGHT".<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="isImageSafe">
        /// Whether the image passed safety checks. If false, `url` is empty.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="url">
        /// The direct link to the upscaled image. Empty when the image did not pass safety checks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpscaleImageObject(
            string resolution,
            bool isImageSafe,
            int seed,
            string? url)
        {
            this.Url = url;
            this.Resolution = resolution ?? throw new global::System.ArgumentNullException(nameof(resolution));
            this.IsImageSafe = isImageSafe;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpscaleImageObject" /> class.
        /// </summary>
        public UpscaleImageObject()
        {
        }

    }
}