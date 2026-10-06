
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A request to edit one image. The `image` to edit is required. The<br/>
    /// output is always returned at that image's exact width and height, so<br/>
    /// this request takes no output size.
    /// </summary>
    public sealed partial class PreciseEditImageIdeogram45Request
    {
        /// <summary>
        /// The edit instruction, in natural language or as a structured JSON<br/>
        /// prompt. Natural language is automatically converted into a<br/>
        /// structured prompt; valid structured JSON is used as is.
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
        /// The image to edit, as raw bytes (max 50MB; JPEG, PNG, or WEBP). Multipart requests only; ignored if `image_asset_identifier` is also supplied. Required when supplying a `mask` or a `context_window`. The output always matches this image's width and height, and pixels the edit did not meaningfully change are copied exactly from it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The image to edit, as raw bytes (max 50MB; JPEG, PNG, or WEBP). Multipart requests only; ignored if `image_asset_identifier` is also supplied. Required when supplying a `mask` or a `context_window`. The output always matches this image's width and height, and pixels the edit did not meaningfully change are copied exactly from it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// Optional additional images to guide the edit, by reference. These are never edited themselves; only `image_asset_identifier` or `image` is. Requires the image being edited to be supplied by reference too, and cannot be combined with `mask`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? ReferenceImageAssetIdentifiers { get; set; }

        /// <summary>
        /// Optional images to guide the edit (max 4, max 50MB each; JPEG, PNG, or WEBP). They are never edited themselves; only `image` is. Multipart requests only; ignored if `reference_image_asset_identifiers` is also supplied. A request with a `mask` can include at most three, because the mask takes up one reference slot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? ReferenceImages { get; set; }

        /// <summary>
        /// An optional mask that limits the edit to part of `image` (max 50MB; JPEG, PNG, or WEBP). Multipart requests only. Black marks the area to edit and white the area to keep; values in between are rounded to the nearer of the two. The mask must have the same width and height as `image` and contain both black and white areas. Requires `image` as raw bytes; masks cannot be combined with asset references. A masked request can include at most three `reference_images`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public byte[]? Mask { get; set; }

        /// <summary>
        /// An optional mask that limits the edit to part of `image` (max 50MB; JPEG, PNG, or WEBP). Multipart requests only. Black marks the area to edit and white the area to keep; values in between are rounded to the nearer of the two. The mask must have the same width and height as `image` and contain both black and white areas. Requires `image` as raw bytes; masks cannot be combined with asset references. A masked request can include at most three `reference_images`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskname")]
        public string? Maskname { get; set; }

        /// <summary>
        /// Which region of the image to edit.<br/>
        /// `none`, the default, edits the whole image. A large image may come back smaller than it was sent.<br/>
        /// `auto` requires a `mask` and automatically selects an appropriate context region around the masked area.<br/>
        /// `y_min,x_min,y_max,x_max` names the region explicitly, by its corners. Rows come first, matching the `bbox` ordering used elsewhere in this API, and the values are the edited image's own pixels with the origin at its top-left corner. For example `512,1024,2048,3072` is the region 2048 pixels wide and 1536 tall whose top-left corner is 1024 across and 512 down. The maximum edges are exclusive, so the region measures `x_max - x_min` by `y_max - y_min`. It must lie inside the image, measure at least 256px on each side, have an aspect ratio between 1:6 and 6:1, and cover no more than 4194304 pixels. A `mask` may select only pixels inside it.<br/>
        /// With `auto` or an explicit region, only that region changes and the output keeps the image's own width and height.<br/>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_window")]
        public string? ContextWindow { get; set; }

        /// <summary>
        /// The rendering quality to use. `very_low` is the fastest and cheapest, and `high` takes longer and is priced higher.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.PreciseEditImageIdeogram45RequestQualityJsonConverter))]
        public global::Ideogram.PreciseEditImageIdeogram45RequestQuality? Quality { get; set; }

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
        /// Initializes a new instance of the <see cref="PreciseEditImageIdeogram45Request" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The edit instruction, in natural language or as a structured JSON<br/>
        /// prompt. Natural language is automatically converted into a<br/>
        /// structured prompt; valid structured JSON is used as is.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// The image to edit, as an existing upload or generated image asset. Supply this or `image`, never both. Takes priority over `image` if both are supplied. Cannot be combined with `mask`.
        /// </param>
        /// <param name="image">
        /// The image to edit, as raw bytes (max 50MB; JPEG, PNG, or WEBP). Multipart requests only; ignored if `image_asset_identifier` is also supplied. Required when supplying a `mask` or a `context_window`. The output always matches this image's width and height, and pixels the edit did not meaningfully change are copied exactly from it.
        /// </param>
        /// <param name="imagename">
        /// The image to edit, as raw bytes (max 50MB; JPEG, PNG, or WEBP). Multipart requests only; ignored if `image_asset_identifier` is also supplied. Required when supplying a `mask` or a `context_window`. The output always matches this image's width and height, and pixels the edit did not meaningfully change are copied exactly from it.
        /// </param>
        /// <param name="referenceImageAssetIdentifiers">
        /// Optional additional images to guide the edit, by reference. These are never edited themselves; only `image_asset_identifier` or `image` is. Requires the image being edited to be supplied by reference too, and cannot be combined with `mask`.
        /// </param>
        /// <param name="referenceImages">
        /// Optional images to guide the edit (max 4, max 50MB each; JPEG, PNG, or WEBP). They are never edited themselves; only `image` is. Multipart requests only; ignored if `reference_image_asset_identifiers` is also supplied. A request with a `mask` can include at most three, because the mask takes up one reference slot.
        /// </param>
        /// <param name="mask">
        /// An optional mask that limits the edit to part of `image` (max 50MB; JPEG, PNG, or WEBP). Multipart requests only. Black marks the area to edit and white the area to keep; values in between are rounded to the nearer of the two. The mask must have the same width and height as `image` and contain both black and white areas. Requires `image` as raw bytes; masks cannot be combined with asset references. A masked request can include at most three `reference_images`.
        /// </param>
        /// <param name="maskname">
        /// An optional mask that limits the edit to part of `image` (max 50MB; JPEG, PNG, or WEBP). Multipart requests only. Black marks the area to edit and white the area to keep; values in between are rounded to the nearer of the two. The mask must have the same width and height as `image` and contain both black and white areas. Requires `image` as raw bytes; masks cannot be combined with asset references. A masked request can include at most three `reference_images`.
        /// </param>
        /// <param name="contextWindow">
        /// Which region of the image to edit.<br/>
        /// `none`, the default, edits the whole image. A large image may come back smaller than it was sent.<br/>
        /// `auto` requires a `mask` and automatically selects an appropriate context region around the masked area.<br/>
        /// `y_min,x_min,y_max,x_max` names the region explicitly, by its corners. Rows come first, matching the `bbox` ordering used elsewhere in this API, and the values are the edited image's own pixels with the origin at its top-left corner. For example `512,1024,2048,3072` is the region 2048 pixels wide and 1536 tall whose top-left corner is 1024 across and 512 down. The maximum edges are exclusive, so the region measures `x_max - x_min` by `y_max - y_min`. It must lie inside the image, measure at least 256px on each side, have an aspect ratio between 1:6 and 6:1, and cover no more than 4194304 pixels. A `mask` may select only pixels inside it.<br/>
        /// With `auto` or an explicit region, only that region changes and the output keeps the image's own width and height.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="quality">
        /// The rendering quality to use. `very_low` is the fastest and cheapest, and `high` takes longer and is priced higher.<br/>
        /// Default Value: medium
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
        public PreciseEditImageIdeogram45Request(
            string prompt,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            byte[]? image,
            string? imagename,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceImageAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? referenceImages,
            byte[]? mask,
            string? maskname,
            string? contextWindow,
            global::Ideogram.PreciseEditImageIdeogram45RequestQuality? quality,
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
            this.ContextWindow = contextWindow;
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
        /// Initializes a new instance of the <see cref="PreciseEditImageIdeogram45Request" /> class.
        /// </summary>
        public PreciseEditImageIdeogram45Request()
        {
        }

    }
}