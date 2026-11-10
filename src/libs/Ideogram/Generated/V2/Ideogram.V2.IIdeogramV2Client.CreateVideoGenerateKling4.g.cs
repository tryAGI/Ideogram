#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// Generate a video with Kling 4.0<br/>
        /// Generate a video from a text prompt with Kling 4.0, at up to 1080p and<br/>
        /// 30 seconds. Every other input is optional and they combine freely:<br/>
        /// - Frames: up to 10 `frames` in timeline order. The first opens the video,<br/>
        ///   the last of two or more closes it, and the video passes through the<br/>
        ///   rest in between.<br/>
        /// - References: up to 10 `reference_images` and 5 reference videos the<br/>
        ///   prompt refers to as `[Image1]`, `[Video1]`, and so on.<br/>
        /// Upload images using `multipart/form-data`, or pass stored assets by<br/>
        /// identifier. Returns a `generation_id`; poll<br/>
        /// `GET /v2/generations/{generation_id}` or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.GenerateVideoKling4Response> CreateVideoGenerateKling4Async(

            global::Ideogram.V2.VideoGeneratePostGenerateVideoKling4Request request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a video with Kling 4.0<br/>
        /// Generate a video from a text prompt with Kling 4.0, at up to 1080p and<br/>
        /// 30 seconds. Every other input is optional and they combine freely:<br/>
        /// - Frames: up to 10 `frames` in timeline order. The first opens the video,<br/>
        ///   the last of two or more closes it, and the video passes through the<br/>
        ///   rest in between.<br/>
        /// - References: up to 10 `reference_images` and 5 reference videos the<br/>
        ///   prompt refers to as `[Image1]`, `[Video1]`, and so on.<br/>
        /// Upload images using `multipart/form-data`, or pass stored assets by<br/>
        /// identifier. Returns a `generation_id`; poll<br/>
        /// `GET /v2/generations/{generation_id}` or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.GenerateVideoKling4Response>> CreateVideoGenerateKling4AsResponseAsync(

            global::Ideogram.V2.VideoGeneratePostGenerateVideoKling4Request request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a video with Kling 4.0<br/>
        /// Generate a video from a text prompt with Kling 4.0, at up to 1080p and<br/>
        /// 30 seconds. Every other input is optional and they combine freely:<br/>
        /// - Frames: up to 10 `frames` in timeline order. The first opens the video,<br/>
        ///   the last of two or more closes it, and the video passes through the<br/>
        ///   rest in between.<br/>
        /// - References: up to 10 `reference_images` and 5 reference videos the<br/>
        ///   prompt refers to as `[Image1]`, `[Video1]`, and so on.<br/>
        /// Upload images using `multipart/form-data`, or pass stored assets by<br/>
        /// identifier. Returns a `generation_id`; poll<br/>
        /// `GET /v2/generations/{generation_id}` or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// A natural-language prompt describing the video to generate. Refer to references by position, as in "[Image1] walks toward the camera".
        /// </param>
        /// <param name="frames">
        /// Images for the video to pass through, in timeline order, in a common format such as JPEG, PNG, or WEBP, up to 50MB each. The first opens the video and, with two or more, the last closes it. Multipart requests only. Uploaded images are used for this request only and are not stored.
        /// </param>
        /// <param name="referenceImages">
        /// Reference images, in prompt order. Common formats such as JPEG, PNG, and WEBP are supported, up to 50MB each. Multipart requests only. Uploaded images are used for this request only and are not stored.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generated video. Defaults to the ratio nearest the first frame's shape, or 16x9 without a first frame.
        /// </param>
        /// <param name="resolution">
        /// The resolution tier of the generated video.<br/>
        /// Default Value: 1080p
        /// </param>
        /// <param name="duration">
        /// The length of the generated video in seconds.<br/>
        /// Default Value: 10
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
        global::System.Threading.Tasks.Task<global::Ideogram.V2.GenerateVideoKling4Response> CreateVideoGenerateKling4Async(
            string prompt,
            bool? dryRun = default,
            global::System.Collections.Generic.IList<byte[]>? frames = default,
            global::System.Collections.Generic.IList<byte[]>? referenceImages = default,
            global::Ideogram.V2.Kling4AspectRatio? aspectRatio = default,
            global::Ideogram.V2.Kling4Resolution? resolution = default,
            int? duration = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}