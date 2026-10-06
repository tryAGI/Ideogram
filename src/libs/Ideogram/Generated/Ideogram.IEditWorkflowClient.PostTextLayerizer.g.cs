#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Text Layerizer<br/>
        /// Turns a flat image into an editable design asynchronously: detected text<br/>
        /// is returned as positioned text blocks with matched fonts, sizes, and<br/>
        /// colors, alongside a text-free base image and a standalone HTML page of<br/>
        /// the editable design. Returns a `generation_id`; poll<br/>
        /// `GET /v2/generations/{generation_id}` or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.TextLayerizerResponse> PostTextLayerizerAsync(

            global::Ideogram.TextLayerizerRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text Layerizer<br/>
        /// Turns a flat image into an editable design asynchronously: detected text<br/>
        /// is returned as positioned text blocks with matched fonts, sizes, and<br/>
        /// colors, alongside a text-free base image and a standalone HTML page of<br/>
        /// the editable design. Returns a `generation_id`; poll<br/>
        /// `GET /v2/generations/{generation_id}` or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.TextLayerizerResponse>> PostTextLayerizerAsResponseAsync(

            global::Ideogram.TextLayerizerRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text Layerizer<br/>
        /// Turns a flat image into an editable design asynchronously: detected text<br/>
        /// is returned as positioned text blocks with matched fonts, sizes, and<br/>
        /// colors, alongside a text-free base image and a standalone HTML page of<br/>
        /// the editable design. Returns a `generation_id`; poll<br/>
        /// `GET /v2/generations/{generation_id}` or supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// JPEG, PNG or WEBP source; at most 50 MB. Multipart only.
        /// </param>
        /// <param name="imagename">
        /// JPEG, PNG or WEBP source; at most 50 MB. Multipart only.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="prompt">
        /// A description of the image, used to guide text detection. When omitted, detection runs on the image alone.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="fontCandidateFiles">
        /// Candidate font files to make available for text style matching and to embed in the standalone HTML page. Supported formats .ttf, .otf, .woff, .woff2 (max 5 MB each, at most 5 files). Multipart only. You are responsible for holding the rights to embed and redistribute the fonts you upload.
        /// </param>
        /// <param name="private">
        /// Outputs are private by default. Enterprise outputs are always private.
        /// </param>
        /// <param name="targetCollectionId">
        /// URL-safe base64 ID of a writable destination collection.
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
        global::System.Threading.Tasks.Task<global::Ideogram.TextLayerizerResponse> PostTextLayerizerAsync(
            bool? dryRun = default,
            byte[]? image = default,
            string? imagename = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            string? prompt = default,
            int? seed = default,
            global::System.Collections.Generic.IList<byte[]>? fontCandidateFiles = default,
            bool? @private = default,
            string? targetCollectionId = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}