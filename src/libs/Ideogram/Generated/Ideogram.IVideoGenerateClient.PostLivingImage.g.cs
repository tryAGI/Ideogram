#nullable enable

namespace Ideogram
{
    public partial interface IVideoGenerateClient
    {
        /// <summary>
        /// Turn a still image into a subtle looping video<br/>
        /// Animates one image into a short, loop-ready clip for use as a living background. The camera stays fixed and only the parts of the scene that would move in real life move: water, light, mist, particles, fabric, creatures. Ideogram inspects the image and writes the motion prompt, so the request needs only the image.<br/>
        /// Video generation runs asynchronously. Poll `GET /v1/generations/{generation_id}` with the returned `generation_id` until the generation completes or fails.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LivingImageResponse> PostLivingImageAsync(

            global::Ideogram.LivingImageRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Turn a still image into a subtle looping video<br/>
        /// Animates one image into a short, loop-ready clip for use as a living background. The camera stays fixed and only the parts of the scene that would move in real life move: water, light, mist, particles, fabric, creatures. Ideogram inspects the image and writes the motion prompt, so the request needs only the image.<br/>
        /// Video generation runs asynchronously. Poll `GET /v1/generations/{generation_id}` with the returned `generation_id` until the generation completes or fails.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.LivingImageResponse>> PostLivingImageAsResponseAsync(

            global::Ideogram.LivingImageRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Turn a still image into a subtle looping video<br/>
        /// Animates one image into a short, loop-ready clip for use as a living background. The camera stays fixed and only the parts of the scene that would move in real life move: water, light, mist, particles, fabric, creatures. Ideogram inspects the image and writes the motion prompt, so the request needs only the image.<br/>
        /// Video generation runs asynchronously. Poll `GET /v1/generations/{generation_id}` with the returned `generation_id` until the generation completes or fails.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="quality">
        /// The output resolution tier. `standard` renders at 768P; `high` renders at 2K. Higher tiers cost more.<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="duration">
        /// The length of the generated video in seconds.<br/>
        /// Default Value: 8<br/>
        /// Example: 8
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. The output video is added to it when the request completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LivingImageResponse> PostLivingImageAsync(
            global::Ideogram.AssetIdentifier imageAssetIdentifier,
            bool? dryRun = default,
            global::Ideogram.LivingImageQuality? quality = default,
            int? duration = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}