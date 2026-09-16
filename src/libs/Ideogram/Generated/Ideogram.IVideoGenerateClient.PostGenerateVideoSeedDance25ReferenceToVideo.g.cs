#nullable enable

namespace Ideogram
{
    public partial interface IVideoGenerateClient
    {
        /// <summary>
        /// Produce a video from reference images and videos with Seedance 2.5<br/>
        /// Produce a video from a text prompt and reference media with<br/>
        /// Seedance 2.5.<br/>
        /// The prompt addresses the references by position: the first reference<br/>
        /// image is `[Image1]`, the second<br/>
        /// `[Image2]`, the first reference video is<br/>
        /// `[Video1]`, and so on. Supply reference images<br/>
        /// either as `reference_image_asset_identifiers` (images already stored<br/>
        /// with Ideogram) or as raw `reference_images` bytes (multipart requests<br/>
        /// only); supplying both is rejected, and uploaded bytes are used for this<br/>
        /// request only and are not stored as an asset. Supply reference videos as<br/>
        /// `reference_video_asset_identifiers`, which must reference videos<br/>
        /// generated with Ideogram. At most 9 reference images and 10<br/>
        /// reference videos are accepted, and reference videos are capped again on<br/>
        /// clip length: each clip must be between 2 and 30 seconds long, and the clips must total no more than 30 seconds.<br/>
        /// At least one reference image or video is required: the model<br/>
        /// conditions every generation on the media it is given, so a request<br/>
        /// with no references is rejected.<br/>
        /// Video generation always runs asynchronously: the response returns as<br/>
        /// soon as the request is accepted and carries only a `generation_id`.<br/>
        /// Poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using that id, or supply a<br/>
        /// `webhook_url` to have the finished result POSTed to your server<br/>
        /// instead.<br/>
        /// Video links are available for a limited period of time; download the<br/>
        /// video if you want to keep it.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoSeedDance25Response> PostGenerateVideoSeedDance25ReferenceToVideoAsync(

            global::Ideogram.GenerateVideoSeedDance25ReferenceToVideoRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Produce a video from reference images and videos with Seedance 2.5<br/>
        /// Produce a video from a text prompt and reference media with<br/>
        /// Seedance 2.5.<br/>
        /// The prompt addresses the references by position: the first reference<br/>
        /// image is `[Image1]`, the second<br/>
        /// `[Image2]`, the first reference video is<br/>
        /// `[Video1]`, and so on. Supply reference images<br/>
        /// either as `reference_image_asset_identifiers` (images already stored<br/>
        /// with Ideogram) or as raw `reference_images` bytes (multipart requests<br/>
        /// only); supplying both is rejected, and uploaded bytes are used for this<br/>
        /// request only and are not stored as an asset. Supply reference videos as<br/>
        /// `reference_video_asset_identifiers`, which must reference videos<br/>
        /// generated with Ideogram. At most 9 reference images and 10<br/>
        /// reference videos are accepted, and reference videos are capped again on<br/>
        /// clip length: each clip must be between 2 and 30 seconds long, and the clips must total no more than 30 seconds.<br/>
        /// At least one reference image or video is required: the model<br/>
        /// conditions every generation on the media it is given, so a request<br/>
        /// with no references is rejected.<br/>
        /// Video generation always runs asynchronously: the response returns as<br/>
        /// soon as the request is accepted and carries only a `generation_id`.<br/>
        /// Poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using that id, or supply a<br/>
        /// `webhook_url` to have the finished result POSTed to your server<br/>
        /// instead.<br/>
        /// Video links are available for a limited period of time; download the<br/>
        /// video if you want to keep it.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateVideoSeedDance25Response>> PostGenerateVideoSeedDance25ReferenceToVideoAsResponseAsync(

            global::Ideogram.GenerateVideoSeedDance25ReferenceToVideoRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Produce a video from reference images and videos with Seedance 2.5<br/>
        /// Produce a video from a text prompt and reference media with<br/>
        /// Seedance 2.5.<br/>
        /// The prompt addresses the references by position: the first reference<br/>
        /// image is `[Image1]`, the second<br/>
        /// `[Image2]`, the first reference video is<br/>
        /// `[Video1]`, and so on. Supply reference images<br/>
        /// either as `reference_image_asset_identifiers` (images already stored<br/>
        /// with Ideogram) or as raw `reference_images` bytes (multipart requests<br/>
        /// only); supplying both is rejected, and uploaded bytes are used for this<br/>
        /// request only and are not stored as an asset. Supply reference videos as<br/>
        /// `reference_video_asset_identifiers`, which must reference videos<br/>
        /// generated with Ideogram. At most 9 reference images and 10<br/>
        /// reference videos are accepted, and reference videos are capped again on<br/>
        /// clip length: each clip must be between 2 and 30 seconds long, and the clips must total no more than 30 seconds.<br/>
        /// At least one reference image or video is required: the model<br/>
        /// conditions every generation on the media it is given, so a request<br/>
        /// with no references is rejected.<br/>
        /// Video generation always runs asynchronously: the response returns as<br/>
        /// soon as the request is accepted and carries only a `generation_id`.<br/>
        /// Poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using that id, or supply a<br/>
        /// `webhook_url` to have the finished result POSTed to your server<br/>
        /// instead.<br/>
        /// Video links are available for a limited period of time; download the<br/>
        /// video if you want to keep it.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// A natural-language prompt describing the video to produce. Reference media is addressed by position, as in "[Image1] walks toward the camera with the motion of [Video1]".<br/>
        /// Example: [Image1] walks through the snowy forest at dawn.
        /// </param>
        /// <param name="referenceImageAssetIdentifiers">
        /// Images already stored with Ideogram to use as references, by reference, in prompt order. Cannot be combined with `reference_images`. Only image assets are accepted.
        /// </param>
        /// <param name="referenceImages">
        /// Images to use as references (max size 50MB each), as raw bytes, in prompt order; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. Cannot be combined with `reference_image_asset_identifiers`. The bytes are used for this request only and are not stored as an asset.
        /// </param>
        /// <param name="referenceVideoAssetIdentifiers">
        /// Videos generated with Ideogram to use as references, by reference, in prompt order. Each clip must be between 2 and 30 seconds long, and the clips must total no more than 30 seconds. Raw video uploads are not accepted.
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
        /// A collection you can write to, by its URL-safe base64 collection id. The output videos are added to it when the request completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoSeedDance25Response> PostGenerateVideoSeedDance25ReferenceToVideoAsync(
            string prompt,
            bool? dryRun = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceImageAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? referenceImages = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceVideoAssetIdentifiers = default,
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