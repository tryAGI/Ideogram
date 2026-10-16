
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// The ad platform whose published safe zone the ad must stay inside.<br/>
    /// The ad is generated inside the largest rectangle that fits the<br/>
    /// platform's safe zone for the requested aspect ratio, and the space<br/>
    /// around it is filled in so the output is still exactly the requested<br/>
    /// `resolution`. `google` covers YouTube and Google Ads placements.<br/>
    /// Use `meta_stories` or `meta_reels` for Meta placements; Reels uses<br/>
    /// the largest rectangle inside its notched safe zone. The legacy<br/>
    /// `meta` value is still supported and uses a more conservative safe<br/>
    /// zone. When omitted, the ad fills the whole frame and every<br/>
    /// supported `resolution` is accepted. Any other value is rejected<br/>
    /// with a 400.<br/>
    /// Each platform accepts only the resolutions for which it publishes a<br/>
    /// safe zone; any other `resolution` is rejected with a 400:<br/>
    /// | Platform | Accepted resolutions |<br/>
    /// | --- | --- |<br/>
    /// | `google` | `1920x1080`, `3840x2160`, `1080x1080`, `2400x2400`, `2880x2880`, `1080x1920`, `2160x3840` |<br/>
    /// | `tiktok` | `1920x1080`, `3840x2160`, `1080x1080`, `2400x2400`, `2880x2880`, `1080x1920`, `2160x3840` |<br/>
    /// | `meta_stories` | `1080x1920`, `2160x3840` |<br/>
    /// | `meta_reels` | `1080x1920`, `2160x3840` |<br/>
    /// | `meta` (legacy) | `1080x1920`, `2160x3840` |<br/>
    /// | `snapchat` | `1080x1920`, `2160x3840` |
    /// </summary>
    public enum V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform
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
    public static class V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform value)
        {
            return value switch
            {
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform.Google => "google",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform.Meta => "meta",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform.MetaReels => "meta_reels",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform.MetaStories => "meta_stories",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform.Snapchat => "snapchat",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform.Tiktok => "tiktok",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform? ToEnum(string value)
        {
            return value switch
            {
                "google" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform.Google,
                "meta" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform.Meta,
                "meta_reels" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform.MetaReels,
                "meta_stories" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform.MetaStories,
                "snapchat" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform.Snapchat,
                "tiktok" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaPlatform.Tiktok,
                _ => null,
            };
        }
    }
}