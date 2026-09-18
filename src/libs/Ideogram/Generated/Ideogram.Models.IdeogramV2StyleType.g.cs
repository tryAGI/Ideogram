
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The style type to generate with. When omitted, the model's default styling is used; pass `auto` to have a style selected automatically from the prompt.<br/>
    /// Example: realistic
    /// </summary>
    public enum IdeogramV2StyleType
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
    public static class IdeogramV2StyleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdeogramV2StyleType value)
        {
            return value switch
            {
                IdeogramV2StyleType.Anime => "anime",
                IdeogramV2StyleType.Auto => "auto",
                IdeogramV2StyleType.Design => "design",
                IdeogramV2StyleType.General => "general",
                IdeogramV2StyleType.Realistic => "realistic",
                IdeogramV2StyleType.Render3d => "render_3d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdeogramV2StyleType? ToEnum(string value)
        {
            return value switch
            {
                "anime" => IdeogramV2StyleType.Anime,
                "auto" => IdeogramV2StyleType.Auto,
                "design" => IdeogramV2StyleType.Design,
                "general" => IdeogramV2StyleType.General,
                "realistic" => IdeogramV2StyleType.Realistic,
                "render_3d" => IdeogramV2StyleType.Render3d,
                _ => null,
            };
        }
    }
}