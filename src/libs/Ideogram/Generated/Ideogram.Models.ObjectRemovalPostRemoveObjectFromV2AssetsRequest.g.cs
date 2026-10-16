
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ObjectRemovalPostRemoveObjectFromV2AssetsRequest
    {
        /// <summary>
        /// The source image to remove an object from. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The source image to remove an object from. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// A black-and-white mask the same size as the image; white (&gt;= 128) marks the region to remove. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Mask { get; set; }

        /// <summary>
        /// A black-and-white mask the same size as the image; white (&gt;= 128) marks the region to remove. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Maskname { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectRemovalPostRemoveObjectFromV2AssetsRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The source image to remove an object from. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image to remove an object from. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="mask">
        /// A black-and-white mask the same size as the image; white (&gt;= 128) marks the region to remove. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="maskname">
        /// A black-and-white mask the same size as the image; white (&gt;= 128) marks the region to remove. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObjectRemovalPostRemoveObjectFromV2AssetsRequest(
            byte[] image,
            string imagename,
            byte[] mask,
            string maskname,
            int? seed)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Mask = mask ?? throw new global::System.ArgumentNullException(nameof(mask));
            this.Maskname = maskname ?? throw new global::System.ArgumentNullException(nameof(maskname));
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectRemovalPostRemoveObjectFromV2AssetsRequest" /> class.
        /// </summary>
        public ObjectRemovalPostRemoveObjectFromV2AssetsRequest()
        {
        }

    }
}