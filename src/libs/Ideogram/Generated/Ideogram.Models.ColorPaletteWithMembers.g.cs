
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A color palette represented only via its members. Cannot be used in conjunction with preset name.
    /// </summary>
    public sealed partial class ColorPaletteWithMembers
    {
        /// <summary>
        /// A list of ColorPaletteMembers that define the color palette. Each color palette member<br/>
        /// consists of a required color hex and an optional weight between 0.05 and 1.0 (inclusive).<br/>
        /// It is recommended that these weights descend from highest to lowest for the color hexes provided.<br/>
        /// Example: [, , , , ]
        /// </summary>
        /// <example>[, , , , ]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.ColorPaletteMember> Members { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorPaletteWithMembers" /> class.
        /// </summary>
        /// <param name="members">
        /// A list of ColorPaletteMembers that define the color palette. Each color palette member<br/>
        /// consists of a required color hex and an optional weight between 0.05 and 1.0 (inclusive).<br/>
        /// It is recommended that these weights descend from highest to lowest for the color hexes provided.<br/>
        /// Example: [, , , , ]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColorPaletteWithMembers(
            global::System.Collections.Generic.IList<global::Ideogram.ColorPaletteMember> members)
        {
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorPaletteWithMembers" /> class.
        /// </summary>
        public ColorPaletteWithMembers()
        {
        }
    }
}