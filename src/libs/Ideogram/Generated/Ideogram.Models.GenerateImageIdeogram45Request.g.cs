
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Source images are optional. When supplied, the request becomes an<br/>
    /// image-to-image transform and `size` defaults to "auto" (derived from<br/>
    /// the first source). A prompt is required either way.
    /// </summary>
    public sealed partial class GenerateImageIdeogram45Request
    {
        /// <summary>
        /// The prompt to generate images from, or the edit instruction to<br/>
        /// apply when source images are supplied. Accepts either natural<br/>
        /// language or a structured Ideogram 4.0 JSON prompt; the server<br/>
        /// detects which was supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Controls how a natural-language prompt is prepared. `auto` (the<br/>
        /// default) and `on` rewrite and expand the prompt before<br/>
        /// generation. `off` keeps your wording and only converts the prompt<br/>
        /// into the structured format the model consumes. A prompt that is<br/>
        /// already a valid structured JSON prompt skips magic prompt<br/>
        /// entirely unless `magic_prompt` is `on`. With source images the<br/>
        /// prompt is an edit instruction, and every mode converts it into<br/>
        /// the structured edit contract the model consumes.<br/>
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
        /// The source images to transform (max 5, max size 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifiers` is also supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<byte[]>? Images { get; set; }

        /// <summary>
        /// An optional mask confining the edit to part of the first source image, as raw bytes (multipart requests only; JPEG, PNG, or WEBP, max 25MB). Black marks the area to edit and white the area to preserve; values in between are rounded to whichever is nearer. The mask must have the same width and height as the first source image, and must contain both black and white areas. Requires source images uploaded as raw `images` bytes; masks cannot be combined with `image_asset_identifiers`. The mask is supplied to the model as an additional reference image, so a masked request may carry at most three other source images. Supplying a mask fixes the output to the first source's own size, so `size` is rejected alongside it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public byte[]? Mask { get; set; }

        /// <summary>
        /// An optional mask confining the edit to part of the first source image, as raw bytes (multipart requests only; JPEG, PNG, or WEBP, max 25MB). Black marks the area to edit and white the area to preserve; values in between are rounded to whichever is nearer. The mask must have the same width and height as the first source image, and must contain both black and white areas. Requires source images uploaded as raw `images` bytes; masks cannot be combined with `image_asset_identifiers`. The mask is supplied to the model as an additional reference image, so a masked request may carry at most three other source images. Supplying a mask fixes the output to the first source's own size, so `size` is rejected alongside it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskname")]
        public string? Maskname { get; set; }

        /// <summary>
        /// The output size: "auto" or an exact "WIDTHxHEIGHT".<br/>
        /// Without source images, an exact size must be one of the supported<br/>
        /// 1K/2K presets (for example 1024x1024, 2048x2048 or 1440x2880);<br/>
        /// "auto" or omitted lets the server pick a supported size based on<br/>
        /// the prompt.<br/>
        /// With source images, "auto" (the default) returns the output at the<br/>
        /// first source image's own width and height. A source too large for<br/>
        /// the model is scaled down to fit while keeping its exact proportion,<br/>
        /// and a source whose aspect ratio is outside 1:6 to 6:1 is rejected,<br/>
        /// because serving it would mean reshaping an image you did not ask to<br/>
        /// reshape — name an exact size if that is what you want.<br/>
        /// An exact size must have both dimensions multiples of 32 and at least<br/>
        /// 256px, the total size at most 2048x2048 pixels, and the aspect ratio<br/>
        /// at most 6:1. Naming one reshapes the source to it.<br/>
        /// Pricing is tiered by the resolved output pixels: up to 1024x1024<br/>
        /// bills as 1K, above that as 2K.<br/>
        /// Example: 2048x2048
        /// </summary>
        /// <example>2048x2048</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// The rendering speed to use.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GenerateImageIdeogram45RequestRenderingSpeedJsonConverter))]
        public global::Ideogram.GenerateImageIdeogram45RequestRenderingSpeed? RenderingSpeed { get; set; }

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
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_copyright_detection")]
        public bool? EnableCopyrightDetection { get; set; }

        /// <summary>
        /// When false (the default), the request blocks until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
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
        /// The prompt to generate images from, or the edit instruction to<br/>
        /// apply when source images are supplied. Accepts either natural<br/>
        /// language or a structured Ideogram 4.0 JSON prompt; the server<br/>
        /// detects which was supplied.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls how a natural-language prompt is prepared. `auto` (the<br/>
        /// default) and `on` rewrite and expand the prompt before<br/>
        /// generation. `off` keeps your wording and only converts the prompt<br/>
        /// into the structured format the model consumes. A prompt that is<br/>
        /// already a valid structured JSON prompt skips magic prompt<br/>
        /// entirely unless `magic_prompt` is `on`. With source images the<br/>
        /// prompt is an edit instruction, and every mode converts it into<br/>
        /// the structured edit contract the model consumes.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="imageAssetIdentifiers">
        /// Existing upload or generated image assets to transform, by reference. Takes priority over `images` if both are supplied. The first source is the primary image; any further sources are additional references. Supplying sources turns the request into an image-to-image transform.
        /// </param>
        /// <param name="images">
        /// The source images to transform (max 5, max size 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifiers` is also supplied.
        /// </param>
        /// <param name="mask">
        /// An optional mask confining the edit to part of the first source image, as raw bytes (multipart requests only; JPEG, PNG, or WEBP, max 25MB). Black marks the area to edit and white the area to preserve; values in between are rounded to whichever is nearer. The mask must have the same width and height as the first source image, and must contain both black and white areas. Requires source images uploaded as raw `images` bytes; masks cannot be combined with `image_asset_identifiers`. The mask is supplied to the model as an additional reference image, so a masked request may carry at most three other source images. Supplying a mask fixes the output to the first source's own size, so `size` is rejected alongside it.
        /// </param>
        /// <param name="maskname">
        /// An optional mask confining the edit to part of the first source image, as raw bytes (multipart requests only; JPEG, PNG, or WEBP, max 25MB). Black marks the area to edit and white the area to preserve; values in between are rounded to whichever is nearer. The mask must have the same width and height as the first source image, and must contain both black and white areas. Requires source images uploaded as raw `images` bytes; masks cannot be combined with `image_asset_identifiers`. The mask is supplied to the model as an additional reference image, so a masked request may carry at most three other source images. Supplying a mask fixes the output to the first source's own size, so `size` is rejected alongside it.
        /// </param>
        /// <param name="size">
        /// The output size: "auto" or an exact "WIDTHxHEIGHT".<br/>
        /// Without source images, an exact size must be one of the supported<br/>
        /// 1K/2K presets (for example 1024x1024, 2048x2048 or 1440x2880);<br/>
        /// "auto" or omitted lets the server pick a supported size based on<br/>
        /// the prompt.<br/>
        /// With source images, "auto" (the default) returns the output at the<br/>
        /// first source image's own width and height. A source too large for<br/>
        /// the model is scaled down to fit while keeping its exact proportion,<br/>
        /// and a source whose aspect ratio is outside 1:6 to 6:1 is rejected,<br/>
        /// because serving it would mean reshaping an image you did not ask to<br/>
        /// reshape — name an exact size if that is what you want.<br/>
        /// An exact size must have both dimensions multiples of 32 and at least<br/>
        /// 256px, the total size at most 2048x2048 pixels, and the aspect ratio<br/>
        /// at most 6:1. Naming one reshapes the source to it.<br/>
        /// Pricing is tiered by the resolved output pixels: up to 1024x1024<br/>
        /// bills as 1K, above that as 2K.<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: default
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
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request blocks until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
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
            global::Ideogram.GenerateImageIdeogram45RequestRenderingSpeed? renderingSpeed,
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
            this.RenderingSpeed = renderingSpeed;
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