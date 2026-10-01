#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Ad Variations<br/>
        /// Creates on-brand variations of an ad along one axis, preserving logos,<br/>
        /// brand colors, the product, and all on-image text. Upload the source<br/>
        /// creative as `image` using `multipart/form-data` and choose a<br/>
        /// `variation_type`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AdVariationsResponse> PostAdVariationsAsync(

            global::Ideogram.AdVariationsRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ad Variations<br/>
        /// Creates on-brand variations of an ad along one axis, preserving logos,<br/>
        /// brand colors, the product, and all on-image text. Upload the source<br/>
        /// creative as `image` using `multipart/form-data` and choose a<br/>
        /// `variation_type`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.AdVariationsResponse>> PostAdVariationsAsResponseAsync(

            global::Ideogram.AdVariationsRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ad Variations<br/>
        /// Creates on-brand variations of an ad along one axis, preserving logos,<br/>
        /// brand colors, the product, and all on-image text. Upload the source<br/>
        /// creative as `image` using `multipart/form-data` and choose a<br/>
        /// `variation_type`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The source creative to vary (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported. Multipart requests only. Each output keeps<br/>
        /// the source's aspect ratio, capped at 3:1 between the long and short<br/>
        /// sides.
        /// </param>
        /// <param name="imagename">
        /// The source creative to vary (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported. Multipart requests only. Each output keeps<br/>
        /// the source's aspect ratio, capped at 3:1 between the long and short<br/>
        /// sides.
        /// </param>
        /// <param name="variationType">
        /// The axis to vary. `people`<br/>
        /// replaces the people in the ad with different talent. `setting`<br/>
        /// moves the same subject and product to a different environment.<br/>
        /// `group_size` changes how many people appear. `scene` shifts the<br/>
        /// moment or occasion (time of day, season, or activity).
        /// </param>
        /// <param name="prompt">
        /// Optional direction to steer the variation, for example "set it on a beach" or "make the models older". Anything it explicitly asks to change takes priority over the default preservation rules.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="numImages">
        /// The number of variations to generate along the requested axis.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="private">
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AdVariationsResponse> PostAdVariationsAsync(
            global::Ideogram.AdVariationsRequestVariationType variationType,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            string? prompt = default,
            global::Ideogram.AdVariationsQuality? quality = default,
            int? numImages = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}