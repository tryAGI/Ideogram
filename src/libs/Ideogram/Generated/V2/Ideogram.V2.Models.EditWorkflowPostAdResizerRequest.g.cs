
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EditWorkflowPostAdResizerRequest
    {
        /// <summary>
        /// The source creative to reframe (max size 25MB). JPEG, PNG, and<br/>
        /// WEBP formats are supported. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The source creative to reframe (max size 25MB). JPEG, PNG, and<br/>
        /// WEBP formats are supported. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// Target ad resolution, formatted as `WIDTHxHEIGHT`. Any value not in<br/>
        /// the list is rejected with a 400. Each output image has exactly these<br/>
        /// pixel dimensions, with or without a `platform`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolutionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution Resolution { get; set; }

        /// <summary>
        /// The ad platform whose published safe zone the ad must stay inside.<br/>
        /// The ad is generated inside the largest rectangle that fits the<br/>
        /// platform's safe zone for the requested aspect ratio, and the space<br/>
        /// around it is filled in so the output is still exactly the requested<br/>
        /// `resolution`. `google` covers YouTube and Google Ads placements.<br/>
        /// Use `meta_stories` or `meta_reels` for Meta placements; Reels uses<br/>
        /// the largest rectangle inside its notched safe zone. The legacy<br/>
        /// `meta` value is still supported and uses a more conservative safe<br/>
        /// zone. When omitted, the ad fills the whole frame and every<br/>
        /// supported `resolution` is accepted. Any other value is rejected<br/>
        /// with a 400.<br/>
        /// Each platform accepts only the resolutions for which it publishes a<br/>
        /// safe zone; any other `resolution` is rejected with a 400:<br/>
        /// | Platform | Accepted resolutions |<br/>
        /// | --- | --- |<br/>
        /// | `google` | `1920x1080`, `3840x2160`, `1080x1080`, `2400x2400`, `2880x2880`, `1080x1920`, `2160x3840` |<br/>
        /// | `tiktok` | `1920x1080`, `3840x2160`, `1080x1080`, `2400x2400`, `2880x2880`, `1080x1920`, `2160x3840` |<br/>
        /// | `meta_stories` | `1080x1920`, `2160x3840` |<br/>
        /// | `meta_reels` | `1080x1920`, `2160x3840` |<br/>
        /// | `meta` (legacy) | `1080x1920`, `2160x3840` |<br/>
        /// | `snapchat` | `1080x1920`, `2160x3840` |
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatformJsonConverter))]
        public global::Ideogram.V2.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform? Platform { get; set; }

        /// <summary>
        /// Optional edit instruction to apply while reframing, for example "remove the logo" or "put the price bottom-right".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The quality tier for the reframe. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.AdResizerQualityJsonConverter))]
        public global::Ideogram.V2.AdResizerQuality? Quality { get; set; }

        /// <summary>
        /// The number of reframed variations to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

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
        /// Initializes a new instance of the <see cref="EditWorkflowPostAdResizerRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The source creative to reframe (max size 25MB). JPEG, PNG, and<br/>
        /// WEBP formats are supported. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source creative to reframe (max size 25MB). JPEG, PNG, and<br/>
        /// WEBP formats are supported. Multipart requests only.
        /// </param>
        /// <param name="resolution">
        /// Target ad resolution, formatted as `WIDTHxHEIGHT`. Any value not in<br/>
        /// the list is rejected with a 400. Each output image has exactly these<br/>
        /// pixel dimensions, with or without a `platform`.
        /// </param>
        /// <param name="platform">
        /// The ad platform whose published safe zone the ad must stay inside.<br/>
        /// The ad is generated inside the largest rectangle that fits the<br/>
        /// platform's safe zone for the requested aspect ratio, and the space<br/>
        /// around it is filled in so the output is still exactly the requested<br/>
        /// `resolution`. `google` covers YouTube and Google Ads placements.<br/>
        /// Use `meta_stories` or `meta_reels` for Meta placements; Reels uses<br/>
        /// the largest rectangle inside its notched safe zone. The legacy<br/>
        /// `meta` value is still supported and uses a more conservative safe<br/>
        /// zone. When omitted, the ad fills the whole frame and every<br/>
        /// supported `resolution` is accepted. Any other value is rejected<br/>
        /// with a 400.<br/>
        /// Each platform accepts only the resolutions for which it publishes a<br/>
        /// safe zone; any other `resolution` is rejected with a 400:<br/>
        /// | Platform | Accepted resolutions |<br/>
        /// | --- | --- |<br/>
        /// | `google` | `1920x1080`, `3840x2160`, `1080x1080`, `2400x2400`, `2880x2880`, `1080x1920`, `2160x3840` |<br/>
        /// | `tiktok` | `1920x1080`, `3840x2160`, `1080x1080`, `2400x2400`, `2880x2880`, `1080x1920`, `2160x3840` |<br/>
        /// | `meta_stories` | `1080x1920`, `2160x3840` |<br/>
        /// | `meta_reels` | `1080x1920`, `2160x3840` |<br/>
        /// | `meta` (legacy) | `1080x1920`, `2160x3840` |<br/>
        /// | `snapchat` | `1080x1920`, `2160x3840` |
        /// </param>
        /// <param name="prompt">
        /// Optional edit instruction to apply while reframing, for example "remove the logo" or "put the price bottom-right".
        /// </param>
        /// <param name="quality">
        /// The quality tier for the reframe. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="numImages">
        /// The number of reframed variations to generate.<br/>
        /// Default Value: 1
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
        public EditWorkflowPostAdResizerRequest(
            byte[] image,
            string imagename,
            global::Ideogram.V2.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution resolution,
            global::Ideogram.V2.V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform? platform,
            string? prompt,
            global::Ideogram.V2.AdResizerQuality? quality,
            int? numImages,
            string? webhookUrl)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Resolution = resolution;
            this.Platform = platform;
            this.Prompt = prompt;
            this.Quality = quality;
            this.NumImages = numImages;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditWorkflowPostAdResizerRequest" /> class.
        /// </summary>
        public EditWorkflowPostAdResizerRequest()
        {
        }

    }
}