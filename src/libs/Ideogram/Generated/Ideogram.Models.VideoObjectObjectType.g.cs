
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Discriminator marking this entry as a generated video in the polling endpoint's mixed data array.
    /// </summary>
    public enum VideoObjectObjectType
    {
        /// <summary>
        ///
        /// </summary>
        VideoGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoObjectObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoObjectObjectType value)
        {
            return value switch
            {
                VideoObjectObjectType.VideoGeneration => "video.generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoObjectObjectType? ToEnum(string value)
        {
            return value switch
            {
                "video.generation" => VideoObjectObjectType.VideoGeneration,
                _ => null,
            };
        }
    }
}