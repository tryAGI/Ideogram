
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Where enhancements apply. Omit to let Topaz choose per image.
    /// </summary>
    public enum UpscaleImageTopazTextRefineRequestSubjectDetection
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
    public static class UpscaleImageTopazTextRefineRequestSubjectDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleImageTopazTextRefineRequestSubjectDetection value)
        {
            return value switch
            {
                UpscaleImageTopazTextRefineRequestSubjectDetection.All => "all",
                UpscaleImageTopazTextRefineRequestSubjectDetection.Background => "background",
                UpscaleImageTopazTextRefineRequestSubjectDetection.Foreground => "foreground",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleImageTopazTextRefineRequestSubjectDetection? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpscaleImageTopazTextRefineRequestSubjectDetection.All,
                "background" => UpscaleImageTopazTextRefineRequestSubjectDetection.Background,
                "foreground" => UpscaleImageTopazTextRefineRequestSubjectDetection.Foreground,
                _ => null,
            };
        }
    }
}