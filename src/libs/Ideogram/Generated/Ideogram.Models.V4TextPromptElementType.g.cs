
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Discriminator. Must be `text`.
    /// </summary>
    public enum V4TextPromptElementType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V4TextPromptElementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V4TextPromptElementType value)
        {
            return value switch
            {
                V4TextPromptElementType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V4TextPromptElementType? ToEnum(string value)
        {
            return value switch
            {
                "text" => V4TextPromptElementType.Text,
                _ => null,
            };
        }
    }
}