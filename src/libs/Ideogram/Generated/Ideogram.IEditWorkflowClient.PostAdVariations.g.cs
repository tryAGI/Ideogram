#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Advertisement Variations<br/>
        /// Generates a brand-locked creative variation of the source ad along the<br/>
        /// requested variation axis: different people, a different setting, a<br/>
        /// different group size, or a different scene. Logos, brand colors, the<br/>
        /// product, and all on-image text are preserved; only the requested axis<br/>
        /// changes.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed. The completed generation<br/>
        /// reports the exact amount billed for the request in<br/>
        /// `usage_cost_usd_micros`.<br/>
        /// Each returned image is generated at the source creative's own aspect<br/>
        /// ratio (the long side to short side ratio is capped at 3:1).<br/>
        /// Supply the source creative as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two forms;<br/>
        /// supplying both, or neither, is rejected with a 400.
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
        /// Advertisement Variations<br/>
        /// Generates a brand-locked creative variation of the source ad along the<br/>
        /// requested variation axis: different people, a different setting, a<br/>
        /// different group size, or a different scene. Logos, brand colors, the<br/>
        /// product, and all on-image text are preserved; only the requested axis<br/>
        /// changes.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed. The completed generation<br/>
        /// reports the exact amount billed for the request in<br/>
        /// `usage_cost_usd_micros`.<br/>
        /// Each returned image is generated at the source creative's own aspect<br/>
        /// ratio (the long side to short side ratio is capped at 3:1).<br/>
        /// Supply the source creative as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two forms;<br/>
        /// supplying both, or neither, is rejected with a 400.
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
        /// Advertisement Variations<br/>
        /// Generates a brand-locked creative variation of the source ad along the<br/>
        /// requested variation axis: different people, a different setting, a<br/>
        /// different group size, or a different scene. Logos, brand colors, the<br/>
        /// product, and all on-image text are preserved; only the requested axis<br/>
        /// changes.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed. The completed generation<br/>
        /// reports the exact amount billed for the request in<br/>
        /// `usage_cost_usd_micros`.<br/>
        /// Each returned image is generated at the source creative's own aspect<br/>
        /// ratio (the long side to short side ratio is capped at 3:1).<br/>
        /// Supply the source creative as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two forms;<br/>
        /// supplying both, or neither, is rejected with a 400.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The source creative to vary (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Multipart requests only.<br/>
        /// Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="imagename">
        /// The source creative to vary (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Multipart requests only.<br/>
        /// Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="variationType">
        /// The axis to vary while everything else stays on-brand. `PEOPLE`<br/>
        /// replaces the people in the ad with different talent. `SETTING`<br/>
        /// moves the same subject and product to a different environment.<br/>
        /// `GROUP_SIZE` changes how many people appear. `SCENE` shifts the<br/>
        /// moment or occasion (time of day, season, or activity).
        /// </param>
        /// <param name="prompt">
        /// Optional direction to steer the variation, for example "set it on a beach" or "make the models older". Takes priority over the default preservation rules for anything it explicitly asks to change.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
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
            global::Ideogram.GptImage2Quality? quality = default,
            int? numImages = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}