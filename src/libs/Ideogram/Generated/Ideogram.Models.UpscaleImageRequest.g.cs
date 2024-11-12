
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpscaleImageRequest
    {
        /// <summary>
        /// A request to upscale a provided image with the help of an optional prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.UpscaleInitialImageRequest ImageRequest { get; set; }

        /// <summary>
        /// An image binary; only JPEG, WEBPs and PNGs are supported at this time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] ImageFile { get; set; }

        /// <summary>
        /// An image binary; only JPEG, WEBPs and PNGs are supported at this time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpscaleImageRequest" /> class.
        /// </summary>
        /// <param name="imageRequest">
        /// A request to upscale a provided image with the help of an optional prompt.
        /// </param>
        /// <param name="imageFile">
        /// An image binary; only JPEG, WEBPs and PNGs are supported at this time
        /// </param>
        /// <param name="imageFilename">
        /// An image binary; only JPEG, WEBPs and PNGs are supported at this time
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpscaleImageRequest(
            global::Ideogram.UpscaleInitialImageRequest imageRequest,
            byte[] imageFile,
            string imageFilename)
        {
            this.ImageRequest = imageRequest ?? throw new global::System.ArgumentNullException(nameof(imageRequest));
            this.ImageFile = imageFile ?? throw new global::System.ArgumentNullException(nameof(imageFile));
            this.ImageFilename = imageFilename ?? throw new global::System.ArgumentNullException(nameof(imageFilename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpscaleImageRequest" /> class.
        /// </summary>
        public UpscaleImageRequest()
        {
        }
    }
}