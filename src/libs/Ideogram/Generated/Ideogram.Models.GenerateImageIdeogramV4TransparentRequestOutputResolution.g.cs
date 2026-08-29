
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output resolution tier for the generated images. Tiers are<br/>
    /// total-pixel budgets matching a square of the named size (for<br/>
    /// example, `8K` delivers at most 8192x8192 total pixels); wide and<br/>
    /// tall aspect ratios keep the same pixel budget, so a single<br/>
    /// dimension may exceed the named size. Defaults to 1K.<br/>
    /// Default Value: 1K
    /// </summary>
    public enum GenerateImageIdeogramV4TransparentRequestOutputResolution
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
    public static class GenerateImageIdeogramV4TransparentRequestOutputResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageIdeogramV4TransparentRequestOutputResolution value)
        {
            return value switch
            {
                GenerateImageIdeogramV4TransparentRequestOutputResolution.x1k => "1K",
                GenerateImageIdeogramV4TransparentRequestOutputResolution.x2k => "2K",
                GenerateImageIdeogramV4TransparentRequestOutputResolution.x4k => "4K",
                GenerateImageIdeogramV4TransparentRequestOutputResolution.x8k => "8K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageIdeogramV4TransparentRequestOutputResolution? ToEnum(string value)
        {
            return value switch
            {
                "1K" => GenerateImageIdeogramV4TransparentRequestOutputResolution.x1k,
                "2K" => GenerateImageIdeogramV4TransparentRequestOutputResolution.x2k,
                "4K" => GenerateImageIdeogramV4TransparentRequestOutputResolution.x4k,
                "8K" => GenerateImageIdeogramV4TransparentRequestOutputResolution.x8k,
                _ => null,
            };
        }
    }
}