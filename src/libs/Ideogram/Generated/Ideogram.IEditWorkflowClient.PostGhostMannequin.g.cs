#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Create ghost-mannequin garment photography<br/>
        /// Transforms one or more photographs of the same garment into a polished<br/>
        /// ghost-mannequin product image on a clean white studio background. The<br/>
        /// garment keeps its identity and construction while the source person,<br/>
        /// mannequin, hanger, environment, and other clothing are removed.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply one or more garment references. Use the directional fields when<br/>
        /// the camera direction is known; each direction accepts either an<br/>
        /// existing `AssetIdentifier` or one raw image, but not both. Additional<br/>
        /// unlabeled references can be supplied through exactly one transport:<br/>
        /// `garment_asset_identifiers`, or multipart `garment_images`.
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
        /// Create ghost-mannequin garment photography<br/>
        /// Transforms one or more photographs of the same garment into a polished<br/>
        /// ghost-mannequin product image on a clean white studio background. The<br/>
        /// garment keeps its identity and construction while the source person,<br/>
        /// mannequin, hanger, environment, and other clothing are removed.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply one or more garment references. Use the directional fields when<br/>
        /// the camera direction is known; each direction accepts either an<br/>
        /// existing `AssetIdentifier` or one raw image, but not both. Additional<br/>
        /// unlabeled references can be supplied through exactly one transport:<br/>
        /// `garment_asset_identifiers`, or multipart `garment_images`.
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
        /// Create ghost-mannequin garment photography<br/>
        /// Transforms one or more photographs of the same garment into a polished<br/>
        /// ghost-mannequin product image on a clean white studio background. The<br/>
        /// garment keeps its identity and construction while the source person,<br/>
        /// mannequin, hanger, environment, and other clothing are removed.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply one or more garment references. Use the directional fields when<br/>
        /// the camera direction is known; each direction accepts either an<br/>
        /// existing `AssetIdentifier` or one raw image, but not both. Additional<br/>
        /// unlabeled references can be supplied through exactly one transport:<br/>
        /// `garment_asset_identifiers`, or multipart `garment_images`.
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
        /// Raw images of the same garment, up to 50 MB each. JPEG, PNG, WEBP,<br/>
        /// HEIF, AVIF, GIF, BMP, TIFF, and MPO are supported. Multipart<br/>
        /// requests only. Mutually exclusive with<br/>
        /// `garment_asset_identifiers`.
        /// </param>
        /// <param name="frontAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="frontImage">
        /// Optional raw front-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `front_asset_identifier`.
        /// </param>
        /// <param name="frontImagename">
        /// Optional raw front-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `front_asset_identifier`.
        /// </param>
        /// <param name="backAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="backImage">
        /// Optional raw back-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `back_asset_identifier`.
        /// </param>
        /// <param name="backImagename">
        /// Optional raw back-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `back_asset_identifier`.
        /// </param>
        /// <param name="leftAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="leftImage">
        /// Optional raw left-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `left_asset_identifier`.
        /// </param>
        /// <param name="leftImagename">
        /// Optional raw left-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `left_asset_identifier`.
        /// </param>
        /// <param name="rightAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="rightImage">
        /// Optional raw right-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `right_asset_identifier`.
        /// </param>
        /// <param name="rightImagename">
        /// Optional raw right-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `right_asset_identifier`.
        /// </param>
        /// <param name="topAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="topImage">
        /// Optional raw top-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `top_asset_identifier`.
        /// </param>
        /// <param name="topImagename">
        /// Optional raw top-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `top_asset_identifier`.
        /// </param>
        /// <param name="bottomAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="bottomImage">
        /// Optional raw bottom-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with<br/>
        /// `bottom_asset_identifier`.
        /// </param>
        /// <param name="bottomImagename">
        /// Optional raw bottom-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with<br/>
        /// `bottom_asset_identifier`.
        /// </param>
        /// <param name="view">
        /// Camera view for the output garment.
        /// </param>
        /// <param name="instruction">
        /// Optional reconstruction guidance or identity-critical garment<br/>
        /// details for the analyzer to verify. The output always uses the<br/>
        /// workflow's clean white studio presentation.
        /// </param>
        /// <param name="metadata">
        /// Optional JSON object serialized as a string containing factual<br/>
        /// product context, such as title, brand, category, color, material,<br/>
        /// item code, and exact printed text. Metadata helps disambiguate the<br/>
        /// garment references but does not add unsupported visual features.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Defaults to `1:1` when omitted. Supported<br/>
        /// values are `1:1`, `3:4`, `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
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
            global::Ideogram.GptImage2Quality? quality = default,
            int? seed = default,
            string? targetCollectionId = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}