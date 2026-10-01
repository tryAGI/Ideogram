
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Source `images` are optional. When supplied, the request edits them<br/>
    /// and `size` defaults to "auto". A prompt is required either way.
    /// </summary>
    public sealed partial class GenerateImageIdeogram45Request
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptModeJsonConverter))]
        public global::Ideogram.MagicPromptMode? MagicPrompt { get; set; }

        /// <summary>
        /// Existing upload or generated image assets to transform, by reference. Takes priority over `images` if both are supplied. The first source is the primary image; any further sources are additional references. Supplying sources turns the request into an image-to-image transform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? ImageAssetIdentifiers { get; set; }

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
        /// The output size: "auto", "source" or an exact "WIDTHxHEIGHT".<br/>
        /// Without source images, an exact size must be one of the supported<br/>
        /// 1K/2K presets (for example 1024x1024, 2048x2048 or 1440x2880);<br/>
        /// "auto" or omitted picks a supported size based on the prompt.<br/>
        /// "source" is rejected.<br/>
        /// With source images, "auto" (the default) picks a supported 2K size<br/>
        /// based on the source images and the prompt, and "source" returns the<br/>
        /// output at the first source image's own width and height (scaled<br/>
        /// down, keeping its proportions, if it is too large for the model).<br/>
        /// Every source image's aspect ratio must be between 1:6 and 6:1.<br/>
        /// An exact size must have both sides a multiple of 32 and at least<br/>
        /// 256px, a total of at most 2048x2048 pixels, and an aspect ratio of<br/>
        /// at most 6:1. With source images, an exact size reshapes the source<br/>
        /// to it.<br/>
        /// Pricing is tiered by the resolved output pixels: up to 1024x1024<br/>
        /// bills as 1K, above that as 2K. An "auto" size bills as 2K.<br/>
        /// Default Value: auto<br/>
        /// Example: 2048x2048
        /// </summary>
        /// <example>2048x2048</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// The rendering quality to use. Higher quality takes longer and costs more. Defaults to `medium` with source images and `high` without. `very_low`, the fastest and cheapest, requires source images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GenerateImageIdeogram45RequestQualityJsonConverter))]
        public global::Ideogram.GenerateImageIdeogram45RequestQuality? Quality { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
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
        /// private and loopback hosts and the cloud metadata service are rejected.<br/>
        /// Example: https://api.example.com/webhooks/ideogram
        /// </summary>
        /// <example>https://api.example.com/webhooks/ideogram</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// A collection you can write to, by its URL-safe base64 collection id. The output images are added to it when the request completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_collection_id")]
        public string? TargetCollectionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageIdeogram45Request" /> class.
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
        /// <param name="imageAssetIdentifiers">
        /// Existing upload or generated image assets to transform, by reference. Takes priority over `images` if both are supplied. The first source is the primary image; any further sources are additional references. Supplying sources turns the request into an image-to-image transform.
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
        /// The output size: "auto", "source" or an exact "WIDTHxHEIGHT".<br/>
        /// Without source images, an exact size must be one of the supported<br/>
        /// 1K/2K presets (for example 1024x1024, 2048x2048 or 1440x2880);<br/>
        /// "auto" or omitted picks a supported size based on the prompt.<br/>
        /// "source" is rejected.<br/>
        /// With source images, "auto" (the default) picks a supported 2K size<br/>
        /// based on the source images and the prompt, and "source" returns the<br/>
        /// output at the first source image's own width and height (scaled<br/>
        /// down, keeping its proportions, if it is too large for the model).<br/>
        /// Every source image's aspect ratio must be between 1:6 and 6:1.<br/>
        /// An exact size must have both sides a multiple of 32 and at least<br/>
        /// 256px, a total of at most 2048x2048 pixels, and an aspect ratio of<br/>
        /// at most 6:1. With source images, an exact size reshapes the source<br/>
        /// to it.<br/>
        /// Pricing is tiered by the resolved output pixels: up to 1024x1024<br/>
        /// bills as 1K, above that as 2K. An "auto" size bills as 2K.<br/>
        /// Default Value: auto<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="quality">
        /// The rendering quality to use. Higher quality takes longer and costs more. Defaults to `medium` with source images and `high` without. `very_low`, the fastest and cheapest, requires source images.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
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
        /// private and loopback hosts and the cloud metadata service are rejected.<br/>
        /// Example: https://api.example.com/webhooks/ideogram
        /// </param>
        /// <param name="private">
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. The output images are added to it when the request completes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageIdeogram45Request(
            string prompt,
            global::Ideogram.MagicPromptMode? magicPrompt,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? imageAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? images,
            byte[]? mask,
            string? maskname,
            string? size,
            global::Ideogram.GenerateImageIdeogram45RequestQuality? quality,
            int? seed,
            int? numImages,
            bool? enableCopyrightDetection,
            bool? async,
            string? webhookUrl,
            bool? @private,
            string? targetCollectionId)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.MagicPrompt = magicPrompt;
            this.ImageAssetIdentifiers = imageAssetIdentifiers;
            this.Images = images;
            this.Mask = mask;
            this.Maskname = maskname;
            this.Size = size;
            this.Quality = quality;
            this.Seed = seed;
            this.NumImages = numImages;
            this.EnableCopyrightDetection = enableCopyrightDetection;
            this.Async = async;
            this.WebhookUrl = webhookUrl;
            this.Private = @private;
            this.TargetCollectionId = targetCollectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageIdeogram45Request" /> class.
        /// </summary>
        public GenerateImageIdeogram45Request()
        {
        }

    }
}