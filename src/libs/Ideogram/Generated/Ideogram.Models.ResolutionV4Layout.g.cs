
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The resolutions supported for Ideogram 4.0 layout-to-image and design generation.<br/>
    /// Example: 1024x1024
    /// </summary>
    public enum ResolutionV4Layout
    {
        /// <summary>
        /// 
        /// </summary>
        x1024x1024,
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
    public static class ResolutionV4LayoutExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResolutionV4Layout value)
        {
            return value switch
            {
                ResolutionV4Layout.x1024x1024 => "1024x1024",
                ResolutionV4Layout.x1120x896 => "1120x896",
                ResolutionV4Layout.x1152x864 => "1152x864",
                ResolutionV4Layout.x1248x832 => "1248x832",
                ResolutionV4Layout.x1280x720 => "1280x720",
                ResolutionV4Layout.x1280x800 => "1280x800",
                ResolutionV4Layout.x1440x720 => "1440x720",
                ResolutionV4Layout.x720x1280 => "720x1280",
                ResolutionV4Layout.x720x1440 => "720x1440",
                ResolutionV4Layout.x800x1280 => "800x1280",
                ResolutionV4Layout.x832x1248 => "832x1248",
                ResolutionV4Layout.x864x1152 => "864x1152",
                ResolutionV4Layout.x896x1120 => "896x1120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResolutionV4Layout? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => ResolutionV4Layout.x1024x1024,
                "1120x896" => ResolutionV4Layout.x1120x896,
                "1152x864" => ResolutionV4Layout.x1152x864,
                "1248x832" => ResolutionV4Layout.x1248x832,
                "1280x720" => ResolutionV4Layout.x1280x720,
                "1280x800" => ResolutionV4Layout.x1280x800,
                "1440x720" => ResolutionV4Layout.x1440x720,
                "720x1280" => ResolutionV4Layout.x720x1280,
                "720x1440" => ResolutionV4Layout.x720x1440,
                "800x1280" => ResolutionV4Layout.x800x1280,
                "832x1248" => ResolutionV4Layout.x832x1248,
                "864x1152" => ResolutionV4Layout.x864x1152,
                "896x1120" => ResolutionV4Layout.x896x1120,
                _ => null,
            };
        }
    }
}