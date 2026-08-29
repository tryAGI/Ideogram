
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// How the mini-app is embedded. `iframe` loads the app in a sandboxed frame; `mfe` loads it as a micro-frontend module.
    /// </summary>
    public enum PublishMiniAppPreviewRequestEmbed
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
    public static class PublishMiniAppPreviewRequestEmbedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishMiniAppPreviewRequestEmbed value)
        {
            return value switch
            {
                PublishMiniAppPreviewRequestEmbed.Iframe => "iframe",
                PublishMiniAppPreviewRequestEmbed.Mfe => "mfe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishMiniAppPreviewRequestEmbed? ToEnum(string value)
        {
            return value switch
            {
                "iframe" => PublishMiniAppPreviewRequestEmbed.Iframe,
                "mfe" => PublishMiniAppPreviewRequestEmbed.Mfe,
                _ => null,
            };
        }
    }
}