
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Status of the API key
    /// </summary>
    public enum ApiKeyStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiKeyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiKeyStatus value)
        {
            return value switch
            {
                ApiKeyStatus.Active => "ACTIVE",
                ApiKeyStatus.Disabled => "DISABLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiKeyStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => ApiKeyStatus.Active,
                "DISABLED" => ApiKeyStatus.Disabled,
                _ => null,
            };
        }
    }
}