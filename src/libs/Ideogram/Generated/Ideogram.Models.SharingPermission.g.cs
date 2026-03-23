
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Permission level for the shared organization. OWNER is read-only and cannot be set via add/remove.
    /// </summary>
    public enum SharingPermission
    {
        /// <summary>
        /// 
        /// </summary>
        Editor,
        /// <summary>
        /// 
        /// </summary>
        Owner,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SharingPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SharingPermission value)
        {
            return value switch
            {
                SharingPermission.Editor => "EDITOR",
                SharingPermission.Owner => "OWNER",
                SharingPermission.Viewer => "VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SharingPermission? ToEnum(string value)
        {
            return value switch
            {
                "EDITOR" => SharingPermission.Editor,
                "OWNER" => SharingPermission.Owner,
                "VIEWER" => SharingPermission.Viewer,
                _ => null,
            };
        }
    }
}