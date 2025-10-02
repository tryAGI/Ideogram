
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
        ACTIVE,
        /// <summary>
        /// 
        /// </summary>
        DISABLED,
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
                ApiKeyStatus.ACTIVE => "ACTIVE",
                ApiKeyStatus.DISABLED => "DISABLED",
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
                "ACTIVE" => ApiKeyStatus.ACTIVE,
                "DISABLED" => ApiKeyStatus.DISABLED,
                _ => null,
            };
        }
    }
}