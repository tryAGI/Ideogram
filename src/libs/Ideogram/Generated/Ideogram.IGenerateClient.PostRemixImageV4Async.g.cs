#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Remix with Ideogram 4.0 asynchronously<br/>
        /// Accepts an Ideogram 4.0 remix request for asynchronous processing and returns<br/>
        /// immediately with a `generation_id`. Poll `GET /v1/generations/{generation_id}`<br/>
        /// to retrieve the result. If a `webhook_url` is supplied, the generated images<br/>
        /// are additionally POSTed to it once ready.
        /// </summary>
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AsyncImageGenerationResponseV4> PostRemixImageV4AsyncAsync(

            global::Ideogram.RemixImageRequestV4 request,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix with Ideogram 4.0 asynchronously<br/>
        /// Accepts an Ideogram 4.0 remix request for asynchronous processing and returns<br/>
        /// immediately with a `generation_id`. Poll `GET /v1/generations/{generation_id}`<br/>
        /// to retrieve the result. If a `webhook_url` is supplied, the generated images<br/>
        /// are additionally POSTed to it once ready.
        /// </summary>
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.AsyncImageGenerationResponseV4>> PostRemixImageV4AsyncAsResponseAsync(

            global::Ideogram.RemixImageRequestV4 request,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix with Ideogram 4.0 asynchronously<br/>
        /// Accepts an Ideogram 4.0 remix request for asynchronous processing and returns<br/>
        /// immediately with a `generation_id`. Poll `GET /v1/generations/{generation_id}`<br/>
        /// to retrieve the result. If a `webhook_url` is supplied, the generated images<br/>
        /// are additionally POSTed to it once ready.
        /// </summary>
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
        /// <param name="image">
        /// The initial image binary (max 25MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The initial image binary (max 25MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="textPrompt">
        /// The text prompt that guides the remix.
        /// </param>
        /// <param name="imageWeight">
        /// Optional. How strongly the output should resemble the input image. Higher values keep<br/>
        /// the input image's structure; lower values allow the prompt to drive the output more.<br/>
        /// When omitted, the weight is chosen automatically from the edit instruction; supplying<br/>
        /// a value overrides that automatic choice.
        /// </param>
        /// <param name="resolution">
        /// The 1K and 2K resolutions supported for Ideogram 4.0 image generation.<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). See GenerateImageRequestV3 for details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AsyncImageGenerationResponseV4> PostRemixImageV4AsyncAsync(
            byte[] image,
            string imagename,
            string textPrompt,
            string? webhookUrl = default,
            int? imageWeight = default,
            global::Ideogram.ResolutionV4? resolution = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            bool? enableCopyrightDetection = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remix with Ideogram 4.0 asynchronously<br/>
        /// Accepts an Ideogram 4.0 remix request for asynchronous processing and returns<br/>
        /// immediately with a `generation_id`. Poll `GET /v1/generations/{generation_id}`<br/>
        /// to retrieve the result. If a `webhook_url` is supplied, the generated images<br/>
        /// are additionally POSTed to it once ready.
        /// </summary>
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
        /// <param name="image">
        /// The initial image binary (max 25MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The initial image binary (max 25MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="textPrompt">
        /// The text prompt that guides the remix.
        /// </param>
        /// <param name="imageWeight">
        /// Optional. How strongly the output should resemble the input image. Higher values keep<br/>
        /// the input image's structure; lower values allow the prompt to drive the output more.<br/>
        /// When omitted, the weight is chosen automatically from the edit instruction; supplying<br/>
        /// a value overrides that automatic choice.
        /// </param>
        /// <param name="resolution">
        /// The 1K and 2K resolutions supported for Ideogram 4.0 image generation.<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). See GenerateImageRequestV3 for details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AsyncImageGenerationResponseV4> PostRemixImageV4AsyncAsync(
            global::System.IO.Stream image,
            string imagename,
            string textPrompt,
            string? webhookUrl = default,
            int? imageWeight = default,
            global::Ideogram.ResolutionV4? resolution = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            bool? enableCopyrightDetection = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix with Ideogram 4.0 asynchronously<br/>
        /// Accepts an Ideogram 4.0 remix request for asynchronous processing and returns<br/>
        /// immediately with a `generation_id`. Poll `GET /v1/generations/{generation_id}`<br/>
        /// to retrieve the result. If a `webhook_url` is supplied, the generated images<br/>
        /// are additionally POSTed to it once ready.
        /// </summary>
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
        /// <param name="image">
        /// The initial image binary (max 25MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The initial image binary (max 25MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="textPrompt">
        /// The text prompt that guides the remix.
        /// </param>
        /// <param name="imageWeight">
        /// Optional. How strongly the output should resemble the input image. Higher values keep<br/>
        /// the input image's structure; lower values allow the prompt to drive the output more.<br/>
        /// When omitted, the weight is chosen automatically from the edit instruction; supplying<br/>
        /// a value overrides that automatic choice.
        /// </param>
        /// <param name="resolution">
        /// The 1K and 2K resolutions supported for Ideogram 4.0 image generation.<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). See GenerateImageRequestV3 for details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.AsyncImageGenerationResponseV4>> PostRemixImageV4AsyncAsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            string textPrompt,
            string? webhookUrl = default,
            int? imageWeight = default,
            global::Ideogram.ResolutionV4? resolution = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            bool? enableCopyrightDetection = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}