
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A color palette specified only via its name. Cannot be used in conjunction with members.
    /// </summary>
    public sealed partial class IdeogramColorPaletteWithPresetName
    {
        /// <summary>
        /// A color palette preset value.<br/>
        /// Example: pastel
        /// </summary>
        /// <example>pastel</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.IdeogramColorPalettePresetNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.IdeogramColorPalettePresetName Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdeogramColorPaletteWithPresetName" /> class.
        /// </summary>
        /// <param name="name">
        /// A color palette preset value.<br/>
        /// Example: pastel
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdeogramColorPaletteWithPresetName(
            global::Ideogram.IdeogramColorPalettePresetName name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdeogramColorPaletteWithPresetName" /> class.
        /// </summary>
        public IdeogramColorPaletteWithPresetName()
        {
        }

    }
}