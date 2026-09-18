#nullable enable

namespace Ideogram
{
    public partial interface IVideoGenerateClient
    {
        /// <summary>
        /// Create a looping 360-degree product video<br/>
        /// Animates one product image through a complete turntable revolution and returns to the starting pose so the result loops cleanly.<br/>
        /// Video generation runs asynchronously. Poll `GET /v1/generations/{generation_id}` with the returned `generation_id` until the generation completes or fails.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoSeedDance25Response> PostProduct360VideoAsync(

            global::Ideogram.Product360VideoRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a looping 360-degree product video<br/>
        /// Animates one product image through a complete turntable revolution and returns to the starting pose so the result loops cleanly.<br/>
        /// Video generation runs asynchronously. Poll `GET /v1/generations/{generation_id}` with the returned `generation_id` until the generation completes or fails.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateVideoSeedDance25Response>> PostProduct360VideoAsResponseAsync(

            global::Ideogram.Product360VideoRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a looping 360-degree product video<br/>
        /// Animates one product image through a complete turntable revolution and returns to the starting pose so the result loops cleanly.<br/>
        /// Video generation runs asynchronously. Poll `GET /v1/generations/{generation_id}` with the returned `generation_id` until the generation completes or fails.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="direction">
        /// Direction the product rotates around its vertical axis.
        /// </param>
        /// <param name="productDescription">
        /// Optional factual description of the product in the source image.
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
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. The output video is added to it when the request completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoSeedDance25Response> PostProduct360VideoAsync(
            global::Ideogram.AssetIdentifier imageAssetIdentifier,
            global::Ideogram.Product360VideoDirection direction,
            string? productDescription = default,
            global::Ideogram.SeedDance25Resolution? resolution = default,
            int? duration = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}