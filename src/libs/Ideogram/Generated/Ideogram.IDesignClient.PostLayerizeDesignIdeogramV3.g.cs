#nullable enable

namespace Ideogram
{
    public partial interface IDesignClient
    {
        /// <summary>
        /// Layerize the text in an image<br/>
        /// Decompose a flat image into an editable design: the text in the image<br/>
        /// is detected, erased from the image, and returned as positioned text<br/>
        /// blocks with matched fonts, sizes, and colors, alongside a text-free<br/>
        /// base image.<br/>
        /// Supply the source either as an `image_asset_identifier` reference (an<br/>
        /// image already stored with Ideogram) or as raw `image` bytes (multipart<br/>
        /// requests only). Provide exactly one of the two forms; supplying both,<br/>
        /// or neither, is rejected with a 400.<br/>
        /// A `prompt` describing the image can guide text detection; when<br/>
        /// omitted, detection runs on the image alone.<br/>
        /// By default the request blocks until layerization is complete and<br/>
        /// returns the result in `data`. Set `async` to true to return<br/>
        /// immediately after the request is accepted, then poll for completion<br/>
        /// and results with `GET /v1/generations/{generation_id}` using the<br/>
        /// returned `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LayerizeDesignIdeogramV3Response> PostLayerizeDesignIdeogramV3Async(

            global::Ideogram.LayerizeDesignIdeogramV3Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Layerize the text in an image<br/>
        /// Decompose a flat image into an editable design: the text in the image<br/>
        /// is detected, erased from the image, and returned as positioned text<br/>
        /// blocks with matched fonts, sizes, and colors, alongside a text-free<br/>
        /// base image.<br/>
        /// Supply the source either as an `image_asset_identifier` reference (an<br/>
        /// image already stored with Ideogram) or as raw `image` bytes (multipart<br/>
        /// requests only). Provide exactly one of the two forms; supplying both,<br/>
        /// or neither, is rejected with a 400.<br/>
        /// A `prompt` describing the image can guide text detection; when<br/>
        /// omitted, detection runs on the image alone.<br/>
        /// By default the request blocks until layerization is complete and<br/>
        /// returns the result in `data`. Set `async` to true to return<br/>
        /// immediately after the request is accepted, then poll for completion<br/>
        /// and results with `GET /v1/generations/{generation_id}` using the<br/>
        /// returned `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.LayerizeDesignIdeogramV3Response>> PostLayerizeDesignIdeogramV3AsResponseAsync(

            global::Ideogram.LayerizeDesignIdeogramV3Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Layerize the text in an image<br/>
        /// Decompose a flat image into an editable design: the text in the image<br/>
        /// is detected, erased from the image, and returned as positioned text<br/>
        /// blocks with matched fonts, sizes, and colors, alongside a text-free<br/>
        /// base image.<br/>
        /// Supply the source either as an `image_asset_identifier` reference (an<br/>
        /// image already stored with Ideogram) or as raw `image` bytes (multipart<br/>
        /// requests only). Provide exactly one of the two forms; supplying both,<br/>
        /// or neither, is rejected with a 400.<br/>
        /// A `prompt` describing the image can guide text detection; when<br/>
        /// omitted, detection runs on the image alone.<br/>
        /// By default the request blocks until layerization is complete and<br/>
        /// returns the result in `data`. Set `async` to true to return<br/>
        /// immediately after the request is accepted, then poll for completion<br/>
        /// and results with `GET /v1/generations/{generation_id}` using the<br/>
        /// returned `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The source image to layerize (max size 50MB), as raw bytes; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="imagename">
        /// The source image to layerize (max size 50MB), as raw bytes; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only. Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="prompt">
        /// A description of the image, used to guide text detection. When omitted, detection runs on the image alone.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="async">
        /// When false (the default), the request blocks until layerization is complete and returns the result in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
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
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            string? prompt = default,
            int? seed = default,
            bool? async = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}