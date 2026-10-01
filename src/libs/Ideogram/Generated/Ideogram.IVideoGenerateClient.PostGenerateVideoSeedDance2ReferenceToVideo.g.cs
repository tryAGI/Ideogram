#nullable enable

namespace Ideogram
{
    public partial interface IVideoGenerateClient
    {
        /// <summary>
        /// Reference to video with Seedance 2.0<br/>
        /// Generate a video from a text prompt and reference media with<br/>
        /// Seedance 2.0. Upload at least one image in `reference_images`, plus optional<br/>
        /// `reference_audios`, using `multipart/form-data`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoSeedDance2Response> PostGenerateVideoSeedDance2ReferenceToVideoAsync(

            global::Ideogram.GenerateVideoSeedDance2ReferenceToVideoRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reference to video with Seedance 2.0<br/>
        /// Generate a video from a text prompt and reference media with<br/>
        /// Seedance 2.0. Upload at least one image in `reference_images`, plus optional<br/>
        /// `reference_audios`, using `multipart/form-data`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateVideoSeedDance2Response>> PostGenerateVideoSeedDance2ReferenceToVideoAsResponseAsync(

            global::Ideogram.GenerateVideoSeedDance2ReferenceToVideoRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reference to video with Seedance 2.0<br/>
        /// Generate a video from a text prompt and reference media with<br/>
        /// Seedance 2.0. Upload at least one image in `reference_images`, plus optional<br/>
        /// `reference_audios`, using `multipart/form-data`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}`<br/>
        /// or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// A natural-language prompt describing the video to produce. Refer to references by position, as in "@Image1 walks toward the camera".<br/>
        /// Example: @Image1 walks through the snowy forest at dawn.
        /// </param>
        /// <param name="referenceImageAssetIdentifiers">
        /// Images already stored with Ideogram to use as references, by reference, in prompt order. Cannot be combined with `reference_images`. Only image assets are accepted.
        /// </param>
        /// <param name="referenceImages">
        /// Reference images, in prompt order. Common formats such as JPEG, PNG, and WEBP are supported, up to 50MB each. Multipart requests only. Uploaded images are used for this request only and are not stored.
        /// </param>
        /// <param name="referenceVideoAssetIdentifiers">
        /// Uploaded or generated videos to use as references, by reference, in prompt order. Each clip must be between 2 and 15 seconds long, and the clips must total no more than 15 seconds. Upload video files first and pass their asset identifiers.
        /// </param>
        /// <param name="referenceAudios">
        /// MP3 or WAV audio references, in prompt order. Multipart requests only. Each file must be at most 15 MB and between 2 and 15 seconds long, with a combined duration of at most 15 seconds. Requires at least one reference image. Audio is used for this request only and is not saved to your library.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generated video. `AUTO` lets the model choose the<br/>
        /// most suitable ratio from the prompt; any other value pins the ratio.<br/>
        /// Default Value: auto
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
        /// A collection you can write to, by its URL-safe base64 collection id. The output videos are added to it when the request completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoSeedDance2Response> PostGenerateVideoSeedDance2ReferenceToVideoAsync(
            string prompt,
            bool? dryRun = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceImageAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? referenceImages = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceVideoAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? referenceAudios = default,
            global::Ideogram.SeedDance2AspectRatio? aspectRatio = default,
            global::Ideogram.SeedDance2Resolution? resolution = default,
            int? duration = default,
            bool? generateAudio = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}