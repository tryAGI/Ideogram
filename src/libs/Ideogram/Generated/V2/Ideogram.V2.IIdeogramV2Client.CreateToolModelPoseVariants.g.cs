#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// Model Pose Variants<br/>
        /// Changes the model's pose or camera angle in a fashion image while<br/>
        /// preserving the model, garment, styling, and scene. Upload the<br/>
        /// `source_image` using `multipart/form-data` and describe the new pose in<br/>
        /// `instruction`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.ModelPoseVariantsResponse> CreateToolModelPoseVariantsAsync(

            global::Ideogram.V2.EditWorkflowPostModelPoseVariantsRequest request,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Model Pose Variants<br/>
        /// Changes the model's pose or camera angle in a fashion image while<br/>
        /// preserving the model, garment, styling, and scene. Upload the<br/>
        /// `source_image` using `multipart/form-data` and describe the new pose in<br/>
        /// `instruction`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.ModelPoseVariantsResponse>> CreateToolModelPoseVariantsAsResponseAsync(

            global::Ideogram.V2.EditWorkflowPostModelPoseVariantsRequest request,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Model Pose Variants<br/>
        /// Changes the model's pose or camera angle in a fashion image while<br/>
        /// preserving the model, garment, styling, and scene. Upload the<br/>
        /// `source_image` using `multipart/form-data` and describe the new pose in<br/>
        /// `instruction`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="sourceImage">
        /// Fashion image to edit (max size 50MB). JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO formats are supported. Multipart<br/>
        /// requests only.
        /// </param>
        /// <param name="sourceImagename">
        /// Fashion image to edit (max size 50MB). JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO formats are supported. Multipart<br/>
        /// requests only.
        /// </param>
        /// <param name="instruction">
        /// Plain-language pose or camera direction, such as a front-facing<br/>
        /// catalog stance or right-facing walking profile.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. When omitted, the nearest supported ratio is<br/>
        /// derived from the source image. Supported values are `1:1`, `3:4`,<br/>
        /// `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
        /// </param>
        /// <param name="numImages">
        /// Number of pose variants to create.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.V2.ModelPoseVariantsResponse> CreateToolModelPoseVariantsAsync(
            byte[] sourceImage,
            string sourceImagename,
            string instruction,
            string? aspectRatio = default,
            global::Ideogram.V2.ModelPoseVariantsQuality? quality = default,
            int? seed = default,
            int? numImages = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Model Pose Variants<br/>
        /// Changes the model's pose or camera angle in a fashion image while<br/>
        /// preserving the model, garment, styling, and scene. Upload the<br/>
        /// `source_image` using `multipart/form-data` and describe the new pose in<br/>
        /// `instruction`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="sourceImage">
        /// Fashion image to edit (max size 50MB). JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO formats are supported. Multipart<br/>
        /// requests only.
        /// </param>
        /// <param name="sourceImagename">
        /// Fashion image to edit (max size 50MB). JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO formats are supported. Multipart<br/>
        /// requests only.
        /// </param>
        /// <param name="instruction">
        /// Plain-language pose or camera direction, such as a front-facing<br/>
        /// catalog stance or right-facing walking profile.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. When omitted, the nearest supported ratio is<br/>
        /// derived from the source image. Supported values are `1:1`, `3:4`,<br/>
        /// `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
        /// </param>
        /// <param name="numImages">
        /// Number of pose variants to create.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.V2.ModelPoseVariantsResponse> CreateToolModelPoseVariantsAsync(
            global::System.IO.Stream sourceImage,
            string sourceImagename,
            string instruction,
            string? aspectRatio = default,
            global::Ideogram.V2.ModelPoseVariantsQuality? quality = default,
            int? seed = default,
            int? numImages = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Model Pose Variants<br/>
        /// Changes the model's pose or camera angle in a fashion image while<br/>
        /// preserving the model, garment, styling, and scene. Upload the<br/>
        /// `source_image` using `multipart/form-data` and describe the new pose in<br/>
        /// `instruction`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="sourceImage">
        /// Fashion image to edit (max size 50MB). JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO formats are supported. Multipart<br/>
        /// requests only.
        /// </param>
        /// <param name="sourceImagename">
        /// Fashion image to edit (max size 50MB). JPEG, PNG, WEBP, HEIF,<br/>
        /// AVIF, GIF, BMP, TIFF, and MPO formats are supported. Multipart<br/>
        /// requests only.
        /// </param>
        /// <param name="instruction">
        /// Plain-language pose or camera direction, such as a front-facing<br/>
        /// catalog stance or right-facing walking profile.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. When omitted, the nearest supported ratio is<br/>
        /// derived from the source image. Supported values are `1:1`, `3:4`,<br/>
        /// `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
        /// </param>
        /// <param name="numImages">
        /// Number of pose variants to create.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.ModelPoseVariantsResponse>> CreateToolModelPoseVariantsAsResponseAsync(
            global::System.IO.Stream sourceImage,
            string sourceImagename,
            string instruction,
            string? aspectRatio = default,
            global::Ideogram.V2.ModelPoseVariantsQuality? quality = default,
            int? seed = default,
            int? numImages = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}