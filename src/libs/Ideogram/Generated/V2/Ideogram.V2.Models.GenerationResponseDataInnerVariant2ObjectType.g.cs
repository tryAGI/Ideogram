
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// Discriminator value: svg.generation
    /// </summary>
    public enum GenerationResponseDataInnerVariant2ObjectType
    {
        /// <summary>
        /// svg.generation
        /// </summary>
        SvgGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationResponseDataInnerVariant2ObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationResponseDataInnerVariant2ObjectType value)
        {
            return value switch
            {
                GenerationResponseDataInnerVariant2ObjectType.SvgGeneration => "svg.generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationResponseDataInnerVariant2ObjectType? ToEnum(string value)
        {
            return value switch
            {
                "svg.generation" => GenerationResponseDataInnerVariant2ObjectType.SvgGeneration,
                _ => null,
            };
        }
    }
}