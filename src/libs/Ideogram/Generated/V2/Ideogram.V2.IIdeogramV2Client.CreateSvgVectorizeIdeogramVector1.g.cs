#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// Vectorizer<br/>
        /// Converts an image to SVG asynchronously.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.VectorizerResponse> CreateSvgVectorizeIdeogramVector1Async(

            global::Ideogram.V2.SvgGeneratePostVectorizerRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Vectorizer<br/>
        /// Converts an image to SVG asynchronously.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.VectorizerResponse>> CreateSvgVectorizeIdeogramVector1AsResponseAsync(

            global::Ideogram.V2.SvgGeneratePostVectorizerRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Vectorizer<br/>
        /// Converts an image to SVG asynchronously.
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
        /// An identifier for an ideogram asset.
        /// </param>
        /// <param name="mode">
        /// Simple uses fewer shapes; detailed preserves fine detail; auto chooses the level of detail that best suits the image.<br/>
        /// Default Value: auto
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
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.VectorizerResponse> CreateSvgVectorizeIdeogramVector1Async(
            bool? dryRun = default,
            byte[]? image = default,
            string? imagename = default,
            global::Ideogram.V2.AssetIdentifier? imageAssetIdentifier = default,
            global::Ideogram.V2.V2SvgVectorizeIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaMode? mode = default,
            bool? @private = default,
            string? targetCollectionId = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}