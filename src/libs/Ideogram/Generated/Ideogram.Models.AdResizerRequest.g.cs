
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Upload the source creative as `image` and choose a target `resolution`.
    /// </summary>
    public sealed partial class AdResizerRequest
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// The source creative to reframe (max size 25MB). JPEG, PNG, and<br/>
        /// WEBP formats are supported. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The source creative to reframe (max size 25MB). JPEG, PNG, and<br/>
        /// WEBP formats are supported. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// Target ad resolution, formatted as `WIDTHxHEIGHT`. Any value not in<br/>
        /// the list is rejected with a 400. Each output image has exactly these<br/>
        /// pixel dimensions, with or without a `platform`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AdResizerRequestResolutionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AdResizerRequestResolution Resolution { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AdResizerRequestPlatformJsonConverter))]
        public global::Ideogram.AdResizerRequestPlatform? Platform { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AdResizerQualityJsonConverter))]
        public global::Ideogram.AdResizerQuality? Quality { get; set; }

        /// <summary>
        /// The number of reframed variations to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// A collection you can write to, by its URL-safe base64 collection id. Completed outputs are added to it automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_collection_id")]
        public string? TargetCollectionId { get; set; }

        /// <summary>
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdResizerRequest" /> class.
        /// </summary>
        /// <param name="resolution">
        /// Target ad resolution, formatted as `WIDTHxHEIGHT`. Any value not in<br/>
        /// the list is rejected with a 400. Each output image has exactly these<br/>
        /// pixel dimensions, with or without a `platform`.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The source creative to reframe (max size 25MB). JPEG, PNG, and<br/>
        /// WEBP formats are supported. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source creative to reframe (max size 25MB). JPEG, PNG, and<br/>
        /// WEBP formats are supported. Multipart requests only.
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
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. Completed outputs are added to it automatically.
        /// </param>
        /// <param name="private">
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdResizerRequest(
            global::Ideogram.AdResizerRequestResolution resolution,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            byte[]? image,
            string? imagename,
            global::Ideogram.AdResizerRequestPlatform? platform,
            string? prompt,
            global::Ideogram.AdResizerQuality? quality,
            int? numImages,
            string? targetCollectionId,
            bool? @private,
            string? webhookUrl)
        {
            this.ImageAssetIdentifier = imageAssetIdentifier;
            this.Image = image;
            this.Imagename = imagename;
            this.Resolution = resolution;
            this.Platform = platform;
            this.Prompt = prompt;
            this.Quality = quality;
            this.NumImages = numImages;
            this.TargetCollectionId = targetCollectionId;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdResizerRequest" /> class.
        /// </summary>
        public AdResizerRequest()
        {
        }

    }
}