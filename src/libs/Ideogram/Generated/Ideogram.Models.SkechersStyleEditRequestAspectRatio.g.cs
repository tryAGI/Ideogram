
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
        x184,
        /// <summary>
        ///
        /// </summary>
        x243,
        /// <summary>
        ///
        /// </summary>
        x556,
        /// <summary>
        ///
        /// </summary>
        x61,
        /// <summary>
        ///
        /// </summary>
        x969,
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
                SkechersStyleEditRequestAspectRatio.x184 => "184",
                SkechersStyleEditRequestAspectRatio.x243 => "243",
                SkechersStyleEditRequestAspectRatio.x556 => "556",
                SkechersStyleEditRequestAspectRatio.x61 => "61",
                SkechersStyleEditRequestAspectRatio.x969 => "969",
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
                "184" => SkechersStyleEditRequestAspectRatio.x184,
                "243" => SkechersStyleEditRequestAspectRatio.x243,
                "556" => SkechersStyleEditRequestAspectRatio.x556,
                "61" => SkechersStyleEditRequestAspectRatio.x61,
                "969" => SkechersStyleEditRequestAspectRatio.x969,
                _ => null,
            };
        }
    }
}