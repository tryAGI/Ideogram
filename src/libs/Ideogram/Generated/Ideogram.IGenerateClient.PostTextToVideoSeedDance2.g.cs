#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Generate a video from text with Seedance 2.0<br/>
        /// Generates a video from a text prompt using the Seedance 2.0 model. The<br/>
        /// request is always processed asynchronously: this endpoint returns<br/>
        /// immediately with a `generation_id` and an empty `data` array. Poll<br/>
        /// `/v1/generations/{generation_id}` with the returned `generation_id` to<br/>
        /// retrieve the video once it is ready, or supply `webhook_url` to have the<br/>
        /// result delivered to your server.<br/>
        /// Video links are available for a limited period of time; if you would like<br/>
        /// to keep the video, you must download it.
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
        global::System.Threading.Tasks.Task<global::Ideogram.VideoGenerationResponse> PostTextToVideoSeedDance2Async(

            global::Ideogram.TextToVideoRequestSeedDance2 request,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a video from text with Seedance 2.0<br/>
        /// Generates a video from a text prompt using the Seedance 2.0 model. The<br/>
        /// request is always processed asynchronously: this endpoint returns<br/>
        /// immediately with a `generation_id` and an empty `data` array. Poll<br/>
        /// `/v1/generations/{generation_id}` with the returned `generation_id` to<br/>
        /// retrieve the video once it is ready, or supply `webhook_url` to have the<br/>
        /// result delivered to your server.<br/>
        /// Video links are available for a limited period of time; if you would like<br/>
        /// to keep the video, you must download it.
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.VideoGenerationResponse>> PostTextToVideoSeedDance2AsResponseAsync(

            global::Ideogram.TextToVideoRequestSeedDance2 request,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a video from text with Seedance 2.0<br/>
        /// Generates a video from a text prompt using the Seedance 2.0 model. The<br/>
        /// request is always processed asynchronously: this endpoint returns<br/>
        /// immediately with a `generation_id` and an empty `data` array. Poll<br/>
        /// `/v1/generations/{generation_id}` with the returned `generation_id` to<br/>
        /// retrieve the video once it is ready, or supply `webhook_url` to have the<br/>
        /// result delivered to your server.<br/>
        /// Video links are available for a limited period of time; if you would like<br/>
        /// to keep the video, you must download it.
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
        /// A natural-language prompt describing the video to generate.<br/>
        /// Example: A red fox running through a snowy forest at dawn.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generated video. `AUTO` lets the model choose the<br/>
        /// most suitable ratio from the prompt; any other value pins the ratio.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="resolution">
        /// The resolution tier of the generated video.<br/>
        /// Default Value: 720p
        /// </param>
        /// <param name="duration">
        /// The length of the generated video in seconds. When omitted, the model<br/>
        /// picks the best duration for the prompt ("auto").<br/>
        /// Example: 5
        /// </param>
        /// <param name="numVideos">
        /// How many videos to generate for this request. Each video is generated<br/>
        /// and billed independently.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="generateAudio">
        /// Whether to generate an audio track for the video. Audio roughly<br/>
        /// doubles the provider cost and is subject to stricter output moderation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.VideoGenerationResponse> PostTextToVideoSeedDance2Async(
            string prompt,
            string? webhookUrl = default,
            global::Ideogram.SeedDance2AspectRatio? aspectRatio = default,
            global::Ideogram.SeedDance2Resolution? resolution = default,
            int? duration = default,
            int? numVideos = default,
            bool? generateAudio = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}