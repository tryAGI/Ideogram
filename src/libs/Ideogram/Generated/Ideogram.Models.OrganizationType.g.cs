
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The type of organization
    /// </summary>
    public enum OrganizationType
    {
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationType value)
        {
            return value switch
            {
                OrganizationType.Enterprise => "ENTERPRISE",
                OrganizationType.Private => "PRIVATE",
                OrganizationType.Team => "TEAM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationType? ToEnum(string value)
        {
            return value switch
            {
                "ENTERPRISE" => OrganizationType.Enterprise,
                "PRIVATE" => OrganizationType.Private,
                "TEAM" => OrganizationType.Team,
                _ => null,
            };
        }
    }
}