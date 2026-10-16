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
        global::System.Threading.Tasks.Task<global::Ideogram.LayerizeDesignIdeogramV3Response> DesignPostLayerizeDesignIdeogramV3Async(

            global::Ideogram.DesignPostLayerizeDesignIdeogramV3Request request,
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.LayerizeDesignIdeogramV3Response>> DesignPostLayerizeDesignIdeogramV3AsResponseAsync(

            global::Ideogram.DesignPostLayerizeDesignIdeogramV3Request request,
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
        /// Random seed. Set for reproducible generation.
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
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LayerizeDesignIdeogramV3Response> DesignPostLayerizeDesignIdeogramV3Async(
            byte[] image,
            string imagename,
            bool? dryRun = default,
            string? prompt = default,
            int? seed = default,
            global::System.Collections.Generic.IList<byte[]>? fontCandidateFiles = default,
            bool? async = default,
            string? webhookUrl = default,
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
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="fontCandidateFiles">
        /// Candidate font files to make available for text style matching. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB each, maximum 5 files). Multipart requests only.
        /// </param>
        /// <param name="fontCandidateFilesFileNames">
        /// Optional file names to use for the multipart 'font_candidate_files' file parts.
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
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LayerizeDesignIdeogramV3Response> DesignPostLayerizeDesignIdeogramV3Async(
            global::System.IO.Stream image,
            string imagename,
            bool? dryRun = default,
            string? prompt = default,
            int? seed = default,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? fontCandidateFiles = default,
            global::System.Collections.Generic.IReadOnlyList<string>? fontCandidateFilesFileNames = default,
            bool? async = default,
            string? webhookUrl = default,
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
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="fontCandidateFiles">
        /// Candidate font files to make available for text style matching. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB each, maximum 5 files). Multipart requests only.
        /// </param>
        /// <param name="fontCandidateFilesFileNames">
        /// Optional file names to use for the multipart 'font_candidate_files' file parts.
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
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.LayerizeDesignIdeogramV3Response>> DesignPostLayerizeDesignIdeogramV3AsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            bool? dryRun = default,
            string? prompt = default,
            int? seed = default,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? fontCandidateFiles = default,
            global::System.Collections.Generic.IReadOnlyList<string>? fontCandidateFilesFileNames = default,
            bool? async = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}