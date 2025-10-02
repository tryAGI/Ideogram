
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
        OWNER,
        /// <summary>
        /// 
        /// </summary>
        MEMBER,
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
                ApiProfileRole.OWNER => "OWNER",
                ApiProfileRole.MEMBER => "MEMBER",
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
                "OWNER" => ApiProfileRole.OWNER,
                "MEMBER" => ApiProfileRole.MEMBER,
                _ => null,
            };
        }
    }
}