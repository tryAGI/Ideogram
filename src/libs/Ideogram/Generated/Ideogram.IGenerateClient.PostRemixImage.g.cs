#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Remix (legacy)<br/>
        /// Remix provided images synchronously based on a given prompt and optional parameters.<br/>
        /// Input images are cropped to the chosen aspect ratio before being remixed.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageResponse> PostRemixImageAsync(

            global::Ideogram.RemixImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix (legacy)<br/>
        /// Remix provided images synchronously based on a given prompt and optional parameters.<br/>
        /// Input images are cropped to the chosen aspect ratio before being remixed.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="imageRequest">
        /// A request to generate a new image using a provided image and a prompt.<br/>
        /// Example: {"aspect_ratio":"ASPECT_10_16","magic_prompt_option":"ON","model":"V_2","prompt":"A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there is an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.","image_weight":50}
        /// </param>
        /// <param name="imageFile">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imageFilename">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageResponse> PostRemixImageAsync(
            global::Ideogram.InitialImageRequest imageRequest,
            byte[] imageFile,
            string imageFilename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}