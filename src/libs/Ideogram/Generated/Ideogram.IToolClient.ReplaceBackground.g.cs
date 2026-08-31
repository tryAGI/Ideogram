#nullable enable

namespace Ideogram
{
    public partial interface IToolClient
    {
        /// <summary>
        /// Replace an image background<br/>
        /// Replaces the background of one image from a text prompt while preserving<br/>
        /// the foreground subject. The foreground mask is detected automatically;<br/>
        /// callers do not provide a mask.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply exactly one source transport: an existing `AssetIdentifier` in<br/>
        /// `image_asset_identifier`, or raw `image` bytes in a multipart request.<br/>
        /// Supplying both or neither is rejected with a 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ReplaceBackgroundResponse> ReplaceBackgroundAsync(

            global::Ideogram.ReplaceBackgroundRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace an image background<br/>
        /// Replaces the background of one image from a text prompt while preserving<br/>
        /// the foreground subject. The foreground mask is detected automatically;<br/>
        /// callers do not provide a mask.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply exactly one source transport: an existing `AssetIdentifier` in<br/>
        /// `image_asset_identifier`, or raw `image` bytes in a multipart request.<br/>
        /// Supplying both or neither is rejected with a 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ReplaceBackgroundResponse>> ReplaceBackgroundAsResponseAsync(

            global::Ideogram.ReplaceBackgroundRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace an image background<br/>
        /// Replaces the background of one image from a text prompt while preserving<br/>
        /// the foreground subject. The foreground mask is detected automatically;<br/>
        /// callers do not provide a mask.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply exactly one source transport: an existing `AssetIdentifier` in<br/>
        /// `image_asset_identifier`, or raw `image` bytes in a multipart request.<br/>
        /// Supplying both or neither is rejected with a 400.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// Raw source-image bytes. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP,<br/>
        /// TIFF, and MPO are supported, up to 50 MB. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// Raw source-image bytes. JPEG, PNG, WEBP, HEIF, AVIF, GIF, BMP,<br/>
        /// TIFF, and MPO are supported, up to 50 MB. Multipart requests only.
        /// </param>
        /// <param name="prompt">
        /// Plain-language description of the desired new background.
        /// </param>
        /// <param name="quality">
        /// The generation quality level. Defaults to `HIGH`.<br/>
        /// Default Value: HIGH
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="private">
        /// If true, the user is requesting private generation. If omitted,<br/>
        /// this defaults to the user's plan entitlement. Enterprise<br/>
        /// generations are always private.
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
        global::System.Threading.Tasks.Task<global::Ideogram.ReplaceBackgroundResponse> ReplaceBackgroundAsync(
            string prompt,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            global::Ideogram.GptImage2Quality? quality = default,
            int? numImages = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}