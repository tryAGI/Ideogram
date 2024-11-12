
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InternalTestingNestedObjectRequiredFields
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prop_one")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PropOne { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prop_two")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PropTwo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTestingNestedObjectRequiredFields" /> class.
        /// </summary>
        /// <param name="propOne"></param>
        /// <param name="propTwo"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public InternalTestingNestedObjectRequiredFields(
            string propOne,
            string propTwo)
        {
            this.PropOne = propOne ?? throw new global::System.ArgumentNullException(nameof(propOne));
            this.PropTwo = propTwo ?? throw new global::System.ArgumentNullException(nameof(propTwo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTestingNestedObjectRequiredFields" /> class.
        /// </summary>
        public InternalTestingNestedObjectRequiredFields()
        {
        }
    }
}