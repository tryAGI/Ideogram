
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Use a shoe color swatch or an uploaded logo reference as the style source.
    /// </summary>
    public enum SwanSLogoDesignRequestSourceMode
    {
        /// <summary>
        ///
        /// </summary>
        ShoeSwatch,
        /// <summary>
        ///
        /// </summary>
        UserReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwanSLogoDesignRequestSourceModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwanSLogoDesignRequestSourceMode value)
        {
            return value switch
            {
                SwanSLogoDesignRequestSourceMode.ShoeSwatch => "shoe_swatch",
                SwanSLogoDesignRequestSourceMode.UserReference => "user_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwanSLogoDesignRequestSourceMode? ToEnum(string value)
        {
            return value switch
            {
                "shoe_swatch" => SwanSLogoDesignRequestSourceMode.ShoeSwatch,
                "user_reference" => SwanSLogoDesignRequestSourceMode.UserReference,
                _ => null,
            };
        }
    }
}