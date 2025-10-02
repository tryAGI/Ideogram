
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Type of API profile<br/>
    /// Example: INDIVIDUAL
    /// </summary>
    public enum ApiProfileType
    {
        /// <summary>
        /// 
        /// </summary>
        INDIVIDUAL,
        /// <summary>
        /// 
        /// </summary>
        ENTERPRISE,
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
                ApiProfileType.INDIVIDUAL => "INDIVIDUAL",
                ApiProfileType.ENTERPRISE => "ENTERPRISE",
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
                "INDIVIDUAL" => ApiProfileType.INDIVIDUAL,
                "ENTERPRISE" => ApiProfileType.ENTERPRISE,
                _ => null,
            };
        }
    }
}