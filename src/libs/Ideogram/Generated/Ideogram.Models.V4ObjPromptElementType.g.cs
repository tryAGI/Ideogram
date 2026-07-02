
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Discriminator. Must be `obj`.
    /// </summary>
    public enum V4ObjPromptElementType
    {
        /// <summary>
        /// 
        /// </summary>
        Obj,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V4ObjPromptElementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V4ObjPromptElementType value)
        {
            return value switch
            {
                V4ObjPromptElementType.Obj => "obj",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V4ObjPromptElementType? ToEnum(string value)
        {
            return value switch
            {
                "obj" => V4ObjPromptElementType.Obj,
                _ => null,
            };
        }
    }
}