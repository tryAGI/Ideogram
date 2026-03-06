
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Time segment granularity for usage breakdown<br/>
    /// Example: DAY
    /// </summary>
    public enum SegmentBy
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Hour,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SegmentByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SegmentBy value)
        {
            return value switch
            {
                SegmentBy.Day => "DAY",
                SegmentBy.Hour => "HOUR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SegmentBy? ToEnum(string value)
        {
            return value switch
            {
                "DAY" => SegmentBy.Day,
                "HOUR" => SegmentBy.Hour,
                _ => null,
            };
        }
    }
}