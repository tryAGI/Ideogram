#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// Ghost Mannequin<br/>
        /// Turns photos of one garment into a ghost-mannequin product image on a<br/>
        /// clean white studio background, removing the person, mannequin, hanger,<br/>
        /// and other clothing. Upload the photos using `multipart/form-data`, in<br/>
        /// the directional fields (such as `front_image`) when the camera<br/>
        /// direction is known and in `garment_images` otherwise.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.GhostMannequinResponse> CreateToolGhostMannequinAsync(

            global::Ideogram.V2.EditWorkflowPostGhostMannequinRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ghost Mannequin<br/>
        /// Turns photos of one garment into a ghost-mannequin product image on a<br/>
        /// clean white studio background, removing the person, mannequin, hanger,<br/>
        /// and other clothing. Upload the photos using `multipart/form-data`, in<br/>
        /// the directional fields (such as `front_image`) when the camera<br/>
        /// direction is known and in `garment_images` otherwise.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.GhostMannequinResponse>> CreateToolGhostMannequinAsResponseAsync(

            global::Ideogram.V2.EditWorkflowPostGhostMannequinRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ghost Mannequin<br/>
        /// Turns photos of one garment into a ghost-mannequin product image on a<br/>
        /// clean white studio background, removing the person, mannequin, hanger,<br/>
        /// and other clothing. Upload the photos using `multipart/form-data`, in<br/>
        /// the directional fields (such as `front_image`) when the camera<br/>
        /// direction is known and in `garment_images` otherwise.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="garmentImages">
        /// Additional photos of the same garment, up to 50 MB each. JPEG,<br/>
        /// PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and MPO are supported.<br/>
        /// Multipart requests only.
        /// </param>
        /// <param name="frontImage">
        /// Optional front-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="frontImagename">
        /// Optional front-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="backImage">
        /// Optional back-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="backImagename">
        /// Optional back-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="leftImage">
        /// Optional left-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="leftImagename">
        /// Optional left-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="rightImage">
        /// Optional right-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="rightImagename">
        /// Optional right-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="topImage">
        /// Optional top-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="topImagename">
        /// Optional top-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="bottomImage">
        /// Optional bottom-view garment photo, up to 50 MB. Multipart<br/>
        /// requests only.
        /// </param>
        /// <param name="bottomImagename">
        /// Optional bottom-view garment photo, up to 50 MB. Multipart<br/>
        /// requests only.
        /// </param>
        /// <param name="outputReferenceAssetIdentifier">
        /// An identifier for an ideogram asset.
        /// </param>
        /// <param name="outputReferenceImage">
        /// Optional presentation example, up to 50 MB. Multipart requests only.<br/>
        /// Guides pose, framing, and lighting without copying its garment,<br/>
        /// colors, text, or branding. Garment photos remain authoritative for<br/>
        /// product identity; view and aspect_ratio take precedence, and the<br/>
        /// background remains white. Does not replace a required garment photo.<br/>
        /// Mutually exclusive with `output_reference_asset_identifier`.
        /// </param>
        /// <param name="outputReferenceImagename">
        /// Optional presentation example, up to 50 MB. Multipart requests only.<br/>
        /// Guides pose, framing, and lighting without copying its garment,<br/>
        /// colors, text, or branding. Garment photos remain authoritative for<br/>
        /// product identity; view and aspect_ratio take precedence, and the<br/>
        /// background remains white. Does not replace a required garment photo.<br/>
        /// Mutually exclusive with `output_reference_asset_identifier`.
        /// </param>
        /// <param name="view">
        /// Camera view for the output garment.
        /// </param>
        /// <param name="instruction">
        /// Optional reconstruction guidance or identity-critical garment<br/>
        /// details to check against the photos. The output always uses a clean<br/>
        /// white studio background.
        /// </param>
        /// <param name="metadata">
        /// Optional JSON object serialized as a string containing factual<br/>
        /// product context, such as title, brand, category, color, material,<br/>
        /// item code, and exact printed text. Metadata helps disambiguate the<br/>
        /// garment photos but does not add features they do not show.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Defaults to `1:1` when omitted. Supported<br/>
        /// values are `1:1`, `3:4`, `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
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
        global::System.Threading.Tasks.Task<global::Ideogram.V2.GhostMannequinResponse> CreateToolGhostMannequinAsync(
            global::Ideogram.V2.V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView view,
            bool? dryRun = default,
            global::System.Collections.Generic.IList<byte[]>? garmentImages = default,
            byte[]? frontImage = default,
            string? frontImagename = default,
            byte[]? backImage = default,
            string? backImagename = default,
            byte[]? leftImage = default,
            string? leftImagename = default,
            byte[]? rightImage = default,
            string? rightImagename = default,
            byte[]? topImage = default,
            string? topImagename = default,
            byte[]? bottomImage = default,
            string? bottomImagename = default,
            global::Ideogram.V2.AssetIdentifier? outputReferenceAssetIdentifier = default,
            byte[]? outputReferenceImage = default,
            string? outputReferenceImagename = default,
            string? instruction = default,
            string? metadata = default,
            string? aspectRatio = default,
            global::Ideogram.V2.GhostMannequinQuality? quality = default,
            int? seed = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}