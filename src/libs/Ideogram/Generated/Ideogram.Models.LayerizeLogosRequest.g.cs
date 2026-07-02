
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LayerizeLogosRequest
    {
        /// <summary>
        /// The flat design image to analyze. The image should be in JPEG, PNG, or WebP format (max size 10MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("design_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] DesignImage { get; set; }

        /// <summary>
        /// The flat design image to analyze. The image should be in JPEG, PNG, or WebP format (max size 10MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("design_imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DesignImagename { get; set; }

        /// <summary>
        /// Reference image assets to match against logos and image elements detected in<br/>
        /// `design_image`. Each entry is assigned a `ref_id` of `REF_0`, `REF_1`, ...<br/>
        /// in the order it appears in the request (maximum 10 images). The images<br/>
        /// should be in JPEG, PNG, or WebP format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> ReferenceImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeLogosRequest" /> class.
        /// </summary>
        /// <param name="designImage">
        /// The flat design image to analyze. The image should be in JPEG, PNG, or WebP format (max size 10MB).
        /// </param>
        /// <param name="designImagename">
        /// The flat design image to analyze. The image should be in JPEG, PNG, or WebP format (max size 10MB).
        /// </param>
        /// <param name="referenceImages">
        /// Reference image assets to match against logos and image elements detected in<br/>
        /// `design_image`. Each entry is assigned a `ref_id` of `REF_0`, `REF_1`, ...<br/>
        /// in the order it appears in the request (maximum 10 images). The images<br/>
        /// should be in JPEG, PNG, or WebP format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeLogosRequest(
            byte[] designImage,
            string designImagename,
            global::System.Collections.Generic.IList<byte[]> referenceImages)
        {
            this.DesignImage = designImage ?? throw new global::System.ArgumentNullException(nameof(designImage));
            this.DesignImagename = designImagename ?? throw new global::System.ArgumentNullException(nameof(designImagename));
            this.ReferenceImages = referenceImages ?? throw new global::System.ArgumentNullException(nameof(referenceImages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeLogosRequest" /> class.
        /// </summary>
        public LayerizeLogosRequest()
        {
        }

    }
}