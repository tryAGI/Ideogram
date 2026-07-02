
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Discriminator for the postGenerateDesignV4 oneOf response. Always "url" for this shape.
    /// </summary>
    public enum ImageGenerationResponseV4ResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationResponseV4ResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationResponseV4ResponseType value)
        {
            return value switch
            {
                ImageGenerationResponseV4ResponseType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationResponseV4ResponseType? ToEnum(string value)
        {
            return value switch
            {
                "url" => ImageGenerationResponseV4ResponseType.Url,
                _ => null,
            };
        }
    }
}