#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Create a fashion lookbook<br/>
        /// Creates polished fashion product imagery from one or more product<br/>
        /// references and an aesthetic reference. Each generated shoot is returned<br/>
        /// as four individual lookbook images.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LookbookResponse> PostLookbookAsync(

            global::Ideogram.LookbookRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a fashion lookbook<br/>
        /// Creates polished fashion product imagery from one or more product<br/>
        /// references and an aesthetic reference. Each generated shoot is returned<br/>
        /// as four individual lookbook images.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.LookbookResponse>> PostLookbookAsResponseAsync(

            global::Ideogram.LookbookRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a fashion lookbook<br/>
        /// Creates polished fashion product imagery from one or more product<br/>
        /// references and an aesthetic reference. Each generated shoot is returned<br/>
        /// as four individual lookbook images.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.
        /// </summary>
        /// <param name="productAssetIdentifiers">
        /// Product images whose appearance must be preserved in the generated looks.
        /// </param>
        /// <param name="category">
        /// Selects the category-specific Lookbook presentation reference.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of each generated 2x2 composite before it is split into images. Defaults to `1:1` when omitted. Supported values are `1:1`, `3:4`, and `9:16`.
        /// </param>
        /// <param name="numShoots">
        /// Number of four-image lookbook shoots to create.<br/>
        /// Default Value: 3
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
        global::System.Threading.Tasks.Task<global::Ideogram.LookbookResponse> PostLookbookAsync(
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier> productAssetIdentifiers,
            global::Ideogram.LookbookRequestCategory category,
            string? aspectRatio = default,
            int? numShoots = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}