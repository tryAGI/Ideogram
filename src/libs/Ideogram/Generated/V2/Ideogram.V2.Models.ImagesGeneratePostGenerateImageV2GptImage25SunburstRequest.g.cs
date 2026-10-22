
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagesGeneratePostGenerateImageV2GptImage25SunburstRequest
    {
        /// <summary>
        /// The prompt to generate images from, or the edit instruction to apply when source images are supplied. It is passed to the model as written.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Optional source images to edit (max 16, max 25MB each; JPEG, PNG, or WEBP). Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<byte[]>? Images { get; set; }

        /// <summary>
        /// An optional mask for the first source image (max 25MB; JPEG, PNG, or WEBP). Multipart requests only. White pixels mark the area to edit and black pixels mark the area to keep. The mask must have the same dimensions as the first source image and requires source images in the same request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public byte[]? Mask { get; set; }

        /// <summary>
        /// An optional mask for the first source image (max 25MB; JPEG, PNG, or WEBP). Multipart requests only. White pixels mark the area to edit and black pixels mark the area to keep. The mask must have the same dimensions as the first source image and requires source images in the same request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskname")]
        public string? Maskname { get; set; }

        /// <summary>
        /// The output background. `transparent` returns images with an alpha channel, `opaque` forces a solid background, and `auto` lets the model decide from the prompt.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackgroundJsonConverter))]
        public global::Ideogram.V2.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackground? Background { get; set; }

        /// <summary>
        /// How much rendering effort the model spends. Lower tiers return sooner and cost less; `auto` lets the model choose, which it currently renders at `high`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQualityJsonConverter))]
        public global::Ideogram.V2.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality? Quality { get; set; }

        /// <summary>
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.
        /// </summary>
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
        /// Initializes a new instance of the <see cref="ImagesGeneratePostGenerateImageV2GptImage25SunburstRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to generate images from, or the edit instruction to apply when source images are supplied. It is passed to the model as written.
        /// </param>
        /// <param name="images">
        /// Optional source images to edit (max 16, max 25MB each; JPEG, PNG, or WEBP). Multipart requests only.
        /// </param>
        /// <param name="mask">
        /// An optional mask for the first source image (max 25MB; JPEG, PNG, or WEBP). Multipart requests only. White pixels mark the area to edit and black pixels mark the area to keep. The mask must have the same dimensions as the first source image and requires source images in the same request.
        /// </param>
        /// <param name="maskname">
        /// An optional mask for the first source image (max 25MB; JPEG, PNG, or WEBP). Multipart requests only. White pixels mark the area to edit and black pixels mark the area to keep. The mask must have the same dimensions as the first source image and requires source images in the same request.
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
        /// Random seed. Set for reproducible generation.
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
        public ImagesGeneratePostGenerateImageV2GptImage25SunburstRequest(
            string prompt,
            global::System.Collections.Generic.IList<byte[]>? images,
            byte[]? mask,
            string? maskname,
            global::Ideogram.V2.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackground? background,
            global::Ideogram.V2.V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality? quality,
            int? numImages,
            int? seed,
            string? aspectRatio,
            string? resolution,
            bool? async,
            string? webhookUrl)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesGeneratePostGenerateImageV2GptImage25SunburstRequest" /> class.
        /// </summary>
        public ImagesGeneratePostGenerateImageV2GptImage25SunburstRequest()
        {
        }

    }
}