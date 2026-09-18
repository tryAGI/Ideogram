
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A color palette preset value.<br/>
    /// Example: pastel
    /// </summary>
    public enum IdeogramColorPalettePresetName
    {
        /// <summary>
        ///
        /// </summary>
        Ember,
        /// <summary>
        ///
        /// </summary>
        Fresh,
        /// <summary>
        ///
        /// </summary>
        Jungle,
        /// <summary>
        ///
        /// </summary>
        Magic,
        /// <summary>
        ///
        /// </summary>
        Melon,
        /// <summary>
        ///
        /// </summary>
        Mosaic,
        /// <summary>
        ///
        /// </summary>
        Pastel,
        /// <summary>
        ///
        /// </summary>
        Ultramarine,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IdeogramColorPalettePresetNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdeogramColorPalettePresetName value)
        {
            return value switch
            {
                IdeogramColorPalettePresetName.Ember => "ember",
                IdeogramColorPalettePresetName.Fresh => "fresh",
                IdeogramColorPalettePresetName.Jungle => "jungle",
                IdeogramColorPalettePresetName.Magic => "magic",
                IdeogramColorPalettePresetName.Melon => "melon",
                IdeogramColorPalettePresetName.Mosaic => "mosaic",
                IdeogramColorPalettePresetName.Pastel => "pastel",
                IdeogramColorPalettePresetName.Ultramarine => "ultramarine",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdeogramColorPalettePresetName? ToEnum(string value)
        {
            return value switch
            {
                "ember" => IdeogramColorPalettePresetName.Ember,
                "fresh" => IdeogramColorPalettePresetName.Fresh,
                "jungle" => IdeogramColorPalettePresetName.Jungle,
                "magic" => IdeogramColorPalettePresetName.Magic,
                "melon" => IdeogramColorPalettePresetName.Melon,
                "mosaic" => IdeogramColorPalettePresetName.Mosaic,
                "pastel" => IdeogramColorPalettePresetName.Pastel,
                "ultramarine" => IdeogramColorPalettePresetName.Ultramarine,
                _ => null,
            };
        }
    }
}