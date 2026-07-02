#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Generate an editable V4 HTML design asynchronously via webhook<br/>
        /// Accepts an Ideogram 4.0 HTML design request for asynchronous processing and<br/>
        /// returns immediately with a request_id. The generated design is POSTed to the<br/>
        /// supplied `webhook_url` once ready.
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
        global::System.Threading.Tasks.Task<global::Ideogram.AsyncImageGenerationResponseV4> PostGenerateDesignV4AsyncAsync(
            string webhookUrl,

            global::Ideogram.GenerateDesignRequestV4 request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an editable V4 HTML design asynchronously via webhook<br/>
        /// Accepts an Ideogram 4.0 HTML design request for asynchronous processing and<br/>
        /// returns immediately with a request_id. The generated design is POSTed to the<br/>
        /// supplied `webhook_url` once ready.
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.AsyncImageGenerationResponseV4>> PostGenerateDesignV4AsyncAsResponseAsync(
            string webhookUrl,

            global::Ideogram.GenerateDesignRequestV4 request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an editable V4 HTML design asynchronously via webhook<br/>
        /// Accepts an Ideogram 4.0 HTML design request for asynchronous processing and<br/>
        /// returns immediately with a request_id. The generated design is POSTed to the<br/>
        /// supplied `webhook_url` once ready.
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
        /// <param name="prompt">
        /// The text prompt for editable design generation.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="magicPromptOption">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use for this request.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 4.0 layout-to-image and design generation.<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. For Ideogram V4, `rendering_speed=FLASH`<br/>
        /// is coming soon; requests with `rendering_speed=FLASH` currently<br/>
        /// return a 400.
        /// </param>
        /// <param name="inspirationReferenceImages">
        /// Experimental. Up to 4 static inspiration images used as transferable visual style references for V4 layout-to-image design. Images are not edit targets and are not inserted into the generated HTML layout. Supported formats are JPEG, PNG, and WebP (max size 10MB each). Animated images are not supported.
        /// </param>
        /// <param name="inspirationReferenceModel">
        /// Experimental. Model to use for the inspiration vision prepass.<br/>
        /// Default Value: claude-sonnet-4-6
        /// </param>
        /// <param name="artifactGenerationModel">
        /// Experimental. Model to use for the HTML/layout and base-plate handoff generation call.<br/>
        /// Default Value: claude-sonnet-4-6
        /// </param>
        /// <param name="layout2imageVariant">
        /// Experimental. Staging only. Select a v4 layout-to-image pipeline variant.<br/>
        /// Omit for the default v4l2i path. Rejected on production.
        /// </param>
        /// <param name="responseType">
        /// layered (default): full editable design payload with text layers and HTML.<br/>
        /// url: JSON with an expiring link to the final composited cover image.<br/>
        /// binary: raw PNG bytes of the final composited cover image (Content-Type image/png).<br/>
        /// html: raw HTML document of the generated layout (Content-Type text/html).<br/>
        /// Default Value: layered
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AsyncImageGenerationResponseV4> PostGenerateDesignV4AsyncAsync(
            string webhookUrl,
            string prompt,
            int? seed = default,
            global::Ideogram.MagicPromptOption? magicPromptOption = default,
            string? magicPromptSystemPromptConfigId = default,
            global::Ideogram.ResolutionV4Layout? resolution = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            global::System.Collections.Generic.IList<byte[]>? inspirationReferenceImages = default,
            global::Ideogram.GenerateDesignRequestV4InspirationReferenceModel? inspirationReferenceModel = default,
            global::Ideogram.GenerateDesignRequestV4ArtifactGenerationModel? artifactGenerationModel = default,
            global::Ideogram.GenerateDesignRequestV4Layout2imageVariant? layout2imageVariant = default,
            global::Ideogram.GenerateDesignRequestV4ResponseType? responseType = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}