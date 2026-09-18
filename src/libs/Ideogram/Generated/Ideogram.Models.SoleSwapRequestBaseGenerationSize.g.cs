
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Output resolution tier. Defaults to 2k.<br/>
    /// Default Value: 2k
    /// </summary>
    public enum SoleSwapRequestBaseGenerationSize
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SoleSwapRequestBaseGenerationSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SoleSwapRequestBaseGenerationSize value)
        {
            return value switch
            {
                SoleSwapRequestBaseGenerationSize.x1k => "1k",
                SoleSwapRequestBaseGenerationSize.x2k => "2k",
                SoleSwapRequestBaseGenerationSize.x4k => "4k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SoleSwapRequestBaseGenerationSize? ToEnum(string value)
        {
            return value switch
            {
                "1k" => SoleSwapRequestBaseGenerationSize.x1k,
                "2k" => SoleSwapRequestBaseGenerationSize.x2k,
                "4k" => SoleSwapRequestBaseGenerationSize.x4k,
                _ => null,
            };
        }
    }
}