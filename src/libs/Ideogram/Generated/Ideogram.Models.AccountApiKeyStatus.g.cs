
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public enum AccountApiKeyStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Archived,
        /// <summary>
        ///
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccountApiKeyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccountApiKeyStatus value)
        {
            return value switch
            {
                AccountApiKeyStatus.Active => "active",
                AccountApiKeyStatus.Archived => "archived",
                AccountApiKeyStatus.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccountApiKeyStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => AccountApiKeyStatus.Active,
                "archived" => AccountApiKeyStatus.Archived,
                "disabled" => AccountApiKeyStatus.Disabled,
                _ => null,
            };
        }
    }
}