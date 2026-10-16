
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagesRemixPostRemixImageV2IdeogramV3CharacterRequest
    {
        /// <summary>
        /// The prompt that guides the remix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The image to transform (max 50MB). JPEG, PNG, and WEBP are supported. Multipart requests only. The uploaded image is saved to your account as the remix's source. Omit `resolution` and `aspect_ratio` to keep its shape; a different requested shape center-crops the source to fit first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The image to transform (max 50MB). JPEG, PNG, and WEBP are supported. Multipart requests only. The uploaded image is saved to your account as the remix's source. Omit `resolution` and `aspect_ratio` to keep its shape; a different requested shape center-crops the source to fit first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// Optional. How closely the result should follow the source image, from 1 to 100. When omitted the server chooses a value from your prompt, which is the usual case.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_weight")]
        public int? ImageWeight { get; set; }

        /// <summary>
        /// Description of what to exclude from the images. Descriptions in the prompt take precedence over descriptions in the negative prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// An image to use as the character reference (max 25MB). JPEG, PNG, and WEBP are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_reference_images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> CharacterReferenceImages { get; set; }

        /// <summary>
        /// Optional grayscale mask for the character reference image, the same size as that image, marking where the character is. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; cannot be combined with `character_reference_collection_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_reference_mask")]
        public byte[]? CharacterReferenceMask { get; set; }

        /// <summary>
        /// Optional grayscale mask for the character reference image, the same size as that image, marking where the character is. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; cannot be combined with `character_reference_collection_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_reference_maskname")]
        public string? CharacterReferenceMaskname { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The resolutions supported for Ideogram 3.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ResolutionV3JsonConverter))]
        public global::Ideogram.ResolutionV3? Resolution { get; set; }

        /// <summary>
        /// Output aspect ratio. Cannot be combined with resolution. Generation defaults to 1x1; remix keeps the source ratio when both fields are omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AspectRatioV3JsonConverter))]
        public global::Ideogram.AspectRatioV3? AspectRatio { get; set; }

        /// <summary>
        /// The rendering speed to use.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter))]
        public global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? RenderingSpeed { get; set; }

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
        /// The style type to remix the character with. Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleTypeJsonConverter))]
        public global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType? StyleType { get; set; }

        /// <summary>
        /// Images to use as style references (max 10, max 25MB each). JPEG, PNG, and WEBP are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? StyleReferenceImages { get; set; }

        /// <summary>
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_copyright_detection")]
        public bool? EnableCopyrightDetection { get; set; }

        /// <summary>
        /// When false (the default), the request waits until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v2/generations/{generation_id}` using the returned `generation_id`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public bool? Async { get; set; }

        /// <summary>
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesRemixPostRemixImageV2IdeogramV3CharacterRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt that guides the remix.
        /// </param>
        /// <param name="image">
        /// The image to transform (max 50MB). JPEG, PNG, and WEBP are supported. Multipart requests only. The uploaded image is saved to your account as the remix's source. Omit `resolution` and `aspect_ratio` to keep its shape; a different requested shape center-crops the source to fit first.
        /// </param>
        /// <param name="imagename">
        /// The image to transform (max 50MB). JPEG, PNG, and WEBP are supported. Multipart requests only. The uploaded image is saved to your account as the remix's source. Omit `resolution` and `aspect_ratio` to keep its shape; a different requested shape center-crops the source to fit first.
        /// </param>
        /// <param name="characterReferenceImages">
        /// An image to use as the character reference (max 25MB). JPEG, PNG, and WEBP are supported.
        /// </param>
        /// <param name="imageWeight">
        /// Optional. How closely the result should follow the source image, from 1 to 100. When omitted the server chooses a value from your prompt, which is the usual case.
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from the images. Descriptions in the prompt take precedence over descriptions in the negative prompt.
        /// </param>
        /// <param name="characterReferenceMask">
        /// Optional grayscale mask for the character reference image, the same size as that image, marking where the character is. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; cannot be combined with `character_reference_collection_id`.
        /// </param>
        /// <param name="characterReferenceMaskname">
        /// Optional grayscale mask for the character reference image, the same size as that image, marking where the character is. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; cannot be combined with `character_reference_collection_id`.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Cannot be combined with resolution. Generation defaults to 1x1; remix keeps the source ratio when both fields are omitted.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="styleType">
        /// The style type to remix the character with. Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max 25MB each). JPEG, PNG, and WEBP are supported.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request waits until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v2/generations/{generation_id}` using the returned `generation_id`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl">
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagesRemixPostRemixImageV2IdeogramV3CharacterRequest(
            string prompt,
            byte[] image,
            string imagename,
            global::System.Collections.Generic.IList<byte[]> characterReferenceImages,
            int? imageWeight,
            string? negativePrompt,
            byte[]? characterReferenceMask,
            string? characterReferenceMaskname,
            int? seed,
            global::Ideogram.ResolutionV3? resolution,
            global::Ideogram.AspectRatioV3? aspectRatio,
            global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed,
            global::Ideogram.MagicPromptMode? magicPrompt,
            int? numImages,
            global::Ideogram.V2ImageRemixIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType? styleType,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages,
            bool? enableCopyrightDetection,
            bool? async,
            string? webhookUrl)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.ImageWeight = imageWeight;
            this.NegativePrompt = negativePrompt;
            this.CharacterReferenceImages = characterReferenceImages ?? throw new global::System.ArgumentNullException(nameof(characterReferenceImages));
            this.CharacterReferenceMask = characterReferenceMask;
            this.CharacterReferenceMaskname = characterReferenceMaskname;
            this.Seed = seed;
            this.Resolution = resolution;
            this.AspectRatio = aspectRatio;
            this.RenderingSpeed = renderingSpeed;
            this.MagicPrompt = magicPrompt;
            this.NumImages = numImages;
            this.StyleType = styleType;
            this.StyleReferenceImages = styleReferenceImages;
            this.EnableCopyrightDetection = enableCopyrightDetection;
            this.Async = async;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesRemixPostRemixImageV2IdeogramV3CharacterRequest" /> class.
        /// </summary>
        public ImagesRemixPostRemixImageV2IdeogramV3CharacterRequest()
        {
        }

    }
}