
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostGenerateDesignV4200ResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.PostGenerateDesignV4200ResponseDiscriminatorResponseTypeJsonConverter))]
        public global::Ideogram.PostGenerateDesignV4200ResponseDiscriminatorResponseType? ResponseType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostGenerateDesignV4200ResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="responseType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostGenerateDesignV4200ResponseDiscriminator(
            global::Ideogram.PostGenerateDesignV4200ResponseDiscriminatorResponseType? responseType)
        {
            this.ResponseType = responseType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostGenerateDesignV4200ResponseDiscriminator" /> class.
        /// </summary>
        public PostGenerateDesignV4200ResponseDiscriminator()
        {
        }

    }
}