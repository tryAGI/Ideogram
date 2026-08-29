
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The style type to generate with. When omitted, the model's default styling is used; pass AUTO to have a style selected automatically from the prompt.<br/>
    /// Example: REALISTIC
    /// </summary>
    public enum StyleTypeV2
    {
        /// <summary>
        ///
        /// </summary>
        Anime,
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Design,
        /// <summary>
        ///
        /// </summary>
        General,
        /// <summary>
        ///
        /// </summary>
        Realistic,
        /// <summary>
        ///
        /// </summary>
        Render3d,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StyleTypeV2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StyleTypeV2 value)
        {
            return value switch
            {
                StyleTypeV2.Anime => "ANIME",
                StyleTypeV2.Auto => "AUTO",
                StyleTypeV2.Design => "DESIGN",
                StyleTypeV2.General => "GENERAL",
                StyleTypeV2.Realistic => "REALISTIC",
                StyleTypeV2.Render3d => "RENDER_3D",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StyleTypeV2? ToEnum(string value)
        {
            return value switch
            {
                "ANIME" => StyleTypeV2.Anime,
                "AUTO" => StyleTypeV2.Auto,
                "DESIGN" => StyleTypeV2.Design,
                "GENERAL" => StyleTypeV2.General,
                "REALISTIC" => StyleTypeV2.Realistic,
                "RENDER_3D" => StyleTypeV2.Render3d,
                _ => null,
            };
        }
    }
}