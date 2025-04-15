#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Edit<br/>
        /// Edit a given image synchronously using the provided mask. The mask indicates which part of the image<br/>
        /// should be edited, while the prompt and chosen style type can further guide the edit.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageResponse> PostEditImageAsync(
            global::Ideogram.EditImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Edit<br/>
        /// Edit a given image synchronously using the provided mask. The mask indicates which part of the image<br/>
        /// should be edited, while the prompt and chosen style type can further guide the edit.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="imageFile">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imageFilename">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="mask">
        /// A black and white image of the same size as the image being edited (max size 10MB). Black regions in the mask should match up with the regions of the image that you would like to edit; only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="maskname">
        /// A black and white image of the same size as the image being edited (max size 10MB). Black regions in the mask should match up with the regions of the image that you would like to edit; only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="prompt">
        /// The prompt used to describe the edited result.<br/>
        /// Example: A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there is an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.
        /// </param>
        /// <param name="model">
        /// The model used to generate an image or edit one. /generate and /remix supports all model types, however, /edit is only supported for V_2 and V_2_TURBO.<br/>
        /// Default Value: V_2<br/>
        /// Example: V_2_TURBO
        /// </param>
        /// <param name="magicPromptOption">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageResponse> PostEditImageAsync(
            byte[] imageFile,
            string imageFilename,
            byte[] mask,
            string maskname,
            string prompt,
            global::Ideogram.ModelEnum model,
            global::Ideogram.MagicPromptOption? magicPromptOption = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.StyleType? styleType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}