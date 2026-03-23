
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The model used to generate an image or edit one. /generate and /remix supports all model types, however, /edit is only supported for V_2 and V_2_TURBO.<br/>
    /// Default Value: V_2<br/>
    /// Example: V_2_TURBO
    /// </summary>
    public enum ModelEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        V1,
        /// <summary>
        /// 
        /// </summary>
        V1Turbo,
        /// <summary>
        /// 
        /// </summary>
        V2,
        /// <summary>
        /// 
        /// </summary>
        V2a,
        /// <summary>
        /// 
        /// </summary>
        V2aTurbo,
        /// <summary>
        /// 
        /// </summary>
        V2Turbo,
        /// <summary>
        /// 
        /// </summary>
        V3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelEnum value)
        {
            return value switch
            {
                ModelEnum.Auto => "AUTO",
                ModelEnum.V1 => "V_1",
                ModelEnum.V1Turbo => "V_1_TURBO",
                ModelEnum.V2 => "V_2",
                ModelEnum.V2a => "V_2A",
                ModelEnum.V2aTurbo => "V_2A_TURBO",
                ModelEnum.V2Turbo => "V_2_TURBO",
                ModelEnum.V3 => "V_3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelEnum? ToEnum(string value)
        {
            return value switch
            {
                "AUTO" => ModelEnum.Auto,
                "V_1" => ModelEnum.V1,
                "V_1_TURBO" => ModelEnum.V1Turbo,
                "V_2" => ModelEnum.V2,
                "V_2A" => ModelEnum.V2a,
                "V_2A_TURBO" => ModelEnum.V2aTurbo,
                "V_2_TURBO" => ModelEnum.V2Turbo,
                "V_3" => ModelEnum.V3,
                _ => null,
            };
        }
    }
}