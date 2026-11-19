#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// Remix with Ideogram 4.5<br/>
        /// Transform an existing image with Ideogram 4.5, guided by a text<br/>
        /// prompt. Supply one source image to transform and, optionally, up to<br/>
        /// four reference images to bring into the result (for example a<br/>
        /// product, a logo, or a style). Upload images using<br/>
        /// `multipart/form-data`, or pass existing assets by reference.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.RemixImageIdeogram45Response> CreateImageRemixIdeogram45Async(

            global::Ideogram.V2.ImagesRemixPostRemixImageV2Ideogram45Request request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix with Ideogram 4.5<br/>
        /// Transform an existing image with Ideogram 4.5, guided by a text<br/>
        /// prompt. Supply one source image to transform and, optionally, up to<br/>
        /// four reference images to bring into the result (for example a<br/>
        /// product, a logo, or a style). Upload images using<br/>
        /// `multipart/form-data`, or pass existing assets by reference.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.RemixImageIdeogram45Response>> CreateImageRemixIdeogram45AsResponseAsync(

            global::Ideogram.V2.ImagesRemixPostRemixImageV2Ideogram45Request request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix with Ideogram 4.5<br/>
        /// Transform an existing image with Ideogram 4.5, guided by a text<br/>
        /// prompt. Supply one source image to transform and, optionally, up to<br/>
        /// four reference images to bring into the result (for example a<br/>
        /// product, a logo, or a style). Upload images using<br/>
        /// `multipart/form-data`, or pass existing assets by reference.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The prompt that guides the remix. It is always read as an editing instruction, so there is no `magic_prompt` option.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// The existing upload or generated image to transform. Supply this or `image`, never both. Leave `size` as "source" to keep its shape.
        /// </param>
        /// <param name="image">
        /// The image to transform. JPEG, PNG, and WEBP are supported. Multipart requests only. The uploaded image is saved to your account as the remix's source. Supply this or `image_asset_identifier`, never both. Leave `size` as "source" to keep its shape.
        /// </param>
        /// <param name="imagename">
        /// The image to transform. JPEG, PNG, and WEBP are supported. Multipart requests only. The uploaded image is saved to your account as the remix's source. Supply this or `image_asset_identifier`, never both. Leave `size` as "source" to keep its shape.
        /// </param>
        /// <param name="referenceImageAssetIdentifiers">
        /// Optional existing upload or generated images to bring into the result, such as a product, a logo, or a style. They guide the remix but are not transformed themselves. Supply this or `reference_images`, never both.
        /// </param>
        /// <param name="referenceImages">
        /// Optional reference images to upload (max 4; JPEG, PNG, or WEBP). The same rules as `reference_image_asset_identifiers` apply. Multipart requests only.
        /// </param>
        /// <param name="imageWeight">
        /// Optional. How closely the result should follow the source image, from 1 to 100. When omitted the server chooses a value from your prompt, which is the usual case. Only accepted when the output keeps the source image's shape: combining `image_weight` with a `size` whose aspect ratio differs from the source's is rejected with a 400.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// The output size: "source" or an exact "WIDTHxHEIGHT".<br/>
        /// "source" (the default) keeps the source image's shape at the<br/>
        /// closest supported Ideogram 4.5 size. An exact size must be a<br/>
        /// supported Ideogram 4.5 size (for example 2048x2048 or 1440x2560),<br/>
        /// and one whose aspect ratio differs from the source's cannot be<br/>
        /// combined with `image_weight`.<br/>
        /// Default Value: source
        /// </param>
        /// <param name="quality">
        /// The rendering quality to use. Higher quality takes longer and costs more.<br/>
        /// Default Value: high
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request waits until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v2/generations/{generation_id}` using the returned `generation_id`.<br/>
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
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.RemixImageIdeogram45Response> CreateImageRemixIdeogram45Async(
            string prompt,
            bool? dryRun = default,
            global::Ideogram.V2.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            global::System.Collections.Generic.IList<global::Ideogram.V2.AssetIdentifier>? referenceImageAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? referenceImages = default,
            int? imageWeight = default,
            int? numImages = default,
            string? size = default,
            global::Ideogram.V2.V2ImageRemixIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality? quality = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}