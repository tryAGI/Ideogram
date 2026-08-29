
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output-size tier for P-Image Ideogram.
    /// </summary>
    public enum PImageResolution
    {
        /// <summary>
        ///
        /// </summary>
        x1k,
        /// <summary>
        ///
        /// </summary>
        x2k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PImageResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PImageResolution value)
        {
            return value switch
            {
                PImageResolution.x1k => "1K",
                PImageResolution.x2k => "2K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PImageResolution? ToEnum(string value)
        {
            return value switch
            {
                "1K" => PImageResolution.x1k,
                "2K" => PImageResolution.x2k,
                _ => null,
            };
        }
    }
}