
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Supply the source images either as `image_asset_identifiers` references<br/>
    /// or (multipart requests only) as raw `images` bytes. At least one source<br/>
    /// is required; if both forms are given, the references are used and the<br/>
    /// bytes are ignored. The first source is the primary image being<br/>
    /// transformed; any further sources are additional references.
    /// </summary>
    public sealed partial class EditImageIdeogram45Request
    {
        /// <summary>
        /// Optional guidance for the transformation. Image-to-image conditions on the source images, so the model can run from the sources alone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Controls magic prompt (automatic rewriting of the edit instruction into the structured format the model consumes). `AUTO` (the default) and `ON` rewrite; `OFF` sends the prompt verbatim. Ignored when no prompt is supplied.<br/>
        /// Default Value: AUTO
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptOptionJsonConverter))]
        public global::Ideogram.MagicPromptOption? MagicPrompt { get; set; }

        /// <summary>
        /// Existing upload or generated image assets to transform, by reference. Takes priority over `images` if both are supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? ImageAssetIdentifiers { get; set; }

        /// <summary>
        /// The source images to transform (max 5, max size 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifiers` is also supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<byte[]>? Images { get; set; }

        /// <summary>
        /// The number of output images to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// The output size: either "auto" (the default) or an exact size<br/>
        /// formatted as "WIDTHxHEIGHT", for example "1024x1024" or<br/>
        /// "1152x768". With "auto", the output uses the supported resolution<br/>
        /// closest to the first source image's dimensions. An exact size must<br/>
        /// have both dimensions multiples of 32 and at least 256px, the total<br/>
        /// size at most 2048x2048 pixels, and the aspect ratio at most 6:1.<br/>
        /// Pricing is tiered by total pixels: up to 1024x1024 bills as 1K,<br/>
        /// above that as 2K.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.EditImageIdeogram45RequestRenderingSpeedJsonConverter))]
        public global::Ideogram.EditImageIdeogram45RequestRenderingSpeed? RenderingSpeed { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// When false (the default), the request blocks until the output image is ready and returns it in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
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
        /// Initializes a new instance of the <see cref="EditImageIdeogram45Request" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Optional guidance for the transformation. Image-to-image conditions on the source images, so the model can run from the sources alone.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic rewriting of the edit instruction into the structured format the model consumes). `AUTO` (the default) and `ON` rewrite; `OFF` sends the prompt verbatim. Ignored when no prompt is supplied.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="imageAssetIdentifiers">
        /// Existing upload or generated image assets to transform, by reference. Takes priority over `images` if both are supplied.
        /// </param>
        /// <param name="images">
        /// The source images to transform (max 5, max size 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifiers` is also supplied.
        /// </param>
        /// <param name="numImages">
        /// The number of output images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// The output size: either "auto" (the default) or an exact size<br/>
        /// formatted as "WIDTHxHEIGHT", for example "1024x1024" or<br/>
        /// "1152x768". With "auto", the output uses the supported resolution<br/>
        /// closest to the first source image's dimensions. An exact size must<br/>
        /// have both dimensions multiples of 32 and at least 256px, the total<br/>
        /// size at most 2048x2048 pixels, and the aspect ratio at most 6:1.<br/>
        /// Pricing is tiered by total pixels: up to 1024x1024 bills as 1K,<br/>
        /// above that as 2K.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="async">
        /// When false (the default), the request blocks until the output image is ready and returns it in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
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
        public EditImageIdeogram45Request(
            string? prompt,
            global::Ideogram.MagicPromptOption? magicPrompt,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? imageAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? images,
            int? numImages,
            string? size,
            global::Ideogram.EditImageIdeogram45RequestRenderingSpeed? renderingSpeed,
            int? seed,
            bool? async,
            string? webhookUrl,
            bool? @private,
            string? targetCollectionId)
        {
            this.Prompt = prompt;
            this.MagicPrompt = magicPrompt;
            this.ImageAssetIdentifiers = imageAssetIdentifiers;
            this.Images = images;
            this.NumImages = numImages;
            this.Size = size;
            this.RenderingSpeed = renderingSpeed;
            this.Seed = seed;
            this.Async = async;
            this.WebhookUrl = webhookUrl;
            this.Private = @private;
            this.TargetCollectionId = targetCollectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageIdeogram45Request" /> class.
        /// </summary>
        public EditImageIdeogram45Request()
        {
        }

    }
}