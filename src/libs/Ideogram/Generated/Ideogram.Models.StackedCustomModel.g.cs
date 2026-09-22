
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StackedCustomModel
    {
        /// <summary>
        /// Custom model URI of one stacked layer, in the form `model/&lt;model_name&gt;/version/&lt;version_name&gt;`.<br/>
        /// Example: model/my-base-plora/version/1
        /// </summary>
        /// <example>model/my-base-plora/version/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_model_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomModelUri { get; set; }

        /// <summary>
        /// Scale applied to this layer's pLoRA, multiplied with any weight already registered on its checkpoint(s).<br/>
        /// Default Value: 1F<br/>
        /// Example: 0.5F
        /// </summary>
        /// <example>0.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StackedCustomModel" /> class.
        /// </summary>
        /// <param name="customModelUri">
        /// Custom model URI of one stacked layer, in the form `model/&lt;model_name&gt;/version/&lt;version_name&gt;`.<br/>
        /// Example: model/my-base-plora/version/1
        /// </param>
        /// <param name="weight">
        /// Scale applied to this layer's pLoRA, multiplied with any weight already registered on its checkpoint(s).<br/>
        /// Default Value: 1F<br/>
        /// Example: 0.5F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StackedCustomModel(
            string customModelUri,
            double? weight)
        {
            this.CustomModelUri = customModelUri ?? throw new global::System.ArgumentNullException(nameof(customModelUri));
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackedCustomModel" /> class.
        /// </summary>
        public StackedCustomModel()
        {
        }

    }
}