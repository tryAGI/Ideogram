
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Always "url" for this shape.
    /// </summary>
    public enum ImageGenerationResponseV4ImageToImageResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationResponseV4ImageToImageResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationResponseV4ImageToImageResponseType value)
        {
            return value switch
            {
                ImageGenerationResponseV4ImageToImageResponseType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationResponseV4ImageToImageResponseType? ToEnum(string value)
        {
            return value switch
            {
                "url" => ImageGenerationResponseV4ImageToImageResponseType.Url,
                _ => null,
            };
        }
    }
}