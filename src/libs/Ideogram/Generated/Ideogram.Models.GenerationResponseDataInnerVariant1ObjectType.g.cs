
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Discriminator value: image.without-prompt-or-seed
    /// </summary>
    public enum GenerationResponseDataInnerVariant1ObjectType
    {
        /// <summary>
        /// image.without-prompt-or-seed
        /// </summary>
        ImageWithoutPromptOrSeed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationResponseDataInnerVariant1ObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationResponseDataInnerVariant1ObjectType value)
        {
            return value switch
            {
                GenerationResponseDataInnerVariant1ObjectType.ImageWithoutPromptOrSeed => "image.without-prompt-or-seed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationResponseDataInnerVariant1ObjectType? ToEnum(string value)
        {
            return value switch
            {
                "image.without-prompt-or-seed" => GenerationResponseDataInnerVariant1ObjectType.ImageWithoutPromptOrSeed,
                _ => null,
            };
        }
    }
}