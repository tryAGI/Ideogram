#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Create marketplace-ready product packshots<br/>
        /// Creates one polished product photograph from one or more ordered product<br/>
        /// references. An optional style reference may guide framing, crop,<br/>
        /// background, and lighting without changing the product's identity.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed. Product fidelity is<br/>
        /// best-effort and details absent from every reference may be reconstructed.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.PackshotsResponse> PostPackshotsAsync(

            global::Ideogram.PackshotsRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create marketplace-ready product packshots<br/>
        /// Creates one polished product photograph from one or more ordered product<br/>
        /// references. An optional style reference may guide framing, crop,<br/>
        /// background, and lighting without changing the product's identity.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed. Product fidelity is<br/>
        /// best-effort and details absent from every reference may be reconstructed.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.PackshotsResponse>> PostPackshotsAsResponseAsync(

            global::Ideogram.PackshotsRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create marketplace-ready product packshots<br/>
        /// Creates one polished product photograph from one or more ordered product<br/>
        /// references. An optional style reference may guide framing, crop,<br/>
        /// background, and lighting without changing the product's identity.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed. Product fidelity is<br/>
        /// best-effort and details absent from every reference may be reconstructed.
        /// </summary>
        /// <param name="productAssetIdentifiers">
        /// Ordered uploaded or generated product images. Their product color,<br/>
        /// construction, materials, logos, proportions, and distinguishing<br/>
        /// details guide every output.
        /// </param>
        /// <param name="styleReferenceAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="view">
        /// Product view to generate.
        /// </param>
        /// <param name="instruction">
        /// Optional art direction for the studio background, lighting,<br/>
        /// framing, and presentation. Product fidelity rules always take<br/>
        /// precedence.
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio for every generated image. Supported values are<br/>
        /// `1:1`, `3:4`, `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
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
        global::System.Threading.Tasks.Task<global::Ideogram.PackshotsResponse> PostPackshotsAsync(
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier> productAssetIdentifiers,
            global::Ideogram.PackshotView view,
            global::Ideogram.AssetIdentifier? styleReferenceAssetIdentifier = default,
            string? instruction = default,
            string? aspectRatio = default,
            global::Ideogram.GptImage2Quality? quality = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}