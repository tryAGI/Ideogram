#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Dress a person in one or more garments<br/>
        /// Generates a photorealistic image of the person in the supplied photo<br/>
        /// wearing the supplied garments, preserving their face, body, and<br/>
        /// background.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply the person as either an `AssetIdentifier` reference<br/>
        /// (`person_asset_identifier`) or the raw image bytes directly<br/>
        /// (`person_image`, multipart requests only), and likewise the garments as<br/>
        /// either `garment_asset_identifiers` or `garment_images`. For each of the<br/>
        /// two sources, provide exactly one of the two forms; supplying both, or<br/>
        /// neither, is rejected with a 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.VirtualTryOnResponse> PostVirtualTryOnAsync(

            global::Ideogram.VirtualTryOnRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Dress a person in one or more garments<br/>
        /// Generates a photorealistic image of the person in the supplied photo<br/>
        /// wearing the supplied garments, preserving their face, body, and<br/>
        /// background.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply the person as either an `AssetIdentifier` reference<br/>
        /// (`person_asset_identifier`) or the raw image bytes directly<br/>
        /// (`person_image`, multipart requests only), and likewise the garments as<br/>
        /// either `garment_asset_identifiers` or `garment_images`. For each of the<br/>
        /// two sources, provide exactly one of the two forms; supplying both, or<br/>
        /// neither, is rejected with a 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.VirtualTryOnResponse>> PostVirtualTryOnAsResponseAsync(

            global::Ideogram.VirtualTryOnRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Dress a person in one or more garments<br/>
        /// Generates a photorealistic image of the person in the supplied photo<br/>
        /// wearing the supplied garments, preserving their face, body, and<br/>
        /// background.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply the person as either an `AssetIdentifier` reference<br/>
        /// (`person_asset_identifier`) or the raw image bytes directly<br/>
        /// (`person_image`, multipart requests only), and likewise the garments as<br/>
        /// either `garment_asset_identifiers` or `garment_images`. For each of the<br/>
        /// two sources, provide exactly one of the two forms; supplying both, or<br/>
        /// neither, is rejected with a 400.
        /// </summary>
        /// <param name="personAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="personImage">
        /// Photo of the person to dress (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Multipart requests only.<br/>
        /// Provide exactly one of `person_asset_identifier` or `person_image`.
        /// </param>
        /// <param name="personImagename">
        /// Photo of the person to dress (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Multipart requests only.<br/>
        /// Provide exactly one of `person_asset_identifier` or `person_image`.
        /// </param>
        /// <param name="garmentAssetIdentifiers">
        /// Photos of the clothing items to put on the person, by reference.<br/>
        /// Multiple garments are layered into one coherent outfit. Provide<br/>
        /// exactly one of `garment_asset_identifiers` or `garment_images`.
        /// </param>
        /// <param name="garmentImages">
        /// Photos of the clothing items to put on the person (max 7, max size<br/>
        /// 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are<br/>
        /// supported. Multipart requests only. Provide exactly one of<br/>
        /// `garment_asset_identifiers` or `garment_images`.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generated image. Defaults to the aspect<br/>
        /// ratio of the person's photo when omitted. Supported values are<br/>
        /// `1:1`, `3:4`, `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="instruction">
        /// Free-text art direction, for example which garments to name, how to<br/>
        /// pose the person, and what background to place them in. The person's<br/>
        /// identity and each garment's exact appearance are always preserved,<br/>
        /// whatever this says. When omitted, the person keeps the pose and<br/>
        /// background from their photo.
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
        global::System.Threading.Tasks.Task<global::Ideogram.VirtualTryOnResponse> PostVirtualTryOnAsync(
            global::Ideogram.AssetIdentifier? personAssetIdentifier = default,
            byte[]? personImage = default,
            string? personImagename = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? garmentAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? garmentImages = default,
            string? aspectRatio = default,
            string? instruction = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}