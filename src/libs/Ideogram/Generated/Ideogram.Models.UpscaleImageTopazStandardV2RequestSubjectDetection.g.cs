
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Where enhancements apply. Omit to let Topaz choose per image.
    /// </summary>
    public enum UpscaleImageTopazStandardV2RequestSubjectDetection
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Background,
        /// <summary>
        ///
        /// </summary>
        Foreground,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpscaleImageTopazStandardV2RequestSubjectDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleImageTopazStandardV2RequestSubjectDetection value)
        {
            return value switch
            {
                UpscaleImageTopazStandardV2RequestSubjectDetection.All => "all",
                UpscaleImageTopazStandardV2RequestSubjectDetection.Background => "background",
                UpscaleImageTopazStandardV2RequestSubjectDetection.Foreground => "foreground",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleImageTopazStandardV2RequestSubjectDetection? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpscaleImageTopazStandardV2RequestSubjectDetection.All,
                "background" => UpscaleImageTopazStandardV2RequestSubjectDetection.Background,
                "foreground" => UpscaleImageTopazStandardV2RequestSubjectDetection.Foreground,
                _ => null,
            };
        }
    }
}