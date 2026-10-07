
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// How the values of an attribute key are stored and filtered.
    /// </summary>
    public enum AttributeValueType
    {
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AttributeValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AttributeValueType value)
        {
            return value switch
            {
                AttributeValueType.Number => "NUMBER",
                AttributeValueType.Text => "TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AttributeValueType? ToEnum(string value)
        {
            return value switch
            {
                "NUMBER" => AttributeValueType.Number,
                "TEXT" => AttributeValueType.Text,
                _ => null,
            };
        }
    }
}