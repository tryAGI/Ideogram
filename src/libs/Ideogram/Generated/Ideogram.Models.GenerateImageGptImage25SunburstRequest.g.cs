
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Source images are optional. When supplied (as `image_asset_identifiers`<br/>
    /// references, or as raw `images` bytes in multipart requests), the prompt<br/>
    /// is applied to the sources as an edit; if both forms are given, the<br/>
    /// references are used and the bytes are ignored. Without source images<br/>
    /// the prompt alone drives the generation.
    /// </summary>
    public sealed partial class GenerateImageGptImage25SunburstRequest
    {
        /// <summary>
        /// The prompt to generate images from, or the edit instruction to apply when source images are supplied. The model consumes it directly, without rewriting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Existing upload or generated image assets to edit, by reference. Takes priority over `images` if both are supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? ImageAssetIdentifiers { get; set; }

        /// <summary>
        /// The source images to edit (max 16, max size 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifiers` is also supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<byte[]>? Images { get; set; }

        /// <summary>
        /// An optional mask applied to the first source image, as raw bytes (multipart requests only; JPEG, PNG, or WEBP, max 25MB). Fully transparent mask pixels mark the areas to edit; the mask must have the same dimensions as the first source image. Requires source images uploaded as raw `images` bytes in the same request; masks cannot be combined with `image_asset_identifiers`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public byte[]? Mask { get; set; }

        /// <summary>
        /// An optional mask applied to the first source image, as raw bytes (multipart requests only; JPEG, PNG, or WEBP, max 25MB). Fully transparent mask pixels mark the areas to edit; the mask must have the same dimensions as the first source image. Requires source images uploaded as raw `images` bytes in the same request; masks cannot be combined with `image_asset_identifiers`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskname")]
        public string? Maskname { get; set; }

        /// <summary>
        /// The output background. `transparent` returns images with an alpha channel, `opaque` forces a solid background, and `auto` lets the model decide from the prompt.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GenerateImageGptImage25SunburstRequestBackgroundJsonConverter))]
        public global::Ideogram.GenerateImageGptImage25SunburstRequestBackground? Background { get; set; }

        /// <summary>
        /// How much rendering effort the model spends. Lower tiers return sooner and cost less; `auto` lets the model choose, which it currently renders at `high`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GenerateImageGptImage25SunburstRequestQualityJsonConverter))]
        public global::Ideogram.GenerateImageGptImage25SunburstRequestQuality? Quality { get; set; }

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
        /// The requested output aspect ratio, for example "1:1", "16:9", or "9:16". Ignored when `resolution` is provided. Defaults to "1:1".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// Exact output resolution, formatted as "WIDTHxHEIGHT", for example<br/>
        /// "2048x2048" or "1920x1088". When provided, this takes precedence<br/>
        /// over `aspect_ratio`. The dimensions must satisfy GPT Image 2.5 Sunburst<br/>
        /// constraints: each side is a multiple of 16, the largest side is at<br/>
        /// most 3840px, the long:short ratio is at most 3:1, and total pixels<br/>
        /// are between 655360 and 8294400 inclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public string? Resolution { get; set; }

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
        /// Initializes a new instance of the <see cref="GenerateImageGptImage25SunburstRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to generate images from, or the edit instruction to apply when source images are supplied. The model consumes it directly, without rewriting.
        /// </param>
        /// <param name="imageAssetIdentifiers">
        /// Existing upload or generated image assets to edit, by reference. Takes priority over `images` if both are supplied.
        /// </param>
        /// <param name="images">
        /// The source images to edit (max 16, max size 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifiers` is also supplied.
        /// </param>
        /// <param name="mask">
        /// An optional mask applied to the first source image, as raw bytes (multipart requests only; JPEG, PNG, or WEBP, max 25MB). Fully transparent mask pixels mark the areas to edit; the mask must have the same dimensions as the first source image. Requires source images uploaded as raw `images` bytes in the same request; masks cannot be combined with `image_asset_identifiers`.
        /// </param>
        /// <param name="maskname">
        /// An optional mask applied to the first source image, as raw bytes (multipart requests only; JPEG, PNG, or WEBP, max 25MB). Fully transparent mask pixels mark the areas to edit; the mask must have the same dimensions as the first source image. Requires source images uploaded as raw `images` bytes in the same request; masks cannot be combined with `image_asset_identifiers`.
        /// </param>
        /// <param name="background">
        /// The output background. `transparent` returns images with an alpha channel, `opaque` forces a solid background, and `auto` lets the model decide from the prompt.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="quality">
        /// How much rendering effort the model spends. Lower tiers return sooner and cost less; `auto` lets the model choose, which it currently renders at `high`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="aspectRatio">
        /// The requested output aspect ratio, for example "1:1", "16:9", or "9:16". Ignored when `resolution` is provided. Defaults to "1:1".
        /// </param>
        /// <param name="resolution">
        /// Exact output resolution, formatted as "WIDTHxHEIGHT", for example<br/>
        /// "2048x2048" or "1920x1088". When provided, this takes precedence<br/>
        /// over `aspect_ratio`. The dimensions must satisfy GPT Image 2.5 Sunburst<br/>
        /// constraints: each side is a multiple of 16, the largest side is at<br/>
        /// most 3840px, the long:short ratio is at most 3:1, and total pixels<br/>
        /// are between 655360 and 8294400 inclusive.
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
        public GenerateImageGptImage25SunburstRequest(
            string prompt,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? imageAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? images,
            byte[]? mask,
            string? maskname,
            global::Ideogram.GenerateImageGptImage25SunburstRequestBackground? background,
            global::Ideogram.GenerateImageGptImage25SunburstRequestQuality? quality,
            int? numImages,
            int? seed,
            string? aspectRatio,
            string? resolution,
            bool? async,
            string? webhookUrl,
            bool? @private,
            string? targetCollectionId)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ImageAssetIdentifiers = imageAssetIdentifiers;
            this.Images = images;
            this.Mask = mask;
            this.Maskname = maskname;
            this.Background = background;
            this.Quality = quality;
            this.NumImages = numImages;
            this.Seed = seed;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Async = async;
            this.WebhookUrl = webhookUrl;
            this.Private = @private;
            this.TargetCollectionId = targetCollectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageGptImage25SunburstRequest" /> class.
        /// </summary>
        public GenerateImageGptImage25SunburstRequest()
        {
        }

    }
}