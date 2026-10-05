
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Output ratio. When omitted, derive the nearest supported ratio from the base.
    /// </summary>
    public enum SkechersStyleEditRequestAspectRatio
    {
        /// <summary>
        ///
        /// </summary>
        x16_9,
        /// <summary>
        ///
        /// </summary>
        x1_1,
        /// <summary>
        ///
        /// </summary>
        x3_4,
        /// <summary>
        ///
        /// </summary>
        x4_3,
        /// <summary>
        ///
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SkechersStyleEditRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkechersStyleEditRequestAspectRatio value)
        {
            return value switch
            {
                SkechersStyleEditRequestAspectRatio.x16_9 => "16:9",
                SkechersStyleEditRequestAspectRatio.x1_1 => "1:1",
                SkechersStyleEditRequestAspectRatio.x3_4 => "3:4",
                SkechersStyleEditRequestAspectRatio.x4_3 => "4:3",
                SkechersStyleEditRequestAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkechersStyleEditRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => SkechersStyleEditRequestAspectRatio.x16_9,
                "1:1" => SkechersStyleEditRequestAspectRatio.x1_1,
                "3:4" => SkechersStyleEditRequestAspectRatio.x3_4,
                "4:3" => SkechersStyleEditRequestAspectRatio.x4_3,
                "9:16" => SkechersStyleEditRequestAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}