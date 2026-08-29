
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RemoveObjectRequest
    {
        /// <summary>
        /// The image to remove an object from (max size 25MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The image to remove an object from (max size 25MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// A binary mask the same size as the image; white (&gt;= 128) marks the region to remove. Only JPEG, WebP and PNG formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Mask { get; set; }

        /// <summary>
        /// A binary mask the same size as the image; white (&gt;= 128) marks the region to remove. Only JPEG, WebP and PNG formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Maskname { get; set; }

        /// <summary>
        /// Optional random seed for reproducible output. When omitted, a random seed is chosen.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Optional number of diffusion steps. Higher is slower but can improve quality; values are clamped to [1, 128]. When omitted, the model default is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_inference_steps")]
        public int? NumInferenceSteps { get; set; }

        /// <summary>
        /// Optional classifier-free guidance (CFG) scale. Higher follows the removal instruction more strongly; values are clamped to [1, 10]. When omitted, the model default is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_scale")]
        public float? GuidanceScale { get; set; }

        /// <summary>
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.RenderingSpeedJsonConverter))]
        public global::Ideogram.RenderingSpeed? RenderingSpeed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveObjectRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The image to remove an object from (max size 25MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imagename">
        /// The image to remove an object from (max size 25MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="mask">
        /// A binary mask the same size as the image; white (&gt;= 128) marks the region to remove. Only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="maskname">
        /// A binary mask the same size as the image; white (&gt;= 128) marks the region to remove. Only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="seed">
        /// Optional random seed for reproducible output. When omitted, a random seed is chosen.
        /// </param>
        /// <param name="numInferenceSteps">
        /// Optional number of diffusion steps. Higher is slower but can improve quality; values are clamped to [1, 128]. When omitted, the model default is used.
        /// </param>
        /// <param name="guidanceScale">
        /// Optional classifier-free guidance (CFG) scale. Higher follows the removal instruction more strongly; values are clamped to [1, 10]. When omitted, the model default is used.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveObjectRequest(
            byte[] image,
            string imagename,
            byte[] mask,
            string maskname,
            int? seed,
            int? numInferenceSteps,
            float? guidanceScale,
            global::Ideogram.RenderingSpeed? renderingSpeed)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Mask = mask ?? throw new global::System.ArgumentNullException(nameof(mask));
            this.Maskname = maskname ?? throw new global::System.ArgumentNullException(nameof(maskname));
            this.Seed = seed;
            this.NumInferenceSteps = numInferenceSteps;
            this.GuidanceScale = guidanceScale;
            this.RenderingSpeed = renderingSpeed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveObjectRequest" /> class.
        /// </summary>
        public RemoveObjectRequest()
        {
        }

    }
}