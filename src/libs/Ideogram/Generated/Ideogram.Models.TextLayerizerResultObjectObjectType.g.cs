
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public enum TextLayerizerResultObjectObjectType
    {
        /// <summary>
        ///
        /// </summary>
        LayerizedDesignGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextLayerizerResultObjectObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextLayerizerResultObjectObjectType value)
        {
            return value switch
            {
                TextLayerizerResultObjectObjectType.LayerizedDesignGeneration => "layerized_design.generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextLayerizerResultObjectObjectType? ToEnum(string value)
        {
            return value switch
            {
                "layerized_design.generation" => TextLayerizerResultObjectObjectType.LayerizedDesignGeneration,
                _ => null,
            };
        }
    }
}