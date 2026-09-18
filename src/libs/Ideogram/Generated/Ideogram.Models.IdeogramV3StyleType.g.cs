
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The style type to generate with.<br/>
    /// Default Value: general<br/>
    /// Example: general
    /// </summary>
    public enum IdeogramV3StyleType
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        Design,
        /// <summary>
        ///
        /// </summary>
        Fiction,
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
        Stylized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IdeogramV3StyleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdeogramV3StyleType value)
        {
            return value switch
            {
                IdeogramV3StyleType.Auto => "auto",
                IdeogramV3StyleType.Custom => "custom",
                IdeogramV3StyleType.Design => "design",
                IdeogramV3StyleType.Fiction => "fiction",
                IdeogramV3StyleType.General => "general",
                IdeogramV3StyleType.Realistic => "realistic",
                IdeogramV3StyleType.Stylized => "stylized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdeogramV3StyleType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => IdeogramV3StyleType.Auto,
                "custom" => IdeogramV3StyleType.Custom,
                "design" => IdeogramV3StyleType.Design,
                "fiction" => IdeogramV3StyleType.Fiction,
                "general" => IdeogramV3StyleType.General,
                "realistic" => IdeogramV3StyleType.Realistic,
                "stylized" => IdeogramV3StyleType.Stylized,
                _ => null,
            };
        }
    }
}