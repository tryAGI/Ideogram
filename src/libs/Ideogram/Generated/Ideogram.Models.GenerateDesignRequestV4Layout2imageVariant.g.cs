
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Experimental. Staging only. Select a v4 layout-to-image pipeline variant.<br/>
    /// Omit for the default v4l2i path. Rejected on production.
    /// </summary>
    public enum GenerateDesignRequestV4Layout2imageVariant
    {
        /// <summary>
        /// 
        /// </summary>
        BboxAware,
        /// <summary>
        /// 
        /// </summary>
        Opus47,
        /// <summary>
        /// 
        /// </summary>
        SeparateImageLayer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateDesignRequestV4Layout2imageVariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateDesignRequestV4Layout2imageVariant value)
        {
            return value switch
            {
                GenerateDesignRequestV4Layout2imageVariant.BboxAware => "bbox_aware",
                GenerateDesignRequestV4Layout2imageVariant.Opus47 => "opus_4_7",
                GenerateDesignRequestV4Layout2imageVariant.SeparateImageLayer => "separate_image_layer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateDesignRequestV4Layout2imageVariant? ToEnum(string value)
        {
            return value switch
            {
                "bbox_aware" => GenerateDesignRequestV4Layout2imageVariant.BboxAware,
                "opus_4_7" => GenerateDesignRequestV4Layout2imageVariant.Opus47,
                "separate_image_layer" => GenerateDesignRequestV4Layout2imageVariant.SeparateImageLayer,
                _ => null,
            };
        }
    }
}