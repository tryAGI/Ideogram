#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Design one Swan S logo candidate<br/>
        /// Creates one isolated logo candidate using either a shoe swatch or a supplied style reference. For 3D reference designs, choose split or full coverage with design_variant. Send a separate request for each candidate; each request completes and is billed independently. Processing is asynchronous. Poll GET /v1/generations/{generation_id} until completed or failed.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.SwanSLogoDesignResponse> PostSwanSLogoDesignAsync(

            global::Ideogram.SwanSLogoDesignRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Design one Swan S logo candidate<br/>
        /// Creates one isolated logo candidate using either a shoe swatch or a supplied style reference. For 3D reference designs, choose split or full coverage with design_variant. Send a separate request for each candidate; each request completes and is billed independently. Processing is asynchronous. Poll GET /v1/generations/{generation_id} until completed or failed.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.SwanSLogoDesignResponse>> PostSwanSLogoDesignAsResponseAsync(

            global::Ideogram.SwanSLogoDesignRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Design one Swan S logo candidate<br/>
        /// Creates one isolated logo candidate using either a shoe swatch or a supplied style reference. For 3D reference designs, choose split or full coverage with design_variant. Send a separate request for each candidate; each request completes and is billed independently. Processing is asynchronous. Poll GET /v1/generations/{generation_id} until completed or failed.
        /// </summary>
        /// <param name="logoStyle"></param>
        /// <param name="sourceMode">
        /// Use a shoe color swatch or an uploaded logo reference as the style source.
        /// </param>
        /// <param name="designVariant">
        /// Required for 3D user_reference designs. Omit for other designs.
        /// </param>
        /// <param name="styleSourceAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="geometryHeroAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="logoSpecificationAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="flatSilhouetteAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="quality">
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </param>
        /// <param name="private">
        /// When true or omitted, keep outputs private. Enterprise accounts always generate privately.
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
        global::System.Threading.Tasks.Task<global::Ideogram.SwanSLogoDesignResponse> PostSwanSLogoDesignAsync(
            global::Ideogram.SwanSLogoDesignRequestLogoStyle logoStyle,
            global::Ideogram.SwanSLogoDesignRequestSourceMode sourceMode,
            global::Ideogram.AssetIdentifier styleSourceAssetIdentifier,
            global::Ideogram.SwanSLogoDesignRequestDesignVariant? designVariant = default,
            global::Ideogram.AssetIdentifier? geometryHeroAssetIdentifier = default,
            global::Ideogram.AssetIdentifier? logoSpecificationAssetIdentifier = default,
            global::Ideogram.AssetIdentifier? flatSilhouetteAssetIdentifier = default,
            global::Ideogram.GptImage2Quality? quality = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}