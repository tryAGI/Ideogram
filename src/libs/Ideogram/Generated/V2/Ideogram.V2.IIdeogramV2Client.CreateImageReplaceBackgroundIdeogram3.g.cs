#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// Replace background with Ideogram 3.0<br/>
        /// Replace the background of an image from a text prompt with Ideogram 3.0,<br/>
        /// keeping the automatically detected foreground subject; no mask is<br/>
        /// needed. Upload the source `image` using `multipart/form-data`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}`<br/>
        /// or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.ReplaceBackgroundResponse> CreateImageReplaceBackgroundIdeogram3Async(

            global::Ideogram.V2.ToolReplaceBackgroundIdeogramV3Request request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace background with Ideogram 3.0<br/>
        /// Replace the background of an image from a text prompt with Ideogram 3.0,<br/>
        /// keeping the automatically detected foreground subject; no mask is<br/>
        /// needed. Upload the source `image` using `multipart/form-data`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}`<br/>
        /// or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.ReplaceBackgroundResponse>> CreateImageReplaceBackgroundIdeogram3AsResponseAsync(

            global::Ideogram.V2.ToolReplaceBackgroundIdeogramV3Request request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace background with Ideogram 3.0<br/>
        /// Replace the background of an image from a text prompt with Ideogram 3.0,<br/>
        /// keeping the automatically detected foreground subject; no mask is<br/>
        /// needed. Upload the source `image` using `multipart/form-data`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}`<br/>
        /// or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Multipart requests only.<br/>
        /// The longer side must be at most 3 times the shorter side; wider<br/>
        /// aspect ratios are rejected with a 400.
        /// </param>
        /// <param name="imagename">
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Multipart requests only.<br/>
        /// The longer side must be at most 3 times the shorter side; wider<br/>
        /// aspect ratios are rejected with a 400.
        /// </param>
        /// <param name="prompt">
        /// Plain-language description of the desired new background.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="private">
        /// Whether to keep the result private. When omitted, defaults to your<br/>
        /// plan's setting. Enterprise generations are always private.
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
        global::System.Threading.Tasks.Task<global::Ideogram.V2.ReplaceBackgroundResponse> CreateImageReplaceBackgroundIdeogram3Async(
            byte[] image,
            string imagename,
            string prompt,
            bool? dryRun = default,
            global::Ideogram.V2.V2ImageReplaceBackgroundIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed = default,
            int? numImages = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Replace background with Ideogram 3.0<br/>
        /// Replace the background of an image from a text prompt with Ideogram 3.0,<br/>
        /// keeping the automatically detected foreground subject; no mask is<br/>
        /// needed. Upload the source `image` using `multipart/form-data`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}`<br/>
        /// or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Multipart requests only.<br/>
        /// The longer side must be at most 3 times the shorter side; wider<br/>
        /// aspect ratios are rejected with a 400.
        /// </param>
        /// <param name="imagename">
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Multipart requests only.<br/>
        /// The longer side must be at most 3 times the shorter side; wider<br/>
        /// aspect ratios are rejected with a 400.
        /// </param>
        /// <param name="prompt">
        /// Plain-language description of the desired new background.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="private">
        /// Whether to keep the result private. When omitted, defaults to your<br/>
        /// plan's setting. Enterprise generations are always private.
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
        global::System.Threading.Tasks.Task<global::Ideogram.V2.ReplaceBackgroundResponse> CreateImageReplaceBackgroundIdeogram3Async(
            global::System.IO.Stream image,
            string imagename,
            string prompt,
            bool? dryRun = default,
            global::Ideogram.V2.V2ImageReplaceBackgroundIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed = default,
            int? numImages = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace background with Ideogram 3.0<br/>
        /// Replace the background of an image from a text prompt with Ideogram 3.0,<br/>
        /// keeping the automatically detected foreground subject; no mask is<br/>
        /// needed. Upload the source `image` using `multipart/form-data`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}`<br/>
        /// or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Multipart requests only.<br/>
        /// The longer side must be at most 3 times the shorter side; wider<br/>
        /// aspect ratios are rejected with a 400.
        /// </param>
        /// <param name="imagename">
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Multipart requests only.<br/>
        /// The longer side must be at most 3 times the shorter side; wider<br/>
        /// aspect ratios are rejected with a 400.
        /// </param>
        /// <param name="prompt">
        /// Plain-language description of the desired new background.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="private">
        /// Whether to keep the result private. When omitted, defaults to your<br/>
        /// plan's setting. Enterprise generations are always private.
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
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.ReplaceBackgroundResponse>> CreateImageReplaceBackgroundIdeogram3AsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            string prompt,
            bool? dryRun = default,
            global::Ideogram.V2.V2ImageReplaceBackgroundIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed = default,
            int? numImages = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}