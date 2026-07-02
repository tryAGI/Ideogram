
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Present when `status` is `completed`; always "url" for this shape.
    /// </summary>
    public enum GenerationResponseResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationResponseResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationResponseResponseType value)
        {
            return value switch
            {
                GenerationResponseResponseType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationResponseResponseType? ToEnum(string value)
        {
            return value switch
            {
                "url" => GenerationResponseResponseType.Url,
                _ => null,
            };
        }
    }
}