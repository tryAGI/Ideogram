
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public enum V2AccountUsageGetParametersSourcesSchemaItems
    {
        /// <summary>
        ///
        /// </summary>
        Api,
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2AccountUsageGetParametersSourcesSchemaItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2AccountUsageGetParametersSourcesSchemaItems value)
        {
            return value switch
            {
                V2AccountUsageGetParametersSourcesSchemaItems.Api => "api",
                V2AccountUsageGetParametersSourcesSchemaItems.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2AccountUsageGetParametersSourcesSchemaItems? ToEnum(string value)
        {
            return value switch
            {
                "api" => V2AccountUsageGetParametersSourcesSchemaItems.Api,
                "app" => V2AccountUsageGetParametersSourcesSchemaItems.App,
                _ => null,
            };
        }
    }
}