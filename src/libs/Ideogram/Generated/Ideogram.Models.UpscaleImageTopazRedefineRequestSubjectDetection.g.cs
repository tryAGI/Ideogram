
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Where enhancements apply. Omit to let Topaz choose per image.
    /// </summary>
    public enum UpscaleImageTopazRedefineRequestSubjectDetection
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
    public static class UpscaleImageTopazRedefineRequestSubjectDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleImageTopazRedefineRequestSubjectDetection value)
        {
            return value switch
            {
                UpscaleImageTopazRedefineRequestSubjectDetection.All => "all",
                UpscaleImageTopazRedefineRequestSubjectDetection.Background => "background",
                UpscaleImageTopazRedefineRequestSubjectDetection.Foreground => "foreground",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleImageTopazRedefineRequestSubjectDetection? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpscaleImageTopazRedefineRequestSubjectDetection.All,
                "background" => UpscaleImageTopazRedefineRequestSubjectDetection.Background,
                "foreground" => UpscaleImageTopazRedefineRequestSubjectDetection.Foreground,
                _ => null,
            };
        }
    }
}