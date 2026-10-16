
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerateImageIdeogramV4CustomModelRequest
    {
        /// <summary>
        /// The prompt to generate images from, in natural language or as a<br/>
        /// structured Ideogram 4.0 JSON prompt. A structured JSON prompt is<br/>
        /// used as is and skips magic prompt unless `magic_prompt` is `on`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The custom model URI, in the form `model/&lt;model_name&gt;/version/&lt;version_name&gt;`. You or your organization must have access to the model. The model determines which rendering speeds are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_model_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomModelUri { get; set; }

        /// <summary>
        /// Remove the background after generation and return transparent PNG images. Included in the custom model generation price at no extra charge. When false, the model's automatic background removal behavior still applies.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transparent_background")]
        public bool? TransparentBackground { get; set; }

        /// <summary>
        /// Controls how a natural-language prompt is prepared. `auto` (the<br/>
        /// default) and `on` rewrite and expand the prompt before generation.<br/>
        /// `off` keeps your wording and only converts it into a structured<br/>
        /// prompt. A valid structured JSON prompt skips magic prompt unless<br/>
        /// `magic_prompt` is `on`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.MagicPromptModeJsonConverter))]
        public global::Ideogram.V2.MagicPromptMode? MagicPrompt { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Optional. When supplied, the images are generated at this<br/>
        /// resolution. When omitted, an aspect ratio is picked automatically<br/>
        /// based on the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.ResolutionV4JsonConverter))]
        public global::Ideogram.V2.ResolutionV4? Resolution { get; set; }

        /// <summary>
        /// The rendering speed to use. When omitted, a speed supported by the custom model is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.GenerateImageIdeogramV4CustomModelRequestRenderingSpeedJsonConverter))]
        public global::Ideogram.V2.GenerateImageIdeogramV4CustomModelRequestRenderingSpeed? RenderingSpeed { get; set; }

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
        /// Initializes a new instance of the <see cref="GenerateImageIdeogramV4CustomModelRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to generate images from, in natural language or as a<br/>
        /// structured Ideogram 4.0 JSON prompt. A structured JSON prompt is<br/>
        /// used as is and skips magic prompt unless `magic_prompt` is `on`.
        /// </param>
        /// <param name="customModelUri">
        /// The custom model URI, in the form `model/&lt;model_name&gt;/version/&lt;version_name&gt;`. You or your organization must have access to the model. The model determines which rendering speeds are supported.
        /// </param>
        /// <param name="transparentBackground">
        /// Remove the background after generation and return transparent PNG images. Included in the custom model generation price at no extra charge. When false, the model's automatic background removal behavior still applies.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="magicPrompt">
        /// Controls how a natural-language prompt is prepared. `auto` (the<br/>
        /// default) and `on` rewrite and expand the prompt before generation.<br/>
        /// `off` keeps your wording and only converts it into a structured<br/>
        /// prompt. A valid structured JSON prompt skips magic prompt unless<br/>
        /// `magic_prompt` is `on`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="resolution">
        /// Optional. When supplied, the images are generated at this<br/>
        /// resolution. When omitted, an aspect ratio is picked automatically<br/>
        /// based on the prompt.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. When omitted, a speed supported by the custom model is used.
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
        public GenerateImageIdeogramV4CustomModelRequest(
            string prompt,
            string customModelUri,
            bool? transparentBackground,
            global::Ideogram.V2.MagicPromptMode? magicPrompt,
            int? seed,
            int? numImages,
            global::Ideogram.V2.ResolutionV4? resolution,
            global::Ideogram.V2.GenerateImageIdeogramV4CustomModelRequestRenderingSpeed? renderingSpeed,
            bool? enableCopyrightDetection,
            bool? async,
            string? webhookUrl)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.CustomModelUri = customModelUri ?? throw new global::System.ArgumentNullException(nameof(customModelUri));
            this.TransparentBackground = transparentBackground;
            this.MagicPrompt = magicPrompt;
            this.Seed = seed;
            this.NumImages = numImages;
            this.Resolution = resolution;
            this.RenderingSpeed = renderingSpeed;
            this.EnableCopyrightDetection = enableCopyrightDetection;
            this.Async = async;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageIdeogramV4CustomModelRequest" /> class.
        /// </summary>
        public GenerateImageIdeogramV4CustomModelRequest()
        {
        }

    }
}