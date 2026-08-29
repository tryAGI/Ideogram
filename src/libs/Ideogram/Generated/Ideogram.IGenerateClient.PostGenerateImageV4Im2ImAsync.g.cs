#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Image-to-image with Ideogram 4.0 asynchronously via webhook<br/>
        /// Accepts an Ideogram 4.0 image-to-image request for asynchronous processing<br/>
        /// and returns immediately with a request_id. The generated images are POSTed<br/>
        /// to the supplied `webhook_url` once ready.
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
        global::System.Threading.Tasks.Task<global::Ideogram.AsyncImageGenerationResponseV4> PostGenerateImageV4Im2ImAsyncAsync(
            string webhookUrl,

            global::Ideogram.GenerateImageRequestV4Im2Im request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image-to-image with Ideogram 4.0 asynchronously via webhook<br/>
        /// Accepts an Ideogram 4.0 image-to-image request for asynchronous processing<br/>
        /// and returns immediately with a request_id. The generated images are POSTed<br/>
        /// to the supplied `webhook_url` once ready.
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.AsyncImageGenerationResponseV4>> PostGenerateImageV4Im2ImAsyncAsResponseAsync(
            string webhookUrl,

            global::Ideogram.GenerateImageRequestV4Im2Im request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image-to-image with Ideogram 4.0 asynchronously via webhook<br/>
        /// Accepts an Ideogram 4.0 image-to-image request for asynchronous processing<br/>
        /// and returns immediately with a request_id. The generated images are POSTed<br/>
        /// to the supplied `webhook_url` once ready.
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
        /// <param name="additionalImages">
        /// Optional. Up to 4 additional reference images used together with `image` to condition<br/>
        /// the generation, for a maximum of 5 reference images total. Each image may be up to 25MB;<br/>
        /// only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="prompt">
        /// An optional text prompt to guide the generation.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="magicPromptOption">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use for this request.
        /// </param>
        /// <param name="resolution">
        /// Output resolutions for Ideogram 4.0 image-to-image. Superset of ResolutionV4 (the 1K/2K t2im set) plus the small 512-tier (512x512, 768x384, 384x768).<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. For Ideogram V4, `rendering_speed=FLASH`<br/>
        /// is coming soon; requests with `rendering_speed=FLASH` currently<br/>
        /// return a 400.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). See GenerateImageRequestV3 for details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AsyncImageGenerationResponseV4> PostGenerateImageV4Im2ImAsyncAsync(
            string webhookUrl,
            byte[] image,
            string imagename,
            global::System.Collections.Generic.IList<byte[]>? additionalImages = default,
            string? prompt = default,
            int? seed = default,
            global::Ideogram.MagicPromptOption? magicPromptOption = default,
            string? magicPromptSystemPromptConfigId = default,
            global::Ideogram.ResolutionV4ImageToImage? resolution = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            bool? enableCopyrightDetection = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Image-to-image with Ideogram 4.0 asynchronously via webhook<br/>
        /// Accepts an Ideogram 4.0 image-to-image request for asynchronous processing<br/>
        /// and returns immediately with a request_id. The generated images are POSTed<br/>
        /// to the supplied `webhook_url` once ready.
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
        /// <param name="additionalImages">
        /// Optional. Up to 4 additional reference images used together with `image` to condition<br/>
        /// the generation, for a maximum of 5 reference images total. Each image may be up to 25MB;<br/>
        /// only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="additionalImagesFileNames">
        /// Optional file names to use for the multipart 'additional_images' file parts.
        /// </param>
        /// <param name="prompt">
        /// An optional text prompt to guide the generation.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="magicPromptOption">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use for this request.
        /// </param>
        /// <param name="resolution">
        /// Output resolutions for Ideogram 4.0 image-to-image. Superset of ResolutionV4 (the 1K/2K t2im set) plus the small 512-tier (512x512, 768x384, 384x768).<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. For Ideogram V4, `rendering_speed=FLASH`<br/>
        /// is coming soon; requests with `rendering_speed=FLASH` currently<br/>
        /// return a 400.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). See GenerateImageRequestV3 for details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AsyncImageGenerationResponseV4> PostGenerateImageV4Im2ImAsyncAsync(
            string webhookUrl,
            global::System.IO.Stream image,
            string imagename,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? additionalImages = default,
            global::System.Collections.Generic.IReadOnlyList<string>? additionalImagesFileNames = default,
            string? prompt = default,
            int? seed = default,
            global::Ideogram.MagicPromptOption? magicPromptOption = default,
            string? magicPromptSystemPromptConfigId = default,
            global::Ideogram.ResolutionV4ImageToImage? resolution = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            bool? enableCopyrightDetection = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image-to-image with Ideogram 4.0 asynchronously via webhook<br/>
        /// Accepts an Ideogram 4.0 image-to-image request for asynchronous processing<br/>
        /// and returns immediately with a request_id. The generated images are POSTed<br/>
        /// to the supplied `webhook_url` once ready.
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
        /// <param name="additionalImages">
        /// Optional. Up to 4 additional reference images used together with `image` to condition<br/>
        /// the generation, for a maximum of 5 reference images total. Each image may be up to 25MB;<br/>
        /// only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="additionalImagesFileNames">
        /// Optional file names to use for the multipart 'additional_images' file parts.
        /// </param>
        /// <param name="prompt">
        /// An optional text prompt to guide the generation.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="magicPromptOption">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use for this request.
        /// </param>
        /// <param name="resolution">
        /// Output resolutions for Ideogram 4.0 image-to-image. Superset of ResolutionV4 (the 1K/2K t2im set) plus the small 512-tier (512x512, 768x384, 384x768).<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. For Ideogram V4, `rendering_speed=FLASH`<br/>
        /// is coming soon; requests with `rendering_speed=FLASH` currently<br/>
        /// return a 400.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). See GenerateImageRequestV3 for details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.AsyncImageGenerationResponseV4>> PostGenerateImageV4Im2ImAsyncAsResponseAsync(
            string webhookUrl,
            global::System.IO.Stream image,
            string imagename,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? additionalImages = default,
            global::System.Collections.Generic.IReadOnlyList<string>? additionalImagesFileNames = default,
            string? prompt = default,
            int? seed = default,
            global::Ideogram.MagicPromptOption? magicPromptOption = default,
            string? magicPromptSystemPromptConfigId = default,
            global::Ideogram.ResolutionV4ImageToImage? resolution = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            bool? enableCopyrightDetection = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}