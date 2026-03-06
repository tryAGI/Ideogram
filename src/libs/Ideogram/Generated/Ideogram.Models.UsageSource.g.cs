
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Filter usage by source - API for programmatic API usage, APP for web application usage<br/>
    /// Default Value: API
    /// </summary>
    public enum UsageSource
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
    public static class UsageSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageSource value)
        {
            return value switch
            {
                UsageSource.Api => "API",
                UsageSource.App => "APP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageSource? ToEnum(string value)
        {
            return value switch
            {
                "API" => UsageSource.Api,
                "APP" => UsageSource.App,
                _ => null,
            };
        }
    }
}