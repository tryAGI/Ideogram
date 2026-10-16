
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Discriminator value: video.generation
    /// </summary>
    public enum GenerationResponseDataInnerVariant4ObjectType
    {
        /// <summary>
        /// video.generation
        /// </summary>
        VideoGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationResponseDataInnerVariant4ObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationResponseDataInnerVariant4ObjectType value)
        {
            return value switch
            {
                GenerationResponseDataInnerVariant4ObjectType.VideoGeneration => "video.generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationResponseDataInnerVariant4ObjectType? ToEnum(string value)
        {
            return value switch
            {
                "video.generation" => GenerationResponseDataInnerVariant4ObjectType.VideoGeneration,
                _ => null,
            };
        }
    }
}