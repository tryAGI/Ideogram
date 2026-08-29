#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Generate a video from an image with Seedance 2.0<br/>
        /// Generates a video from a first-frame image and a text prompt using the<br/>
        /// Seedance 2.0 model. The request is always processed asynchronously: this<br/>
        /// endpoint returns immediately with a `generation_id` and an empty `data`<br/>
        /// array. Poll `/v1/generations/{generation_id}` with the returned<br/>
        /// `generation_id` to retrieve the video once it is ready, or supply<br/>
        /// `webhook_url` to have the result delivered to your server.<br/>
        /// Supply the first frame in exactly one of two ways: upload the image bytes<br/>
        /// directly in the `image` part, or reference an existing Ideogram asset you<br/>
        /// own with `image_asset_id`. Provide exactly one of `image` or<br/>
        /// `image_asset_id`; supplying neither or both is rejected.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.VideoGenerationResponse> PostImageToVideoSeedDance2Async(

            global::Ideogram.ImageToVideoRequestSeedDance2 request,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a video from an image with Seedance 2.0<br/>
        /// Generates a video from a first-frame image and a text prompt using the<br/>
        /// Seedance 2.0 model. The request is always processed asynchronously: this<br/>
        /// endpoint returns immediately with a `generation_id` and an empty `data`<br/>
        /// array. Poll `/v1/generations/{generation_id}` with the returned<br/>
        /// `generation_id` to retrieve the video once it is ready, or supply<br/>
        /// `webhook_url` to have the result delivered to your server.<br/>
        /// Supply the first frame in exactly one of two ways: upload the image bytes<br/>
        /// directly in the `image` part, or reference an existing Ideogram asset you<br/>
        /// own with `image_asset_id`. Provide exactly one of `image` or<br/>
        /// `image_asset_id`; supplying neither or both is rejected.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.VideoGenerationResponse>> PostImageToVideoSeedDance2AsResponseAsync(

            global::Ideogram.ImageToVideoRequestSeedDance2 request,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a video from an image with Seedance 2.0<br/>
        /// Generates a video from a first-frame image and a text prompt using the<br/>
        /// Seedance 2.0 model. The request is always processed asynchronously: this<br/>
        /// endpoint returns immediately with a `generation_id` and an empty `data`<br/>
        /// array. Poll `/v1/generations/{generation_id}` with the returned<br/>
        /// `generation_id` to retrieve the video once it is ready, or supply<br/>
        /// `webhook_url` to have the result delivered to your server.<br/>
        /// Supply the first frame in exactly one of two ways: upload the image bytes<br/>
        /// directly in the `image` part, or reference an existing Ideogram asset you<br/>
        /// own with `image_asset_id`. Provide exactly one of `image` or<br/>
        /// `image_asset_id`; supplying neither or both is rejected.<br/>
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
        /// <param name="image">
        /// The first-frame image binary (max 25MB); only JPEG, WebP and PNG<br/>
        /// formats are supported. Provide this or `image_asset_id`, not both.
        /// </param>
        /// <param name="imagename">
        /// The first-frame image binary (max 25MB); only JPEG, WebP and PNG<br/>
        /// formats are supported. Provide this or `image_asset_id`, not both.
        /// </param>
        /// <param name="imageAssetId">
        /// A reference to an existing Ideogram asset you own to use as the first<br/>
        /// frame, in place of uploading `image`. Only image assets (an uploaded<br/>
        /// image or a generated image) are accepted. Provide this or `image`,<br/>
        /// not both.
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
        global::System.Threading.Tasks.Task<global::Ideogram.VideoGenerationResponse> PostImageToVideoSeedDance2Async(
            string prompt,
            string? webhookUrl = default,
            byte[]? image = default,
            string? imagename = default,
            global::Ideogram.AssetIdentifier? imageAssetId = default,
            global::Ideogram.SeedDance2AspectRatio? aspectRatio = default,
            global::Ideogram.SeedDance2Resolution? resolution = default,
            int? duration = default,
            int? numVideos = default,
            bool? generateAudio = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}