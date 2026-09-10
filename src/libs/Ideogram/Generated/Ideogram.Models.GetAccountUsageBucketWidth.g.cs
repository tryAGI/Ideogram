
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Default Value: 1d
    /// </summary>
    public enum GetAccountUsageBucketWidth
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
    public static class GetAccountUsageBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAccountUsageBucketWidth value)
        {
            return value switch
            {
                GetAccountUsageBucketWidth.x1d => "1d",
                GetAccountUsageBucketWidth.x1h => "1h",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAccountUsageBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1d" => GetAccountUsageBucketWidth.x1d,
                "1h" => GetAccountUsageBucketWidth.x1h,
                _ => null,
            };
        }
    }
}