
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Discriminator marking this entry as a generated image in the polling endpoint's mixed data array.
    /// </summary>
    public enum ImageGenerationObjectObjectType
    {
        /// <summary>
        ///
        /// </summary>
        ImageGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationObjectObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationObjectObjectType value)
        {
            return value switch
            {
                ImageGenerationObjectObjectType.ImageGeneration => "image.generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationObjectObjectType? ToEnum(string value)
        {
            return value switch
            {
                "image.generation" => ImageGenerationObjectObjectType.ImageGeneration,
                _ => null,
            };
        }
    }
}