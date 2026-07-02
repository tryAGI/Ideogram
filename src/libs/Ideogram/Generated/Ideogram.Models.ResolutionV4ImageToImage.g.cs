
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The resolutions supported for Ideogram 4.0 image-to-image generation.<br/>
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
        x1024x832,
        /// <summary>
        /// 
        /// </summary>
        x1024x896,
        /// <summary>
        /// 
        /// </summary>
        x1024x960,
        /// <summary>
        /// 
        /// </summary>
        x1120x896,
        /// <summary>
        /// 
        /// </summary>
        x1152x864,
        /// <summary>
        /// 
        /// </summary>
        x1248x832,
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
        x1440x720,
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
        x800x1280,
        /// <summary>
        /// 
        /// </summary>
        x832x1024,
        /// <summary>
        /// 
        /// </summary>
        x832x1248,
        /// <summary>
        /// 
        /// </summary>
        x832x960,
        /// <summary>
        /// 
        /// </summary>
        x864x1152,
        /// <summary>
        /// 
        /// </summary>
        x896x1024,
        /// <summary>
        /// 
        /// </summary>
        x896x1120,
        /// <summary>
        /// 
        /// </summary>
        x896x960,
        /// <summary>
        /// 
        /// </summary>
        x960x1024,
        /// <summary>
        /// 
        /// </summary>
        x960x832,
        /// <summary>
        /// 
        /// </summary>
        x960x896,
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
                ResolutionV4ImageToImage.x1024x832 => "1024x832",
                ResolutionV4ImageToImage.x1024x896 => "1024x896",
                ResolutionV4ImageToImage.x1024x960 => "1024x960",
                ResolutionV4ImageToImage.x1120x896 => "1120x896",
                ResolutionV4ImageToImage.x1152x864 => "1152x864",
                ResolutionV4ImageToImage.x1248x832 => "1248x832",
                ResolutionV4ImageToImage.x1280x720 => "1280x720",
                ResolutionV4ImageToImage.x1280x800 => "1280x800",
                ResolutionV4ImageToImage.x1440x720 => "1440x720",
                ResolutionV4ImageToImage.x512x512 => "512x512",
                ResolutionV4ImageToImage.x720x1280 => "720x1280",
                ResolutionV4ImageToImage.x720x1440 => "720x1440",
                ResolutionV4ImageToImage.x800x1280 => "800x1280",
                ResolutionV4ImageToImage.x832x1024 => "832x1024",
                ResolutionV4ImageToImage.x832x1248 => "832x1248",
                ResolutionV4ImageToImage.x832x960 => "832x960",
                ResolutionV4ImageToImage.x864x1152 => "864x1152",
                ResolutionV4ImageToImage.x896x1024 => "896x1024",
                ResolutionV4ImageToImage.x896x1120 => "896x1120",
                ResolutionV4ImageToImage.x896x960 => "896x960",
                ResolutionV4ImageToImage.x960x1024 => "960x1024",
                ResolutionV4ImageToImage.x960x832 => "960x832",
                ResolutionV4ImageToImage.x960x896 => "960x896",
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
                "1024x832" => ResolutionV4ImageToImage.x1024x832,
                "1024x896" => ResolutionV4ImageToImage.x1024x896,
                "1024x960" => ResolutionV4ImageToImage.x1024x960,
                "1120x896" => ResolutionV4ImageToImage.x1120x896,
                "1152x864" => ResolutionV4ImageToImage.x1152x864,
                "1248x832" => ResolutionV4ImageToImage.x1248x832,
                "1280x720" => ResolutionV4ImageToImage.x1280x720,
                "1280x800" => ResolutionV4ImageToImage.x1280x800,
                "1440x720" => ResolutionV4ImageToImage.x1440x720,
                "512x512" => ResolutionV4ImageToImage.x512x512,
                "720x1280" => ResolutionV4ImageToImage.x720x1280,
                "720x1440" => ResolutionV4ImageToImage.x720x1440,
                "800x1280" => ResolutionV4ImageToImage.x800x1280,
                "832x1024" => ResolutionV4ImageToImage.x832x1024,
                "832x1248" => ResolutionV4ImageToImage.x832x1248,
                "832x960" => ResolutionV4ImageToImage.x832x960,
                "864x1152" => ResolutionV4ImageToImage.x864x1152,
                "896x1024" => ResolutionV4ImageToImage.x896x1024,
                "896x1120" => ResolutionV4ImageToImage.x896x1120,
                "896x960" => ResolutionV4ImageToImage.x896x960,
                "960x1024" => ResolutionV4ImageToImage.x960x1024,
                "960x832" => ResolutionV4ImageToImage.x960x832,
                "960x896" => ResolutionV4ImageToImage.x960x896,
                _ => null,
            };
        }
    }
}