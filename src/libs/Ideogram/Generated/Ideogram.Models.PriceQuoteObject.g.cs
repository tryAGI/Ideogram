
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Always "price_quote".
    /// </summary>
    public enum PriceQuoteObject
    {
        /// <summary>
        ///
        /// </summary>
        PriceQuote,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PriceQuoteObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PriceQuoteObject value)
        {
            return value switch
            {
                PriceQuoteObject.PriceQuote => "price_quote",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PriceQuoteObject? ToEnum(string value)
        {
            return value switch
            {
                "price_quote" => PriceQuoteObject.PriceQuote,
                _ => null,
            };
        }
    }
}