
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public enum SwanSLogoDesignRequestLogoStyle
    {
        /// <summary>
        ///
        /// </summary>
        x3d,
        /// <summary>
        ///
        /// </summary>
        Flat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwanSLogoDesignRequestLogoStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwanSLogoDesignRequestLogoStyle value)
        {
            return value switch
            {
                SwanSLogoDesignRequestLogoStyle.x3d => "3d",
                SwanSLogoDesignRequestLogoStyle.Flat => "flat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwanSLogoDesignRequestLogoStyle? ToEnum(string value)
        {
            return value switch
            {
                "3d" => SwanSLogoDesignRequestLogoStyle.x3d,
                "flat" => SwanSLogoDesignRequestLogoStyle.Flat,
                _ => null,
            };
        }
    }
}