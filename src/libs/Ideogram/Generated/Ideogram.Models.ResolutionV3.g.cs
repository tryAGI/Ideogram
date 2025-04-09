
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The resolutions supported for model version V_3.<br/>
    /// Example: 1024x1024
    /// </summary>
    public enum ResolutionV3
    {
        /// <summary>
        /// 
        /// </summary>
        x512x1536,
        /// <summary>
        /// 
        /// </summary>
        x576x1408,
        /// <summary>
        /// 
        /// </summary>
        x576x1472,
        /// <summary>
        /// 
        /// </summary>
        x576x1536,
        /// <summary>
        /// 
        /// </summary>
        x640x1344,
        /// <summary>
        /// 
        /// </summary>
        x640x1408,
        /// <summary>
        /// 
        /// </summary>
        x640x1472,
        /// <summary>
        /// 
        /// </summary>
        x640x1536,
        /// <summary>
        /// 
        /// </summary>
        x704x1152,
        /// <summary>
        /// 
        /// </summary>
        x704x1216,
        /// <summary>
        /// 
        /// </summary>
        x704x1280,
        /// <summary>
        /// 
        /// </summary>
        x704x1344,
        /// <summary>
        /// 
        /// </summary>
        x704x1408,
        /// <summary>
        /// 
        /// </summary>
        x704x1472,
        /// <summary>
        /// 
        /// </summary>
        x736x1312,
        /// <summary>
        /// 
        /// </summary>
        x768x1088,
        /// <summary>
        /// 
        /// </summary>
        x768x1216,
        /// <summary>
        /// 
        /// </summary>
        x768x1280,
        /// <summary>
        /// 
        /// </summary>
        x768x1344,
        /// <summary>
        /// 
        /// </summary>
        x800x1280,
        /// <summary>
        /// 
        /// </summary>
        x832x960,
        /// <summary>
        /// 
        /// </summary>
        x832x1024,
        /// <summary>
        /// 
        /// </summary>
        x832x1088,
        /// <summary>
        /// 
        /// </summary>
        x832x1152,
        /// <summary>
        /// 
        /// </summary>
        x832x1216,
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
        x896x960,
        /// <summary>
        /// 
        /// </summary>
        x896x1024,
        /// <summary>
        /// 
        /// </summary>
        x896x1088,
        /// <summary>
        /// 
        /// </summary>
        x896x1120,
        /// <summary>
        /// 
        /// </summary>
        x896x1152,
        /// <summary>
        /// 
        /// </summary>
        x960x832,
        /// <summary>
        /// 
        /// </summary>
        x960x896,
        /// <summary>
        /// 
        /// </summary>
        x960x1024,
        /// <summary>
        /// 
        /// </summary>
        x960x1088,
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
        x1024x1024,
        /// <summary>
        /// 
        /// </summary>
        x1088x768,
        /// <summary>
        /// 
        /// </summary>
        x1088x832,
        /// <summary>
        /// 
        /// </summary>
        x1088x896,
        /// <summary>
        /// 
        /// </summary>
        x1088x960,
        /// <summary>
        /// 
        /// </summary>
        x1120x896,
        /// <summary>
        /// 
        /// </summary>
        x1152x704,
        /// <summary>
        /// 
        /// </summary>
        x1152x832,
        /// <summary>
        /// 
        /// </summary>
        x1152x864,
        /// <summary>
        /// 
        /// </summary>
        x1152x896,
        /// <summary>
        /// 
        /// </summary>
        x1216x704,
        /// <summary>
        /// 
        /// </summary>
        x1216x768,
        /// <summary>
        /// 
        /// </summary>
        x1216x832,
        /// <summary>
        /// 
        /// </summary>
        x1248x832,
        /// <summary>
        /// 
        /// </summary>
        x1280x704,
        /// <summary>
        /// 
        /// </summary>
        x1280x768,
        /// <summary>
        /// 
        /// </summary>
        x1280x800,
        /// <summary>
        /// 
        /// </summary>
        x1312x736,
        /// <summary>
        /// 
        /// </summary>
        x1344x640,
        /// <summary>
        /// 
        /// </summary>
        x1344x704,
        /// <summary>
        /// 
        /// </summary>
        x1344x768,
        /// <summary>
        /// 
        /// </summary>
        x1408x576,
        /// <summary>
        /// 
        /// </summary>
        x1408x640,
        /// <summary>
        /// 
        /// </summary>
        x1408x704,
        /// <summary>
        /// 
        /// </summary>
        x1472x576,
        /// <summary>
        /// 
        /// </summary>
        x1472x640,
        /// <summary>
        /// 
        /// </summary>
        x1472x704,
        /// <summary>
        /// 
        /// </summary>
        x1536x512,
        /// <summary>
        /// 
        /// </summary>
        x1536x576,
        /// <summary>
        /// 
        /// </summary>
        x1536x640,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResolutionV3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResolutionV3 value)
        {
            return value switch
            {
                ResolutionV3.x512x1536 => "512x1536",
                ResolutionV3.x576x1408 => "576x1408",
                ResolutionV3.x576x1472 => "576x1472",
                ResolutionV3.x576x1536 => "576x1536",
                ResolutionV3.x640x1344 => "640x1344",
                ResolutionV3.x640x1408 => "640x1408",
                ResolutionV3.x640x1472 => "640x1472",
                ResolutionV3.x640x1536 => "640x1536",
                ResolutionV3.x704x1152 => "704x1152",
                ResolutionV3.x704x1216 => "704x1216",
                ResolutionV3.x704x1280 => "704x1280",
                ResolutionV3.x704x1344 => "704x1344",
                ResolutionV3.x704x1408 => "704x1408",
                ResolutionV3.x704x1472 => "704x1472",
                ResolutionV3.x736x1312 => "736x1312",
                ResolutionV3.x768x1088 => "768x1088",
                ResolutionV3.x768x1216 => "768x1216",
                ResolutionV3.x768x1280 => "768x1280",
                ResolutionV3.x768x1344 => "768x1344",
                ResolutionV3.x800x1280 => "800x1280",
                ResolutionV3.x832x960 => "832x960",
                ResolutionV3.x832x1024 => "832x1024",
                ResolutionV3.x832x1088 => "832x1088",
                ResolutionV3.x832x1152 => "832x1152",
                ResolutionV3.x832x1216 => "832x1216",
                ResolutionV3.x832x1248 => "832x1248",
                ResolutionV3.x864x1152 => "864x1152",
                ResolutionV3.x896x960 => "896x960",
                ResolutionV3.x896x1024 => "896x1024",
                ResolutionV3.x896x1088 => "896x1088",
                ResolutionV3.x896x1120 => "896x1120",
                ResolutionV3.x896x1152 => "896x1152",
                ResolutionV3.x960x832 => "960x832",
                ResolutionV3.x960x896 => "960x896",
                ResolutionV3.x960x1024 => "960x1024",
                ResolutionV3.x960x1088 => "960x1088",
                ResolutionV3.x1024x832 => "1024x832",
                ResolutionV3.x1024x896 => "1024x896",
                ResolutionV3.x1024x960 => "1024x960",
                ResolutionV3.x1024x1024 => "1024x1024",
                ResolutionV3.x1088x768 => "1088x768",
                ResolutionV3.x1088x832 => "1088x832",
                ResolutionV3.x1088x896 => "1088x896",
                ResolutionV3.x1088x960 => "1088x960",
                ResolutionV3.x1120x896 => "1120x896",
                ResolutionV3.x1152x704 => "1152x704",
                ResolutionV3.x1152x832 => "1152x832",
                ResolutionV3.x1152x864 => "1152x864",
                ResolutionV3.x1152x896 => "1152x896",
                ResolutionV3.x1216x704 => "1216x704",
                ResolutionV3.x1216x768 => "1216x768",
                ResolutionV3.x1216x832 => "1216x832",
                ResolutionV3.x1248x832 => "1248x832",
                ResolutionV3.x1280x704 => "1280x704",
                ResolutionV3.x1280x768 => "1280x768",
                ResolutionV3.x1280x800 => "1280x800",
                ResolutionV3.x1312x736 => "1312x736",
                ResolutionV3.x1344x640 => "1344x640",
                ResolutionV3.x1344x704 => "1344x704",
                ResolutionV3.x1344x768 => "1344x768",
                ResolutionV3.x1408x576 => "1408x576",
                ResolutionV3.x1408x640 => "1408x640",
                ResolutionV3.x1408x704 => "1408x704",
                ResolutionV3.x1472x576 => "1472x576",
                ResolutionV3.x1472x640 => "1472x640",
                ResolutionV3.x1472x704 => "1472x704",
                ResolutionV3.x1536x512 => "1536x512",
                ResolutionV3.x1536x576 => "1536x576",
                ResolutionV3.x1536x640 => "1536x640",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResolutionV3? ToEnum(string value)
        {
            return value switch
            {
                "512x1536" => ResolutionV3.x512x1536,
                "576x1408" => ResolutionV3.x576x1408,
                "576x1472" => ResolutionV3.x576x1472,
                "576x1536" => ResolutionV3.x576x1536,
                "640x1344" => ResolutionV3.x640x1344,
                "640x1408" => ResolutionV3.x640x1408,
                "640x1472" => ResolutionV3.x640x1472,
                "640x1536" => ResolutionV3.x640x1536,
                "704x1152" => ResolutionV3.x704x1152,
                "704x1216" => ResolutionV3.x704x1216,
                "704x1280" => ResolutionV3.x704x1280,
                "704x1344" => ResolutionV3.x704x1344,
                "704x1408" => ResolutionV3.x704x1408,
                "704x1472" => ResolutionV3.x704x1472,
                "736x1312" => ResolutionV3.x736x1312,
                "768x1088" => ResolutionV3.x768x1088,
                "768x1216" => ResolutionV3.x768x1216,
                "768x1280" => ResolutionV3.x768x1280,
                "768x1344" => ResolutionV3.x768x1344,
                "800x1280" => ResolutionV3.x800x1280,
                "832x960" => ResolutionV3.x832x960,
                "832x1024" => ResolutionV3.x832x1024,
                "832x1088" => ResolutionV3.x832x1088,
                "832x1152" => ResolutionV3.x832x1152,
                "832x1216" => ResolutionV3.x832x1216,
                "832x1248" => ResolutionV3.x832x1248,
                "864x1152" => ResolutionV3.x864x1152,
                "896x960" => ResolutionV3.x896x960,
                "896x1024" => ResolutionV3.x896x1024,
                "896x1088" => ResolutionV3.x896x1088,
                "896x1120" => ResolutionV3.x896x1120,
                "896x1152" => ResolutionV3.x896x1152,
                "960x832" => ResolutionV3.x960x832,
                "960x896" => ResolutionV3.x960x896,
                "960x1024" => ResolutionV3.x960x1024,
                "960x1088" => ResolutionV3.x960x1088,
                "1024x832" => ResolutionV3.x1024x832,
                "1024x896" => ResolutionV3.x1024x896,
                "1024x960" => ResolutionV3.x1024x960,
                "1024x1024" => ResolutionV3.x1024x1024,
                "1088x768" => ResolutionV3.x1088x768,
                "1088x832" => ResolutionV3.x1088x832,
                "1088x896" => ResolutionV3.x1088x896,
                "1088x960" => ResolutionV3.x1088x960,
                "1120x896" => ResolutionV3.x1120x896,
                "1152x704" => ResolutionV3.x1152x704,
                "1152x832" => ResolutionV3.x1152x832,
                "1152x864" => ResolutionV3.x1152x864,
                "1152x896" => ResolutionV3.x1152x896,
                "1216x704" => ResolutionV3.x1216x704,
                "1216x768" => ResolutionV3.x1216x768,
                "1216x832" => ResolutionV3.x1216x832,
                "1248x832" => ResolutionV3.x1248x832,
                "1280x704" => ResolutionV3.x1280x704,
                "1280x768" => ResolutionV3.x1280x768,
                "1280x800" => ResolutionV3.x1280x800,
                "1312x736" => ResolutionV3.x1312x736,
                "1344x640" => ResolutionV3.x1344x640,
                "1344x704" => ResolutionV3.x1344x704,
                "1344x768" => ResolutionV3.x1344x768,
                "1408x576" => ResolutionV3.x1408x576,
                "1408x640" => ResolutionV3.x1408x640,
                "1408x704" => ResolutionV3.x1408x704,
                "1472x576" => ResolutionV3.x1472x576,
                "1472x640" => ResolutionV3.x1472x640,
                "1472x704" => ResolutionV3.x1472x704,
                "1536x512" => ResolutionV3.x1536x512,
                "1536x576" => ResolutionV3.x1536x576,
                "1536x640" => ResolutionV3.x1536x640,
                _ => null,
            };
        }
    }
}