#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Render a fashion sketch as product photography<br/>
        /// Converts one fashion sketch into photorealistic garment or product<br/>
        /// imagery while preserving its silhouette, construction, colors, and<br/>
        /// visible design details.<br/>
        /// The request runs asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply exactly one sketch transport: an existing `AssetIdentifier` in<br/>
        /// `sketch_asset_identifier`, or raw `sketch_image` bytes in a multipart<br/>
        /// request. Supplying both or neither is rejected with a 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.SketchToRenderResponse> PostSketchToRenderAsync(

            global::Ideogram.SketchToRenderRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Render a fashion sketch as product photography<br/>
        /// Converts one fashion sketch into photorealistic garment or product<br/>
        /// imagery while preserving its silhouette, construction, colors, and<br/>
        /// visible design details.<br/>
        /// The request runs asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply exactly one sketch transport: an existing `AssetIdentifier` in<br/>
        /// `sketch_asset_identifier`, or raw `sketch_image` bytes in a multipart<br/>
        /// request. Supplying both or neither is rejected with a 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.SketchToRenderResponse>> PostSketchToRenderAsResponseAsync(

            global::Ideogram.SketchToRenderRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Render a fashion sketch as product photography<br/>
        /// Converts one fashion sketch into photorealistic garment or product<br/>
        /// imagery while preserving its silhouette, construction, colors, and<br/>
        /// visible design details.<br/>
        /// The request runs asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply exactly one sketch transport: an existing `AssetIdentifier` in<br/>
        /// `sketch_asset_identifier`, or raw `sketch_image` bytes in a multipart<br/>
        /// request. Supplying both or neither is rejected with a 400.
        /// </summary>
        /// <param name="sketchAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="sketchImage">
        /// Raw fashion-sketch bytes. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP,<br/>
        /// TIFF, and MPO are supported, up to 50 MB. Multipart requests only.<br/>
        /// Mutually exclusive with `sketch_asset_identifier`.
        /// </param>
        /// <param name="sketchImagename">
        /// Raw fashion-sketch bytes. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP,<br/>
        /// TIFF, and MPO are supported, up to 50 MB. Multipart requests only.<br/>
        /// Mutually exclusive with `sketch_asset_identifier`.
        /// </param>
        /// <param name="instruction">
        /// Required material and rendering direction, plus any construction<br/>
        /// or design details that are not legible in the sketch.
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of each output image. Defaults to `1:1` when omitted.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
        /// </param>
        /// <param name="numImages">
        /// Number of product renders to create.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.SketchToRenderResponse> PostSketchToRenderAsync(
            string instruction,
            global::Ideogram.AssetIdentifier? sketchAssetIdentifier = default,
            byte[]? sketchImage = default,
            string? sketchImagename = default,
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