
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The ad platform whose published safe zone the advertisement must<br/>
    /// stay inside. `google` covers YouTube and Google Ads placements;<br/>
    /// `meta` covers Facebook and Instagram. When supplied, the<br/>
    /// advertisement is generated inside that platform's safe zone for the<br/>
    /// requested aspect ratio and the remaining space is filled in around<br/>
    /// it. When omitted, the advertisement fills the whole frame. Any other<br/>
    /// value is rejected with a 400.
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
                "snapchat" => AdResizerRequestPlatform.Snapchat,
                "tiktok" => AdResizerRequestPlatform.Tiktok,
                _ => null,
            };
        }
    }
}