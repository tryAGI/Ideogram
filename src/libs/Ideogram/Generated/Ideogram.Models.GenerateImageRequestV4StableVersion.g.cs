
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Optional. Selects a specific pinned stable build. When omitted,<br/>
    /// the default stable model URI is used. When set to `stable_may29`,<br/>
    /// the request is routed to the May 29th stable build.
    /// </summary>
    public enum GenerateImageRequestV4StableVersion
    {
        /// <summary>
        /// 
        /// </summary>
        StableMay29,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateImageRequestV4StableVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageRequestV4StableVersion value)
        {
            return value switch
            {
                GenerateImageRequestV4StableVersion.StableMay29 => "stable_may29",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageRequestV4StableVersion? ToEnum(string value)
        {
            return value switch
            {
                "stable_may29" => GenerateImageRequestV4StableVersion.StableMay29,
                _ => null,
            };
        }
    }
}