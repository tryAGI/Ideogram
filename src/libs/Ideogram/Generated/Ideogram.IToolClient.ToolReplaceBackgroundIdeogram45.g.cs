#nullable enable

namespace Ideogram
{
    public partial interface IToolClient
    {
        /// <summary>
        /// Replace background with Ideogram 4.5<br/>
        /// Rebuild the background of an image as the setting shown in a<br/>
        /// `background_reference` image, with Ideogram 4.5 at its highest<br/>
        /// quality. The people in the source image are kept, people in the<br/>
        /// reference are left out, and results keep the source image's aspect<br/>
        /// ratio. Returns a `generation_id`; poll<br/>
        /// `GET /v2/generations/{generation_id}` or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ReplaceBackgroundResponse> ToolReplaceBackgroundIdeogram45Async(

            global::Ideogram.ToolReplaceBackgroundIdeogram45Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace background with Ideogram 4.5<br/>
        /// Rebuild the background of an image as the setting shown in a<br/>
        /// `background_reference` image, with Ideogram 4.5 at its highest<br/>
        /// quality. The people in the source image are kept, people in the<br/>
        /// reference are left out, and results keep the source image's aspect<br/>
        /// ratio. Returns a `generation_id`; poll<br/>
        /// `GET /v2/generations/{generation_id}` or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ReplaceBackgroundResponse>> ToolReplaceBackgroundIdeogram45AsResponseAsync(

            global::Ideogram.ToolReplaceBackgroundIdeogram45Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace background with Ideogram 4.5<br/>
        /// Rebuild the background of an image as the setting shown in a<br/>
        /// `background_reference` image, with Ideogram 4.5 at its highest<br/>
        /// quality. The people in the source image are kept, people in the<br/>
        /// reference are left out, and results keep the source image's aspect<br/>
        /// ratio. Returns a `generation_id`; poll<br/>
        /// `GET /v2/generations/{generation_id}` or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Its longer side may be at most the<br/>
        /// model's maximum aspect ratio times its shorter side; a more extreme<br/>
        /// proportion is rejected with a 400 that states the allowed range.<br/>
        /// Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Its longer side may be at most the<br/>
        /// model's maximum aspect ratio times its shorter side; a more extreme<br/>
        /// proportion is rejected with a 400 that states the allowed range.<br/>
        /// Multipart requests only.
        /// </param>
        /// <param name="backgroundReference">
        /// A photo of the setting the new background should match. Its people<br/>
        /// are not copied. It is held to the same aspect-ratio limit as<br/>
        /// `image`. Multipart requests only.
        /// </param>
        /// <param name="backgroundReferencename">
        /// A photo of the setting the new background should match. Its people<br/>
        /// are not copied. It is held to the same aspect-ratio limit as<br/>
        /// `image`. Multipart requests only.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="private">
        /// Whether to keep the result private. When omitted, the result is<br/>
        /// private. Enterprise generations are always private.
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
        global::System.Threading.Tasks.Task<global::Ideogram.ReplaceBackgroundResponse> ToolReplaceBackgroundIdeogram45Async(
            byte[] image,
            string imagename,
            byte[] backgroundReference,
            string backgroundReferencename,
            bool? dryRun = default,
            int? numImages = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Replace background with Ideogram 4.5<br/>
        /// Rebuild the background of an image as the setting shown in a<br/>
        /// `background_reference` image, with Ideogram 4.5 at its highest<br/>
        /// quality. The people in the source image are kept, people in the<br/>
        /// reference are left out, and results keep the source image's aspect<br/>
        /// ratio. Returns a `generation_id`; poll<br/>
        /// `GET /v2/generations/{generation_id}` or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Its longer side may be at most the<br/>
        /// model's maximum aspect ratio times its shorter side; a more extreme<br/>
        /// proportion is rejected with a 400 that states the allowed range.<br/>
        /// Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Its longer side may be at most the<br/>
        /// model's maximum aspect ratio times its shorter side; a more extreme<br/>
        /// proportion is rejected with a 400 that states the allowed range.<br/>
        /// Multipart requests only.
        /// </param>
        /// <param name="backgroundReference">
        /// A photo of the setting the new background should match. Its people<br/>
        /// are not copied. It is held to the same aspect-ratio limit as<br/>
        /// `image`. Multipart requests only.
        /// </param>
        /// <param name="backgroundReferencename">
        /// A photo of the setting the new background should match. Its people<br/>
        /// are not copied. It is held to the same aspect-ratio limit as<br/>
        /// `image`. Multipart requests only.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="private">
        /// Whether to keep the result private. When omitted, the result is<br/>
        /// private. Enterprise generations are always private.
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
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ReplaceBackgroundResponse> ToolReplaceBackgroundIdeogram45Async(
            global::System.IO.Stream image,
            string imagename,
            global::System.IO.Stream backgroundReference,
            string backgroundReferencename,
            bool? dryRun = default,
            int? numImages = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace background with Ideogram 4.5<br/>
        /// Rebuild the background of an image as the setting shown in a<br/>
        /// `background_reference` image, with Ideogram 4.5 at its highest<br/>
        /// quality. The people in the source image are kept, people in the<br/>
        /// reference are left out, and results keep the source image's aspect<br/>
        /// ratio. Returns a `generation_id`; poll<br/>
        /// `GET /v2/generations/{generation_id}` or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Its longer side may be at most the<br/>
        /// model's maximum aspect ratio times its shorter side; a more extreme<br/>
        /// proportion is rejected with a 400 that states the allowed range.<br/>
        /// Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and<br/>
        /// MPO are supported, up to 50 MB. Its longer side may be at most the<br/>
        /// model's maximum aspect ratio times its shorter side; a more extreme<br/>
        /// proportion is rejected with a 400 that states the allowed range.<br/>
        /// Multipart requests only.
        /// </param>
        /// <param name="backgroundReference">
        /// A photo of the setting the new background should match. Its people<br/>
        /// are not copied. It is held to the same aspect-ratio limit as<br/>
        /// `image`. Multipart requests only.
        /// </param>
        /// <param name="backgroundReferencename">
        /// A photo of the setting the new background should match. Its people<br/>
        /// are not copied. It is held to the same aspect-ratio limit as<br/>
        /// `image`. Multipart requests only.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="private">
        /// Whether to keep the result private. When omitted, the result is<br/>
        /// private. Enterprise generations are always private.
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
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ReplaceBackgroundResponse>> ToolReplaceBackgroundIdeogram45AsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            global::System.IO.Stream backgroundReference,
            string backgroundReferencename,
            bool? dryRun = default,
            int? numImages = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}