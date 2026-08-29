
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// One edited output image.<br/>
    /// Example: {"seed":12345,"prompt":"prompt","resolution":"2048x2048","url":"https://openapi-generator.tech","is_image_safe":true}
    /// </summary>
    public sealed partial class EditImageObject
    {
        /// <summary>
        /// The direct link to the edited image. Empty when the image did not pass safety checks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The edit instruction the image was generated from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The resolution of the edited image, formatted as "WIDTHxHEIGHT".<br/>
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
        /// Initializes a new instance of the <see cref="EditImageObject" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The edit instruction the image was generated from.
        /// </param>
        /// <param name="resolution">
        /// The resolution of the edited image, formatted as "WIDTHxHEIGHT".<br/>
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
        /// The direct link to the edited image. Empty when the image did not pass safety checks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditImageObject(
            string prompt,
            string resolution,
            bool isImageSafe,
            int seed,
            string? url)
        {
            this.Url = url;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Resolution = resolution ?? throw new global::System.ArgumentNullException(nameof(resolution));
            this.IsImageSafe = isImageSafe;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageObject" /> class.
        /// </summary>
        public EditImageObject()
        {
        }

    }
}