#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// Upscale with Topaz Text Refine<br/>
        /// Upscale an image to 2x, 4x, or 8x its original resolution; no prompt is<br/>
        /// needed. Upload the source `image` using `multipart/form-data`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.V2.UpscaleImageTopazTextRefineResponse> CreateImageUpscaleTopazTextRefineAsync(

            global::Ideogram.V2.ImagesUpscalePostUpscaleImageTopazTextRefineRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upscale with Topaz Text Refine<br/>
        /// Upscale an image to 2x, 4x, or 8x its original resolution; no prompt is<br/>
        /// needed. Upload the source `image` using `multipart/form-data`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.UpscaleImageTopazTextRefineResponse>> CreateImageUpscaleTopazTextRefineAsResponseAsync(

            global::Ideogram.V2.ImagesUpscalePostUpscaleImageTopazTextRefineRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upscale with Topaz Text Refine<br/>
        /// Upscale an image to 2x, 4x, or 8x its original resolution; no prompt is<br/>
        /// needed. Upload the source `image` using `multipart/form-data`.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The source image to upscale, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </param>
        /// <param name="imagename">
        /// The source image to upscale, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </param>
        /// <param name="upscaleFactor">
        /// How much to enlarge the source image: 2x, 4x, or 8x its original width and height. Rejected when the output would exceed 8192px on either side.<br/>
        /// Default Value: x2
        /// </param>
        /// <param name="strength">
        /// Overall intensity of the enhancement model, from 0.01 to 1. Higher values look crisper but can turn unrealistic. Omit to let the model choose per image.
        /// </param>
        /// <param name="sharpen">
        /// Edge sharpening applied after enlarging, from 0 to 1. Omit to let the model choose per image.
        /// </param>
        /// <param name="denoise">
        /// Noise and grain reduction, from 0 to 1. Omit to let the model choose per image.
        /// </param>
        /// <param name="fixCompression">
        /// Compression artifact removal, from 0 to 1. Omit to let the model choose per image.
        /// </param>
        /// <param name="faceEnhancement">
        /// Recover detail in faces. When true, `face_enhancement_strength` and `face_enhancement_creativity` are required.
        /// </param>
        /// <param name="faceEnhancementStrength">
        /// How strongly faces are recovered, from 0 to 1.
        /// </param>
        /// <param name="faceEnhancementCreativity">
        /// How freely face recovery may reinterpret features, from 0 (faithful) to 1 (creative).
        /// </param>
        /// <param name="subjectDetection">
        /// Where enhancements apply. Omit to let the model choose per image.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request blocks until the upscaled image is ready and returns it in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` for the result.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.V2.UpscaleImageTopazTextRefineResponse> CreateImageUpscaleTopazTextRefineAsync(
            byte[] image,
            string imagename,
            bool? dryRun = default,
            global::Ideogram.V2.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor? upscaleFactor = default,
            string? strength = default,
            string? sharpen = default,
            string? denoise = default,
            string? fixCompression = default,
            bool? faceEnhancement = default,
            string? faceEnhancementStrength = default,
            string? faceEnhancementCreativity = default,
            global::Ideogram.V2.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection? subjectDetection = default,
            int? seed = default,
            bool? async = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upscale with Topaz Text Refine<br/>
        /// Upscale an image to 2x, 4x, or 8x its original resolution; no prompt is<br/>
        /// needed. Upload the source `image` using `multipart/form-data`.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The source image to upscale, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </param>
        /// <param name="imagename">
        /// The source image to upscale, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </param>
        /// <param name="upscaleFactor">
        /// How much to enlarge the source image: 2x, 4x, or 8x its original width and height. Rejected when the output would exceed 8192px on either side.<br/>
        /// Default Value: x2
        /// </param>
        /// <param name="strength">
        /// Overall intensity of the enhancement model, from 0.01 to 1. Higher values look crisper but can turn unrealistic. Omit to let the model choose per image.
        /// </param>
        /// <param name="sharpen">
        /// Edge sharpening applied after enlarging, from 0 to 1. Omit to let the model choose per image.
        /// </param>
        /// <param name="denoise">
        /// Noise and grain reduction, from 0 to 1. Omit to let the model choose per image.
        /// </param>
        /// <param name="fixCompression">
        /// Compression artifact removal, from 0 to 1. Omit to let the model choose per image.
        /// </param>
        /// <param name="faceEnhancement">
        /// Recover detail in faces. When true, `face_enhancement_strength` and `face_enhancement_creativity` are required.
        /// </param>
        /// <param name="faceEnhancementStrength">
        /// How strongly faces are recovered, from 0 to 1.
        /// </param>
        /// <param name="faceEnhancementCreativity">
        /// How freely face recovery may reinterpret features, from 0 (faithful) to 1 (creative).
        /// </param>
        /// <param name="subjectDetection">
        /// Where enhancements apply. Omit to let the model choose per image.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request blocks until the upscaled image is ready and returns it in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` for the result.<br/>
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
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.UpscaleImageTopazTextRefineResponse> CreateImageUpscaleTopazTextRefineAsync(
            global::System.IO.Stream image,
            string imagename,
            bool? dryRun = default,
            global::Ideogram.V2.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor? upscaleFactor = default,
            string? strength = default,
            string? sharpen = default,
            string? denoise = default,
            string? fixCompression = default,
            bool? faceEnhancement = default,
            string? faceEnhancementStrength = default,
            string? faceEnhancementCreativity = default,
            global::Ideogram.V2.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection? subjectDetection = default,
            int? seed = default,
            bool? async = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upscale with Topaz Text Refine<br/>
        /// Upscale an image to 2x, 4x, or 8x its original resolution; no prompt is<br/>
        /// needed. Upload the source `image` using `multipart/form-data`.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The source image to upscale, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </param>
        /// <param name="imagename">
        /// The source image to upscale, in a common format such as JPEG, PNG, or WEBP, up to 50MB. Multipart requests only. The uploaded image is used for this request only and is not stored.
        /// </param>
        /// <param name="upscaleFactor">
        /// How much to enlarge the source image: 2x, 4x, or 8x its original width and height. Rejected when the output would exceed 8192px on either side.<br/>
        /// Default Value: x2
        /// </param>
        /// <param name="strength">
        /// Overall intensity of the enhancement model, from 0.01 to 1. Higher values look crisper but can turn unrealistic. Omit to let the model choose per image.
        /// </param>
        /// <param name="sharpen">
        /// Edge sharpening applied after enlarging, from 0 to 1. Omit to let the model choose per image.
        /// </param>
        /// <param name="denoise">
        /// Noise and grain reduction, from 0 to 1. Omit to let the model choose per image.
        /// </param>
        /// <param name="fixCompression">
        /// Compression artifact removal, from 0 to 1. Omit to let the model choose per image.
        /// </param>
        /// <param name="faceEnhancement">
        /// Recover detail in faces. When true, `face_enhancement_strength` and `face_enhancement_creativity` are required.
        /// </param>
        /// <param name="faceEnhancementStrength">
        /// How strongly faces are recovered, from 0 to 1.
        /// </param>
        /// <param name="faceEnhancementCreativity">
        /// How freely face recovery may reinterpret features, from 0 (faithful) to 1 (creative).
        /// </param>
        /// <param name="subjectDetection">
        /// Where enhancements apply. Omit to let the model choose per image.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request blocks until the upscaled image is ready and returns it in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` for the result.<br/>
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
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.UpscaleImageTopazTextRefineResponse>> CreateImageUpscaleTopazTextRefineAsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            bool? dryRun = default,
            global::Ideogram.V2.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaUpscaleFactor? upscaleFactor = default,
            string? strength = default,
            string? sharpen = default,
            string? denoise = default,
            string? fixCompression = default,
            bool? faceEnhancement = default,
            string? faceEnhancementStrength = default,
            string? faceEnhancementCreativity = default,
            global::Ideogram.V2.V2ImageUpscaleTopazTextRefinePostRequestBodyContentMultipartFormDataSchemaSubjectDetection? subjectDetection = default,
            int? seed = default,
            bool? async = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}