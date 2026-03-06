
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
        Owner,
        /// <summary>
        /// 
        /// </summary>
        Member,
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
                ApiProfileRole.Owner => "OWNER",
                ApiProfileRole.Member => "MEMBER",
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
                "OWNER" => ApiProfileRole.Owner,
                "MEMBER" => ApiProfileRole.Member,
                _ => null,
            };
        }
    }
}