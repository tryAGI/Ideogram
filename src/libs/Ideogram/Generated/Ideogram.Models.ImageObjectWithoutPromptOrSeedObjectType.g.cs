
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Discriminator marking this entry as an image result without prompt or seed.
    /// </summary>
    public enum ImageObjectWithoutPromptOrSeedObjectType
    {
        /// <summary>
        ///
        /// </summary>
        ImageWithoutPromptOrSeed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageObjectWithoutPromptOrSeedObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageObjectWithoutPromptOrSeedObjectType value)
        {
            return value switch
            {
                ImageObjectWithoutPromptOrSeedObjectType.ImageWithoutPromptOrSeed => "image.without-prompt-or-seed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageObjectWithoutPromptOrSeedObjectType? ToEnum(string value)
        {
            return value switch
            {
                "image.without-prompt-or-seed" => ImageObjectWithoutPromptOrSeedObjectType.ImageWithoutPromptOrSeed,
                _ => null,
            };
        }
    }
}