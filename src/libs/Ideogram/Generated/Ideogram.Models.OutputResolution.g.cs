
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output resolution tier for the generated image. Tiers are<br/>
    /// total-pixel budgets matching a square of the named size (for example,<br/>
    /// `8K` delivers at most 8192x8192 total pixels); wide and tall aspect<br/>
    /// ratios keep the same pixel budget, so a single dimension may exceed<br/>
    /// the named size. Defaults to 1K.<br/>
    /// Default Value: 1K
    /// </summary>
    public enum OutputResolution
    {
        /// <summary>
        ///
        /// </summary>
        x1k,
        /// <summary>
        ///
        /// </summary>
        x2k,
        /// <summary>
        ///
        /// </summary>
        x4k,
        /// <summary>
        ///
        /// </summary>
        x8k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputResolution value)
        {
            return value switch
            {
                OutputResolution.x1k => "1K",
                OutputResolution.x2k => "2K",
                OutputResolution.x4k => "4K",
                OutputResolution.x8k => "8K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputResolution? ToEnum(string value)
        {
            return value switch
            {
                "1K" => OutputResolution.x1k,
                "2K" => OutputResolution.x2k,
                "4K" => OutputResolution.x4k,
                "8K" => OutputResolution.x8k,
                _ => null,
            };
        }
    }
}