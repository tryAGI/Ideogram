
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagesRemixPostRemixImageV2Ideogram45Request
    {
        /// <summary>
        /// The prompt that guides the remix. It is always read as an editing instruction, so there is no `magic_prompt` option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The existing upload or generated image to transform. Supply this or `image`, never both. Leave `size` as "source" to keep its shape.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.V2.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// The image to transform. JPEG, PNG, and WEBP are supported. Multipart requests only. The uploaded image is saved to your account as the remix's source. Supply this or `image_asset_identifier`, never both. Leave `size` as "source" to keep its shape.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The image to transform. JPEG, PNG, and WEBP are supported. Multipart requests only. The uploaded image is saved to your account as the remix's source. Supply this or `image_asset_identifier`, never both. Leave `size` as "source" to keep its shape.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// Optional existing upload or generated images to bring into the result, such as a product, a logo, or a style. They guide the remix but are not transformed themselves. Supply this or `reference_images`, never both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.V2.AssetIdentifier>? ReferenceImageAssetIdentifiers { get; set; }

        /// <summary>
        /// Optional reference images to upload (max 4; JPEG, PNG, or WEBP). The same rules as `reference_image_asset_identifiers` apply. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? ReferenceImages { get; set; }

        /// <summary>
        /// Optional. How closely the result should follow the source image, from 1 to 100. When omitted the server chooses a value from your prompt, which is the usual case. Only accepted when the output keeps the source image's shape: combining `image_weight` with a `size` whose aspect ratio differs from the source's is rejected with a 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_weight")]
        public int? ImageWeight { get; set; }

        /// <summary>
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// The output size: "source" or an exact "WIDTHxHEIGHT".<br/>
        /// "source" (the default) keeps the source image's shape at the<br/>
        /// closest supported Ideogram 4.5 size. An exact size must be a<br/>
        /// supported Ideogram 4.5 size (for example 2048x2048 or 1440x2560),<br/>
        /// and one whose aspect ratio differs from the source's cannot be<br/>
        /// combined with `image_weight`.<br/>
        /// Default Value: source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// The rendering quality to use. Higher quality takes longer and costs more.<br/>
        /// Default Value: high
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.V2ImageRemixIdeogram45PostRequestBodyContentMultipartFormDataSchemaQualityJsonConverter))]
        public global::Ideogram.V2.V2ImageRemixIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality? Quality { get; set; }

        /// <summary>
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_copyright_detection")]
        public bool? EnableCopyrightDetection { get; set; }

        /// <summary>
        /// When false (the default), the request waits until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v2/generations/{generation_id}` using the returned `generation_id`.<br/>
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
        /// Initializes a new instance of the <see cref="ImagesRemixPostRemixImageV2Ideogram45Request" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt that guides the remix. It is always read as an editing instruction, so there is no `magic_prompt` option.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// The existing upload or generated image to transform. Supply this or `image`, never both. Leave `size` as "source" to keep its shape.
        /// </param>
        /// <param name="image">
        /// The image to transform. JPEG, PNG, and WEBP are supported. Multipart requests only. The uploaded image is saved to your account as the remix's source. Supply this or `image_asset_identifier`, never both. Leave `size` as "source" to keep its shape.
        /// </param>
        /// <param name="imagename">
        /// The image to transform. JPEG, PNG, and WEBP are supported. Multipart requests only. The uploaded image is saved to your account as the remix's source. Supply this or `image_asset_identifier`, never both. Leave `size` as "source" to keep its shape.
        /// </param>
        /// <param name="referenceImageAssetIdentifiers">
        /// Optional existing upload or generated images to bring into the result, such as a product, a logo, or a style. They guide the remix but are not transformed themselves. Supply this or `reference_images`, never both.
        /// </param>
        /// <param name="referenceImages">
        /// Optional reference images to upload (max 4; JPEG, PNG, or WEBP). The same rules as `reference_image_asset_identifiers` apply. Multipart requests only.
        /// </param>
        /// <param name="imageWeight">
        /// Optional. How closely the result should follow the source image, from 1 to 100. When omitted the server chooses a value from your prompt, which is the usual case. Only accepted when the output keeps the source image's shape: combining `image_weight` with a `size` whose aspect ratio differs from the source's is rejected with a 400.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// The output size: "source" or an exact "WIDTHxHEIGHT".<br/>
        /// "source" (the default) keeps the source image's shape at the<br/>
        /// closest supported Ideogram 4.5 size. An exact size must be a<br/>
        /// supported Ideogram 4.5 size (for example 2048x2048 or 1440x2560),<br/>
        /// and one whose aspect ratio differs from the source's cannot be<br/>
        /// combined with `image_weight`.<br/>
        /// Default Value: source
        /// </param>
        /// <param name="quality">
        /// The rendering quality to use. Higher quality takes longer and costs more.<br/>
        /// Default Value: high
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request waits until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v2/generations/{generation_id}` using the returned `generation_id`.<br/>
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
        public ImagesRemixPostRemixImageV2Ideogram45Request(
            string prompt,
            global::Ideogram.V2.AssetIdentifier? imageAssetIdentifier,
            byte[]? image,
            string? imagename,
            global::System.Collections.Generic.IList<global::Ideogram.V2.AssetIdentifier>? referenceImageAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? referenceImages,
            int? imageWeight,
            int? numImages,
            string? size,
            global::Ideogram.V2.V2ImageRemixIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality? quality,
            bool? enableCopyrightDetection,
            bool? async,
            string? webhookUrl)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ImageAssetIdentifier = imageAssetIdentifier;
            this.Image = image;
            this.Imagename = imagename;
            this.ReferenceImageAssetIdentifiers = referenceImageAssetIdentifiers;
            this.ReferenceImages = referenceImages;
            this.ImageWeight = imageWeight;
            this.NumImages = numImages;
            this.Size = size;
            this.Quality = quality;
            this.EnableCopyrightDetection = enableCopyrightDetection;
            this.Async = async;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesRemixPostRemixImageV2Ideogram45Request" /> class.
        /// </summary>
        public ImagesRemixPostRemixImageV2Ideogram45Request()
        {
        }

    }
}