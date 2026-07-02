
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public enum V4PromptElementDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Obj,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V4PromptElementDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V4PromptElementDiscriminatorType value)
        {
            return value switch
            {
                V4PromptElementDiscriminatorType.Obj => "obj",
                V4PromptElementDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V4PromptElementDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "obj" => V4PromptElementDiscriminatorType.Obj,
                "text" => V4PromptElementDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}