#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Ad Resizer<br/>
        /// Reframes an ad creative to an exact ad resolution, regenerating the<br/>
        /// layout so text and key elements stay legible at the new size. Upload<br/>
        /// the source creative as `image` using `multipart/form-data`, and supply<br/>
        /// `platform` to keep the ad inside that platform's safe zone.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AdResizerResponse> PostAdResizerAsync(

            global::Ideogram.AdResizerRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ad Resizer<br/>
        /// Reframes an ad creative to an exact ad resolution, regenerating the<br/>
        /// layout so text and key elements stay legible at the new size. Upload<br/>
        /// the source creative as `image` using `multipart/form-data`, and supply<br/>
        /// `platform` to keep the ad inside that platform's safe zone.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.AdResizerResponse>> PostAdResizerAsResponseAsync(

            global::Ideogram.AdResizerRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ad Resizer<br/>
        /// Reframes an ad creative to an exact ad resolution, regenerating the<br/>
        /// layout so text and key elements stay legible at the new size. Upload<br/>
        /// the source creative as `image` using `multipart/form-data`, and supply<br/>
        /// `platform` to keep the ad inside that platform's safe zone.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AdResizerResponse> PostAdResizerAsync(
            global::Ideogram.AdResizerRequestResolution resolution,
            bool? dryRun = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            global::Ideogram.AdResizerRequestPlatform? platform = default,
            string? prompt = default,
            global::Ideogram.AdResizerQuality? quality = default,
            int? numImages = default,
            string? targetCollectionId = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}