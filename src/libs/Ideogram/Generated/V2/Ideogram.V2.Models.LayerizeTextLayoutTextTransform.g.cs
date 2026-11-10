
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public enum LayerizeTextLayoutTextTransform
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
    public static class LayerizeTextLayoutTextTransformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeTextLayoutTextTransform value)
        {
            return value switch
            {
                LayerizeTextLayoutTextTransform.Lowercase => "lowercase",
                LayerizeTextLayoutTextTransform.None => "none",
                LayerizeTextLayoutTextTransform.Uppercase => "uppercase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeTextLayoutTextTransform? ToEnum(string value)
        {
            return value switch
            {
                "lowercase" => LayerizeTextLayoutTextTransform.Lowercase,
                "none" => LayerizeTextLayoutTextTransform.None,
                "uppercase" => LayerizeTextLayoutTextTransform.Uppercase,
                _ => null,
            };
        }
    }
}