
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
        AUTO,
        /// <summary>
        /// 
        /// </summary>
        GENERAL,
        /// <summary>
        /// 
        /// </summary>
        REALISTIC,
        /// <summary>
        /// 
        /// </summary>
        DESIGN,
        /// <summary>
        /// 
        /// </summary>
        CUSTOM,
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
                StyleTypeV3.AUTO => "AUTO",
                StyleTypeV3.GENERAL => "GENERAL",
                StyleTypeV3.REALISTIC => "REALISTIC",
                StyleTypeV3.DESIGN => "DESIGN",
                StyleTypeV3.CUSTOM => "CUSTOM",
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
                "AUTO" => StyleTypeV3.AUTO,
                "GENERAL" => StyleTypeV3.GENERAL,
                "REALISTIC" => StyleTypeV3.REALISTIC,
                "DESIGN" => StyleTypeV3.DESIGN,
                "CUSTOM" => StyleTypeV3.CUSTOM,
                _ => null,
            };
        }
    }
}