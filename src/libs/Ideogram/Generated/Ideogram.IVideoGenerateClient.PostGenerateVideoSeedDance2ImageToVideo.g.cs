#nullable enable

namespace Ideogram
{
    public partial interface IVideoGenerateClient
    {
        /// <summary>
        /// Generate a video from a first frame with Seedance 2.0, by asset id or by uploaded bytes<br/>
        /// Generate one or more videos from a first-frame image and a text prompt<br/>
        /// with Seedance 2.0. Supply the first frame either as an<br/>
        /// `image_asset_identifier` reference (an image already stored with<br/>
        /// Ideogram) or as raw `image` bytes (multipart requests only) — callers<br/>
        /// are never required to upload the asset first. Exactly one source is<br/>
        /// required; supplying neither or both is rejected. Only image assets are<br/>
        /// accepted as a first frame. Uploaded bytes are used for this request<br/>
        /// only and are not stored as an asset.<br/>
        /// To generate a transition between two stills, supply a final frame as<br/>
        /// well, in either of the same two forms: `end_image_asset_identifier` or<br/>
        /// `end_image`. The final frame is optional, follows the same one-form-only<br/>
        /// rule, and requires a first frame.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoSeedDance2Response> PostGenerateVideoSeedDance2ImageToVideoAsync(

            global::Ideogram.GenerateVideoSeedDance2ImageToVideoRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a video from a first frame with Seedance 2.0, by asset id or by uploaded bytes<br/>
        /// Generate one or more videos from a first-frame image and a text prompt<br/>
        /// with Seedance 2.0. Supply the first frame either as an<br/>
        /// `image_asset_identifier` reference (an image already stored with<br/>
        /// Ideogram) or as raw `image` bytes (multipart requests only) — callers<br/>
        /// are never required to upload the asset first. Exactly one source is<br/>
        /// required; supplying neither or both is rejected. Only image assets are<br/>
        /// accepted as a first frame. Uploaded bytes are used for this request<br/>
        /// only and are not stored as an asset.<br/>
        /// To generate a transition between two stills, supply a final frame as<br/>
        /// well, in either of the same two forms: `end_image_asset_identifier` or<br/>
        /// `end_image`. The final frame is optional, follows the same one-form-only<br/>
        /// rule, and requires a first frame.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateVideoSeedDance2Response>> PostGenerateVideoSeedDance2ImageToVideoAsResponseAsync(

            global::Ideogram.GenerateVideoSeedDance2ImageToVideoRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a video from a first frame with Seedance 2.0, by asset id or by uploaded bytes<br/>
        /// Generate one or more videos from a first-frame image and a text prompt<br/>
        /// with Seedance 2.0. Supply the first frame either as an<br/>
        /// `image_asset_identifier` reference (an image already stored with<br/>
        /// Ideogram) or as raw `image` bytes (multipart requests only) — callers<br/>
        /// are never required to upload the asset first. Exactly one source is<br/>
        /// required; supplying neither or both is rejected. Only image assets are<br/>
        /// accepted as a first frame. Uploaded bytes are used for this request<br/>
        /// only and are not stored as an asset.<br/>
        /// To generate a transition between two stills, supply a final frame as<br/>
        /// well, in either of the same two forms: `end_image_asset_identifier` or<br/>
        /// `end_image`. The final frame is optional, follows the same one-form-only<br/>
        /// rule, and requires a first frame.<br/>
        /// Video generation always runs asynchronously: the response returns as<br/>
        /// soon as the request is accepted and carries only a `generation_id`.<br/>
        /// Poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using that id, or supply a<br/>
        /// `webhook_url` to have the finished result POSTed to your server<br/>
        /// instead.<br/>
        /// Video links are available for a limited period of time; download the<br/>
        /// video if you want to keep it.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// A reference to an image already stored with Ideogram to use as the first frame, in place of uploading `image`. Only image assets are accepted.
        /// </param>
        /// <param name="image">
        /// The first-frame image to animate (max size 50MB), as raw bytes; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. The bytes are used for this request only and are not stored as an asset.
        /// </param>
        /// <param name="imagename">
        /// The first-frame image to animate (max size 50MB), as raw bytes; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. The bytes are used for this request only and are not stored as an asset.
        /// </param>
        /// <param name="endImageAssetIdentifier">
        /// An optional final frame, as a reference to an image already stored with Ideogram. When supplied, the generated video transitions from the first frame to this one. Only image assets are accepted.
        /// </param>
        /// <param name="endImage">
        /// An optional final frame (max size 50MB), as raw bytes; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. When supplied, the generated video transitions from the first frame to this one. The bytes are used for this request only and are not stored as an asset.
        /// </param>
        /// <param name="endImagename">
        /// An optional final frame (max size 50MB), as raw bytes; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. When supplied, the generated video transitions from the first frame to this one. The bytes are used for this request only and are not stored as an asset.
        /// </param>
        /// <param name="prompt">
        /// A natural-language prompt describing how the first frame should animate.<br/>
        /// Example: The camera slowly pans right as the waves roll in.
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoSeedDance2Response> PostGenerateVideoSeedDance2ImageToVideoAsync(
            string prompt,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            global::Ideogram.AssetIdentifier? endImageAssetIdentifier = default,
            byte[]? endImage = default,
            string? endImagename = default,
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