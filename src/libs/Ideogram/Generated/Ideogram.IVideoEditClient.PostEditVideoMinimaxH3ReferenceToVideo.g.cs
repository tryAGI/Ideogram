#nullable enable

namespace Ideogram
{
    public partial interface IVideoEditClient
    {
        /// <summary>
        /// Reference to video with MiniMax H3<br/>
        /// Produce a video from a text prompt and optional reference media with<br/>
        /// MiniMax H3. Upload `reference_images` and `reference_audios` using<br/>
        /// `multipart/form-data`, and address them in the prompt by position<br/>
        /// (`Image 1`, `Audio 1`, …). Returns a `generation_id`; poll<br/>
        /// `GET /v2/generations/{generation_id}` or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoMinimaxH3Response> PostEditVideoMinimaxH3ReferenceToVideoAsync(

            global::Ideogram.EditVideoMinimaxH3ReferenceToVideoRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reference to video with MiniMax H3<br/>
        /// Produce a video from a text prompt and optional reference media with<br/>
        /// MiniMax H3. Upload `reference_images` and `reference_audios` using<br/>
        /// `multipart/form-data`, and address them in the prompt by position<br/>
        /// (`Image 1`, `Audio 1`, …). Returns a `generation_id`; poll<br/>
        /// `GET /v2/generations/{generation_id}` or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateVideoMinimaxH3Response>> PostEditVideoMinimaxH3ReferenceToVideoAsResponseAsync(

            global::Ideogram.EditVideoMinimaxH3ReferenceToVideoRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reference to video with MiniMax H3<br/>
        /// Produce a video from a text prompt and optional reference media with<br/>
        /// MiniMax H3. Upload `reference_images` and `reference_audios` using<br/>
        /// `multipart/form-data`, and address them in the prompt by position<br/>
        /// (`Image 1`, `Audio 1`, …). Returns a `generation_id`; poll<br/>
        /// `GET /v2/generations/{generation_id}` or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// A natural-language prompt describing the video to produce. Reference media is addressed by position, as in "Image 1 walks toward the camera with the motion of Video 1".<br/>
        /// Example: Image 1 walks through the snowy forest at dawn.
        /// </param>
        /// <param name="referenceImageAssetIdentifiers">
        /// Images already stored with Ideogram to use as references, by reference, in prompt order. Cannot be combined with `reference_images`. Only image assets are accepted.
        /// </param>
        /// <param name="referenceImages">
        /// Images to use as references (max size 50MB each), as raw bytes, in prompt order; only common image formats such as JPEG, PNG, and WEBP are supported. Uploaded images are used for this request only and are not stored.
        /// </param>
        /// <param name="referenceVideoAssetIdentifiers">
        /// Videos generated or uploaded with Ideogram to use as motion references, by reference, in prompt order. Each clip must be between 2 and 15 seconds long, and the clips must total no more than 15 seconds. Raw video uploads are not accepted.
        /// </param>
        /// <param name="referenceAudios">
        /// MP3 or WAV audio references, in prompt order as Audio 1, Audio 2, and Audio 3. Multipart uploads only; up to 15 MB per file and 2–15 seconds each. Audio and video references must total no more than 15 seconds. Requires a reference image or video. At most 12 references across images, videos, and audio. Used only for this request and not saved as assets.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generated video.<br/>
        /// Default Value: 16x9
        /// </param>
        /// <param name="resolution">
        /// The resolution tier of the generated video, spelled the way MiniMax<br/>
        /// spells it. `480P` and `768P` are generated natively; `2K` and `4K` are<br/>
        /// upscaled from a `768P` result.<br/>
        /// Higher tiers cost more.<br/>
        /// Default Value: 2K
        /// </param>
        /// <param name="duration">
        /// The length of the generated video in seconds.<br/>
        /// Default Value: 5<br/>
        /// Example: 5
        /// </param>
        /// <param name="promptExpansionMode">
        /// How much the model may rewrite the prompt before generating. `disabled`<br/>
        /// uses the prompt as written; the other modes trade latency for a richer<br/>
        /// rewrite.<br/>
        /// Default Value: balanced
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoMinimaxH3Response> PostEditVideoMinimaxH3ReferenceToVideoAsync(
            string prompt,
            bool? dryRun = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceImageAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? referenceImages = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceVideoAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? referenceAudios = default,
            global::Ideogram.MinimaxH3AspectRatio? aspectRatio = default,
            global::Ideogram.MinimaxH3Resolution? resolution = default,
            int? duration = default,
            global::Ideogram.MinimaxH3PromptExpansionMode? promptExpansionMode = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}