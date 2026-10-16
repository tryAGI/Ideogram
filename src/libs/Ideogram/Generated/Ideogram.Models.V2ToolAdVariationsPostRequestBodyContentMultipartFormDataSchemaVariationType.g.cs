
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The axis to vary. `people`<br/>
    /// replaces the people in the ad with different talent. `setting`<br/>
    /// moves the same subject and product to a different environment.<br/>
    /// `group_size` changes how many people appear. `scene` shifts the<br/>
    /// moment or occasion (time of day, season, or activity).
    /// </summary>
    public enum V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType
    {
        /// <summary>
        ///
        /// </summary>
        GroupSize,
        /// <summary>
        ///
        /// </summary>
        People,
        /// <summary>
        ///
        /// </summary>
        Scene,
        /// <summary>
        ///
        /// </summary>
        Setting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType value)
        {
            return value switch
            {
                V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType.GroupSize => "group_size",
                V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType.People => "people",
                V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType.Scene => "scene",
                V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType.Setting => "setting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType? ToEnum(string value)
        {
            return value switch
            {
                "group_size" => V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType.GroupSize,
                "people" => V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType.People,
                "scene" => V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType.Scene,
                "setting" => V2ToolAdVariationsPostRequestBodyContentMultipartFormDataSchemaVariationType.Setting,
                _ => null,
            };
        }
    }
}