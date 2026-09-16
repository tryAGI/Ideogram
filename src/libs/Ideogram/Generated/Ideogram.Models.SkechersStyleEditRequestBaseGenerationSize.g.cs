
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Output resolution tier; corresponds to the app's low, medium, and high settings.<br/>
    /// Default Value: 2K
    /// </summary>
    public enum SkechersStyleEditRequestBaseGenerationSize
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
    public static class SkechersStyleEditRequestBaseGenerationSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkechersStyleEditRequestBaseGenerationSize value)
        {
            return value switch
            {
                SkechersStyleEditRequestBaseGenerationSize.x1k => "1K",
                SkechersStyleEditRequestBaseGenerationSize.x2k => "2K",
                SkechersStyleEditRequestBaseGenerationSize.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkechersStyleEditRequestBaseGenerationSize? ToEnum(string value)
        {
            return value switch
            {
                "1K" => SkechersStyleEditRequestBaseGenerationSize.x1k,
                "2K" => SkechersStyleEditRequestBaseGenerationSize.x2k,
                "4K" => SkechersStyleEditRequestBaseGenerationSize.x4k,
                _ => null,
            };
        }
    }
}