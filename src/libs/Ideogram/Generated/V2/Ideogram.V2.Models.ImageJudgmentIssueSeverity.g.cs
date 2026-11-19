
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// `obvious`: a careful client would see it at normal size. `subtle`: visible when zooming in. `acceptable`: real, but a known limit nobody could fix by editing.
    /// </summary>
    public enum ImageJudgmentIssueSeverity
    {
        /// <summary>
        /// a careful client would see it at normal size. `subtle`: visible when zooming in. `acceptable`: real, but a known limit nobody could fix by editing.
        /// </summary>
        Acceptable,
        /// <summary>
        /// a careful client would see it at normal size. `subtle`: visible when zooming in. `acceptable`: real, but a known limit nobody could fix by editing.
        /// </summary>
        Obvious,
        /// <summary>
        /// a careful client would see it at normal size. `subtle`: visible when zooming in. `acceptable`: real, but a known limit nobody could fix by editing.
        /// </summary>
        Subtle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageJudgmentIssueSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageJudgmentIssueSeverity value)
        {
            return value switch
            {
                ImageJudgmentIssueSeverity.Acceptable => "acceptable",
                ImageJudgmentIssueSeverity.Obvious => "obvious",
                ImageJudgmentIssueSeverity.Subtle => "subtle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageJudgmentIssueSeverity? ToEnum(string value)
        {
            return value switch
            {
                "acceptable" => ImageJudgmentIssueSeverity.Acceptable,
                "obvious" => ImageJudgmentIssueSeverity.Obvious,
                "subtle" => ImageJudgmentIssueSeverity.Subtle,
                _ => null,
            };
        }
    }
}