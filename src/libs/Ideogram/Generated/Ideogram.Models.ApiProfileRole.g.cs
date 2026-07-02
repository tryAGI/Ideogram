
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Role within an organization profile. ADMIN only exists for TEAM_API organizations.<br/>
    /// Example: OWNER
    /// </summary>
    public enum ApiProfileRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
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
                ApiProfileRole.Admin => "ADMIN",
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
                "ADMIN" => ApiProfileRole.Admin,
                "MEMBER" => ApiProfileRole.Member,
                "OWNER" => ApiProfileRole.Owner,
                _ => null,
            };
        }
    }
}