#nullable enable

namespace Ideogram
{
    public partial interface IVideoGenerateClient
    {
        /// <summary>
        /// Generate a video from a text prompt with Kling v3 Standard<br/>
        /// Generate a video from a text prompt with Kling v3 Standard.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoKlingV3Response> PostGenerateVideoKlingV3StandardTextToVideoAsync(

            global::Ideogram.GenerateVideoKlingV3StandardTextToVideoRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a video from a text prompt with Kling v3 Standard<br/>
        /// Generate a video from a text prompt with Kling v3 Standard.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateVideoKlingV3Response>> PostGenerateVideoKlingV3StandardTextToVideoAsResponseAsync(

            global::Ideogram.GenerateVideoKlingV3StandardTextToVideoRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a video from a text prompt with Kling v3 Standard<br/>
        /// Generate a video from a text prompt with Kling v3 Standard.<br/>
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
        /// <param name="negativePrompt">
        /// Description of what to keep out of the video. Descriptions in the prompt take precedence over descriptions in the negative prompt.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generated video.<br/>
        /// Default Value: 16x9
        /// </param>
        /// <param name="duration">
        /// The length of the generated video in seconds. Defaults to 5 seconds<br/>
        /// when omitted.<br/>
        /// Example: 5
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
        /// leave the model more freedom. Defaults to 0.5 when omitted.<br/>
        /// Example: 0.5F
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
        /// A collection you can write to, by its URL-safe base64 collection id. The output videos are added to it when the request completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoKlingV3Response> PostGenerateVideoKlingV3StandardTextToVideoAsync(
            string prompt,
            string? negativePrompt = default,
            global::Ideogram.KlingV3AspectRatio? aspectRatio = default,
            int? duration = default,
            bool? generateAudio = default,
            global::Ideogram.KlingV3ShotType? shotType = default,
            float? cfgScale = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}