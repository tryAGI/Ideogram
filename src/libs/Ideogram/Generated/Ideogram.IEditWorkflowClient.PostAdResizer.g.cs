#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Advertisement Resizer<br/>
        /// Reframes the source creative to the exact requested ad resolution,<br/>
        /// regenerating the layout so text and key elements stay legible at the<br/>
        /// target size.<br/>
        /// Supply `platform` to keep the whole advertisement clear of that<br/>
        /// platform's own interface. The advertisement is generated at the largest<br/>
        /// rectangle that fits inside the platform's published safe zone for the<br/>
        /// requested aspect ratio, placed at that rectangle's position, and the<br/>
        /// space around it is filled in so the returned image is still exactly the<br/>
        /// requested resolution. Omit `platform` and the advertisement fills the<br/>
        /// whole frame.<br/>
        /// Safe zones are published per aspect ratio, and not every platform<br/>
        /// publishes one for every ratio. `google` and `tiktok` publish `16:9`,<br/>
        /// `1:1`, and `9:16`; `meta` and `snapchat` publish `9:16` only. A<br/>
        /// `platform` combined with a `resolution` that platform has no safe zone<br/>
        /// for is rejected with a 400.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed. The completed generation<br/>
        /// reports the exact amount billed for the request in<br/>
        /// `usage_cost_usd_micros`.<br/>
        /// Supply the source creative as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two forms;<br/>
        /// supplying both, or neither, is rejected with a 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AdResizerResponse> PostAdResizerAsync(

            global::Ideogram.AdResizerRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Advertisement Resizer<br/>
        /// Reframes the source creative to the exact requested ad resolution,<br/>
        /// regenerating the layout so text and key elements stay legible at the<br/>
        /// target size.<br/>
        /// Supply `platform` to keep the whole advertisement clear of that<br/>
        /// platform's own interface. The advertisement is generated at the largest<br/>
        /// rectangle that fits inside the platform's published safe zone for the<br/>
        /// requested aspect ratio, placed at that rectangle's position, and the<br/>
        /// space around it is filled in so the returned image is still exactly the<br/>
        /// requested resolution. Omit `platform` and the advertisement fills the<br/>
        /// whole frame.<br/>
        /// Safe zones are published per aspect ratio, and not every platform<br/>
        /// publishes one for every ratio. `google` and `tiktok` publish `16:9`,<br/>
        /// `1:1`, and `9:16`; `meta` and `snapchat` publish `9:16` only. A<br/>
        /// `platform` combined with a `resolution` that platform has no safe zone<br/>
        /// for is rejected with a 400.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed. The completed generation<br/>
        /// reports the exact amount billed for the request in<br/>
        /// `usage_cost_usd_micros`.<br/>
        /// Supply the source creative as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two forms;<br/>
        /// supplying both, or neither, is rejected with a 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.AdResizerResponse>> PostAdResizerAsResponseAsync(

            global::Ideogram.AdResizerRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Advertisement Resizer<br/>
        /// Reframes the source creative to the exact requested ad resolution,<br/>
        /// regenerating the layout so text and key elements stay legible at the<br/>
        /// target size.<br/>
        /// Supply `platform` to keep the whole advertisement clear of that<br/>
        /// platform's own interface. The advertisement is generated at the largest<br/>
        /// rectangle that fits inside the platform's published safe zone for the<br/>
        /// requested aspect ratio, placed at that rectangle's position, and the<br/>
        /// space around it is filled in so the returned image is still exactly the<br/>
        /// requested resolution. Omit `platform` and the advertisement fills the<br/>
        /// whole frame.<br/>
        /// Safe zones are published per aspect ratio, and not every platform<br/>
        /// publishes one for every ratio. `google` and `tiktok` publish `16:9`,<br/>
        /// `1:1`, and `9:16`; `meta` and `snapchat` publish `9:16` only. A<br/>
        /// `platform` combined with a `resolution` that platform has no safe zone<br/>
        /// for is rejected with a 400.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed. The completed generation<br/>
        /// reports the exact amount billed for the request in<br/>
        /// `usage_cost_usd_micros`.<br/>
        /// Supply the source creative as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two forms;<br/>
        /// supplying both, or neither, is rejected with a 400.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The source creative to reframe (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Multipart requests only.<br/>
        /// Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="imagename">
        /// The source creative to reframe (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Multipart requests only.<br/>
        /// Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="resolution">
        /// Target ad resolution, formatted as `WIDTHxHEIGHT`. Must be one of<br/>
        /// the supported ad resolutions listed above; any other value is<br/>
        /// rejected with a 400. Each returned image has exactly these pixel<br/>
        /// dimensions, whether or not a `platform` was supplied.
        /// </param>
        /// <param name="platform">
        /// The ad platform whose published safe zone the advertisement must<br/>
        /// stay inside. `google` covers YouTube and Google Ads placements;<br/>
        /// `meta` covers Facebook and Instagram. When supplied, the<br/>
        /// advertisement is generated inside that platform's safe zone for the<br/>
        /// requested aspect ratio and the remaining space is filled in around<br/>
        /// it. When omitted, the advertisement fills the whole frame. Any other<br/>
        /// value is rejected with a 400.
        /// </param>
        /// <param name="prompt">
        /// Optional edit instruction to apply while reframing, for example "remove the logo" or "put the price bottom-right".
        /// </param>
        /// <param name="quality">
        /// The generation quality level. Higher levels may use more inference steps<br/>
        /// or additional prompt processing. `VERY_HIGH` generates multiple<br/>
        /// candidates internally and returns the strongest result, so it has<br/>
        /// noticeably higher latency and cost than the other levels.
        /// </param>
        /// <param name="numImages">
        /// The number of reframed variations to generate.<br/>
        /// Default Value: 1
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
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            global::Ideogram.AdResizerRequestPlatform? platform = default,
            string? prompt = default,
            global::Ideogram.Quality? quality = default,
            int? numImages = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}