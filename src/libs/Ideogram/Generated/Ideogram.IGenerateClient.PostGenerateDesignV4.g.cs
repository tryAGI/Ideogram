#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Generate an editable design with Ideogram 4.0 HTML<br/>
        /// Experimental prototype endpoint for generating an editable V4 HTML design from a prompt.<br/>
        /// Optionally accepts inspiration reference images to guide transferable visual style. Inspiration images are design/style references only and are not edit targets.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.PostGenerateDesignV4200Response> PostGenerateDesignV4Async(

            global::Ideogram.GenerateDesignRequestV4 request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an editable design with Ideogram 4.0 HTML<br/>
        /// Experimental prototype endpoint for generating an editable V4 HTML design from a prompt.<br/>
        /// Optionally accepts inspiration reference images to guide transferable visual style. Inspiration images are design/style references only and are not edit targets.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.PostGenerateDesignV4200Response>> PostGenerateDesignV4AsResponseAsync(

            global::Ideogram.GenerateDesignRequestV4 request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an editable design with Ideogram 4.0 HTML<br/>
        /// Experimental prototype endpoint for generating an editable V4 HTML design from a prompt.<br/>
        /// Optionally accepts inspiration reference images to guide transferable visual style. Inspiration images are design/style references only and are not edit targets.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Ideogram.PostGenerateDesignV4200Response> PostGenerateDesignV4Async(
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