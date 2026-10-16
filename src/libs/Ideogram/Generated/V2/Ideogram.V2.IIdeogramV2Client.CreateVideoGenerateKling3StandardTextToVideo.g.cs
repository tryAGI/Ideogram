#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// Text to video with Kling v3 Standard<br/>
        /// Generate a video from a text prompt with Kling v3 Standard.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.V2.GenerateVideoKlingV3Response> CreateVideoGenerateKling3StandardTextToVideoAsync(

            global::Ideogram.V2.GenerateVideoKlingV3StandardTextToVideoRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text to video with Kling v3 Standard<br/>
        /// Generate a video from a text prompt with Kling v3 Standard.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.GenerateVideoKlingV3Response>> CreateVideoGenerateKling3StandardTextToVideoAsResponseAsync(

            global::Ideogram.V2.GenerateVideoKlingV3StandardTextToVideoRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text to video with Kling v3 Standard<br/>
        /// Generate a video from a text prompt with Kling v3 Standard.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}`<br/>
        /// or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// A natural-language prompt describing the video to generate.
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
        global::System.Threading.Tasks.Task<global::Ideogram.V2.GenerateVideoKlingV3Response> CreateVideoGenerateKling3StandardTextToVideoAsync(
            string prompt,
            bool? dryRun = default,
            string? negativePrompt = default,
            global::Ideogram.V2.KlingV3AspectRatio? aspectRatio = default,
            int? duration = default,
            bool? generateAudio = default,
            global::Ideogram.V2.KlingV3ShotType? shotType = default,
            string? cfgScale = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}