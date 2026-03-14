
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Role of a user in an organization.
    /// </summary>
    public enum OrganizationRoleEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Owner,
        /// <summary>
        /// 
        /// </summary>
        Writer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationRoleEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationRoleEnum value)
        {
            return value switch
            {
                OrganizationRoleEnum.Owner => "OWNER",
                OrganizationRoleEnum.Writer => "WRITER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationRoleEnum? ToEnum(string value)
        {
            return value switch
            {
                "OWNER" => OrganizationRoleEnum.Owner,
                "WRITER" => OrganizationRoleEnum.Writer,
                _ => null,
            };
        }
    }
}