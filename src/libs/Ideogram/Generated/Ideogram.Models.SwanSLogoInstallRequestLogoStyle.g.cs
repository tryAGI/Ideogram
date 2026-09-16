
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public enum SwanSLogoInstallRequestLogoStyle
    {
        /// <summary>
        ///
        /// </summary>
        x3d,
        /// <summary>
        ///
        /// </summary>
        Flat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwanSLogoInstallRequestLogoStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwanSLogoInstallRequestLogoStyle value)
        {
            return value switch
            {
                SwanSLogoInstallRequestLogoStyle.x3d => "3d",
                SwanSLogoInstallRequestLogoStyle.Flat => "flat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwanSLogoInstallRequestLogoStyle? ToEnum(string value)
        {
            return value switch
            {
                "3d" => SwanSLogoInstallRequestLogoStyle.x3d,
                "flat" => SwanSLogoInstallRequestLogoStyle.Flat,
                _ => null,
            };
        }
    }
}