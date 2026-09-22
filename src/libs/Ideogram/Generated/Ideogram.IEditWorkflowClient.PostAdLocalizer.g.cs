#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Rebuild an advertisement in another language<br/>
        /// Rebuilds the source advertisement for one target language. Layout,<br/>
        /// logos, brand type, and the product are preserved; the visible marketing<br/>
        /// copy is what changes.<br/>
        /// Without `exact_copy` the copy is translated. Supply `exact_copy` to<br/>
        /// place wording that has already been approved, character for character,<br/>
        /// instead of translating it.<br/>
        /// The output keeps the source advertisement's own shape and is generated<br/>
        /// at a frame derived from it, so neither the shape nor the size is asked<br/>
        /// for.<br/>
        /// One request localizes into one language. Localize into several languages<br/>
        /// by submitting one request per language.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply the source advertisement as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two forms;<br/>
        /// supplying both, or neither, is rejected with a 400.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AdLocalizerResponse> PostAdLocalizerAsync(

            global::Ideogram.AdLocalizerRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rebuild an advertisement in another language<br/>
        /// Rebuilds the source advertisement for one target language. Layout,<br/>
        /// logos, brand type, and the product are preserved; the visible marketing<br/>
        /// copy is what changes.<br/>
        /// Without `exact_copy` the copy is translated. Supply `exact_copy` to<br/>
        /// place wording that has already been approved, character for character,<br/>
        /// instead of translating it.<br/>
        /// The output keeps the source advertisement's own shape and is generated<br/>
        /// at a frame derived from it, so neither the shape nor the size is asked<br/>
        /// for.<br/>
        /// One request localizes into one language. Localize into several languages<br/>
        /// by submitting one request per language.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply the source advertisement as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two forms;<br/>
        /// supplying both, or neither, is rejected with a 400.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.AdLocalizerResponse>> PostAdLocalizerAsResponseAsync(

            global::Ideogram.AdLocalizerRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rebuild an advertisement in another language<br/>
        /// Rebuilds the source advertisement for one target language. Layout,<br/>
        /// logos, brand type, and the product are preserved; the visible marketing<br/>
        /// copy is what changes.<br/>
        /// Without `exact_copy` the copy is translated. Supply `exact_copy` to<br/>
        /// place wording that has already been approved, character for character,<br/>
        /// instead of translating it.<br/>
        /// The output keeps the source advertisement's own shape and is generated<br/>
        /// at a frame derived from it, so neither the shape nor the size is asked<br/>
        /// for.<br/>
        /// One request localizes into one language. Localize into several languages<br/>
        /// by submitting one request per language.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply the source advertisement as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two forms;<br/>
        /// supplying both, or neither, is rejected with a 400.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The source advertisement to localize (max size 25MB), as raw bytes;<br/>
        /// only JPEG, PNG, and WEBP formats are supported. Multipart requests<br/>
        /// only. Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="imagename">
        /// The source advertisement to localize (max size 25MB), as raw bytes;<br/>
        /// only JPEG, PNG, and WEBP formats are supported. Multipart requests<br/>
        /// only. Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="language">
        /// The target language the copy is rebuilt in. Arabic is rendered right-to-left.
        /// </param>
        /// <param name="exactCopy">
        /// Pre-approved wording, one `original =&gt; replacement` mapping per line. Each mapping names the text element showing `original` and sets it to `replacement`, placed character for character rather than translated. Any text element not listed is left as it is in the source. When omitted, all visible marketing copy is translated.
        /// </param>
        /// <param name="prompt">
        /// Optional additional direction for the localization, for example "keep the badge in English". It takes priority over the preservation rules for anything it explicitly asks to change.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="numImages">
        /// Number of localized variations to create for this language.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. Completed outputs are added to it automatically.
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
        global::System.Threading.Tasks.Task<global::Ideogram.AdLocalizerResponse> PostAdLocalizerAsync(
            global::Ideogram.AdLocalizerRequestLanguage language,
            bool? dryRun = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            string? exactCopy = default,
            string? prompt = default,
            global::Ideogram.AdLocalizerQuality? quality = default,
            int? seed = default,
            int? numImages = default,
            string? targetCollectionId = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}