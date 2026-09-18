#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Edit an image, optionally using a mask<br/>
        /// Applies an instruction to an image. When a mask is supplied, it identifies<br/>
        /// the primary edit region. Without a mask, the model edits the full image.<br/>
        /// Optional reference images can guide the requested appearance. Set<br/>
        /// `preserve_unmasked_pixels` to keep decoded pixels outside a supplied mask<br/>
        /// unchanged in the final image.<br/>
        /// The request runs asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.PreciseMaskedEditResponse> PostPreciseMaskedEditAsync(

            global::Ideogram.PreciseMaskedEditRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit an image, optionally using a mask<br/>
        /// Applies an instruction to an image. When a mask is supplied, it identifies<br/>
        /// the primary edit region. Without a mask, the model edits the full image.<br/>
        /// Optional reference images can guide the requested appearance. Set<br/>
        /// `preserve_unmasked_pixels` to keep decoded pixels outside a supplied mask<br/>
        /// unchanged in the final image.<br/>
        /// The request runs asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.PreciseMaskedEditResponse>> PostPreciseMaskedEditAsResponseAsync(

            global::Ideogram.PreciseMaskedEditRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit an image, optionally using a mask<br/>
        /// Applies an instruction to an image. When a mask is supplied, it identifies<br/>
        /// the primary edit region. Without a mask, the model edits the full image.<br/>
        /// Optional reference images can guide the requested appearance. Set<br/>
        /// `preserve_unmasked_pixels` to keep decoded pixels outside a supplied mask<br/>
        /// unchanged in the final image.<br/>
        /// The request runs asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.
        /// </summary>
        /// <param name="model">
        /// The model used to apply the masked edit.
        /// </param>
        /// <param name="quality">
        /// The generation quality level. Defaults to `high`.<br/>
        /// Default Value: high
        /// </param>
        /// <param name="sourceAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="sourceImage">
        /// Raw source image bytes. Supported formats and the 50 MB limit match the image upload API. Available only with `multipart/form-data`.
        /// </param>
        /// <param name="sourceImagename">
        /// Raw source image bytes. Supported formats and the 50 MB limit match the image upload API. Available only with `multipart/form-data`.
        /// </param>
        /// <param name="maskAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="referenceAssetIdentifiers">
        /// Optional assets that show the desired appearance of the edit. GPT Image 2 accepts up to 15. Ideogram 4.5 accepts up to 4 without a mask, or 3 when a mask is supplied.
        /// </param>
        /// <param name="instruction">
        /// Plain-language description of the desired change.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
        /// </param>
        /// <param name="numImages">
        /// Number of edited images to create.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="private">
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
        /// </param>
        /// <param name="preserveUnmaskedPixels">
        /// When true, decoded pixels outside the mask are copied from the<br/>
        /// source image into the final result. Requires `mask_asset_identifier`.<br/>
        /// When false, the final result is the model's full edited image.<br/>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.PreciseMaskedEditResponse> PostPreciseMaskedEditAsync(
            string instruction,
            global::Ideogram.PreciseMaskedEditModel? model = default,
            global::Ideogram.GptImage2Quality? quality = default,
            global::Ideogram.AssetIdentifier? sourceAssetIdentifier = default,
            byte[]? sourceImage = default,
            string? sourceImagename = default,
            global::Ideogram.AssetIdentifier? maskAssetIdentifier = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceAssetIdentifiers = default,
            int? seed = default,
            int? numImages = default,
            bool? @private = default,
            bool? preserveUnmaskedPixels = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}