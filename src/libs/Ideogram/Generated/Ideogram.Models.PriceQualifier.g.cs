
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Whether a quoted price is what the request would bill (`exact`) or a<br/>
    /// computed estimate for a product priced from provider cost after<br/>
    /// inference (`estimate`).
    /// </summary>
    public enum PriceQualifier
    {
        /// <summary>
        ///
        /// </summary>
        Estimate,
        /// <summary>
        ///
        /// </summary>
        Exact,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PriceQualifierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PriceQualifier value)
        {
            return value switch
            {
                PriceQualifier.Estimate => "estimate",
                PriceQualifier.Exact => "exact",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PriceQualifier? ToEnum(string value)
        {
            return value switch
            {
                "estimate" => PriceQualifier.Estimate,
                "exact" => PriceQualifier.Exact,
                _ => null,
            };
        }
    }
}