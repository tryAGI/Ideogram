
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
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Design,
        /// <summary>
        /// 
        /// </summary>
        Fiction,
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
                StyleTypeV3.Custom => "CUSTOM",
                StyleTypeV3.Design => "DESIGN",
                StyleTypeV3.Fiction => "FICTION",
                StyleTypeV3.General => "GENERAL",
                StyleTypeV3.Realistic => "REALISTIC",
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
                "CUSTOM" => StyleTypeV3.Custom,
                "DESIGN" => StyleTypeV3.Design,
                "FICTION" => StyleTypeV3.Fiction,
                "GENERAL" => StyleTypeV3.General,
                "REALISTIC" => StyleTypeV3.Realistic,
                "STYLIZED" => StyleTypeV3.Stylized,
                _ => null,
            };
        }
    }
}