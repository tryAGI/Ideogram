
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// layered (default): full editable design payload with text layers and HTML.<br/>
    /// url: JSON with an expiring link to the final composited cover image.<br/>
    /// binary: raw PNG bytes of the final composited cover image (Content-Type image/png).<br/>
    /// html: raw HTML document of the generated layout (Content-Type text/html).<br/>
    /// Default Value: layered
    /// </summary>
    public enum GenerateDesignRequestV4ResponseType
    {
        /// <summary>
        /// raw PNG bytes of the final composited cover image (Content-Type image/png).
        /// </summary>
        Binary,
        /// <summary>
        /// raw HTML document of the generated layout (Content-Type text/html).
        /// </summary>
        Html,
        /// <summary>
        /// full editable design payload with text layers and HTML.
        /// </summary>
        Layered,
        /// <summary>
        /// JSON with an expiring link to the final composited cover image.
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateDesignRequestV4ResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateDesignRequestV4ResponseType value)
        {
            return value switch
            {
                GenerateDesignRequestV4ResponseType.Binary => "binary",
                GenerateDesignRequestV4ResponseType.Html => "html",
                GenerateDesignRequestV4ResponseType.Layered => "layered",
                GenerateDesignRequestV4ResponseType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateDesignRequestV4ResponseType? ToEnum(string value)
        {
            return value switch
            {
                "binary" => GenerateDesignRequestV4ResponseType.Binary,
                "html" => GenerateDesignRequestV4ResponseType.Html,
                "layered" => GenerateDesignRequestV4ResponseType.Layered,
                "url" => GenerateDesignRequestV4ResponseType.Url,
                _ => null,
            };
        }
    }
}