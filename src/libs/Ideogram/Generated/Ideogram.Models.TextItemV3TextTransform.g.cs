
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Case folding applied at render time. V4 vector-text only.
    /// </summary>
    public enum TextItemV3TextTransform
    {
        /// <summary>
        /// 
        /// </summary>
        Lowercase,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Uppercase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextItemV3TextTransformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextItemV3TextTransform value)
        {
            return value switch
            {
                TextItemV3TextTransform.Lowercase => "lowercase",
                TextItemV3TextTransform.None => "none",
                TextItemV3TextTransform.Uppercase => "uppercase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextItemV3TextTransform? ToEnum(string value)
        {
            return value switch
            {
                "lowercase" => TextItemV3TextTransform.Lowercase,
                "none" => TextItemV3TextTransform.None,
                "uppercase" => TextItemV3TextTransform.Uppercase,
                _ => null,
            };
        }
    }
}