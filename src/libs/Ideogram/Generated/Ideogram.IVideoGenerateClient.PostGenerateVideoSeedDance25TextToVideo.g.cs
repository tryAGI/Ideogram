#nullable enable

namespace Ideogram
{
    public partial interface IVideoGenerateClient
    {
        /// <summary>
        /// Generate a video from a text prompt with Seedance 2.5<br/>
        /// Generate a video from a text prompt with Seedance 2.5, which serves<br/>
        /// resolutions up to 1080p and durations up to 30 seconds.<br/>
        /// Video generation always runs asynchronously: the response returns as<br/>
        /// soon as the request is accepted and carries only a `generation_id`.<br/>
        /// Poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using that id, or supply a<br/>
        /// `webhook_url` to have the finished result POSTed to your server<br/>
        /// instead.<br/>
        /// Video links are available for a limited period of time; download the<br/>
        /// video if you want to keep it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoSeedDance25Response> PostGenerateVideoSeedDance25TextToVideoAsync(

            global::Ideogram.GenerateVideoSeedDance25TextToVideoRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a video from a text prompt with Seedance 2.5<br/>
        /// Generate a video from a text prompt with Seedance 2.5, which serves<br/>
        /// resolutions up to 1080p and durations up to 30 seconds.<br/>
        /// Video generation always runs asynchronously: the response returns as<br/>
        /// soon as the request is accepted and carries only a `generation_id`.<br/>
        /// Poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using that id, or supply a<br/>
        /// `webhook_url` to have the finished result POSTed to your server<br/>
        /// instead.<br/>
        /// Video links are available for a limited period of time; download the<br/>
        /// video if you want to keep it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateVideoSeedDance25Response>> PostGenerateVideoSeedDance25TextToVideoAsResponseAsync(

            global::Ideogram.GenerateVideoSeedDance25TextToVideoRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a video from a text prompt with Seedance 2.5<br/>
        /// Generate a video from a text prompt with Seedance 2.5, which serves<br/>
        /// resolutions up to 1080p and durations up to 30 seconds.<br/>
        /// Video generation always runs asynchronously: the response returns as<br/>
        /// soon as the request is accepted and carries only a `generation_id`.<br/>
        /// Poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using that id, or supply a<br/>
        /// `webhook_url` to have the finished result POSTed to your server<br/>
        /// instead.<br/>
        /// Video links are available for a limited period of time; download the<br/>
        /// video if you want to keep it.
        /// </summary>
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
        /// <param name="generateAudio">
        /// Whether to generate an audio track for the video. Audio roughly<br/>
        /// doubles the provider cost and is subject to stricter output moderation.<br/>
        /// Default Value: false
        /// </param>
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
        /// <param name="private">
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. The output video is added to it when the request completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoSeedDance25Response> PostGenerateVideoSeedDance25TextToVideoAsync(
            string prompt,
            global::Ideogram.SeedDance2AspectRatio? aspectRatio = default,
            global::Ideogram.SeedDance25Resolution? resolution = default,
            int? duration = default,
            bool? generateAudio = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}