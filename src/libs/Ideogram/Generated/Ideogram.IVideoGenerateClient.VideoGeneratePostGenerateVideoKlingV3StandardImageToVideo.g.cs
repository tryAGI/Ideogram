#nullable enable

namespace Ideogram
{
    public partial interface IVideoGenerateClient
    {
        /// <summary>
        /// Image to video with Kling v3 Standard<br/>
        /// Generate a video from a first-frame image and a text prompt with Kling<br/>
        /// v3 Standard. Upload the first frame as `image`, and optionally a final<br/>
        /// frame as `end_image`, using `multipart/form-data`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}`<br/>
        /// or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoKlingV3Response> VideoGeneratePostGenerateVideoKlingV3StandardImageToVideoAsync(

            global::Ideogram.VideoGeneratePostGenerateVideoKlingV3StandardImageToVideoRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image to video with Kling v3 Standard<br/>
        /// Generate a video from a first-frame image and a text prompt with Kling<br/>
        /// v3 Standard. Upload the first frame as `image`, and optionally a final<br/>
        /// frame as `end_image`, using `multipart/form-data`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}`<br/>
        /// or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateVideoKlingV3Response>> VideoGeneratePostGenerateVideoKlingV3StandardImageToVideoAsResponseAsync(

            global::Ideogram.VideoGeneratePostGenerateVideoKlingV3StandardImageToVideoRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image to video with Kling v3 Standard<br/>
        /// Generate a video from a first-frame image and a text prompt with Kling<br/>
        /// v3 Standard. Upload the first frame as `image`, and optionally a final<br/>
        /// frame as `end_image`, using `multipart/form-data`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}`<br/>
        /// or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The first-frame image to animate, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </param>
        /// <param name="imagename">
        /// The first-frame image to animate, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </param>
        /// <param name="endImage">
        /// An optional final frame, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. When supplied, the video transitions from the first frame to this one.
        /// </param>
        /// <param name="endImagename">
        /// An optional final frame, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. When supplied, the video transitions from the first frame to this one.
        /// </param>
        /// <param name="prompt">
        /// A natural-language prompt describing how the first frame should animate.
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to keep out of the video. Descriptions in the prompt take precedence over descriptions in the negative prompt.
        /// </param>
        /// <param name="duration">
        /// The length of the generated video in seconds. Defaults to 5 seconds<br/>
        /// when omitted.
        /// </param>
        /// <param name="generateAudio">
        /// Whether to generate an audio track for the video. Audio roughly<br/>
        /// doubles the provider cost and is subject to stricter output moderation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="shotType">
        /// How the prompt is staged. `customize` follows the prompt as written;<br/>
        /// `intelligent` lets the model break the prompt into its own shots.<br/>
        /// Default Value: customize
        /// </param>
        /// <param name="cfgScale">
        /// How closely the video follows the prompt, from 0 to 1. Lower values<br/>
        /// leave the model more freedom. Defaults to 0.5 when omitted.
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoKlingV3Response> VideoGeneratePostGenerateVideoKlingV3StandardImageToVideoAsync(
            byte[] image,
            string imagename,
            string prompt,
            bool? dryRun = default,
            byte[]? endImage = default,
            string? endImagename = default,
            string? negativePrompt = default,
            int? duration = default,
            bool? generateAudio = default,
            global::Ideogram.KlingV3ShotType? shotType = default,
            string? cfgScale = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Image to video with Kling v3 Standard<br/>
        /// Generate a video from a first-frame image and a text prompt with Kling<br/>
        /// v3 Standard. Upload the first frame as `image`, and optionally a final<br/>
        /// frame as `end_image`, using `multipart/form-data`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}`<br/>
        /// or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The first-frame image to animate, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </param>
        /// <param name="imagename">
        /// The first-frame image to animate, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </param>
        /// <param name="endImage">
        /// An optional final frame, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. When supplied, the video transitions from the first frame to this one.
        /// </param>
        /// <param name="endImagename">
        /// An optional final frame, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. When supplied, the video transitions from the first frame to this one.
        /// </param>
        /// <param name="prompt">
        /// A natural-language prompt describing how the first frame should animate.
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to keep out of the video. Descriptions in the prompt take precedence over descriptions in the negative prompt.
        /// </param>
        /// <param name="duration">
        /// The length of the generated video in seconds. Defaults to 5 seconds<br/>
        /// when omitted.
        /// </param>
        /// <param name="generateAudio">
        /// Whether to generate an audio track for the video. Audio roughly<br/>
        /// doubles the provider cost and is subject to stricter output moderation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="shotType">
        /// How the prompt is staged. `customize` follows the prompt as written;<br/>
        /// `intelligent` lets the model break the prompt into its own shots.<br/>
        /// Default Value: customize
        /// </param>
        /// <param name="cfgScale">
        /// How closely the video follows the prompt, from 0 to 1. Lower values<br/>
        /// leave the model more freedom. Defaults to 0.5 when omitted.
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoKlingV3Response> VideoGeneratePostGenerateVideoKlingV3StandardImageToVideoAsync(
            global::System.IO.Stream image,
            string imagename,
            string prompt,
            bool? dryRun = default,
            global::System.IO.Stream? endImage = default,
            string? endImagename = default,
            string? negativePrompt = default,
            int? duration = default,
            bool? generateAudio = default,
            global::Ideogram.KlingV3ShotType? shotType = default,
            string? cfgScale = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image to video with Kling v3 Standard<br/>
        /// Generate a video from a first-frame image and a text prompt with Kling<br/>
        /// v3 Standard. Upload the first frame as `image`, and optionally a final<br/>
        /// frame as `end_image`, using `multipart/form-data`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}`<br/>
        /// or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The first-frame image to animate, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </param>
        /// <param name="imagename">
        /// The first-frame image to animate, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </param>
        /// <param name="endImage">
        /// An optional final frame, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. When supplied, the video transitions from the first frame to this one.
        /// </param>
        /// <param name="endImagename">
        /// An optional final frame, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. When supplied, the video transitions from the first frame to this one.
        /// </param>
        /// <param name="prompt">
        /// A natural-language prompt describing how the first frame should animate.
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to keep out of the video. Descriptions in the prompt take precedence over descriptions in the negative prompt.
        /// </param>
        /// <param name="duration">
        /// The length of the generated video in seconds. Defaults to 5 seconds<br/>
        /// when omitted.
        /// </param>
        /// <param name="generateAudio">
        /// Whether to generate an audio track for the video. Audio roughly<br/>
        /// doubles the provider cost and is subject to stricter output moderation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="shotType">
        /// How the prompt is staged. `customize` follows the prompt as written;<br/>
        /// `intelligent` lets the model break the prompt into its own shots.<br/>
        /// Default Value: customize
        /// </param>
        /// <param name="cfgScale">
        /// How closely the video follows the prompt, from 0 to 1. Lower values<br/>
        /// leave the model more freedom. Defaults to 0.5 when omitted.
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateVideoKlingV3Response>> VideoGeneratePostGenerateVideoKlingV3StandardImageToVideoAsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            string prompt,
            bool? dryRun = default,
            global::System.IO.Stream? endImage = default,
            string? endImagename = default,
            string? negativePrompt = default,
            int? duration = default,
            bool? generateAudio = default,
            global::Ideogram.KlingV3ShotType? shotType = default,
            string? cfgScale = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}