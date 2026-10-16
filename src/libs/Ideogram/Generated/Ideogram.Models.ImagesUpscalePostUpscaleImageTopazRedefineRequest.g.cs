
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagesUpscalePostUpscaleImageTopazRedefineRequest
    {
        /// <summary>
        /// The source image to upscale, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The source image to upscale, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// How much to enlarge the source image: 2x, 4x, or 8x its original width and height. Rejected when the output would exceed 8192px on either side.<br/>
        /// Default Value: x2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscale_factor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactorJsonConverter))]
        public global::Ideogram.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor? UpscaleFactor { get; set; }

        /// <summary>
        /// An optional prompt guiding the detail the model regenerates while enlarging the image. Leave empty to enhance the source image as-is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// How strongly the model reinterprets the source while enlarging it, from 1 (most faithful) to 9 (most creative).<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creativity")]
        public int? Creativity { get; set; }

        /// <summary>
        /// When true, the model describes the image itself and any `prompt` is ignored.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoprompt")]
        public bool? Autoprompt { get; set; }

        /// <summary>
        /// How much fine texture the model adds, from 1 to 5. Keep it low at low creativity.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture")]
        public int? Texture { get; set; }

        /// <summary>
        /// Apply a detail adjustment after rendering. When true, `detail_strength` sets how much.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public bool? Detail { get; set; }

        /// <summary>
        /// Detail adjustment intensity, from 0 to 10.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail_strength")]
        public string? DetailStrength { get; set; }

        /// <summary>
        /// Edge sharpening applied after enlarging, from 0 to 1. Omit to let the model choose per image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharpen")]
        public string? Sharpen { get; set; }

        /// <summary>
        /// Noise and grain reduction, from 0 to 1. Omit to let the model choose per image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("denoise")]
        public string? Denoise { get; set; }

        /// <summary>
        /// Recover detail in faces. When true, `face_enhancement_strength` and `face_enhancement_creativity` are required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_enhancement")]
        public bool? FaceEnhancement { get; set; }

        /// <summary>
        /// How strongly faces are recovered, from 0 to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_enhancement_strength")]
        public string? FaceEnhancementStrength { get; set; }

        /// <summary>
        /// How freely face recovery may reinterpret features, from 0 (faithful) to 1 (creative).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_enhancement_creativity")]
        public string? FaceEnhancementCreativity { get; set; }

        /// <summary>
        /// Where enhancements apply. Omit to let the model choose per image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_detection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetectionJsonConverter))]
        public global::Ideogram.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection? SubjectDetection { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// When false (the default), the request blocks until the upscaled image is ready and returns it in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` for the result.<br/>
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
        /// Initializes a new instance of the <see cref="ImagesUpscalePostUpscaleImageTopazRedefineRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The source image to upscale, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </param>
        /// <param name="imagename">
        /// The source image to upscale, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </param>
        /// <param name="upscaleFactor">
        /// How much to enlarge the source image: 2x, 4x, or 8x its original width and height. Rejected when the output would exceed 8192px on either side.<br/>
        /// Default Value: x2
        /// </param>
        /// <param name="prompt">
        /// An optional prompt guiding the detail the model regenerates while enlarging the image. Leave empty to enhance the source image as-is.
        /// </param>
        /// <param name="creativity">
        /// How strongly the model reinterprets the source while enlarging it, from 1 (most faithful) to 9 (most creative).<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="autoprompt">
        /// When true, the model describes the image itself and any `prompt` is ignored.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="texture">
        /// How much fine texture the model adds, from 1 to 5. Keep it low at low creativity.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="detail">
        /// Apply a detail adjustment after rendering. When true, `detail_strength` sets how much.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="detailStrength">
        /// Detail adjustment intensity, from 0 to 10.
        /// </param>
        /// <param name="sharpen">
        /// Edge sharpening applied after enlarging, from 0 to 1. Omit to let the model choose per image.
        /// </param>
        /// <param name="denoise">
        /// Noise and grain reduction, from 0 to 1. Omit to let the model choose per image.
        /// </param>
        /// <param name="faceEnhancement">
        /// Recover detail in faces. When true, `face_enhancement_strength` and `face_enhancement_creativity` are required.
        /// </param>
        /// <param name="faceEnhancementStrength">
        /// How strongly faces are recovered, from 0 to 1.
        /// </param>
        /// <param name="faceEnhancementCreativity">
        /// How freely face recovery may reinterpret features, from 0 (faithful) to 1 (creative).
        /// </param>
        /// <param name="subjectDetection">
        /// Where enhancements apply. Omit to let the model choose per image.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request blocks until the upscaled image is ready and returns it in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` for the result.<br/>
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
        public ImagesUpscalePostUpscaleImageTopazRedefineRequest(
            byte[] image,
            string imagename,
            global::Ideogram.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor? upscaleFactor,
            string? prompt,
            int? creativity,
            bool? autoprompt,
            int? texture,
            bool? detail,
            string? detailStrength,
            string? sharpen,
            string? denoise,
            bool? faceEnhancement,
            string? faceEnhancementStrength,
            string? faceEnhancementCreativity,
            global::Ideogram.V2ImageUpscaleTopazRedefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection? subjectDetection,
            int? seed,
            bool? async,
            string? webhookUrl)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.UpscaleFactor = upscaleFactor;
            this.Prompt = prompt;
            this.Creativity = creativity;
            this.Autoprompt = autoprompt;
            this.Texture = texture;
            this.Detail = detail;
            this.DetailStrength = detailStrength;
            this.Sharpen = sharpen;
            this.Denoise = denoise;
            this.FaceEnhancement = faceEnhancement;
            this.FaceEnhancementStrength = faceEnhancementStrength;
            this.FaceEnhancementCreativity = faceEnhancementCreativity;
            this.SubjectDetection = subjectDetection;
            this.Seed = seed;
            this.Async = async;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesUpscalePostUpscaleImageTopazRedefineRequest" /> class.
        /// </summary>
        public ImagesUpscalePostUpscaleImageTopazRedefineRequest()
        {
        }

    }
}