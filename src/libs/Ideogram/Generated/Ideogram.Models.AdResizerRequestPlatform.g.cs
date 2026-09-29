
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The ad platform whose published safe zone the advertisement must<br/>
    /// stay inside. `google` covers YouTube and Google Ads placements;<br/>
    /// use `meta_stories` or `meta_reels` for the placement-specific Meta<br/>
    /// generation bounds. Reels uses the largest rectangle contained by<br/>
    /// its notched safe-zone polygon. The legacy `meta` value remains<br/>
    /// supported for existing callers with its conservative safe zone.<br/>
    /// When supplied, the advertisement is generated inside that<br/>
    /// platform's safe zone for the requested aspect ratio and the<br/>
    /// remaining space is filled in around it. When omitted, the<br/>
    /// advertisement fills the whole frame. Any other value is rejected<br/>
    /// with a 400.
    /// </summary>
    public enum AdResizerRequestPlatform
    {
        /// <summary>
        ///
        /// </summary>
        Google,
        /// <summary>
        ///
        /// </summary>
        Meta,
        /// <summary>
        ///
        /// </summary>
        MetaReels,
        /// <summary>
        ///
        /// </summary>
        MetaStories,
        /// <summary>
        ///
        /// </summary>
        Snapchat,
        /// <summary>
        ///
        /// </summary>
        Tiktok,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdResizerRequestPlatformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdResizerRequestPlatform value)
        {
            return value switch
            {
                AdResizerRequestPlatform.Google => "google",
                AdResizerRequestPlatform.Meta => "meta",
                AdResizerRequestPlatform.MetaReels => "meta_reels",
                AdResizerRequestPlatform.MetaStories => "meta_stories",
                AdResizerRequestPlatform.Snapchat => "snapchat",
                AdResizerRequestPlatform.Tiktok => "tiktok",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdResizerRequestPlatform? ToEnum(string value)
        {
            return value switch
            {
                "google" => AdResizerRequestPlatform.Google,
                "meta" => AdResizerRequestPlatform.Meta,
                "meta_reels" => AdResizerRequestPlatform.MetaReels,
                "meta_stories" => AdResizerRequestPlatform.MetaStories,
                "snapchat" => AdResizerRequestPlatform.Snapchat,
                "tiktok" => AdResizerRequestPlatform.Tiktok,
                _ => null,
            };
        }
    }
}