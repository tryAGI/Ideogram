#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Model Swap<br/>
        /// Replaces the model in a fashion image with the person shown in one to<br/>
        /// four target-model references, keeping the product, pose, scene,<br/>
        /// lighting, and framing. Upload the working image as `source_image` using<br/>
        /// `multipart/form-data`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ModelSwapResponse> PostModelSwapAsync(

            global::Ideogram.ModelSwapRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Model Swap<br/>
        /// Replaces the model in a fashion image with the person shown in one to<br/>
        /// four target-model references, keeping the product, pose, scene,<br/>
        /// lighting, and framing. Upload the working image as `source_image` using<br/>
        /// `multipart/form-data`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ModelSwapResponse>> PostModelSwapAsResponseAsync(

            global::Ideogram.ModelSwapRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Model Swap<br/>
        /// Replaces the model in a fashion image with the person shown in one to<br/>
        /// four target-model references, keeping the product, pose, scene,<br/>
        /// lighting, and framing. Upload the working image as `source_image` using<br/>
        /// `multipart/form-data`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="sourceAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="sourceImage">
        /// The working image whose product, pose, scene, lighting, framing, and camera are preserved. Supported formats and the 50 MB limit match the image upload API. Multipart requests only.
        /// </param>
        /// <param name="sourceImagename">
        /// The working image whose product, pose, scene, lighting, framing, and camera are preserved. Supported formats and the 50 MB limit match the image upload API. Multipart requests only.
        /// </param>
        /// <param name="modelAssetIdentifiers">
        /// Ordered target-model identity and angle references. These images supply only identity, hair, skin tone, and body proportions.
        /// </param>
        /// <param name="instruction">
        /// Optional identity details that are not visible in the target-model references. This cannot override the source roles described above.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. When omitted, the closest supported ratio is derived from the working image.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
        /// </param>
        /// <param name="numImages">
        /// Number of model-swap images to create.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.ModelSwapResponse> PostModelSwapAsync(
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier> modelAssetIdentifiers,
            global::Ideogram.AssetIdentifier? sourceAssetIdentifier = default,
            byte[]? sourceImage = default,
            string? sourceImagename = default,
            string? instruction = default,
            string? aspectRatio = default,
            global::Ideogram.ModelSwapQuality? quality = default,
            int? seed = default,
            int? numImages = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}