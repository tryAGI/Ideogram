#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// Generate SVG with GPT Image 2.6 Flare<br/>
        /// Generates SVG artwork from a prompt with GPT Image 2.6 Flare. The model renders an image and writes it out as SVG markup. Text prompts only: reference images are not supported.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.GenerateSvgResponse> CreateSvgGenerateGptImage26FlareAsync(

            global::Ideogram.V2.GenerateSvgGptImage26FlareRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate SVG with GPT Image 2.6 Flare<br/>
        /// Generates SVG artwork from a prompt with GPT Image 2.6 Flare. The model renders an image and writes it out as SVG markup. Text prompts only: reference images are not supported.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.GenerateSvgResponse>> CreateSvgGenerateGptImage26FlareAsResponseAsync(

            global::Ideogram.V2.GenerateSvgGptImage26FlareRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate SVG with GPT Image 2.6 Flare<br/>
        /// Generates SVG artwork from a prompt with GPT Image 2.6 Flare. The model renders an image and writes it out as SVG markup. Text prompts only: reference images are not supported.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// What the SVG should show, passed to the model as written.
        /// </param>
        /// <param name="aspectRatio">
        /// The output aspect ratio, for example "1:1", "16:9", or "9:16". "auto" (the default) lets the model choose a shape that suits the prompt. The long:short ratio is at most 3:1.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="quality">
        /// How much rendering effort GPT Image 2.6 Flare spends on the image the SVG is drawn from. Lower tiers return sooner and cost less; `auto` lets the model choose, which it currently renders at `high`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="thinkingLevel">
        /// How much the model plans before it renders, separate from `quality`. Lower levels return sooner.<br/>
        /// Default Value: high
        /// </param>
        /// <param name="numImages">
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
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
        global::System.Threading.Tasks.Task<global::Ideogram.V2.GenerateSvgResponse> CreateSvgGenerateGptImage26FlareAsync(
            string prompt,
            bool? dryRun = default,
            string? aspectRatio = default,
            global::Ideogram.V2.GenerateSvgGptImage26FlareRequestQuality? quality = default,
            global::Ideogram.V2.GenerateSvgGptImage26FlareRequestThinkingLevel? thinkingLevel = default,
            int? numImages = default,
            int? seed = default,
            bool? @private = default,
            string? targetCollectionId = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}