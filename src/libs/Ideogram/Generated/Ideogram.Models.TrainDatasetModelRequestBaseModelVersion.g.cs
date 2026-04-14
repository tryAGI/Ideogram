
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Base model version to train on. Defaults to V_3_1.<br/>
    /// Default Value: V_3_1<br/>
    /// Example: V_3_1
    /// </summary>
    public enum TrainDatasetModelRequestBaseModelVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V31,
        /// <summary>
        /// 
        /// </summary>
        V40,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrainDatasetModelRequestBaseModelVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainDatasetModelRequestBaseModelVersion value)
        {
            return value switch
            {
                TrainDatasetModelRequestBaseModelVersion.V31 => "V_3_1",
                TrainDatasetModelRequestBaseModelVersion.V40 => "V_4_0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrainDatasetModelRequestBaseModelVersion? ToEnum(string value)
        {
            return value switch
            {
                "V_3_1" => TrainDatasetModelRequestBaseModelVersion.V31,
                "V_4_0" => TrainDatasetModelRequestBaseModelVersion.V40,
                _ => null,
            };
        }
    }
}