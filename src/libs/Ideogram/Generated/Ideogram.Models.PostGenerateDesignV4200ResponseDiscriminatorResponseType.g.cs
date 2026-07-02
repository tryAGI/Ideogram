
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostGenerateDesignV4200ResponseDiscriminatorResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Layered,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostGenerateDesignV4200ResponseDiscriminatorResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostGenerateDesignV4200ResponseDiscriminatorResponseType value)
        {
            return value switch
            {
                PostGenerateDesignV4200ResponseDiscriminatorResponseType.Layered => "layered",
                PostGenerateDesignV4200ResponseDiscriminatorResponseType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostGenerateDesignV4200ResponseDiscriminatorResponseType? ToEnum(string value)
        {
            return value switch
            {
                "layered" => PostGenerateDesignV4200ResponseDiscriminatorResponseType.Layered,
                "url" => PostGenerateDesignV4200ResponseDiscriminatorResponseType.Url,
                _ => null,
            };
        }
    }
}