
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public enum SvgGenerationObjectObjectType
    {
        /// <summary>
        ///
        /// </summary>
        SvgGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgGenerationObjectObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgGenerationObjectObjectType value)
        {
            return value switch
            {
                SvgGenerationObjectObjectType.SvgGeneration => "svg.generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgGenerationObjectObjectType? ToEnum(string value)
        {
            return value switch
            {
                "svg.generation" => SvgGenerationObjectObjectType.SvgGeneration,
                _ => null,
            };
        }
    }
}