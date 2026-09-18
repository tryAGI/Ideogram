
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Determine if MagicPrompt should be used in generating the request or not.<br/>
    /// Example: on
    /// </summary>
    public enum MagicPromptMode
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Off,
        /// <summary>
        ///
        /// </summary>
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MagicPromptModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MagicPromptMode value)
        {
            return value switch
            {
                MagicPromptMode.Auto => "auto",
                MagicPromptMode.Off => "off",
                MagicPromptMode.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MagicPromptMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => MagicPromptMode.Auto,
                "off" => MagicPromptMode.Off,
                "on" => MagicPromptMode.On,
                _ => null,
            };
        }
    }
}