
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
        /// Example: [{"ColorPaletteMember":{"color_hex":"#b470b3","color_weight":0.49}}, {"ColorPaletteMember":{"color_hex":"#7a79e3","color_weight":0.16}}, {"ColorPaletteMember":{"color_hex":"#a26563","color_weight":0.1}}, {"ColorPaletteMember":{"color_hex":"#5c7d76","color_weight":0.07}}, {"ColorPaletteMember":{"color_hex":"#642a9c","color_weight":0.05}}]
        /// </summary>
        /// <example>[{"ColorPaletteMember":{"color_hex":"#b470b3","color_weight":0.49}}, {"ColorPaletteMember":{"color_hex":"#7a79e3","color_weight":0.16}}, {"ColorPaletteMember":{"color_hex":"#a26563","color_weight":0.1}}, {"ColorPaletteMember":{"color_hex":"#5c7d76","color_weight":0.07}}, {"ColorPaletteMember":{"color_hex":"#642a9c","color_weight":0.05}}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Ideogram.ColorPaletteMember> Members { get; set; } = default!;

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
        /// Example: [{"ColorPaletteMember":{"color_hex":"#b470b3","color_weight":0.49}}, {"ColorPaletteMember":{"color_hex":"#7a79e3","color_weight":0.16}}, {"ColorPaletteMember":{"color_hex":"#a26563","color_weight":0.1}}, {"ColorPaletteMember":{"color_hex":"#5c7d76","color_weight":0.07}}, {"ColorPaletteMember":{"color_hex":"#642a9c","color_weight":0.05}}]
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