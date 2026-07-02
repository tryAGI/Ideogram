
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
        V4Qwen3527b,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bExperimental,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bExperimentalAltcapBal10k,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bExperimentalAltcapBal9k,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bExperimentalNonnas2p5k,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bExperimentalNonnas5k,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bExperimentalQ362p5k,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bExperimentalSlot01,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bExperimentalSlot02,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bExperimentalSlot03,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bExperimentalSlot04,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bExperimentalSlot05,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bExperimentalSlot06,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bExperimentalSlot07,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bExperimentalSlot08,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bExperimentalSlot09,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bExperimentalSlot10,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bFullFinetune,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bFullFinetuneLora,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bPrefused,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bSglangExperimentalQ362p5k,
        /// <summary>
        /// 
        /// </summary>
        V4Qwen3527bSglangExperimentalQ362p5kTp2,
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
        /// <summary>
        /// 
        /// </summary>
        V08,
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
                MagicPromptVersionEnum.V4Qwen3527b => "V4_QWEN_3_5_27B",
                MagicPromptVersionEnum.V4Qwen3527bExperimental => "V4_QWEN_3_5_27B_EXPERIMENTAL",
                MagicPromptVersionEnum.V4Qwen3527bExperimentalAltcapBal10k => "V4_QWEN_3_5_27B_EXPERIMENTAL_ALTCAP_BAL_10K",
                MagicPromptVersionEnum.V4Qwen3527bExperimentalAltcapBal9k => "V4_QWEN_3_5_27B_EXPERIMENTAL_ALTCAP_BAL_9K",
                MagicPromptVersionEnum.V4Qwen3527bExperimentalNonnas2p5k => "V4_QWEN_3_5_27B_EXPERIMENTAL_NONNAS_2P5K",
                MagicPromptVersionEnum.V4Qwen3527bExperimentalNonnas5k => "V4_QWEN_3_5_27B_EXPERIMENTAL_NONNAS_5K",
                MagicPromptVersionEnum.V4Qwen3527bExperimentalQ362p5k => "V4_QWEN_3_5_27B_EXPERIMENTAL_Q36_2P5K",
                MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot01 => "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_01",
                MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot02 => "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_02",
                MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot03 => "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_03",
                MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot04 => "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_04",
                MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot05 => "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_05",
                MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot06 => "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_06",
                MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot07 => "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_07",
                MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot08 => "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_08",
                MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot09 => "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_09",
                MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot10 => "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_10",
                MagicPromptVersionEnum.V4Qwen3527bFullFinetune => "V4_QWEN_3_5_27B_FULL_FINETUNE",
                MagicPromptVersionEnum.V4Qwen3527bFullFinetuneLora => "V4_QWEN_3_5_27B_FULL_FINETUNE_LORA",
                MagicPromptVersionEnum.V4Qwen3527bPrefused => "V4_QWEN_3_5_27B_PREFUSED",
                MagicPromptVersionEnum.V4Qwen3527bSglangExperimentalQ362p5k => "V4_QWEN_3_5_27B_SGLANG_EXPERIMENTAL_Q36_2P5K",
                MagicPromptVersionEnum.V4Qwen3527bSglangExperimentalQ362p5kTp2 => "V4_QWEN_3_5_27B_SGLANG_EXPERIMENTAL_Q36_2P5K_TP2",
                MagicPromptVersionEnum.V0 => "V_0",
                MagicPromptVersionEnum.V01 => "V_0_1",
                MagicPromptVersionEnum.V02 => "V_0_2",
                MagicPromptVersionEnum.V03 => "V_0_3",
                MagicPromptVersionEnum.V04 => "V_0_4",
                MagicPromptVersionEnum.V05 => "V_0_5",
                MagicPromptVersionEnum.V06 => "V_0_6",
                MagicPromptVersionEnum.V07 => "V_0_7",
                MagicPromptVersionEnum.V08 => "V_0_8",
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
                "V4_QWEN_3_5_27B" => MagicPromptVersionEnum.V4Qwen3527b,
                "V4_QWEN_3_5_27B_EXPERIMENTAL" => MagicPromptVersionEnum.V4Qwen3527bExperimental,
                "V4_QWEN_3_5_27B_EXPERIMENTAL_ALTCAP_BAL_10K" => MagicPromptVersionEnum.V4Qwen3527bExperimentalAltcapBal10k,
                "V4_QWEN_3_5_27B_EXPERIMENTAL_ALTCAP_BAL_9K" => MagicPromptVersionEnum.V4Qwen3527bExperimentalAltcapBal9k,
                "V4_QWEN_3_5_27B_EXPERIMENTAL_NONNAS_2P5K" => MagicPromptVersionEnum.V4Qwen3527bExperimentalNonnas2p5k,
                "V4_QWEN_3_5_27B_EXPERIMENTAL_NONNAS_5K" => MagicPromptVersionEnum.V4Qwen3527bExperimentalNonnas5k,
                "V4_QWEN_3_5_27B_EXPERIMENTAL_Q36_2P5K" => MagicPromptVersionEnum.V4Qwen3527bExperimentalQ362p5k,
                "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_01" => MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot01,
                "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_02" => MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot02,
                "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_03" => MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot03,
                "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_04" => MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot04,
                "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_05" => MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot05,
                "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_06" => MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot06,
                "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_07" => MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot07,
                "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_08" => MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot08,
                "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_09" => MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot09,
                "V4_QWEN_3_5_27B_EXPERIMENTAL_SLOT_10" => MagicPromptVersionEnum.V4Qwen3527bExperimentalSlot10,
                "V4_QWEN_3_5_27B_FULL_FINETUNE" => MagicPromptVersionEnum.V4Qwen3527bFullFinetune,
                "V4_QWEN_3_5_27B_FULL_FINETUNE_LORA" => MagicPromptVersionEnum.V4Qwen3527bFullFinetuneLora,
                "V4_QWEN_3_5_27B_PREFUSED" => MagicPromptVersionEnum.V4Qwen3527bPrefused,
                "V4_QWEN_3_5_27B_SGLANG_EXPERIMENTAL_Q36_2P5K" => MagicPromptVersionEnum.V4Qwen3527bSglangExperimentalQ362p5k,
                "V4_QWEN_3_5_27B_SGLANG_EXPERIMENTAL_Q36_2P5K_TP2" => MagicPromptVersionEnum.V4Qwen3527bSglangExperimentalQ362p5kTp2,
                "V_0" => MagicPromptVersionEnum.V0,
                "V_0_1" => MagicPromptVersionEnum.V01,
                "V_0_2" => MagicPromptVersionEnum.V02,
                "V_0_3" => MagicPromptVersionEnum.V03,
                "V_0_4" => MagicPromptVersionEnum.V04,
                "V_0_5" => MagicPromptVersionEnum.V05,
                "V_0_6" => MagicPromptVersionEnum.V06,
                "V_0_7" => MagicPromptVersionEnum.V07,
                "V_0_8" => MagicPromptVersionEnum.V08,
                _ => null,
            };
        }
    }
}