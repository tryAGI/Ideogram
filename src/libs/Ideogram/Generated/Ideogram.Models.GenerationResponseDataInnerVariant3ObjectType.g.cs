
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Discriminator value: image.generation
    /// </summary>
    public enum GenerationResponseDataInnerVariant3ObjectType
    {
        /// <summary>
        /// image.generation
        /// </summary>
        ImageGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationResponseDataInnerVariant3ObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationResponseDataInnerVariant3ObjectType value)
        {
            return value switch
            {
                GenerationResponseDataInnerVariant3ObjectType.ImageGeneration => "image.generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationResponseDataInnerVariant3ObjectType? ToEnum(string value)
        {
            return value switch
            {
                "image.generation" => GenerationResponseDataInnerVariant3ObjectType.ImageGeneration,
                _ => null,
            };
        }
    }
}