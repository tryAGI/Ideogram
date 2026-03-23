
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Role within an enterprise organization profile<br/>
    /// Example: OWNER
    /// </summary>
    public enum ApiProfileRole
    {
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiProfileRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProfileRole value)
        {
            return value switch
            {
                ApiProfileRole.Member => "MEMBER",
                ApiProfileRole.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProfileRole? ToEnum(string value)
        {
            return value switch
            {
                "MEMBER" => ApiProfileRole.Member,
                "OWNER" => ApiProfileRole.Owner,
                _ => null,
            };
        }
    }
}