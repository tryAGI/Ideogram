
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The model version to use for describing images. Defaults to V_3.<br/>
    /// Default Value: V_3
    /// </summary>
    public enum DescribeModelVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V2,
        /// <summary>
        /// 
        /// </summary>
        V3,
        /// <summary>
        /// 
        /// </summary>
        CUSTOM,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DescribeModelVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DescribeModelVersion value)
        {
            return value switch
            {
                DescribeModelVersion.V2 => "V_2",
                DescribeModelVersion.V3 => "V_3",
                DescribeModelVersion.CUSTOM => "CUSTOM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DescribeModelVersion? ToEnum(string value)
        {
            return value switch
            {
                "V_2" => DescribeModelVersion.V2,
                "V_3" => DescribeModelVersion.V3,
                "CUSTOM" => DescribeModelVersion.CUSTOM,
                _ => null,
            };
        }
    }
}