
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagesInpaintPostInpaintImageV2IdeogramV3CustomModelRequest
    {
        /// <summary>
        /// The prompt describing the repainted result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The custom model URI returned by the custom-model API, in the form `model/&lt;model_name&gt;/version/&lt;version_name&gt;`. The authenticated user or organization must have access to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_model_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomModelUri { get; set; }

        /// <summary>
        /// The source image to repaint (max 25MB), as JPEG, PNG, or WEBP. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The source image to repaint (max 25MB), as JPEG, PNG, or WEBP. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// A black-and-white mask the same size as the source image, as JPEG, PNG, or WEBP. Black marks the region to repaint. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Mask { get; set; }

        /// <summary>
        /// A black-and-white mask the same size as the source image, as JPEG, PNG, or WEBP. Black marks the region to repaint. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Maskname { get; set; }

        /// <summary>
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptModeJsonConverter))]
        public global::Ideogram.MagicPromptMode? MagicPrompt { get; set; }

        /// <summary>
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The rendering speed to use. When omitted, the server chooses a speed supported by the selected custom model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.V2ImageInpaintIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter))]
        public global::Ideogram.V2ImageInpaintIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? RenderingSpeed { get; set; }

        /// <summary>
        /// A predefined style preset. Cannot be combined with style codes or style references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.IdeogramV3StylePresetJsonConverter))]
        public global::Ideogram.IdeogramV3StylePreset? StylePreset { get; set; }

        /// <summary>
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_codes")]
        public global::System.Collections.Generic.IList<string>? StyleCodes { get; set; }

        /// <summary>
        /// Images to use as style references (max 10, max 25MB each), as JPEG, PNG, or WEBP.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? StyleReferenceImages { get; set; }

        /// <summary>
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images return `is_image_safe: false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_copyright_detection")]
        public bool? EnableCopyrightDetection { get; set; }

        /// <summary>
        /// When false, wait until the images are ready. When true, return as soon as the request is accepted and poll `GET /v2/generations/{generation_id}`.<br/>
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
        /// Initializes a new instance of the <see cref="ImagesInpaintPostInpaintImageV2IdeogramV3CustomModelRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt describing the repainted result.
        /// </param>
        /// <param name="customModelUri">
        /// The custom model URI returned by the custom-model API, in the form `model/&lt;model_name&gt;/version/&lt;version_name&gt;`. The authenticated user or organization must have access to the model.
        /// </param>
        /// <param name="image">
        /// The source image to repaint (max 25MB), as JPEG, PNG, or WEBP. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image to repaint (max 25MB), as JPEG, PNG, or WEBP. Multipart requests only.
        /// </param>
        /// <param name="mask">
        /// A black-and-white mask the same size as the source image, as JPEG, PNG, or WEBP. Black marks the region to repaint. Multipart requests only.
        /// </param>
        /// <param name="maskname">
        /// A black-and-white mask the same size as the source image, as JPEG, PNG, or WEBP. Black marks the region to repaint. Multipart requests only.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. When omitted, the server chooses a speed supported by the selected custom model.
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset. Cannot be combined with style codes or style references.
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.
        /// </param>
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max 25MB each), as JPEG, PNG, or WEBP.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images return `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false, wait until the images are ready. When true, return as soon as the request is accepted and poll `GET /v2/generations/{generation_id}`.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagesInpaintPostInpaintImageV2IdeogramV3CustomModelRequest(
            string prompt,
            string customModelUri,
            byte[] image,
            string imagename,
            byte[] mask,
            string maskname,
            global::Ideogram.MagicPromptMode? magicPrompt,
            int? numImages,
            int? seed,
            global::Ideogram.V2ImageInpaintIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed,
            global::Ideogram.IdeogramV3StylePreset? stylePreset,
            global::System.Collections.Generic.IList<string>? styleCodes,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages,
            bool? enableCopyrightDetection,
            bool? async)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.CustomModelUri = customModelUri ?? throw new global::System.ArgumentNullException(nameof(customModelUri));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Mask = mask ?? throw new global::System.ArgumentNullException(nameof(mask));
            this.Maskname = maskname ?? throw new global::System.ArgumentNullException(nameof(maskname));
            this.MagicPrompt = magicPrompt;
            this.NumImages = numImages;
            this.Seed = seed;
            this.RenderingSpeed = renderingSpeed;
            this.StylePreset = stylePreset;
            this.StyleCodes = styleCodes;
            this.StyleReferenceImages = styleReferenceImages;
            this.EnableCopyrightDetection = enableCopyrightDetection;
            this.Async = async;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesInpaintPostInpaintImageV2IdeogramV3CustomModelRequest" /> class.
        /// </summary>
        public ImagesInpaintPostInpaintImageV2IdeogramV3CustomModelRequest()
        {
        }

    }
}