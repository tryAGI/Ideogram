
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Type of API profile. TEAM is a seat-based team workspace, where each key belongs to the member who created it and spends that member's seat credits; the other types share their keys across the whole workspace.<br/>
    /// Example: INDIVIDUAL
    /// </summary>
    public enum ApiProfileType
    {
        /// <summary>
        ///
        /// </summary>
        Enterprise,
        /// <summary>
        ///
        /// </summary>
        Individual,
        /// <summary>
        ///
        /// </summary>
        Team,
        /// <summary>
        ///
        /// </summary>
        TeamApi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiProfileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProfileType value)
        {
            return value switch
            {
                ApiProfileType.Enterprise => "ENTERPRISE",
                ApiProfileType.Individual => "INDIVIDUAL",
                ApiProfileType.Team => "TEAM",
                ApiProfileType.TeamApi => "TEAM_API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProfileType? ToEnum(string value)
        {
            return value switch
            {
                "ENTERPRISE" => ApiProfileType.Enterprise,
                "INDIVIDUAL" => ApiProfileType.Individual,
                "TEAM" => ApiProfileType.Team,
                "TEAM_API" => ApiProfileType.TeamApi,
                _ => null,
            };
        }
    }
}