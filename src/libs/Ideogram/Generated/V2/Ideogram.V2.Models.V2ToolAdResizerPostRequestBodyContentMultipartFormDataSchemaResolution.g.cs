
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// Target ad resolution, formatted as `WIDTHxHEIGHT`. Any value not in<br/>
    /// the list is rejected with a 400. Each output image has exactly these<br/>
    /// pixel dimensions, with or without a `platform`.
    /// </summary>
    public enum V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution
    {
        /// <summary>
        ///
        /// </summary>
        x1080x1080,
        /// <summary>
        ///
        /// </summary>
        x1080x1350,
        /// <summary>
        ///
        /// </summary>
        x1080x1920,
        /// <summary>
        ///
        /// </summary>
        x1200x3500,
        /// <summary>
        ///
        /// </summary>
        x1280x3840,
        /// <summary>
        ///
        /// </summary>
        x160x600,
        /// <summary>
        ///
        /// </summary>
        x1800x900,
        /// <summary>
        ///
        /// </summary>
        x1920x1080,
        /// <summary>
        ///
        /// </summary>
        x1920x3840,
        /// <summary>
        ///
        /// </summary>
        x2160x3840,
        /// <summary>
        ///
        /// </summary>
        x2240x3584,
        /// <summary>
        ///
        /// </summary>
        x2336x3504,
        /// <summary>
        ///
        /// </summary>
        x2400x2400,
        /// <summary>
        ///
        /// </summary>
        x2448x3264,
        /// <summary>
        ///
        /// </summary>
        x2560x3200,
        /// <summary>
        ///
        /// </summary>
        x2880x2880,
        /// <summary>
        ///
        /// </summary>
        x300x250,
        /// <summary>
        ///
        /// </summary>
        x300x50,
        /// <summary>
        ///
        /// </summary>
        x300x600,
        /// <summary>
        ///
        /// </summary>
        x3200x2560,
        /// <summary>
        ///
        /// </summary>
        x320x100,
        /// <summary>
        ///
        /// </summary>
        x320x50,
        /// <summary>
        ///
        /// </summary>
        x3264x2448,
        /// <summary>
        ///
        /// </summary>
        x336x280,
        /// <summary>
        ///
        /// </summary>
        x3504x2336,
        /// <summary>
        ///
        /// </summary>
        x3584x2240,
        /// <summary>
        ///
        /// </summary>
        x3840x1280,
        /// <summary>
        ///
        /// </summary>
        x3840x1920,
        /// <summary>
        ///
        /// </summary>
        x3840x2160,
        /// <summary>
        ///
        /// </summary>
        x728x90,
        /// <summary>
        ///
        /// </summary>
        x970x250,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution value)
        {
            return value switch
            {
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x1080x1080 => "1080x1080",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x1080x1350 => "1080x1350",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x1080x1920 => "1080x1920",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x1200x3500 => "1200x3500",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x1280x3840 => "1280x3840",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x160x600 => "160x600",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x1800x900 => "1800x900",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x1920x1080 => "1920x1080",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x1920x3840 => "1920x3840",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x2160x3840 => "2160x3840",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x2240x3584 => "2240x3584",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x2336x3504 => "2336x3504",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x2400x2400 => "2400x2400",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x2448x3264 => "2448x3264",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x2560x3200 => "2560x3200",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x2880x2880 => "2880x2880",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x300x250 => "300x250",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x300x50 => "300x50",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x300x600 => "300x600",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x3200x2560 => "3200x2560",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x320x100 => "320x100",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x320x50 => "320x50",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x3264x2448 => "3264x2448",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x336x280 => "336x280",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x3504x2336 => "3504x2336",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x3584x2240 => "3584x2240",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x3840x1280 => "3840x1280",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x3840x1920 => "3840x1920",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x3840x2160 => "3840x2160",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x728x90 => "728x90",
                V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x970x250 => "970x250",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080x1080" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x1080x1080,
                "1080x1350" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x1080x1350,
                "1080x1920" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x1080x1920,
                "1200x3500" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x1200x3500,
                "1280x3840" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x1280x3840,
                "160x600" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x160x600,
                "1800x900" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x1800x900,
                "1920x1080" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x1920x1080,
                "1920x3840" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x1920x3840,
                "2160x3840" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x2160x3840,
                "2240x3584" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x2240x3584,
                "2336x3504" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x2336x3504,
                "2400x2400" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x2400x2400,
                "2448x3264" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x2448x3264,
                "2560x3200" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x2560x3200,
                "2880x2880" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x2880x2880,
                "300x250" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x300x250,
                "300x50" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x300x50,
                "300x600" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x300x600,
                "3200x2560" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x3200x2560,
                "320x100" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x320x100,
                "320x50" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x320x50,
                "3264x2448" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x3264x2448,
                "336x280" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x336x280,
                "3504x2336" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x3504x2336,
                "3584x2240" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x3584x2240,
                "3840x1280" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x3840x1280,
                "3840x1920" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x3840x1920,
                "3840x2160" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x3840x2160,
                "728x90" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x728x90,
                "970x250" => V2ToolAdResizerPostRequestBodyContentMultipartFormDataSchemaResolution.x970x250,
                _ => null,
            };
        }
    }
}