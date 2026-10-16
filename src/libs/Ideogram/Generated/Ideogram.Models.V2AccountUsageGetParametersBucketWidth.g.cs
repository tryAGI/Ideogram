
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Default Value: 1d
    /// </summary>
    public enum V2AccountUsageGetParametersBucketWidth
    {
        /// <summary>
        ///
        /// </summary>
        x1d,
        /// <summary>
        ///
        /// </summary>
        x1h,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2AccountUsageGetParametersBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2AccountUsageGetParametersBucketWidth value)
        {
            return value switch
            {
                V2AccountUsageGetParametersBucketWidth.x1d => "1d",
                V2AccountUsageGetParametersBucketWidth.x1h => "1h",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2AccountUsageGetParametersBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1d" => V2AccountUsageGetParametersBucketWidth.x1d,
                "1h" => V2AccountUsageGetParametersBucketWidth.x1h,
                _ => null,
            };
        }
    }
}