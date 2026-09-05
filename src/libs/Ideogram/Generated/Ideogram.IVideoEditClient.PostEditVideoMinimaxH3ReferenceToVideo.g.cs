#nullable enable

namespace Ideogram
{
    public partial interface IVideoEditClient
    {
        /// <summary>
        /// Produce a video from reference images and videos with MiniMax H3<br/>
        /// Produce a video from a text prompt and reference media with MiniMax H3.<br/>
        /// The prompt addresses the references by position: the first reference<br/>
        /// image is `Image 1`, the second `Image 2`, the first reference video is<br/>
        /// `Video 1`, and so on. Supply reference images either as<br/>
        /// `reference_image_asset_identifiers` (images already stored with<br/>
        /// Ideogram) or as raw `reference_images` bytes (multipart requests only);<br/>
        /// supplying both is rejected, and uploaded bytes are used for this request<br/>
        /// only and are not stored as an asset. Supply reference videos as<br/>
        /// `reference_video_asset_identifiers`, which must reference videos<br/>
        /// generated with Ideogram. At most 9 reference images and 3 reference<br/>
        /// videos are accepted, and reference videos are capped again on clip<br/>
        /// length.<br/>
        /// References are optional. With none, the video is produced from the<br/>
        /// prompt alone.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoMinimaxH3Response> PostEditVideoMinimaxH3ReferenceToVideoAsync(

            global::Ideogram.EditVideoMinimaxH3ReferenceToVideoRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Produce a video from reference images and videos with MiniMax H3<br/>
        /// Produce a video from a text prompt and reference media with MiniMax H3.<br/>
        /// The prompt addresses the references by position: the first reference<br/>
        /// image is `Image 1`, the second `Image 2`, the first reference video is<br/>
        /// `Video 1`, and so on. Supply reference images either as<br/>
        /// `reference_image_asset_identifiers` (images already stored with<br/>
        /// Ideogram) or as raw `reference_images` bytes (multipart requests only);<br/>
        /// supplying both is rejected, and uploaded bytes are used for this request<br/>
        /// only and are not stored as an asset. Supply reference videos as<br/>
        /// `reference_video_asset_identifiers`, which must reference videos<br/>
        /// generated with Ideogram. At most 9 reference images and 3 reference<br/>
        /// videos are accepted, and reference videos are capped again on clip<br/>
        /// length.<br/>
        /// References are optional. With none, the video is produced from the<br/>
        /// prompt alone.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateVideoMinimaxH3Response>> PostEditVideoMinimaxH3ReferenceToVideoAsResponseAsync(

            global::Ideogram.EditVideoMinimaxH3ReferenceToVideoRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Produce a video from reference images and videos with MiniMax H3<br/>
        /// Produce a video from a text prompt and reference media with MiniMax H3.<br/>
        /// The prompt addresses the references by position: the first reference<br/>
        /// image is `Image 1`, the second `Image 2`, the first reference video is<br/>
        /// `Video 1`, and so on. Supply reference images either as<br/>
        /// `reference_image_asset_identifiers` (images already stored with<br/>
        /// Ideogram) or as raw `reference_images` bytes (multipart requests only);<br/>
        /// supplying both is rejected, and uploaded bytes are used for this request<br/>
        /// only and are not stored as an asset. Supply reference videos as<br/>
        /// `reference_video_asset_identifiers`, which must reference videos<br/>
        /// generated with Ideogram. At most 9 reference images and 3 reference<br/>
        /// videos are accepted, and reference videos are capped again on clip<br/>
        /// length.<br/>
        /// References are optional. With none, the video is produced from the<br/>
        /// prompt alone.<br/>
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
        /// A natural-language prompt describing the video to produce. Reference media is addressed by position, as in "Image 1 walks toward the camera with the motion of Video 1".<br/>
        /// Example: Image 1 walks through the snowy forest at dawn.
        /// </param>
        /// <param name="referenceImageAssetIdentifiers">
        /// Images already stored with Ideogram to use as references, by reference, in prompt order. Cannot be combined with `reference_images`. Only image assets are accepted.
        /// </param>
        /// <param name="referenceImages">
        /// Images to use as references (max size 50MB each), as raw bytes, in prompt order; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. Cannot be combined with `reference_image_asset_identifiers`. The bytes are used for this request only and are not stored as an asset.
        /// </param>
        /// <param name="referenceVideoAssetIdentifiers">
        /// Videos generated with Ideogram to use as motion references, by reference, in prompt order. Each clip must be between 2 and 15 seconds long, and the clips must total no more than 15 seconds. Raw video uploads are not accepted.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generated video.<br/>
        /// Default Value: 16x9
        /// </param>
        /// <param name="resolution">
        /// The resolution tier of the generated video. `480p` and `768p` are<br/>
        /// generated natively; `2k` and `4k` are upscaled from a `768p` result.<br/>
        /// Higher tiers cost more.<br/>
        /// Default Value: 2k
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
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceImageAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? referenceImages = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceVideoAssetIdentifiers = default,
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