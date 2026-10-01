#nullable enable

namespace Ideogram
{
    public partial interface IDesignClient
    {
        /// <summary>
        /// Layerize text with Ideogram 3.0<br/>
        /// Turn a flat image into an editable design: detected text is returned as<br/>
        /// positioned text blocks with matched fonts, sizes, and colors, alongside<br/>
        /// a text-free base image. Upload the image as `image` using<br/>
        /// `multipart/form-data`. Returns results directly by default; set `async`<br/>
        /// or supply a `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LayerizeDesignIdeogramV3Response> PostLayerizeDesignIdeogramV3Async(

            global::Ideogram.LayerizeDesignIdeogramV3Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Layerize text with Ideogram 3.0<br/>
        /// Turn a flat image into an editable design: detected text is returned as<br/>
        /// positioned text blocks with matched fonts, sizes, and colors, alongside<br/>
        /// a text-free base image. Upload the image as `image` using<br/>
        /// `multipart/form-data`. Returns results directly by default; set `async`<br/>
        /// or supply a `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.LayerizeDesignIdeogramV3Response>> PostLayerizeDesignIdeogramV3AsResponseAsync(

            global::Ideogram.LayerizeDesignIdeogramV3Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Layerize text with Ideogram 3.0<br/>
        /// Turn a flat image into an editable design: detected text is returned as<br/>
        /// positioned text blocks with matched fonts, sizes, and colors, alongside<br/>
        /// a text-free base image. Upload the image as `image` using<br/>
        /// `multipart/form-data`. Returns results directly by default; set `async`<br/>
        /// or supply a `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The source image to layerize (max 50MB). Common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image to layerize (max 50MB). Common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only.
        /// </param>
        /// <param name="prompt">
        /// A description of the image, used to guide text detection. When omitted, detection runs on the image alone.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="fontCandidateFiles">
        /// Candidate font files to make available for text style matching. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB each, maximum 5 files). Multipart requests only.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request waits until layerization is complete and returns the result in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` with the returned `generation_id` for the result.<br/>
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
        /// <param name="private">
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. The output is added to it when the request completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LayerizeDesignIdeogramV3Response> PostLayerizeDesignIdeogramV3Async(
            bool? dryRun = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            string? prompt = default,
            int? seed = default,
            global::System.Collections.Generic.IList<byte[]>? fontCandidateFiles = default,
            bool? async = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}