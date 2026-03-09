
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TryOnRequestV3
    {
        /// <summary>
        /// The image containing a person wearing clothing to be modified (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public byte[] Image { get; set; } = default!;

        /// <summary>
        /// The image containing a person wearing clothing to be modified (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Imagename { get; set; } = default!;

        /// <summary>
        /// The prompt describing the desired clothing change.<br/>
        /// Example: Change his shirt to a pink shirt
        /// </summary>
        /// <example>Change his shirt to a pink shirt</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </summary>
        /// <example>ON</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptOptionJsonConverter))]
        public global::Ideogram.MagicPromptOption? MagicPrompt { get; set; }

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
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.RenderingSpeedJsonConverter))]
        public global::Ideogram.RenderingSpeed? RenderingSpeed { get; set; }

        /// <summary>
        /// The style type to generate with.<br/>
        /// Default Value: GENERAL<br/>
        /// Example: GENERAL
        /// </summary>
        /// <example>GENERAL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.StyleTypeV3JsonConverter))]
        public global::Ideogram.StyleTypeV3? StyleType { get; set; }

        /// <summary>
        /// A predefined style preset that applies a specific artistic style to the generated image.<br/>
        /// Example: BRIGHT_ART
        /// </summary>
        /// <example>BRIGHT_ART</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.StylePresetV3JsonConverter))]
        public global::Ideogram.StylePresetV3? StylePreset { get; set; }

        /// <summary>
        /// An image to use as the product reference for the try-on (exactly 1 image required). The image should be in JPEG, PNG or WebP format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_reference_images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<byte[]> ProductReferenceImages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TryOnRequestV3" /> class.
        /// </summary>
        /// <param name="image">
        /// The image containing a person wearing clothing to be modified (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imagename">
        /// The image containing a person wearing clothing to be modified (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="prompt">
        /// The prompt describing the desired clothing change.<br/>
        /// Example: Change his shirt to a pink shirt
        /// </param>
        /// <param name="magicPrompt">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="styleType">
        /// The style type to generate with.<br/>
        /// Default Value: GENERAL<br/>
        /// Example: GENERAL
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset that applies a specific artistic style to the generated image.<br/>
        /// Example: BRIGHT_ART
        /// </param>
        /// <param name="productReferenceImages">
        /// An image to use as the product reference for the try-on (exactly 1 image required). The image should be in JPEG, PNG or WebP format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TryOnRequestV3(
            byte[] image,
            string imagename,
            string prompt,
            global::System.Collections.Generic.IList<byte[]> productReferenceImages,
            global::Ideogram.MagicPromptOption? magicPrompt,
            int? numImages,
            int? seed,
            global::Ideogram.RenderingSpeed? renderingSpeed,
            global::Ideogram.StyleTypeV3? styleType,
            global::Ideogram.StylePresetV3? stylePreset)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ProductReferenceImages = productReferenceImages ?? throw new global::System.ArgumentNullException(nameof(productReferenceImages));
            this.MagicPrompt = magicPrompt;
            this.NumImages = numImages;
            this.Seed = seed;
            this.RenderingSpeed = renderingSpeed;
            this.StyleType = styleType;
            this.StylePreset = stylePreset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TryOnRequestV3" /> class.
        /// </summary>
        public TryOnRequestV3()
        {
        }
    }
}