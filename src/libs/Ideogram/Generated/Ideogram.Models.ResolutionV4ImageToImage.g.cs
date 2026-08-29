
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Output resolutions for Ideogram 4.0 image-to-image. Superset of ResolutionV4 (the 1K/2K t2im set) plus the small 512-tier (512x512, 768x384, 384x768).<br/>
    /// Example: 1024x1024
    /// </summary>
    public enum ResolutionV4ImageToImage
    {
        /// <summary>
        ///
        /// </summary>
        x1024x1024,
        /// <summary>
        ///
        /// </summary>
        x1024x3072,
        /// <summary>
        ///
        /// </summary>
        x1120x896,
        /// <summary>
        ///
        /// </summary>
        x1152x2944,
        /// <summary>
        ///
        /// </summary>
        x1152x864,
        /// <summary>
        ///
        /// </summary>
        x1248x3328,
        /// <summary>
        ///
        /// </summary>
        x1248x832,
        /// <summary>
        ///
        /// </summary>
        x1280x3072,
        /// <summary>
        ///
        /// </summary>
        x1280x720,
        /// <summary>
        ///
        /// </summary>
        x1280x800,
        /// <summary>
        ///
        /// </summary>
        x1296x3168,
        /// <summary>
        ///
        /// </summary>
        x1440x2560,
        /// <summary>
        ///
        /// </summary>
        x1440x2880,
        /// <summary>
        ///
        /// </summary>
        x1440x720,
        /// <summary>
        ///
        /// </summary>
        x1600x2560,
        /// <summary>
        ///
        /// </summary>
        x1664x2496,
        /// <summary>
        ///
        /// </summary>
        x1728x2304,
        /// <summary>
        ///
        /// </summary>
        x1792x2240,
        /// <summary>
        ///
        /// </summary>
        x2048x2048,
        /// <summary>
        ///
        /// </summary>
        x2240x1792,
        /// <summary>
        ///
        /// </summary>
        x2304x1728,
        /// <summary>
        ///
        /// </summary>
        x2496x1664,
        /// <summary>
        ///
        /// </summary>
        x2560x1440,
        /// <summary>
        ///
        /// </summary>
        x2560x1600,
        /// <summary>
        ///
        /// </summary>
        x2880x1440,
        /// <summary>
        ///
        /// </summary>
        x2944x1152,
        /// <summary>
        ///
        /// </summary>
        x3072x1024,
        /// <summary>
        ///
        /// </summary>
        x3072x1280,
        /// <summary>
        ///
        /// </summary>
        x3168x1296,
        /// <summary>
        ///
        /// </summary>
        x3328x1248,
        /// <summary>
        ///
        /// </summary>
        x384x768,
        /// <summary>
        ///
        /// </summary>
        x512x512,
        /// <summary>
        ///
        /// </summary>
        x720x1280,
        /// <summary>
        ///
        /// </summary>
        x720x1440,
        /// <summary>
        ///
        /// </summary>
        x768x384,
        /// <summary>
        ///
        /// </summary>
        x800x1280,
        /// <summary>
        ///
        /// </summary>
        x832x1248,
        /// <summary>
        ///
        /// </summary>
        x864x1152,
        /// <summary>
        ///
        /// </summary>
        x896x1120,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResolutionV4ImageToImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResolutionV4ImageToImage value)
        {
            return value switch
            {
                ResolutionV4ImageToImage.x1024x1024 => "1024x1024",
                ResolutionV4ImageToImage.x1024x3072 => "1024x3072",
                ResolutionV4ImageToImage.x1120x896 => "1120x896",
                ResolutionV4ImageToImage.x1152x2944 => "1152x2944",
                ResolutionV4ImageToImage.x1152x864 => "1152x864",
                ResolutionV4ImageToImage.x1248x3328 => "1248x3328",
                ResolutionV4ImageToImage.x1248x832 => "1248x832",
                ResolutionV4ImageToImage.x1280x3072 => "1280x3072",
                ResolutionV4ImageToImage.x1280x720 => "1280x720",
                ResolutionV4ImageToImage.x1280x800 => "1280x800",
                ResolutionV4ImageToImage.x1296x3168 => "1296x3168",
                ResolutionV4ImageToImage.x1440x2560 => "1440x2560",
                ResolutionV4ImageToImage.x1440x2880 => "1440x2880",
                ResolutionV4ImageToImage.x1440x720 => "1440x720",
                ResolutionV4ImageToImage.x1600x2560 => "1600x2560",
                ResolutionV4ImageToImage.x1664x2496 => "1664x2496",
                ResolutionV4ImageToImage.x1728x2304 => "1728x2304",
                ResolutionV4ImageToImage.x1792x2240 => "1792x2240",
                ResolutionV4ImageToImage.x2048x2048 => "2048x2048",
                ResolutionV4ImageToImage.x2240x1792 => "2240x1792",
                ResolutionV4ImageToImage.x2304x1728 => "2304x1728",
                ResolutionV4ImageToImage.x2496x1664 => "2496x1664",
                ResolutionV4ImageToImage.x2560x1440 => "2560x1440",
                ResolutionV4ImageToImage.x2560x1600 => "2560x1600",
                ResolutionV4ImageToImage.x2880x1440 => "2880x1440",
                ResolutionV4ImageToImage.x2944x1152 => "2944x1152",
                ResolutionV4ImageToImage.x3072x1024 => "3072x1024",
                ResolutionV4ImageToImage.x3072x1280 => "3072x1280",
                ResolutionV4ImageToImage.x3168x1296 => "3168x1296",
                ResolutionV4ImageToImage.x3328x1248 => "3328x1248",
                ResolutionV4ImageToImage.x384x768 => "384x768",
                ResolutionV4ImageToImage.x512x512 => "512x512",
                ResolutionV4ImageToImage.x720x1280 => "720x1280",
                ResolutionV4ImageToImage.x720x1440 => "720x1440",
                ResolutionV4ImageToImage.x768x384 => "768x384",
                ResolutionV4ImageToImage.x800x1280 => "800x1280",
                ResolutionV4ImageToImage.x832x1248 => "832x1248",
                ResolutionV4ImageToImage.x864x1152 => "864x1152",
                ResolutionV4ImageToImage.x896x1120 => "896x1120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResolutionV4ImageToImage? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => ResolutionV4ImageToImage.x1024x1024,
                "1024x3072" => ResolutionV4ImageToImage.x1024x3072,
                "1120x896" => ResolutionV4ImageToImage.x1120x896,
                "1152x2944" => ResolutionV4ImageToImage.x1152x2944,
                "1152x864" => ResolutionV4ImageToImage.x1152x864,
                "1248x3328" => ResolutionV4ImageToImage.x1248x3328,
                "1248x832" => ResolutionV4ImageToImage.x1248x832,
                "1280x3072" => ResolutionV4ImageToImage.x1280x3072,
                "1280x720" => ResolutionV4ImageToImage.x1280x720,
                "1280x800" => ResolutionV4ImageToImage.x1280x800,
                "1296x3168" => ResolutionV4ImageToImage.x1296x3168,
                "1440x2560" => ResolutionV4ImageToImage.x1440x2560,
                "1440x2880" => ResolutionV4ImageToImage.x1440x2880,
                "1440x720" => ResolutionV4ImageToImage.x1440x720,
                "1600x2560" => ResolutionV4ImageToImage.x1600x2560,
                "1664x2496" => ResolutionV4ImageToImage.x1664x2496,
                "1728x2304" => ResolutionV4ImageToImage.x1728x2304,
                "1792x2240" => ResolutionV4ImageToImage.x1792x2240,
                "2048x2048" => ResolutionV4ImageToImage.x2048x2048,
                "2240x1792" => ResolutionV4ImageToImage.x2240x1792,
                "2304x1728" => ResolutionV4ImageToImage.x2304x1728,
                "2496x1664" => ResolutionV4ImageToImage.x2496x1664,
                "2560x1440" => ResolutionV4ImageToImage.x2560x1440,
                "2560x1600" => ResolutionV4ImageToImage.x2560x1600,
                "2880x1440" => ResolutionV4ImageToImage.x2880x1440,
                "2944x1152" => ResolutionV4ImageToImage.x2944x1152,
                "3072x1024" => ResolutionV4ImageToImage.x3072x1024,
                "3072x1280" => ResolutionV4ImageToImage.x3072x1280,
                "3168x1296" => ResolutionV4ImageToImage.x3168x1296,
                "3328x1248" => ResolutionV4ImageToImage.x3328x1248,
                "384x768" => ResolutionV4ImageToImage.x384x768,
                "512x512" => ResolutionV4ImageToImage.x512x512,
                "720x1280" => ResolutionV4ImageToImage.x720x1280,
                "720x1440" => ResolutionV4ImageToImage.x720x1440,
                "768x384" => ResolutionV4ImageToImage.x768x384,
                "800x1280" => ResolutionV4ImageToImage.x800x1280,
                "832x1248" => ResolutionV4ImageToImage.x832x1248,
                "864x1152" => ResolutionV4ImageToImage.x864x1152,
                "896x1120" => ResolutionV4ImageToImage.x896x1120,
                _ => null,
            };
        }
    }
}