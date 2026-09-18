
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The axis to vary while everything else stays on-brand. `people`<br/>
    /// replaces the people in the ad with different talent. `setting`<br/>
    /// moves the same subject and product to a different environment.<br/>
    /// `group_size` changes how many people appear. `scene` shifts the<br/>
    /// moment or occasion (time of day, season, or activity).
    /// </summary>
    public enum AdVariationsRequestVariationType
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
    public static class AdVariationsRequestVariationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdVariationsRequestVariationType value)
        {
            return value switch
            {
                AdVariationsRequestVariationType.GroupSize => "group_size",
                AdVariationsRequestVariationType.People => "people",
                AdVariationsRequestVariationType.Scene => "scene",
                AdVariationsRequestVariationType.Setting => "setting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdVariationsRequestVariationType? ToEnum(string value)
        {
            return value switch
            {
                "group_size" => AdVariationsRequestVariationType.GroupSize,
                "people" => AdVariationsRequestVariationType.People,
                "scene" => AdVariationsRequestVariationType.Scene,
                "setting" => AdVariationsRequestVariationType.Setting,
                _ => null,
            };
        }
    }
}