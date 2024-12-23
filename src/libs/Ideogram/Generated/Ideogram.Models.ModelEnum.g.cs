
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
        V1,
        /// <summary>
        /// 
        /// </summary>
        V1TURBO,
        /// <summary>
        /// 
        /// </summary>
        V2,
        /// <summary>
        /// 
        /// </summary>
        V2TURBO,
        /// <summary>
        /// 
        /// </summary>
        V2a,
        /// <summary>
        /// 
        /// </summary>
        V2aTURBO,
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
                ModelEnum.V1 => "V_1",
                ModelEnum.V1TURBO => "V_1_TURBO",
                ModelEnum.V2 => "V_2",
                ModelEnum.V2TURBO => "V_2_TURBO",
                ModelEnum.V2a => "V_2a",
                ModelEnum.V2aTURBO => "V_2a_TURBO",
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
                "V_1" => ModelEnum.V1,
                "V_1_TURBO" => ModelEnum.V1TURBO,
                "V_2" => ModelEnum.V2,
                "V_2_TURBO" => ModelEnum.V2TURBO,
                "V_2a" => ModelEnum.V2a,
                "V_2a_TURBO" => ModelEnum.V2aTURBO,
                _ => null,
            };
        }
    }
}