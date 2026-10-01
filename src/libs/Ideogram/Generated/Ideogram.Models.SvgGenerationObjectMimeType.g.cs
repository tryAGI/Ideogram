
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public enum SvgGenerationObjectMimeType
    {
        /// <summary>
        ///
        /// </summary>
        ImageSvgPlusxml,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgGenerationObjectMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgGenerationObjectMimeType value)
        {
            return value switch
            {
                SvgGenerationObjectMimeType.ImageSvgPlusxml => "image/svg+xml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgGenerationObjectMimeType? ToEnum(string value)
        {
            return value switch
            {
                "image/svg+xml" => SvgGenerationObjectMimeType.ImageSvgPlusxml,
                _ => null,
            };
        }
    }
}