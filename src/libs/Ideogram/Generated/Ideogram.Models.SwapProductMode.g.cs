
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Replace the footwear or match its colorway to the references.
    /// </summary>
    public enum SwapProductMode
    {
        /// <summary>
        ///
        /// </summary>
        Recolor,
        /// <summary>
        ///
        /// </summary>
        Replace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwapProductModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwapProductMode value)
        {
            return value switch
            {
                SwapProductMode.Recolor => "recolor",
                SwapProductMode.Replace => "replace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwapProductMode? ToEnum(string value)
        {
            return value switch
            {
                "recolor" => SwapProductMode.Recolor,
                "replace" => SwapProductMode.Replace,
                _ => null,
            };
        }
    }
}