#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Colorways<br/>
        /// Recolors masked regions of a product photo, each to its own target<br/>
        /// color, preserving the product's geometry, materials, prints, logos, and<br/>
        /// everything outside the masks. Upload the `image` and up to 4 `masks`<br/>
        /// using `multipart/form-data`, with one entry in `colors` per mask.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ColorwaysResponse> EditWorkflowPostColorwaysAsync(

            global::Ideogram.EditWorkflowPostColorwaysRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Colorways<br/>
        /// Recolors masked regions of a product photo, each to its own target<br/>
        /// color, preserving the product's geometry, materials, prints, logos, and<br/>
        /// everything outside the masks. Upload the `image` and up to 4 `masks`<br/>
        /// using `multipart/form-data`, with one entry in `colors` per mask.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ColorwaysResponse>> EditWorkflowPostColorwaysAsResponseAsync(

            global::Ideogram.EditWorkflowPostColorwaysRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Colorways<br/>
        /// Recolors masked regions of a product photo, each to its own target<br/>
        /// color, preserving the product's geometry, materials, prints, logos, and<br/>
        /// everything outside the masks. Upload the `image` and up to 4 `masks`<br/>
        /// using `multipart/form-data`, with one entry in `colors` per mask.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The product photo to recolor (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The product photo to recolor (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
        /// </param>
        /// <param name="masks">
        /// Masks marking the regions to recolor (max 4, max size 25MB each),<br/>
        /// paired by position with `colors`. JPEG, PNG, and WEBP formats are<br/>
        /// supported. Every mask must have the same pixel dimensions as the<br/>
        /// product photo. White pixels mark the region to recolor and black<br/>
        /// pixels are preserved; alpha-only masks also work (opaque =<br/>
        /// recolor, transparent = preserve).
        /// </param>
        /// <param name="colors">
        /// One target color per mask in `masks`, as six-digit hex codes like<br/>
        /// `#B3202C`, paired by position. The product's shape, construction,<br/>
        /// materials, prints, and logos are always preserved.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Defaults to the product photo's aspect ratio,<br/>
        /// which keeps the original framing. A different ratio extends the<br/>
        /// scene to fill the new shape rather than cropping, so part of the<br/>
        /// frame is newly generated. Supported values are `1:1`, `3:4`,<br/>
        /// `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="webhookUrl">
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ColorwaysResponse> EditWorkflowPostColorwaysAsync(
            byte[] image,
            string imagename,
            global::System.Collections.Generic.IList<string> colors,
            bool? dryRun = default,
            global::System.Collections.Generic.IList<byte[]>? masks = default,
            string? aspectRatio = default,
            global::Ideogram.ColorwaysQuality? quality = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Colorways<br/>
        /// Recolors masked regions of a product photo, each to its own target<br/>
        /// color, preserving the product's geometry, materials, prints, logos, and<br/>
        /// everything outside the masks. Upload the `image` and up to 4 `masks`<br/>
        /// using `multipart/form-data`, with one entry in `colors` per mask.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The product photo to recolor (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The product photo to recolor (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
        /// </param>
        /// <param name="masks">
        /// Masks marking the regions to recolor (max 4, max size 25MB each),<br/>
        /// paired by position with `colors`. JPEG, PNG, and WEBP formats are<br/>
        /// supported. Every mask must have the same pixel dimensions as the<br/>
        /// product photo. White pixels mark the region to recolor and black<br/>
        /// pixels are preserved; alpha-only masks also work (opaque =<br/>
        /// recolor, transparent = preserve).
        /// </param>
        /// <param name="masksFileNames">
        /// Optional file names to use for the multipart 'masks' file parts.
        /// </param>
        /// <param name="colors">
        /// One target color per mask in `masks`, as six-digit hex codes like<br/>
        /// `#B3202C`, paired by position. The product's shape, construction,<br/>
        /// materials, prints, and logos are always preserved.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Defaults to the product photo's aspect ratio,<br/>
        /// which keeps the original framing. A different ratio extends the<br/>
        /// scene to fill the new shape rather than cropping, so part of the<br/>
        /// frame is newly generated. Supported values are `1:1`, `3:4`,<br/>
        /// `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="webhookUrl">
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ColorwaysResponse> EditWorkflowPostColorwaysAsync(
            global::System.IO.Stream image,
            string imagename,
            global::System.Collections.Generic.IList<string> colors,
            bool? dryRun = default,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? masks = default,
            global::System.Collections.Generic.IReadOnlyList<string>? masksFileNames = default,
            string? aspectRatio = default,
            global::Ideogram.ColorwaysQuality? quality = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Colorways<br/>
        /// Recolors masked regions of a product photo, each to its own target<br/>
        /// color, preserving the product's geometry, materials, prints, logos, and<br/>
        /// everything outside the masks. Upload the `image` and up to 4 `masks`<br/>
        /// using `multipart/form-data`, with one entry in `colors` per mask.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The product photo to recolor (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The product photo to recolor (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
        /// </param>
        /// <param name="masks">
        /// Masks marking the regions to recolor (max 4, max size 25MB each),<br/>
        /// paired by position with `colors`. JPEG, PNG, and WEBP formats are<br/>
        /// supported. Every mask must have the same pixel dimensions as the<br/>
        /// product photo. White pixels mark the region to recolor and black<br/>
        /// pixels are preserved; alpha-only masks also work (opaque =<br/>
        /// recolor, transparent = preserve).
        /// </param>
        /// <param name="masksFileNames">
        /// Optional file names to use for the multipart 'masks' file parts.
        /// </param>
        /// <param name="colors">
        /// One target color per mask in `masks`, as six-digit hex codes like<br/>
        /// `#B3202C`, paired by position. The product's shape, construction,<br/>
        /// materials, prints, and logos are always preserved.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Defaults to the product photo's aspect ratio,<br/>
        /// which keeps the original framing. A different ratio extends the<br/>
        /// scene to fill the new shape rather than cropping, so part of the<br/>
        /// frame is newly generated. Supported values are `1:1`, `3:4`,<br/>
        /// `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="webhookUrl">
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ColorwaysResponse>> EditWorkflowPostColorwaysAsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            global::System.Collections.Generic.IList<string> colors,
            bool? dryRun = default,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? masks = default,
            global::System.Collections.Generic.IReadOnlyList<string>? masksFileNames = default,
            string? aspectRatio = default,
            global::Ideogram.ColorwaysQuality? quality = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}