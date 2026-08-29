
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public enum ResizeAdImageQuality
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResizeAdImageQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResizeAdImageQuality value)
        {
            return value switch
            {
                ResizeAdImageQuality.High => "HIGH",
                ResizeAdImageQuality.Low => "LOW",
                ResizeAdImageQuality.Medium => "MEDIUM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResizeAdImageQuality? ToEnum(string value)
        {
            return value switch
            {
                "HIGH" => ResizeAdImageQuality.High,
                "LOW" => ResizeAdImageQuality.Low,
                "MEDIUM" => ResizeAdImageQuality.Medium,
                _ => null,
            };
        }
    }
}