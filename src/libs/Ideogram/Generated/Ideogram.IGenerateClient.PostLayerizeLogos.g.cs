#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Detect and remove reference logos from an image<br/>
        /// Detects caller-supplied reference logos in a flat design image, inpaints<br/>
        /// them out, and returns the cleaned image together with the matched<br/>
        /// bounding boxes (each tagged with the matching reference's `REF_&lt;n&gt;`).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LayerizeLogosResponse> PostLayerizeLogosAsync(

            global::Ideogram.LayerizeLogosRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect and remove reference logos from an image<br/>
        /// Detects caller-supplied reference logos in a flat design image, inpaints<br/>
        /// them out, and returns the cleaned image together with the matched<br/>
        /// bounding boxes (each tagged with the matching reference's `REF_&lt;n&gt;`).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.LayerizeLogosResponse>> PostLayerizeLogosAsResponseAsync(

            global::Ideogram.LayerizeLogosRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect and remove reference logos from an image<br/>
        /// Detects caller-supplied reference logos in a flat design image, inpaints<br/>
        /// them out, and returns the cleaned image together with the matched<br/>
        /// bounding boxes (each tagged with the matching reference's `REF_&lt;n&gt;`).
        /// </summary>
        /// <param name="designImage">
        /// The flat design image to analyze. The image should be in JPEG, PNG, or WebP format (max size 25MB).
        /// </param>
        /// <param name="designImagename">
        /// The flat design image to analyze. The image should be in JPEG, PNG, or WebP format (max size 25MB).
        /// </param>
        /// <param name="referenceImages">
        /// Reference image assets to match against logos and image elements detected in<br/>
        /// `design_image`. Each entry is assigned a `ref_id` of `REF_0`, `REF_1`, ...<br/>
        /// in the order it appears in the request (maximum 10 images). The images<br/>
        /// should be in JPEG, PNG, or WebP format.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LayerizeLogosResponse> PostLayerizeLogosAsync(
            byte[] designImage,
            string designImagename,
            global::System.Collections.Generic.IList<byte[]> referenceImages,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Detect and remove reference logos from an image<br/>
        /// Detects caller-supplied reference logos in a flat design image, inpaints<br/>
        /// them out, and returns the cleaned image together with the matched<br/>
        /// bounding boxes (each tagged with the matching reference's `REF_&lt;n&gt;`).
        /// </summary>
        /// <param name="designImage">
        /// The flat design image to analyze. The image should be in JPEG, PNG, or WebP format (max size 25MB).
        /// </param>
        /// <param name="designImagename">
        /// The flat design image to analyze. The image should be in JPEG, PNG, or WebP format (max size 25MB).
        /// </param>
        /// <param name="referenceImages">
        /// Reference image assets to match against logos and image elements detected in<br/>
        /// `design_image`. Each entry is assigned a `ref_id` of `REF_0`, `REF_1`, ...<br/>
        /// in the order it appears in the request (maximum 10 images). The images<br/>
        /// should be in JPEG, PNG, or WebP format.
        /// </param>
        /// <param name="referenceImagesFileNames">
        /// Optional file names to use for the multipart 'reference_images' file parts.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LayerizeLogosResponse> PostLayerizeLogosAsync(
            global::System.IO.Stream designImage,
            string designImagename,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> referenceImages,
            global::System.Collections.Generic.IReadOnlyList<string>? referenceImagesFileNames = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect and remove reference logos from an image<br/>
        /// Detects caller-supplied reference logos in a flat design image, inpaints<br/>
        /// them out, and returns the cleaned image together with the matched<br/>
        /// bounding boxes (each tagged with the matching reference's `REF_&lt;n&gt;`).
        /// </summary>
        /// <param name="designImage">
        /// The flat design image to analyze. The image should be in JPEG, PNG, or WebP format (max size 25MB).
        /// </param>
        /// <param name="designImagename">
        /// The flat design image to analyze. The image should be in JPEG, PNG, or WebP format (max size 25MB).
        /// </param>
        /// <param name="referenceImages">
        /// Reference image assets to match against logos and image elements detected in<br/>
        /// `design_image`. Each entry is assigned a `ref_id` of `REF_0`, `REF_1`, ...<br/>
        /// in the order it appears in the request (maximum 10 images). The images<br/>
        /// should be in JPEG, PNG, or WebP format.
        /// </param>
        /// <param name="referenceImagesFileNames">
        /// Optional file names to use for the multipart 'reference_images' file parts.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.LayerizeLogosResponse>> PostLayerizeLogosAsResponseAsync(
            global::System.IO.Stream designImage,
            string designImagename,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> referenceImages,
            global::System.Collections.Generic.IReadOnlyList<string>? referenceImagesFileNames = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}