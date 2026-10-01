
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output resolution tier. `standard` renders at 768P; `high` renders at 2K. Higher tiers cost more.<br/>
    /// Default Value: standard
    /// </summary>
    public enum LivingImageQuality
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LivingImageQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LivingImageQuality value)
        {
            return value switch
            {
                LivingImageQuality.High => "high",
                LivingImageQuality.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LivingImageQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => LivingImageQuality.High,
                "standard" => LivingImageQuality.Standard,
                _ => null,
            };
        }
    }
}