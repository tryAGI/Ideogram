#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Transfer a shoe upper onto a preserved sole<br/>
        /// Uses the sole-donor shoe as the output canvas, preserving its sole, camera,<br/>
        /// background, and lighting while transferring the upper from ordered references.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned<br/>
        /// `generation_id` until the generation is completed or failed.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.SoleSwapResponse> PostSoleSwapAsync(

            global::Ideogram.SoleSwapRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfer a shoe upper onto a preserved sole<br/>
        /// Uses the sole-donor shoe as the output canvas, preserving its sole, camera,<br/>
        /// background, and lighting while transferring the upper from ordered references.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned<br/>
        /// `generation_id` until the generation is completed or failed.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.SoleSwapResponse>> PostSoleSwapAsResponseAsync(

            global::Ideogram.SoleSwapRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfer a shoe upper onto a preserved sole<br/>
        /// Uses the sole-donor shoe as the output canvas, preserving its sole, camera,<br/>
        /// background, and lighting while transferring the upper from ordered references.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned<br/>
        /// `generation_id` until the generation is completed or failed.
        /// </summary>
        /// <param name="baseAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="upperAssetIdentifiers">
        /// Ordered upper-donor references. Put the primary upper view first, then additional angles of the same upper to transfer.
        /// </param>
        /// <param name="instruction">
        /// Optional additional direction for the sole swap.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. When omitted, the closest supported ratio is derived from the sole-donor base image.
        /// </param>
        /// <param name="baseGenerationSize">
        /// Output resolution tier. Defaults to 2k.<br/>
        /// Default Value: 2k
        /// </param>
        /// <param name="quality">
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="numImages">
        /// Number of sole-swap images to create.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.SoleSwapResponse> PostSoleSwapAsync(
            global::Ideogram.AssetIdentifier baseAssetIdentifier,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier> upperAssetIdentifiers,
            string? instruction = default,
            string? aspectRatio = default,
            global::Ideogram.SoleSwapRequestBaseGenerationSize? baseGenerationSize = default,
            global::Ideogram.GptImage2Quality? quality = default,
            int? seed = default,
            int? numImages = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}