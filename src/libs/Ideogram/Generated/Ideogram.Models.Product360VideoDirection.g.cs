
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Direction the product rotates around its vertical axis.
    /// </summary>
    public enum Product360VideoDirection
    {
        /// <summary>
        ///
        /// </summary>
        Clockwise,
        /// <summary>
        ///
        /// </summary>
        CounterClockwise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Product360VideoDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Product360VideoDirection value)
        {
            return value switch
            {
                Product360VideoDirection.Clockwise => "clockwise",
                Product360VideoDirection.CounterClockwise => "counter-clockwise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Product360VideoDirection? ToEnum(string value)
        {
            return value switch
            {
                "clockwise" => Product360VideoDirection.Clockwise,
                "counter-clockwise" => Product360VideoDirection.CounterClockwise,
                _ => null,
            };
        }
    }
}