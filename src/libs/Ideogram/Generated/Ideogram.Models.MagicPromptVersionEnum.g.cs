
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The magic prompt version to use when magic prompt option is set to AUTO or ON.<br/>
    /// Example: V_0
    /// </summary>
    public enum MagicPromptVersionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        V0,
        /// <summary>
        /// 
        /// </summary>
        V01,
        /// <summary>
        /// 
        /// </summary>
        V02,
        /// <summary>
        /// 
        /// </summary>
        V03,
        /// <summary>
        /// 
        /// </summary>
        V04,
        /// <summary>
        /// 
        /// </summary>
        V05,
        /// <summary>
        /// 
        /// </summary>
        V06,
        /// <summary>
        /// 
        /// </summary>
        V07,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MagicPromptVersionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MagicPromptVersionEnum value)
        {
            return value switch
            {
                MagicPromptVersionEnum.V0 => "V_0",
                MagicPromptVersionEnum.V01 => "V_0_1",
                MagicPromptVersionEnum.V02 => "V_0_2",
                MagicPromptVersionEnum.V03 => "V_0_3",
                MagicPromptVersionEnum.V04 => "V_0_4",
                MagicPromptVersionEnum.V05 => "V_0_5",
                MagicPromptVersionEnum.V06 => "V_0_6",
                MagicPromptVersionEnum.V07 => "V_0_7",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MagicPromptVersionEnum? ToEnum(string value)
        {
            return value switch
            {
                "V_0" => MagicPromptVersionEnum.V0,
                "V_0_1" => MagicPromptVersionEnum.V01,
                "V_0_2" => MagicPromptVersionEnum.V02,
                "V_0_3" => MagicPromptVersionEnum.V03,
                "V_0_4" => MagicPromptVersionEnum.V04,
                "V_0_5" => MagicPromptVersionEnum.V05,
                "V_0_6" => MagicPromptVersionEnum.V06,
                "V_0_7" => MagicPromptVersionEnum.V07,
                _ => null,
            };
        }
    }
}