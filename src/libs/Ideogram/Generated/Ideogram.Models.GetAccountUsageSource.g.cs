
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAccountUsageSource
    {
        /// <summary>
        ///
        /// </summary>
        Api,
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAccountUsageSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAccountUsageSource value)
        {
            return value switch
            {
                GetAccountUsageSource.Api => "api",
                GetAccountUsageSource.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAccountUsageSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => GetAccountUsageSource.Api,
                "app" => GetAccountUsageSource.App,
                _ => null,
            };
        }
    }
}