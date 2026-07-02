
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public enum MagicPromptRequestMessagesInnerRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MagicPromptRequestMessagesInnerRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MagicPromptRequestMessagesInnerRole value)
        {
            return value switch
            {
                MagicPromptRequestMessagesInnerRole.Assistant => "assistant",
                MagicPromptRequestMessagesInnerRole.System => "system",
                MagicPromptRequestMessagesInnerRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MagicPromptRequestMessagesInnerRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => MagicPromptRequestMessagesInnerRole.Assistant,
                "system" => MagicPromptRequestMessagesInnerRole.System,
                "user" => MagicPromptRequestMessagesInnerRole.User,
                _ => null,
            };
        }
    }
}