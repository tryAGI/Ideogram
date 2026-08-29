
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Request to edit an image with a prompt.<br/>
    /// The `image` field identifies the image being edited; it drives the<br/>
    /// output aspect ratio and transparency decisions. Up to 9 additional<br/>
    /// reference images may be supplied via `reference_images`, for a total of<br/>
    /// 10 images.
    /// </summary>
    public sealed partial class V1EditLiteImagesRequest
    {
        /// <summary>
        /// The prompt describing the desired edit.<br/>
        /// Example: Remove the person from the photo.
        /// </summary>
        /// <example>Remove the person from the photo.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The image being edited (max size 25MB); JPEG, WebP and PNG formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The image being edited (max size 25MB); JPEG, WebP and PNG formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// Optional additional reference images to guide the edit (max 9, max size 25MB each); JPEG, WebP and PNG formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? ReferenceImages { get; set; }

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
        /// A base64url-encoded magic prompt system prompt config ID to use for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt_system_prompt_config_id")]
        public string? MagicPromptSystemPromptConfigId { get; set; }

        /// <summary>
        /// The aspect ratio of the edited output. When omitted, the output<br/>
        /// follows the aspect ratio of the image being edited.<br/>
        /// Example: 16x9
        /// </summary>
        /// <example>16x9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AspectRatioEditLiteJsonConverter))]
        public global::Ideogram.AspectRatioEditLite? AspectRatio { get; set; }

        /// <summary>
        /// Controls whether the edited output has a transparent background.<br/>
        /// - `TRANSPARENT`: the output is produced with a transparent background.<br/>
        /// - `OPAQUE`: the output is produced with an opaque background.<br/>
        /// - `AUTO`: the server decides based on the prompt and the image being<br/>
        ///   edited (e.g. whether it already has a transparent background). This is<br/>
        ///   the default. When the prompt asks only for background removal, the<br/>
        ///   output may be the edited image with its background removed.<br/>
        /// Default Value: AUTO
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transparency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.TransparencyOptionJsonConverter))]
        public global::Ideogram.TransparencyOption? Transparency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1EditLiteImagesRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt describing the desired edit.<br/>
        /// Example: Remove the person from the photo.
        /// </param>
        /// <param name="image">
        /// The image being edited (max size 25MB); JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The image being edited (max size 25MB); JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="referenceImages">
        /// Optional additional reference images to guide the edit (max 9, max size 25MB each); JPEG, WebP and PNG formats are supported.
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
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use for this request.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the edited output. When omitted, the output<br/>
        /// follows the aspect ratio of the image being edited.<br/>
        /// Example: 16x9
        /// </param>
        /// <param name="transparency">
        /// Controls whether the edited output has a transparent background.<br/>
        /// - `TRANSPARENT`: the output is produced with a transparent background.<br/>
        /// - `OPAQUE`: the output is produced with an opaque background.<br/>
        /// - `AUTO`: the server decides based on the prompt and the image being<br/>
        ///   edited (e.g. whether it already has a transparent background). This is<br/>
        ///   the default. When the prompt asks only for background removal, the<br/>
        ///   output may be the edited image with its background removed.<br/>
        /// Default Value: AUTO
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1EditLiteImagesRequest(
            string prompt,
            byte[] image,
            string imagename,
            global::System.Collections.Generic.IList<byte[]>? referenceImages,
            int? numImages,
            int? seed,
            global::Ideogram.MagicPromptOption? magicPrompt,
            string? magicPromptSystemPromptConfigId,
            global::Ideogram.AspectRatioEditLite? aspectRatio,
            global::Ideogram.TransparencyOption? transparency)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.ReferenceImages = referenceImages;
            this.NumImages = numImages;
            this.Seed = seed;
            this.MagicPrompt = magicPrompt;
            this.MagicPromptSystemPromptConfigId = magicPromptSystemPromptConfigId;
            this.AspectRatio = aspectRatio;
            this.Transparency = transparency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1EditLiteImagesRequest" /> class.
        /// </summary>
        public V1EditLiteImagesRequest()
        {
        }

    }
}