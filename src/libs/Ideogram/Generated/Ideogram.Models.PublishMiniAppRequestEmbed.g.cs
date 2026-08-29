
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// How the mini-app is embedded. `iframe` loads the app in a sandboxed frame; `mfe` loads it as a micro-frontend module.
    /// </summary>
    public enum PublishMiniAppRequestEmbed
    {
        /// <summary>
        ///
        /// </summary>
        Iframe,
        /// <summary>
        ///
        /// </summary>
        Mfe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishMiniAppRequestEmbedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishMiniAppRequestEmbed value)
        {
            return value switch
            {
                PublishMiniAppRequestEmbed.Iframe => "iframe",
                PublishMiniAppRequestEmbed.Mfe => "mfe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishMiniAppRequestEmbed? ToEnum(string value)
        {
            return value switch
            {
                "iframe" => PublishMiniAppRequestEmbed.Iframe,
                "mfe" => PublishMiniAppRequestEmbed.Mfe,
                _ => null,
            };
        }
    }
}