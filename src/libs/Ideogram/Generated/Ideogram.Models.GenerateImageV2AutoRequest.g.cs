
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Source `images` are optional. When supplied, Ideogram picks a model<br/>
    /// that can edit them and the prompt describes the change.<br/>
    /// `negative_prompt` cannot be combined with source images.
    /// </summary>
    public sealed partial class GenerateImageV2AutoRequest
    {
        /// <summary>
        /// The prompt to generate images from or, when source images are supplied, the change to make to them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Existing upload or generated image assets to transform, by reference. Takes priority over `images` if both are supplied. Supplying sources turns the request into a transform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? ImageAssetIdentifiers { get; set; }

        /// <summary>
        /// Optional source images to edit (max 10, max 25MB each; JPEG, PNG, or WEBP). Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<byte[]>? Images { get; set; }

        /// <summary>
        /// Description of what to exclude from the images. The prompt takes precedence over the negative prompt. Not every model uses it. Cannot be combined with source images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// Existing upload or generated image assets whose style should guide the generation, by reference. Cannot be combined with source images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? StyleReferenceAssetIdentifiers { get; set; }

        /// <summary>
        /// The output aspect ratio. `auto` (the default) picks the most suitable ratio for the request. Without source images the value must be a supported ratio (for example "16x9" or "1x1"); with source images any "WIDTHxHEIGHT" value is accepted and the output uses the closest supported shape. Omit `resolution` when supplying a non-`auto` value.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// The requested output resolution, formatted as "WIDTHxHEIGHT" (for example "1280x800"). The output is served at the closest resolution the selected model supports. Omit `aspect_ratio` (or leave it `auto`) when supplying a resolution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        /// The output resolution tier. Affects which model serves the request, since not every model offers every tier. When omitted, the selected model's default tier is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GenerateImageV2AutoRequestResolutionTierJsonConverter))]
        public global::Ideogram.GenerateImageV2AutoRequestResolutionTier? ResolutionTier { get; set; }

        /// <summary>
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptModeJsonConverter))]
        public global::Ideogram.MagicPromptMode? MagicPrompt { get; set; }

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
        /// Whether the generated images should be kept private. When omitted, the default follows the caller's plan; some plans always generate privately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// A collection you can write to, by its URL-safe base64 collection id. The output images are added to it when the request completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_collection_id")]
        public string? TargetCollectionId { get; set; }

        /// <summary>
        /// The internal generation category to attribute to the output, as a URL-safe base64 UUID without padding. Only applies when source images are supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_id")]
        public string? CategoryId { get; set; }

        /// <summary>
        /// When false (the default), the request waits until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` with the returned `generation_id` for the result.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public bool? Async { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageV2AutoRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to generate images from or, when source images are supplied, the change to make to them.
        /// </param>
        /// <param name="imageAssetIdentifiers">
        /// Existing upload or generated image assets to transform, by reference. Takes priority over `images` if both are supplied. Supplying sources turns the request into a transform.
        /// </param>
        /// <param name="images">
        /// Optional source images to edit (max 10, max 25MB each; JPEG, PNG, or WEBP). Multipart requests only.
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from the images. The prompt takes precedence over the negative prompt. Not every model uses it. Cannot be combined with source images.
        /// </param>
        /// <param name="styleReferenceAssetIdentifiers">
        /// Existing upload or generated image assets whose style should guide the generation, by reference. Cannot be combined with source images.
        /// </param>
        /// <param name="aspectRatio">
        /// The output aspect ratio. `auto` (the default) picks the most suitable ratio for the request. Without source images the value must be a supported ratio (for example "16x9" or "1x1"); with source images any "WIDTHxHEIGHT" value is accepted and the output uses the closest supported shape. Omit `resolution` when supplying a non-`auto` value.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="resolution">
        /// The requested output resolution, formatted as "WIDTHxHEIGHT" (for example "1280x800"). The output is served at the closest resolution the selected model supports. Omit `aspect_ratio` (or leave it `auto`) when supplying a resolution.
        /// </param>
        /// <param name="resolutionTier">
        /// The output resolution tier. Affects which model serves the request, since not every model offers every tier. When omitted, the selected model's default tier is used.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `auto`.<br/>
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
        /// <param name="private">
        /// Whether the generated images should be kept private. When omitted, the default follows the caller's plan; some plans always generate privately.
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. The output images are added to it when the request completes.
        /// </param>
        /// <param name="categoryId">
        /// The internal generation category to attribute to the output, as a URL-safe base64 UUID without padding. Only applies when source images are supplied.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request waits until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` with the returned `generation_id` for the result.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageV2AutoRequest(
            string prompt,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? imageAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? images,
            string? negativePrompt,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? styleReferenceAssetIdentifiers,
            string? aspectRatio,
            string? resolution,
            global::Ideogram.GenerateImageV2AutoRequestResolutionTier? resolutionTier,
            global::Ideogram.MagicPromptMode? magicPrompt,
            int? numImages,
            int? seed,
            bool? @private,
            string? targetCollectionId,
            string? categoryId,
            bool? async)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ImageAssetIdentifiers = imageAssetIdentifiers;
            this.Images = images;
            this.NegativePrompt = negativePrompt;
            this.StyleReferenceAssetIdentifiers = styleReferenceAssetIdentifiers;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.ResolutionTier = resolutionTier;
            this.MagicPrompt = magicPrompt;
            this.NumImages = numImages;
            this.Seed = seed;
            this.Private = @private;
            this.TargetCollectionId = targetCollectionId;
            this.CategoryId = categoryId;
            this.Async = async;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageV2AutoRequest" /> class.
        /// </summary>
        public GenerateImageV2AutoRequest()
        {
        }

    }
}