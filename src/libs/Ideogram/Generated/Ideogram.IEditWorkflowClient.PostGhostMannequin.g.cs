#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
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
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GhostMannequinResponse> PostGhostMannequinAsync(

            global::Ideogram.GhostMannequinRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
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
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GhostMannequinResponse>> PostGhostMannequinAsResponseAsync(

            global::Ideogram.GhostMannequinRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="garmentAssetIdentifiers">
        /// Ordered uploaded or generated images of the same garment. Use<br/>
        /// multiple angles when available so obscured construction can be<br/>
        /// reconstructed conservatively. Mutually exclusive with<br/>
        /// `garment_images`.
        /// </param>
        /// <param name="garmentImages">
        /// Additional photos of the same garment, up to 50 MB each. JPEG,<br/>
        /// PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and MPO are supported.<br/>
        /// Multipart requests only.
        /// </param>
        /// <param name="frontAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="frontImage">
        /// Optional front-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="frontImagename">
        /// Optional front-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="backAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="backImage">
        /// Optional back-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="backImagename">
        /// Optional back-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="leftAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="leftImage">
        /// Optional left-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="leftImagename">
        /// Optional left-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="rightAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="rightImage">
        /// Optional right-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="rightImagename">
        /// Optional right-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="topAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="topImage">
        /// Optional top-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="topImagename">
        /// Optional top-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="bottomAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="bottomImage">
        /// Optional bottom-view garment photo, up to 50 MB. Multipart<br/>
        /// requests only.
        /// </param>
        /// <param name="bottomImagename">
        /// Optional bottom-view garment photo, up to 50 MB. Multipart<br/>
        /// requests only.
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
        global::System.Threading.Tasks.Task<global::Ideogram.GhostMannequinResponse> PostGhostMannequinAsync(
            global::Ideogram.GhostMannequinRequestView view,
            bool? dryRun = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? garmentAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? garmentImages = default,
            global::Ideogram.AssetIdentifier? frontAssetIdentifier = default,
            byte[]? frontImage = default,
            string? frontImagename = default,
            global::Ideogram.AssetIdentifier? backAssetIdentifier = default,
            byte[]? backImage = default,
            string? backImagename = default,
            global::Ideogram.AssetIdentifier? leftAssetIdentifier = default,
            byte[]? leftImage = default,
            string? leftImagename = default,
            global::Ideogram.AssetIdentifier? rightAssetIdentifier = default,
            byte[]? rightImage = default,
            string? rightImagename = default,
            global::Ideogram.AssetIdentifier? topAssetIdentifier = default,
            byte[]? topImage = default,
            string? topImagename = default,
            global::Ideogram.AssetIdentifier? bottomAssetIdentifier = default,
            byte[]? bottomImage = default,
            string? bottomImagename = default,
            string? instruction = default,
            string? metadata = default,
            string? aspectRatio = default,
            global::Ideogram.GhostMannequinQuality? quality = default,
            int? seed = default,
            string? targetCollectionId = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}