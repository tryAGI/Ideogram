
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Product view to generate.
    /// </summary>
    public enum PackshotView
    {
        /// <summary>
        ///
        /// </summary>
        Back,
        /// <summary>
        ///
        /// </summary>
        Detail,
        /// <summary>
        ///
        /// </summary>
        Front,
        /// <summary>
        ///
        /// </summary>
        ThreeQuarter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PackshotViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackshotView value)
        {
            return value switch
            {
                PackshotView.Back => "BACK",
                PackshotView.Detail => "DETAIL",
                PackshotView.Front => "FRONT",
                PackshotView.ThreeQuarter => "THREE_QUARTER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackshotView? ToEnum(string value)
        {
            return value switch
            {
                "BACK" => PackshotView.Back,
                "DETAIL" => PackshotView.Detail,
                "FRONT" => PackshotView.Front,
                "THREE_QUARTER" => PackshotView.ThreeQuarter,
                _ => null,
            };
        }
    }
}