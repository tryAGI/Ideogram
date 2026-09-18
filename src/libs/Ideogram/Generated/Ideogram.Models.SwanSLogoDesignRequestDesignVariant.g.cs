
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Required for 3D user_reference designs. Omit for other designs.
    /// </summary>
    public enum SwanSLogoDesignRequestDesignVariant
    {
        /// <summary>
        ///
        /// </summary>
        FullCoverage,
        /// <summary>
        ///
        /// </summary>
        SplitCoverage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwanSLogoDesignRequestDesignVariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwanSLogoDesignRequestDesignVariant value)
        {
            return value switch
            {
                SwanSLogoDesignRequestDesignVariant.FullCoverage => "full_coverage",
                SwanSLogoDesignRequestDesignVariant.SplitCoverage => "split_coverage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwanSLogoDesignRequestDesignVariant? ToEnum(string value)
        {
            return value switch
            {
                "full_coverage" => SwanSLogoDesignRequestDesignVariant.FullCoverage,
                "split_coverage" => SwanSLogoDesignRequestDesignVariant.SplitCoverage,
                _ => null,
            };
        }
    }
}