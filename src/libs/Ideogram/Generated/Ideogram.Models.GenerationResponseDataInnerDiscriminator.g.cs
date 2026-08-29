
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerationResponseDataInnerDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GenerationResponseDataInnerDiscriminatorObjectTypeJsonConverter))]
        public global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType? ObjectType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponseDataInnerDiscriminator" /> class.
        /// </summary>
        /// <param name="objectType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationResponseDataInnerDiscriminator(
            global::Ideogram.GenerationResponseDataInnerDiscriminatorObjectType? objectType)
        {
            this.ObjectType = objectType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponseDataInnerDiscriminator" /> class.
        /// </summary>
        public GenerationResponseDataInnerDiscriminator()
        {
        }

    }
}