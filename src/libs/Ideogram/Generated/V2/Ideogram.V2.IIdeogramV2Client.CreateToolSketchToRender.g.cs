#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// Sketch to Render<br/>
        /// Turns a fashion sketch into photorealistic garment or product imagery,<br/>
        /// preserving its silhouette, construction, colors, and design details.<br/>
        /// Upload the `sketch_image` using `multipart/form-data` and describe<br/>
        /// materials and rendering in `instruction`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.SketchToRenderResponse> CreateToolSketchToRenderAsync(

            global::Ideogram.V2.EditWorkflowPostSketchToRenderRequest request,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sketch to Render<br/>
        /// Turns a fashion sketch into photorealistic garment or product imagery,<br/>
        /// preserving its silhouette, construction, colors, and design details.<br/>
        /// Upload the `sketch_image` using `multipart/form-data` and describe<br/>
        /// materials and rendering in `instruction`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.SketchToRenderResponse>> CreateToolSketchToRenderAsResponseAsync(

            global::Ideogram.V2.EditWorkflowPostSketchToRenderRequest request,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sketch to Render<br/>
        /// Turns a fashion sketch into photorealistic garment or product imagery,<br/>
        /// preserving its silhouette, construction, colors, and design details.<br/>
        /// Upload the `sketch_image` using `multipart/form-data` and describe<br/>
        /// materials and rendering in `instruction`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="sketchImage">
        /// The fashion sketch to render, up to 50 MB. JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO are supported. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="sketchImagename">
        /// The fashion sketch to render, up to 50 MB. JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO are supported. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="instruction">
        /// Material and rendering direction, plus any construction or design<br/>
        /// details that are not legible in the sketch.
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of each output image. Defaults to `1:1` when omitted.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
        /// </param>
        /// <param name="numImages">
        /// Number of product renders to create.<br/>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.SketchToRenderResponse> CreateToolSketchToRenderAsync(
            byte[] sketchImage,
            string sketchImagename,
            string instruction,
            string? aspectRatio = default,
            global::Ideogram.V2.SketchToRenderQuality? quality = default,
            int? seed = default,
            int? numImages = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Sketch to Render<br/>
        /// Turns a fashion sketch into photorealistic garment or product imagery,<br/>
        /// preserving its silhouette, construction, colors, and design details.<br/>
        /// Upload the `sketch_image` using `multipart/form-data` and describe<br/>
        /// materials and rendering in `instruction`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="sketchImage">
        /// The fashion sketch to render, up to 50 MB. JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO are supported. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="sketchImagename">
        /// The fashion sketch to render, up to 50 MB. JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO are supported. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="instruction">
        /// Material and rendering direction, plus any construction or design<br/>
        /// details that are not legible in the sketch.
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of each output image. Defaults to `1:1` when omitted.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
        /// </param>
        /// <param name="numImages">
        /// Number of product renders to create.<br/>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.SketchToRenderResponse> CreateToolSketchToRenderAsync(
            global::System.IO.Stream sketchImage,
            string sketchImagename,
            string instruction,
            string? aspectRatio = default,
            global::Ideogram.V2.SketchToRenderQuality? quality = default,
            int? seed = default,
            int? numImages = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sketch to Render<br/>
        /// Turns a fashion sketch into photorealistic garment or product imagery,<br/>
        /// preserving its silhouette, construction, colors, and design details.<br/>
        /// Upload the `sketch_image` using `multipart/form-data` and describe<br/>
        /// materials and rendering in `instruction`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="sketchImage">
        /// The fashion sketch to render, up to 50 MB. JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO are supported. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="sketchImagename">
        /// The fashion sketch to render, up to 50 MB. JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO are supported. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="instruction">
        /// Material and rendering direction, plus any construction or design<br/>
        /// details that are not legible in the sketch.
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of each output image. Defaults to `1:1` when omitted.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
        /// </param>
        /// <param name="numImages">
        /// Number of product renders to create.<br/>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.SketchToRenderResponse>> CreateToolSketchToRenderAsResponseAsync(
            global::System.IO.Stream sketchImage,
            string sketchImagename,
            string instruction,
            string? aspectRatio = default,
            global::Ideogram.V2.SketchToRenderQuality? quality = default,
            int? seed = default,
            int? numImages = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}