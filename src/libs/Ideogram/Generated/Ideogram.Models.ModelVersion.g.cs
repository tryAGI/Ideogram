
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The model_version to use.<br/>
    /// - V_0_3: Model 1.0<br/>
    /// - V_1_1: Model 1.1<br/>
    /// - V_1_5: Model 2.0<br/>
    /// - V_2_1: Model 2a<br/>
    /// - V_3_0: Model 3.0 March 26<br/>
    /// - V_3_1: Model 3.0 Latest<br/>
    /// Example: V_0_3
    /// </summary>
    public enum ModelVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V01,
        /// <summary>
        /// 
        /// </summary>
        V02,
        /// <summary>
        /// Model 1.0
        /// </summary>
        V03,
        /// <summary>
        /// Model 1.1
        /// </summary>
        V11,
        /// <summary>
        /// Model 2.0
        /// </summary>
        V15,
        /// <summary>
        /// Model 2a
        /// </summary>
        V21,
        /// <summary>
        /// Model 3.0 March 26
        /// </summary>
        V30,
        /// <summary>
        /// Model 3.0 Latest
        /// </summary>
        V31,
        /// <summary>
        /// 
        /// </summary>
        EXTERNALGOOGLEVEO30,
        /// <summary>
        /// 
        /// </summary>
        EXTERNALBYTEDANCESEEDANCE10PRO,
        /// <summary>
        /// 
        /// </summary>
        EXTERNALMINIMAXHAILUO02,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVersion value)
        {
            return value switch
            {
                ModelVersion.V01 => "V_0_1",
                ModelVersion.V02 => "V_0_2",
                ModelVersion.V03 => "V_0_3",
                ModelVersion.V11 => "V_1_1",
                ModelVersion.V15 => "V_1_5",
                ModelVersion.V21 => "V_2_1",
                ModelVersion.V30 => "V_3_0",
                ModelVersion.V31 => "V_3_1",
                ModelVersion.EXTERNALGOOGLEVEO30 => "EXTERNAL_GOOGLE_VEO_3_0",
                ModelVersion.EXTERNALBYTEDANCESEEDANCE10PRO => "EXTERNAL_BYTEDANCE_SEEDANCE_1_0_PRO",
                ModelVersion.EXTERNALMINIMAXHAILUO02 => "EXTERNAL_MINIMAX_HAILUO_02",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVersion? ToEnum(string value)
        {
            return value switch
            {
                "V_0_1" => ModelVersion.V01,
                "V_0_2" => ModelVersion.V02,
                "V_0_3" => ModelVersion.V03,
                "V_1_1" => ModelVersion.V11,
                "V_1_5" => ModelVersion.V15,
                "V_2_1" => ModelVersion.V21,
                "V_3_0" => ModelVersion.V30,
                "V_3_1" => ModelVersion.V31,
                "EXTERNAL_GOOGLE_VEO_3_0" => ModelVersion.EXTERNALGOOGLEVEO30,
                "EXTERNAL_BYTEDANCE_SEEDANCE_1_0_PRO" => ModelVersion.EXTERNALBYTEDANCESEEDANCE10PRO,
                "EXTERNAL_MINIMAX_HAILUO_02" => ModelVersion.EXTERNALMINIMAXHAILUO02,
                _ => null,
            };
        }
    }
}