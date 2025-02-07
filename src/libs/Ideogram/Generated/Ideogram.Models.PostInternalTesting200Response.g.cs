
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostInternalTesting200Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_content")]
        public string? ResponseContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalTesting200Response" /> class.
        /// </summary>
        /// <param name="responseContent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostInternalTesting200Response(
            string? responseContent)
        {
            this.ResponseContent = responseContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalTesting200Response" /> class.
        /// </summary>
        public PostInternalTesting200Response()
        {
        }
    }
}