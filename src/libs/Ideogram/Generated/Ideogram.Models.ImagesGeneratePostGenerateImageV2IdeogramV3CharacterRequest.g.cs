
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagesGeneratePostGenerateImageV2IdeogramV3CharacterRequest
    {
        /// <summary>
        /// The prompt to generate images from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Description of what to exclude from the images. The prompt takes precedence over the negative prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// An image of the character to feature (max 25MB; JPEG, PNG, or WEBP).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_reference_images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> CharacterReferenceImages { get; set; }

        /// <summary>
        /// Optional grayscale mask marking where the character is in the character reference image, at the same size as that image (JPEG, PNG, or WEBP). Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_reference_mask")]
        public byte[]? CharacterReferenceMask { get; set; }

        /// <summary>
        /// Optional grayscale mask marking where the character is in the character reference image, at the same size as that image (JPEG, PNG, or WEBP). Multipart requests only.
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
        /// The aspect ratio for an Ideogram 3.x or 2.x generation. `auto` lets the<br/>
        /// model select a ratio from the prompt; any other value pins the ratio.<br/>
        /// Cannot be combined with `resolution`. Omitting the field is not `auto`:<br/>
        /// it uses `1x1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.IdeogramV3AspectRatioJsonConverter))]
        public global::Ideogram.IdeogramV3AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The rendering speed to use.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedJsonConverter))]
        public global::Ideogram.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? RenderingSpeed { get; set; }

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
        /// The style type to generate the character with. Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleTypeJsonConverter))]
        public global::Ideogram.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType? StyleType { get; set; }

        /// <summary>
        /// Images to use as style references (max 10, max 25MB each; JPEG, PNG, or WEBP).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? StyleReferenceImages { get; set; }

        /// <summary>
        /// Optional. Run copyright detection on the generated images. Adds latency; flagged images are returned with `is_image_safe: false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_copyright_detection")]
        public bool? EnableCopyrightDetection { get; set; }

        /// <summary>
        /// When false (the default), the request waits until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` with the returned `generation_id` for the result.<br/>
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
        /// Initializes a new instance of the <see cref="ImagesGeneratePostGenerateImageV2IdeogramV3CharacterRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to generate images from.
        /// </param>
        /// <param name="characterReferenceImages">
        /// An image of the character to feature (max 25MB; JPEG, PNG, or WEBP).
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from the images. The prompt takes precedence over the negative prompt.
        /// </param>
        /// <param name="characterReferenceMask">
        /// Optional grayscale mask marking where the character is in the character reference image, at the same size as that image (JPEG, PNG, or WEBP). Multipart requests only.
        /// </param>
        /// <param name="characterReferenceMaskname">
        /// Optional grayscale mask marking where the character is in the character reference image, at the same size as that image (JPEG, PNG, or WEBP). Multipart requests only.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio for an Ideogram 3.x or 2.x generation. `auto` lets the<br/>
        /// model select a ratio from the prompt; any other value pins the ratio.<br/>
        /// Cannot be combined with `resolution`. Omitting the field is not `auto`:<br/>
        /// it uses `1x1`.
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
        /// The style type to generate the character with. Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max 25MB each; JPEG, PNG, or WEBP).
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Run copyright detection on the generated images. Adds latency; flagged images are returned with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request waits until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` with the returned `generation_id` for the result.<br/>
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
        public ImagesGeneratePostGenerateImageV2IdeogramV3CharacterRequest(
            string prompt,
            global::System.Collections.Generic.IList<byte[]> characterReferenceImages,
            string? negativePrompt,
            byte[]? characterReferenceMask,
            string? characterReferenceMaskname,
            int? seed,
            global::Ideogram.ResolutionV3? resolution,
            global::Ideogram.IdeogramV3AspectRatio? aspectRatio,
            global::Ideogram.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed,
            global::Ideogram.MagicPromptMode? magicPrompt,
            int? numImages,
            global::Ideogram.V2ImageGenerateIdeogram3CharacterPostRequestBodyContentMultipartFormDataSchemaStyleType? styleType,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages,
            bool? enableCopyrightDetection,
            bool? async,
            string? webhookUrl)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
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
        /// Initializes a new instance of the <see cref="ImagesGeneratePostGenerateImageV2IdeogramV3CharacterRequest" /> class.
        /// </summary>
        public ImagesGeneratePostGenerateImageV2IdeogramV3CharacterRequest()
        {
        }

    }
}