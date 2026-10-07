
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"creation_time":"2000-01-23T04:56:07\u002B00:00","value_type":null,"attribute_key":"attribute_key","value":"value"}
    /// </summary>
    public sealed partial class AttributeInfo
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AttributeKey { get; set; }

        /// <summary>
        /// The stored value. NUMBER values are returned in canonical form.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// How the values of an attribute key are stored and filtered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AttributeValueTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AttributeValueType ValueType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time")]
        public global::System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeInfo" /> class.
        /// </summary>
        /// <param name="attributeKey"></param>
        /// <param name="value">
        /// The stored value. NUMBER values are returned in canonical form.
        /// </param>
        /// <param name="valueType">
        /// How the values of an attribute key are stored and filtered.
        /// </param>
        /// <param name="creationTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttributeInfo(
            string attributeKey,
            string value,
            global::Ideogram.AttributeValueType valueType,
            global::System.DateTime? creationTime)
        {
            this.AttributeKey = attributeKey ?? throw new global::System.ArgumentNullException(nameof(attributeKey));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.ValueType = valueType;
            this.CreationTime = creationTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeInfo" /> class.
        /// </summary>
        public AttributeInfo()
        {
        }

    }
}