#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Edit a product image using an instruction and ordered references<br/>
        /// Edits the base image while preserving details the instruction does not<br/>
        /// change. Image 1 is the base; reference images are numbered from image 2<br/>
        /// in the supplied order. Resolve image mentions to these numbers before<br/>
        /// submitting. Descriptions identify the selected view or reference.<br/>
        /// Poll GET /v1/generations/{generation_id} with the returned generation_id<br/>
        /// until the workflow completes or fails.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.SkechersStyleEditResponse> PostSkechersStyleEditAsync(

            global::Ideogram.SkechersStyleEditRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit a product image using an instruction and ordered references<br/>
        /// Edits the base image while preserving details the instruction does not<br/>
        /// change. Image 1 is the base; reference images are numbered from image 2<br/>
        /// in the supplied order. Resolve image mentions to these numbers before<br/>
        /// submitting. Descriptions identify the selected view or reference.<br/>
        /// Poll GET /v1/generations/{generation_id} with the returned generation_id<br/>
        /// until the workflow completes or fails.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.SkechersStyleEditResponse>> PostSkechersStyleEditAsResponseAsync(

            global::Ideogram.SkechersStyleEditRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit a product image using an instruction and ordered references<br/>
        /// Edits the base image while preserving details the instruction does not<br/>
        /// change. Image 1 is the base; reference images are numbered from image 2<br/>
        /// in the supplied order. Resolve image mentions to these numbers before<br/>
        /// submitting. Descriptions identify the selected view or reference.<br/>
        /// Poll GET /v1/generations/{generation_id} with the returned generation_id<br/>
        /// until the workflow completes or fails.
        /// </summary>
        /// <param name="baseAssetIdentifier">
        /// Image to edit, used as image 1 and the output canvas.
        /// </param>
        /// <param name="referenceAssetIdentifiers">
        /// Ordered reference images, numbered from image 2.
        /// </param>
        /// <param name="resolvedInstruction">
        /// Edit instructions with known image mentions resolved to image numbers.
        /// </param>
        /// <param name="baseDescription">
        /// Optional description of the selected base image or named view.
        /// </param>
        /// <param name="referenceDescriptions">
        /// One nonempty description per reference image, in the same order.
        /// </param>
        /// <param name="aspectRatio">
        /// Output ratio. When omitted, derive the nearest supported ratio from the base.
        /// </param>
        /// <param name="baseGenerationSize">
        /// Output resolution tier; corresponds to the app's low, medium, and high settings.<br/>
        /// Default Value: 2k
        /// </param>
        /// <param name="quality">
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </param>
        /// <param name="numImages">
        /// Number of edited images to create.<br/>
        /// Default Value: 1
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
        global::System.Threading.Tasks.Task<global::Ideogram.SkechersStyleEditResponse> PostSkechersStyleEditAsync(
            global::Ideogram.AssetIdentifier baseAssetIdentifier,
            string resolvedInstruction,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? referenceAssetIdentifiers = default,
            string? baseDescription = default,
            global::System.Collections.Generic.IList<string>? referenceDescriptions = default,
            global::Ideogram.SkechersStyleEditRequestAspectRatio? aspectRatio = default,
            global::Ideogram.SkechersStyleEditRequestBaseGenerationSize? baseGenerationSize = default,
            global::Ideogram.GptImage2Quality? quality = default,
            int? numImages = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}