
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolRemoveBackgroundRequest
    {
        /// <summary>
        /// The source image. JPEG, PNG, or WebP, up to 25MB. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The source image. JPEG, PNG, or WebP, up to 25MB. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// Whether to keep the result out of the public gallery. When omitted,<br/>
        /// defaults to your plan's setting, or public if your plan has none.<br/>
        /// Enterprise generations are always private.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// When false (the default), wait for and return the foreground image. When true, return as soon as the request is accepted; poll `GET /v2/generations/{generation_id}` for the result.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public bool? Async { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRemoveBackgroundRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The source image. JPEG, PNG, or WebP, up to 25MB. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image. JPEG, PNG, or WebP, up to 25MB. Multipart requests only.
        /// </param>
        /// <param name="private">
        /// Whether to keep the result out of the public gallery. When omitted,<br/>
        /// defaults to your plan's setting, or public if your plan has none.<br/>
        /// Enterprise generations are always private.
        /// </param>
        /// <param name="async">
        /// When false (the default), wait for and return the foreground image. When true, return as soon as the request is accepted; poll `GET /v2/generations/{generation_id}` for the result.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolRemoveBackgroundRequest(
            byte[] image,
            string imagename,
            bool? @private,
            bool? async)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Private = @private;
            this.Async = async;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRemoveBackgroundRequest" /> class.
        /// </summary>
        public ToolRemoveBackgroundRequest()
        {
        }

    }
}