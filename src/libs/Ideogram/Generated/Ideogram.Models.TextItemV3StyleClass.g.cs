
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Typographic classification of the text.<br/>
    /// Example: body
    /// </summary>
    public enum TextItemV3StyleClass
    {
        /// <summary>
        /// 
        /// </summary>
        H1,
        /// <summary>
        /// 
        /// </summary>
        H2,
        /// <summary>
        /// 
        /// </summary>
        Body,
        /// <summary>
        /// 
        /// </summary>
        Small,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextItemV3StyleClassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextItemV3StyleClass value)
        {
            return value switch
            {
                TextItemV3StyleClass.H1 => "h1",
                TextItemV3StyleClass.H2 => "h2",
                TextItemV3StyleClass.Body => "body",
                TextItemV3StyleClass.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextItemV3StyleClass? ToEnum(string value)
        {
            return value switch
            {
                "h1" => TextItemV3StyleClass.H1,
                "h2" => TextItemV3StyleClass.H2,
                "body" => TextItemV3StyleClass.Body,
                "small" => TextItemV3StyleClass.Small,
                _ => null,
            };
        }
    }
}