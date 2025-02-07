
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InternalTestingNestedObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prop_one")]
        public string? PropOne { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prop_two")]
        public string? PropTwo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTestingNestedObject" /> class.
        /// </summary>
        /// <param name="propOne"></param>
        /// <param name="propTwo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternalTestingNestedObject(
            string? propOne,
            string? propTwo)
        {
            this.PropOne = propOne;
            this.PropTwo = propTwo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTestingNestedObject" /> class.
        /// </summary>
        public InternalTestingNestedObject()
        {
        }
    }
}