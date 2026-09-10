
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Which billing surface the usage came through. `api` usage is attributed to an API key when one was used; `app` usage is attributed to the member who generated it.
    /// </summary>
    public enum AccountUsageLineItemSource
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
    public static class AccountUsageLineItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccountUsageLineItemSource value)
        {
            return value switch
            {
                AccountUsageLineItemSource.Api => "api",
                AccountUsageLineItemSource.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccountUsageLineItemSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => AccountUsageLineItemSource.Api,
                "app" => AccountUsageLineItemSource.App,
                _ => null,
            };
        }
    }
}