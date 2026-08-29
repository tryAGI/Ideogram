#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Generate pose variants of a fashion image<br/>
        /// Changes the model's pose or camera presentation while preserving the<br/>
        /// source model, garment, styling, and scene. An optional pose-reference<br/>
        /// image supplies body pose and gaze only; it does not supply identity,<br/>
        /// clothing, or styling.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply the source as either an `AssetIdentifier` reference<br/>
        /// (`source_asset_identifier`) or raw image bytes (`source_image`,<br/>
        /// multipart requests only). Provide exactly one source form; supplying<br/>
        /// both, or neither, is rejected with a 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ModelPoseVariantsResponse> PostModelPoseVariantsAsync(

            global::Ideogram.ModelPoseVariantsRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate pose variants of a fashion image<br/>
        /// Changes the model's pose or camera presentation while preserving the<br/>
        /// source model, garment, styling, and scene. An optional pose-reference<br/>
        /// image supplies body pose and gaze only; it does not supply identity,<br/>
        /// clothing, or styling.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply the source as either an `AssetIdentifier` reference<br/>
        /// (`source_asset_identifier`) or raw image bytes (`source_image`,<br/>
        /// multipart requests only). Provide exactly one source form; supplying<br/>
        /// both, or neither, is rejected with a 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ModelPoseVariantsResponse>> PostModelPoseVariantsAsResponseAsync(

            global::Ideogram.ModelPoseVariantsRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate pose variants of a fashion image<br/>
        /// Changes the model's pose or camera presentation while preserving the<br/>
        /// source model, garment, styling, and scene. An optional pose-reference<br/>
        /// image supplies body pose and gaze only; it does not supply identity,<br/>
        /// clothing, or styling.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply the source as either an `AssetIdentifier` reference<br/>
        /// (`source_asset_identifier`) or raw image bytes (`source_image`,<br/>
        /// multipart requests only). Provide exactly one source form; supplying<br/>
        /// both, or neither, is rejected with a 400.
        /// </summary>
        /// <param name="sourceAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="sourceImage">
        /// Fashion image to edit (max size 50MB), as raw bytes. JPEG, PNG,<br/>
        /// WEBP, HEIF, AVIF, GIF, BMP, TIFF, and MPO formats are supported.<br/>
        /// Multipart requests only. Provide exactly one of<br/>
        /// `source_asset_identifier` or `source_image`.
        /// </param>
        /// <param name="sourceImagename">
        /// Fashion image to edit (max size 50MB), as raw bytes. JPEG, PNG,<br/>
        /// WEBP, HEIF, AVIF, GIF, BMP, TIFF, and MPO formats are supported.<br/>
        /// Multipart requests only. Provide exactly one of<br/>
        /// `source_asset_identifier` or `source_image`.
        /// </param>
        /// <param name="poseReferenceAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="instruction">
        /// Required plain-language pose or camera direction, such as a<br/>
        /// front-facing catalog stance or right-facing walking profile.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. When omitted, the nearest supported ratio is<br/>
        /// derived from the source image. Supported values are `1:1`, `3:4`,<br/>
        /// `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
        /// </param>
        /// <param name="numImages">
        /// Number of pose variants to create.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.ModelPoseVariantsResponse> PostModelPoseVariantsAsync(
            string instruction,
            global::Ideogram.AssetIdentifier? sourceAssetIdentifier = default,
            byte[]? sourceImage = default,
            string? sourceImagename = default,
            global::Ideogram.AssetIdentifier? poseReferenceAssetIdentifier = default,
            string? aspectRatio = default,
            global::Ideogram.GptImage2Quality? quality = default,
            int? seed = default,
            int? numImages = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}