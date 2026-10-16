
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerateImagePImageIdeogramRequest
    {
        /// <summary>
        /// The prompt to generate images from, in natural language or as a<br/>
        /// structured Ideogram 4.0 JSON prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Controls magic prompt (automatic prompt rewriting). `off` disables magic prompt entirely. Defaults to `auto`.<br/>
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
        /// The generation quality level. Defaults to `medium`.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.GenerationQualityJsonConverter))]
        public global::Ideogram.V2.GenerationQuality? Quality { get; set; }

        /// <summary>
        /// The output size tier. Defaults to `1k`. Cannot be combined with `custom_width`/`custom_height`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public global::Ideogram.V2.GenerateImagePImageIdeogramRequestResolution? Resolution { get; set; }

        /// <summary>
        /// The output aspect ratio. Defaults to `1x1`.<br/>
        /// Default Value: 1x1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.AspectRatioV3JsonConverter))]
        public global::Ideogram.V2.AspectRatioV3? AspectRatio { get; set; }

        /// <summary>
        /// Optional. An exact output width in pixels, used together with<br/>
        /// `custom_height` for output sizes outside the preset tiers. Must<br/>
        /// be a positive multiple of 16 between 16 and 4096, and<br/>
        /// `custom_width` × `custom_height` must not exceed 4,194,304 pixels<br/>
        /// (2048×2048). Cannot be combined with `resolution` or<br/>
        /// `aspect_ratio`; the request is billed at the resolution tier<br/>
        /// matching its total pixel count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_width")]
        public int? CustomWidth { get; set; }

        /// <summary>
        /// Optional. An exact output height in pixels, used together with<br/>
        /// `custom_width`. See `custom_width` for the accepted range and<br/>
        /// billing behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_height")]
        public int? CustomHeight { get; set; }

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
        /// Initializes a new instance of the <see cref="GenerateImagePImageIdeogramRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to generate images from, in natural language or as a<br/>
        /// structured Ideogram 4.0 JSON prompt.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). `off` disables magic prompt entirely. Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="quality">
        /// The generation quality level. Defaults to `medium`.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="resolution">
        /// The output size tier. Defaults to `1k`. Cannot be combined with `custom_width`/`custom_height`.
        /// </param>
        /// <param name="aspectRatio">
        /// The output aspect ratio. Defaults to `1x1`.<br/>
        /// Default Value: 1x1
        /// </param>
        /// <param name="customWidth">
        /// Optional. An exact output width in pixels, used together with<br/>
        /// `custom_height` for output sizes outside the preset tiers. Must<br/>
        /// be a positive multiple of 16 between 16 and 4096, and<br/>
        /// `custom_width` × `custom_height` must not exceed 4,194,304 pixels<br/>
        /// (2048×2048). Cannot be combined with `resolution` or<br/>
        /// `aspect_ratio`; the request is billed at the resolution tier<br/>
        /// matching its total pixel count.
        /// </param>
        /// <param name="customHeight">
        /// Optional. An exact output height in pixels, used together with<br/>
        /// `custom_width`. See `custom_width` for the accepted range and<br/>
        /// billing behavior.
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
        public GenerateImagePImageIdeogramRequest(
            string prompt,
            global::Ideogram.V2.MagicPromptMode? magicPrompt,
            int? seed,
            int? numImages,
            global::Ideogram.V2.GenerationQuality? quality,
            global::Ideogram.V2.GenerateImagePImageIdeogramRequestResolution? resolution,
            global::Ideogram.V2.AspectRatioV3? aspectRatio,
            int? customWidth,
            int? customHeight,
            bool? enableCopyrightDetection,
            bool? async,
            string? webhookUrl)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.MagicPrompt = magicPrompt;
            this.Seed = seed;
            this.NumImages = numImages;
            this.Quality = quality;
            this.Resolution = resolution;
            this.AspectRatio = aspectRatio;
            this.CustomWidth = customWidth;
            this.CustomHeight = customHeight;
            this.EnableCopyrightDetection = enableCopyrightDetection;
            this.Async = async;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImagePImageIdeogramRequest" /> class.
        /// </summary>
        public GenerateImagePImageIdeogramRequest()
        {
        }

    }
}