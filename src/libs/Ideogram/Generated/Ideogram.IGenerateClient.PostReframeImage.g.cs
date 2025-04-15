#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Reframe<br/>
        /// Reframe a square image to a chosen resolution. The supported image formats include JPEG, PNG, and WebP.<br/>
        /// Image links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageResponse> PostReframeImageAsync(
            global::Ideogram.ReframeImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Reframe<br/>
        /// Reframe a square image to a chosen resolution. The supported image formats include JPEG, PNG, and WebP.<br/>
        /// Image links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="imageFile">
        /// The image being reframed (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imageFilename">
        /// The image being reframed (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="resolution">
        /// (For model_version for 2.0 only, cannot be used in conjunction with aspect_ratio) The resolution to use for image generation, represented in width x height. If not specified, defaults to using aspect_ratio.<br/>
        /// Example: RESOLUTION_1024_1024
        /// </param>
        /// <param name="model">
        /// The model used to generate an image or edit one. /generate and /remix supports all model types, however, /edit is only supported for V_2 and V_2_TURBO.<br/>
        /// Default Value: V_2<br/>
        /// Example: V_2_TURBO
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="styleType">
        /// The style type to generate with; this is only applicable for models V_2 and above and should not be specified for model versions V_1.<br/>
        /// Example: REALISTIC
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageResponse> PostReframeImageAsync(
            byte[] imageFile,
            string imageFilename,
            global::Ideogram.Resolution resolution,
            global::Ideogram.ModelEnum model,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.StyleType? styleType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}