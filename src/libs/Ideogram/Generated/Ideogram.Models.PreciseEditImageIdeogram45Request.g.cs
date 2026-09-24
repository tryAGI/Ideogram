
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The image being edited is required, as an `image_asset_identifier`<br/>
    /// reference or as raw `image` bytes. The output is always returned at<br/>
    /// that image's exact width and height, so this request takes no output<br/>
    /// size.
    /// </summary>
    public sealed partial class PreciseEditImageIdeogram45Request
    {
        /// <summary>
        /// The edit instruction to apply to the sources. Accepts either<br/>
        /// natural language or a structured JSON prompt; the server detects<br/>
        /// which was supplied. Natural language is automatically rewritten<br/>
        /// into the model's structured edit contract, while structured JSON<br/>
        /// is consumed directly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The image to edit, as an existing upload or generated image asset. Supply this or `image`, never both. Takes priority over `image` if both are supplied. Cannot be combined with `mask`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// The image to edit, as raw bytes (max size 25MB; JPEG, PNG, or WEBP only). Multipart requests only; ignored if `image_asset_identifier` is also supplied. Required when supplying a `mask`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The image to edit, as raw bytes (max size 25MB; JPEG, PNG, or WEBP only). Multipart requests only; ignored if `image_asset_identifier` is also supplied. Required when supplying a `mask`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// Optional additional images to guide the edit, by reference. These are never edited themselves; only `image_asset_identifier` or `image` is. Requires the image being edited to be supplied by reference too, and cannot be combined with `mask`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? ReferenceImageAssetIdentifiers { get; set; }

        /// <summary>
        /// Optional additional images to guide the edit (max 4, max size 25MB each), as raw bytes; only JPEG, PNG, and WEBP formats are supported. These are never edited themselves; only `image` is. Multipart requests only; ignored if `reference_image_asset_identifiers` is also supplied. A masked request may carry at most three, because the mask occupies one of the model's reference slots.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? ReferenceImages { get; set; }

        /// <summary>
        /// An optional mask confining the edit to part of `image`, as raw bytes (multipart requests only; JPEG, PNG, or WEBP, max 25MB). Black marks the area to edit and white the area to preserve; values in between are rounded to whichever is nearer. The mask must have the same width and height as `image`, and must contain both black and white areas. Requires the image being edited to be uploaded as raw `image` bytes in the same request; masks cannot be combined with asset references. The mask is supplied to the model as an additional reference image, so a masked request may carry at most three `reference_images`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public byte[]? Mask { get; set; }

        /// <summary>
        /// An optional mask confining the edit to part of `image`, as raw bytes (multipart requests only; JPEG, PNG, or WEBP, max 25MB). Black marks the area to edit and white the area to preserve; values in between are rounded to whichever is nearer. The mask must have the same width and height as `image`, and must contain both black and white areas. Requires the image being edited to be uploaded as raw `image` bytes in the same request; masks cannot be combined with asset references. The mask is supplied to the model as an additional reference image, so a masked request may carry at most three `reference_images`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskname")]
        public string? Maskname { get; set; }

        /// <summary>
        /// The rendering speed to use. `ultra` renders multiple candidate edits internally and returns the one that best applies the instruction; it takes longer than `quality`, is priced higher, and supports at most 4 images per request.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.PreciseEditImageIdeogram45RequestRenderingSpeedJsonConverter))]
        public global::Ideogram.PreciseEditImageIdeogram45RequestRenderingSpeed? RenderingSpeed { get; set; }

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
        /// Initializes a new instance of the <see cref="PreciseEditImageIdeogram45Request" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The edit instruction to apply to the sources. Accepts either<br/>
        /// natural language or a structured JSON prompt; the server detects<br/>
        /// which was supplied. Natural language is automatically rewritten<br/>
        /// into the model's structured edit contract, while structured JSON<br/>
        /// is consumed directly.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// The image to edit, as an existing upload or generated image asset. Supply this or `image`, never both. Takes priority over `image` if both are supplied. Cannot be combined with `mask`.
        /// </param>
        /// <param name="image">
        /// The image to edit, as raw bytes (max size 25MB; JPEG, PNG, or WEBP only). Multipart requests only; ignored if `image_asset_identifier` is also supplied. Required when supplying a `mask`.
        /// </param>
        /// <param name="imagename">
        /// The image to edit, as raw bytes (max size 25MB; JPEG, PNG, or WEBP only). Multipart requests only; ignored if `image_asset_identifier` is also supplied. Required when supplying a `mask`.
        /// </param>
        /// <param name="referenceImageAssetIdentifiers">
        /// Optional additional images to guide the edit, by reference. These are never edited themselves; only `image_asset_identifier` or `image` is. Requires the image being edited to be supplied by reference too, and cannot be combined with `mask`.
        /// </param>
        /// <param name="referenceImages">
        /// Optional additional images to guide the edit (max 4, max size 25MB each), as raw bytes; only JPEG, PNG, and WEBP formats are supported. These are never edited themselves; only `image` is. Multipart requests only; ignored if `reference_image_asset_identifiers` is also supplied. A masked request may carry at most three, because the mask occupies one of the model's reference slots.
        /// </param>
        /// <param name="mask">
        /// An optional mask confining the edit to part of `image`, as raw bytes (multipart requests only; JPEG, PNG, or WEBP, max 25MB). Black marks the area to edit and white the area to preserve; values in between are rounded to whichever is nearer. The mask must have the same width and height as `image`, and must contain both black and white areas. Requires the image being edited to be uploaded as raw `image` bytes in the same request; masks cannot be combined with asset references. The mask is supplied to the model as an additional reference image, so a masked request may carry at most three `reference_images`.
        /// </param>
        /// <param name="maskname">
        /// An optional mask confining the edit to part of `image`, as raw bytes (multipart requests only; JPEG, PNG, or WEBP, max 25MB). Black marks the area to edit and white the area to preserve; values in between are rounded to whichever is nearer. The mask must have the same width and height as `image`, and must contain both black and white areas. Requires the image being edited to be uploaded as raw `image` bytes in the same request; masks cannot be combined with asset references. The mask is supplied to the model as an additional reference image, so a masked request may carry at most three `reference_images`.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. `ultra` renders multiple candidate edits internally and returns the one that best applies the instruction; it takes longer than `quality`, is priced higher, and supports at most 4 images per request.<br/>
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
        public PreciseEditImageIdeogram45Request(
            string prompt,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            byte[]? image,
            string? imagename,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceImageAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? referenceImages,
            byte[]? mask,
            string? maskname,
            global::Ideogram.PreciseEditImageIdeogram45RequestRenderingSpeed? renderingSpeed,
            int? seed,
            int? numImages,
            bool? enableCopyrightDetection,
            bool? async,
            string? webhookUrl,
            bool? @private,
            string? targetCollectionId)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ImageAssetIdentifier = imageAssetIdentifier;
            this.Image = image;
            this.Imagename = imagename;
            this.ReferenceImageAssetIdentifiers = referenceImageAssetIdentifiers;
            this.ReferenceImages = referenceImages;
            this.Mask = mask;
            this.Maskname = maskname;
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
        /// Initializes a new instance of the <see cref="PreciseEditImageIdeogram45Request" /> class.
        /// </summary>
        public PreciseEditImageIdeogram45Request()
        {
        }

    }
}