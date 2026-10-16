
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public enum GenerationResponseDataInnerDiscriminatorMappingSvgGenerationMimeType
    {
        /// <summary>
        ///
        /// </summary>
        ImageSvgPlusxml,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationResponseDataInnerDiscriminatorMappingSvgGenerationMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationResponseDataInnerDiscriminatorMappingSvgGenerationMimeType value)
        {
            return value switch
            {
                GenerationResponseDataInnerDiscriminatorMappingSvgGenerationMimeType.ImageSvgPlusxml => "image/svg+xml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationResponseDataInnerDiscriminatorMappingSvgGenerationMimeType? ToEnum(string value)
        {
            return value switch
            {
                "image/svg+xml" => GenerationResponseDataInnerDiscriminatorMappingSvgGenerationMimeType.ImageSvgPlusxml,
                _ => null,
            };
        }
    }
}