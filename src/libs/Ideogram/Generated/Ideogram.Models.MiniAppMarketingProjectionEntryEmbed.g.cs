
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// How the mini-app runs. Iframe and MFE apps use hosted deployments; native apps are bundled into the Ideogram frontend.
    /// </summary>
    public enum MiniAppMarketingProjectionEntryEmbed
    {
        /// <summary>
        ///
        /// </summary>
        Iframe,
        /// <summary>
        ///
        /// </summary>
        Mfe,
        /// <summary>
        ///
        /// </summary>
        Native,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MiniAppMarketingProjectionEntryEmbedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MiniAppMarketingProjectionEntryEmbed value)
        {
            return value switch
            {
                MiniAppMarketingProjectionEntryEmbed.Iframe => "iframe",
                MiniAppMarketingProjectionEntryEmbed.Mfe => "mfe",
                MiniAppMarketingProjectionEntryEmbed.Native => "native",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MiniAppMarketingProjectionEntryEmbed? ToEnum(string value)
        {
            return value switch
            {
                "iframe" => MiniAppMarketingProjectionEntryEmbed.Iframe,
                "mfe" => MiniAppMarketingProjectionEntryEmbed.Mfe,
                "native" => MiniAppMarketingProjectionEntryEmbed.Native,
                _ => null,
            };
        }
    }
}