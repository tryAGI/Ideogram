
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolUsage
    {
        /// <summary>
        /// Name of the tool used<br/>
        /// Example: Turbo Image Generation V3
        /// </summary>
        /// <example>Turbo Image Generation V3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FullToolName { get; set; }

        /// <summary>
        /// Represents a price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Price Amount { get; set; }

        /// <summary>
        /// Base64 encoded API key ID<br/>
        /// Example: JRPVD7jWR1aTBYiJ0UFVOg
        /// </summary>
        /// <example>JRPVD7jWR1aTBYiJ0UFVOg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyId { get; set; }

        /// <summary>
        /// Tool type for filtering usage information<br/>
        /// Example: GENERATE
        /// </summary>
        /// <example>GENERATE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ToolTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.ToolType ToolType { get; set; }

        /// <summary>
        /// The model_version to use.<br/>
        /// - V_0_3: Model 1.0<br/>
        /// - V_1_1: Model 1.1<br/>
        /// - V_1_5: Model 2.0<br/>
        /// - V_2_1: Model 2a<br/>
        /// - V_3_0: Model 3.0 March 26<br/>
        /// - V_3_1: Model 3.0 Latest<br/>
        /// Example: V_0_3
        /// </summary>
        /// <example>V_0_3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ModelVersionJsonConverter))]
        public global::Ideogram.ModelVersion? ModelVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolUsage" /> class.
        /// </summary>
        /// <param name="fullToolName">
        /// Name of the tool used<br/>
        /// Example: Turbo Image Generation V3
        /// </param>
        /// <param name="amount">
        /// Represents a price.
        /// </param>
        /// <param name="apiKeyId">
        /// Base64 encoded API key ID<br/>
        /// Example: JRPVD7jWR1aTBYiJ0UFVOg
        /// </param>
        /// <param name="toolType">
        /// Tool type for filtering usage information<br/>
        /// Example: GENERATE
        /// </param>
        /// <param name="modelVersion">
        /// The model_version to use.<br/>
        /// - V_0_3: Model 1.0<br/>
        /// - V_1_1: Model 1.1<br/>
        /// - V_1_5: Model 2.0<br/>
        /// - V_2_1: Model 2a<br/>
        /// - V_3_0: Model 3.0 March 26<br/>
        /// - V_3_1: Model 3.0 Latest<br/>
        /// Example: V_0_3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolUsage(
            string fullToolName,
            global::Ideogram.Price amount,
            string apiKeyId,
            global::Ideogram.ToolType toolType,
            global::Ideogram.ModelVersion? modelVersion)
        {
            this.FullToolName = fullToolName ?? throw new global::System.ArgumentNullException(nameof(fullToolName));
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.ApiKeyId = apiKeyId ?? throw new global::System.ArgumentNullException(nameof(apiKeyId));
            this.ToolType = toolType;
            this.ModelVersion = modelVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolUsage" /> class.
        /// </summary>
        public ToolUsage()
        {
        }
    }
}