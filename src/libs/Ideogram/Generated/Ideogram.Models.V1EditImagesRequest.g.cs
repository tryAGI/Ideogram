
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1EditImagesRequest
    {
        /// <summary>
        /// The prompt describing the desired edit.<br/>
        /// Example: Change the background to a beach sunset.
        /// </summary>
        /// <example>Change the background to a beach sunset.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Images to edit (max 10 images, max size 10MB each); JPEG, WebP and PNG formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<byte[]>? Images { get; set; }

        /// <summary>
        /// URLs to Ideogram images to use as references (max 10). Supports URLs from generation responses and image uploads. Alternative to uploading via the images field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_urls")]
        public global::System.Collections.Generic.IList<string>? ImageUrls { get; set; }

        /// <summary>
        /// The number of images to generate.<br/>
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
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </summary>
        /// <example>ON</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptOptionJsonConverter))]
        public global::Ideogram.MagicPromptOption? MagicPrompt { get; set; }

        /// <summary>
        /// The resolutions supported for Ideogram 3.0.<br/>
        /// Example: 1280x800
        /// </summary>
        /// <example>1280x800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ResolutionV3JsonConverter))]
        public global::Ideogram.ResolutionV3? Resolution { get; set; }

        /// <summary>
        /// The aspect ratio to use for image generation, which determines the image's resolution. Cannot be used in conjunction with resolution. Defaults to 1x1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AspectRatioV3JsonConverter))]
        public global::Ideogram.AspectRatioV3? AspectRatio { get; set; }

        /// <summary>
        /// Whether the output should have a transparent background. Default false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transparent_background")]
        public bool? TransparentBackground { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1EditImagesRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt describing the desired edit.<br/>
        /// Example: Change the background to a beach sunset.
        /// </param>
        /// <param name="images">
        /// Images to edit (max 10 images, max size 10MB each); JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="imageUrls">
        /// URLs to Ideogram images to use as references (max 10). Supports URLs from generation responses and image uploads. Alternative to uploading via the images field.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="magicPrompt">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.<br/>
        /// Example: 1280x800
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio to use for image generation, which determines the image's resolution. Cannot be used in conjunction with resolution. Defaults to 1x1.
        /// </param>
        /// <param name="transparentBackground">
        /// Whether the output should have a transparent background. Default false.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1EditImagesRequest(
            string prompt,
            global::System.Collections.Generic.IList<byte[]>? images,
            global::System.Collections.Generic.IList<string>? imageUrls,
            int? numImages,
            int? seed,
            global::Ideogram.MagicPromptOption? magicPrompt,
            global::Ideogram.ResolutionV3? resolution,
            global::Ideogram.AspectRatioV3? aspectRatio,
            bool? transparentBackground)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Images = images;
            this.ImageUrls = imageUrls;
            this.NumImages = numImages;
            this.Seed = seed;
            this.MagicPrompt = magicPrompt;
            this.Resolution = resolution;
            this.AspectRatio = aspectRatio;
            this.TransparentBackground = transparentBackground;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1EditImagesRequest" /> class.
        /// </summary>
        public V1EditImagesRequest()
        {
        }
    }
}