
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagesGeneratePostGenerateImageV2Ideogram46Request
    {
        /// <summary>
        /// The prompt to generate images from, or the edit instruction when<br/>
        /// source images are supplied. Natural language or a structured<br/>
        /// Ideogram 4.0 JSON prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Controls how a natural-language prompt is prepared. `auto` (the<br/>
        /// default) and `on` rewrite and expand the prompt before generation.<br/>
        /// `off` keeps your wording and only converts it into a structured<br/>
        /// prompt. A valid structured JSON prompt skips magic prompt unless<br/>
        /// `magic_prompt` is `on`. With source images, every mode converts<br/>
        /// the edit instruction into a structured edit prompt.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.MagicPromptModeJsonConverter))]
        public global::Ideogram.V2.MagicPromptMode? MagicPrompt { get; set; }

        /// <summary>
        /// Optional source images to edit (max 5, max 25MB each; JPEG, PNG, or WEBP). The first image is the one being edited; any others are extra references. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<byte[]>? Images { get; set; }

        /// <summary>
        /// An optional mask that limits the edit to part of the first source image (max 25MB; JPEG, PNG, or WEBP). Multipart requests only. Black marks the area to edit and white the area to keep; values in between are rounded to the nearer of the two. The mask must have the same width and height as the first source image and contain both black and white areas. A masked request can include at most three other source images. With a mask, the output is always the first source image's own size, so `size` cannot be set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public byte[]? Mask { get; set; }

        /// <summary>
        /// An optional mask that limits the edit to part of the first source image (max 25MB; JPEG, PNG, or WEBP). Multipart requests only. Black marks the area to edit and white the area to keep; values in between are rounded to the nearer of the two. The mask must have the same width and height as the first source image and contain both black and white areas. A masked request can include at most three other source images. With a mask, the output is always the first source image's own size, so `size` cannot be set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskname")]
        public string? Maskname { get; set; }

        /// <summary>
        /// The output size: "auto", "auto_2k", "auto_4k", "source" or an<br/>
        /// exact "WIDTHxHEIGHT".<br/>
        /// Without source images, "auto" or omitted picks an aspect ratio based on the prompt and<br/>
        /// renders it at the default resolution, currently 2K. "auto_2k" and<br/>
        /// "auto_4k" also pick the aspect ratio from the prompt, but always<br/>
        /// render it at 2K or 4K. "auto_4k" is not available at `very_low`<br/>
        /// quality. "source" is rejected.<br/>
        /// With source images, "auto" (the default) picks a size based on the<br/>
        /// source images and the prompt at the default resolution, currently<br/>
        /// 2K. "auto_2k" and "auto_4k" make the same pick, but always at 2K or<br/>
        /// 4K. "auto_4k" is not available at `very_low` quality. "source"<br/>
        /// returns the output at the first source image's own width and height<br/>
        /// (scaled down, keeping its proportions, if it is too large for the<br/>
        /// model). Every source image's aspect ratio must be between 1:6 and<br/>
        /// 6:1.<br/>
        /// An exact size must have both sides a multiple of 32 and at least<br/>
        /// 256px, no side longer than 8192px, a total of at most 4096x4096<br/>
        /// pixels, and an aspect ratio of at most 6:1. At `very_low` quality<br/>
        /// the total is at most 2048x2048 pixels and no side may be longer<br/>
        /// than 4608px. With source images, an exact size reshapes the source<br/>
        /// to it.<br/>
        /// Pricing is tiered by the resolved output pixels: up to 1024x1024<br/>
        /// bills as 1K, up to 2048x2048 as 2K, and above that as 4K. "auto"<br/>
        /// bills at the default resolution, currently 2K; "auto_2k" always<br/>
        /// bills as 2K and "auto_4k" always bills as 4K.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// The output background. `transparent` returns images with an alpha channel, `opaque` returns a solid one, and `auto` decides for you.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaBackgroundJsonConverter))]
        public global::Ideogram.V2.V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaBackground? Background { get; set; }

        /// <summary>
        /// The rendering quality to use. Higher quality takes longer and costs more. Defaults to `medium`. `very_low` is the fastest and cheapest, and renders up to 2K (2048x2048 total pixels).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaQualityJsonConverter))]
        public global::Ideogram.V2.V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality? Quality { get; set; }

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
        /// Initializes a new instance of the <see cref="ImagesGeneratePostGenerateImageV2Ideogram46Request" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to generate images from, or the edit instruction when<br/>
        /// source images are supplied. Natural language or a structured<br/>
        /// Ideogram 4.0 JSON prompt.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls how a natural-language prompt is prepared. `auto` (the<br/>
        /// default) and `on` rewrite and expand the prompt before generation.<br/>
        /// `off` keeps your wording and only converts it into a structured<br/>
        /// prompt. A valid structured JSON prompt skips magic prompt unless<br/>
        /// `magic_prompt` is `on`. With source images, every mode converts<br/>
        /// the edit instruction into a structured edit prompt.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="images">
        /// Optional source images to edit (max 5, max 25MB each; JPEG, PNG, or WEBP). The first image is the one being edited; any others are extra references. Multipart requests only.
        /// </param>
        /// <param name="mask">
        /// An optional mask that limits the edit to part of the first source image (max 25MB; JPEG, PNG, or WEBP). Multipart requests only. Black marks the area to edit and white the area to keep; values in between are rounded to the nearer of the two. The mask must have the same width and height as the first source image and contain both black and white areas. A masked request can include at most three other source images. With a mask, the output is always the first source image's own size, so `size` cannot be set.
        /// </param>
        /// <param name="maskname">
        /// An optional mask that limits the edit to part of the first source image (max 25MB; JPEG, PNG, or WEBP). Multipart requests only. Black marks the area to edit and white the area to keep; values in between are rounded to the nearer of the two. The mask must have the same width and height as the first source image and contain both black and white areas. A masked request can include at most three other source images. With a mask, the output is always the first source image's own size, so `size` cannot be set.
        /// </param>
        /// <param name="size">
        /// The output size: "auto", "auto_2k", "auto_4k", "source" or an<br/>
        /// exact "WIDTHxHEIGHT".<br/>
        /// Without source images, "auto" or omitted picks an aspect ratio based on the prompt and<br/>
        /// renders it at the default resolution, currently 2K. "auto_2k" and<br/>
        /// "auto_4k" also pick the aspect ratio from the prompt, but always<br/>
        /// render it at 2K or 4K. "auto_4k" is not available at `very_low`<br/>
        /// quality. "source" is rejected.<br/>
        /// With source images, "auto" (the default) picks a size based on the<br/>
        /// source images and the prompt at the default resolution, currently<br/>
        /// 2K. "auto_2k" and "auto_4k" make the same pick, but always at 2K or<br/>
        /// 4K. "auto_4k" is not available at `very_low` quality. "source"<br/>
        /// returns the output at the first source image's own width and height<br/>
        /// (scaled down, keeping its proportions, if it is too large for the<br/>
        /// model). Every source image's aspect ratio must be between 1:6 and<br/>
        /// 6:1.<br/>
        /// An exact size must have both sides a multiple of 32 and at least<br/>
        /// 256px, no side longer than 8192px, a total of at most 4096x4096<br/>
        /// pixels, and an aspect ratio of at most 6:1. At `very_low` quality<br/>
        /// the total is at most 2048x2048 pixels and no side may be longer<br/>
        /// than 4608px. With source images, an exact size reshapes the source<br/>
        /// to it.<br/>
        /// Pricing is tiered by the resolved output pixels: up to 1024x1024<br/>
        /// bills as 1K, up to 2048x2048 as 2K, and above that as 4K. "auto"<br/>
        /// bills at the default resolution, currently 2K; "auto_2k" always<br/>
        /// bills as 2K and "auto_4k" always bills as 4K.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="background">
        /// The output background. `transparent` returns images with an alpha channel, `opaque` returns a solid one, and `auto` decides for you.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="quality">
        /// The rendering quality to use. Higher quality takes longer and costs more. Defaults to `medium`. `very_low` is the fastest and cheapest, and renders up to 2K (2048x2048 total pixels).
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
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
        public ImagesGeneratePostGenerateImageV2Ideogram46Request(
            string prompt,
            global::Ideogram.V2.MagicPromptMode? magicPrompt,
            global::System.Collections.Generic.IList<byte[]>? images,
            byte[]? mask,
            string? maskname,
            string? size,
            global::Ideogram.V2.V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaBackground? background,
            global::Ideogram.V2.V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality? quality,
            int? seed,
            int? numImages,
            bool? enableCopyrightDetection,
            bool? async,
            string? webhookUrl)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.MagicPrompt = magicPrompt;
            this.Images = images;
            this.Mask = mask;
            this.Maskname = maskname;
            this.Size = size;
            this.Background = background;
            this.Quality = quality;
            this.Seed = seed;
            this.NumImages = numImages;
            this.EnableCopyrightDetection = enableCopyrightDetection;
            this.Async = async;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesGeneratePostGenerateImageV2Ideogram46Request" /> class.
        /// </summary>
        public ImagesGeneratePostGenerateImageV2Ideogram46Request()
        {
        }

    }
}