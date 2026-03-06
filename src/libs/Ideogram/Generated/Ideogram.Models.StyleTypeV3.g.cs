
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The style type to generate with.<br/>
    /// Default Value: GENERAL<br/>
    /// Example: GENERAL
    /// </summary>
    public enum StyleTypeV3
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        General,
        /// <summary>
        /// 
        /// </summary>
        Realistic,
        /// <summary>
        /// 
        /// </summary>
        Design,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Fiction,
        /// <summary>
        /// 
        /// </summary>
        Stylized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StyleTypeV3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StyleTypeV3 value)
        {
            return value switch
            {
                StyleTypeV3.Auto => "AUTO",
                StyleTypeV3.General => "GENERAL",
                StyleTypeV3.Realistic => "REALISTIC",
                StyleTypeV3.Design => "DESIGN",
                StyleTypeV3.Custom => "CUSTOM",
                StyleTypeV3.Fiction => "FICTION",
                StyleTypeV3.Stylized => "STYLIZED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StyleTypeV3? ToEnum(string value)
        {
            return value switch
            {
                "AUTO" => StyleTypeV3.Auto,
                "GENERAL" => StyleTypeV3.General,
                "REALISTIC" => StyleTypeV3.Realistic,
                "DESIGN" => StyleTypeV3.Design,
                "CUSTOM" => StyleTypeV3.Custom,
                "FICTION" => StyleTypeV3.Fiction,
                "STYLIZED" => StyleTypeV3.Stylized,
                _ => null,
            };
        }
    }
}