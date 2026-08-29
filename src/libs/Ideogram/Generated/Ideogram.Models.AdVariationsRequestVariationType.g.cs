
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The axis to vary while everything else stays on-brand. `PEOPLE`<br/>
    /// replaces the people in the ad with different talent. `SETTING`<br/>
    /// moves the same subject and product to a different environment.<br/>
    /// `GROUP_SIZE` changes how many people appear. `SCENE` shifts the<br/>
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
                AdVariationsRequestVariationType.GroupSize => "GROUP_SIZE",
                AdVariationsRequestVariationType.People => "PEOPLE",
                AdVariationsRequestVariationType.Scene => "SCENE",
                AdVariationsRequestVariationType.Setting => "SETTING",
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
                "GROUP_SIZE" => AdVariationsRequestVariationType.GroupSize,
                "PEOPLE" => AdVariationsRequestVariationType.People,
                "SCENE" => AdVariationsRequestVariationType.Scene,
                "SETTING" => AdVariationsRequestVariationType.Setting,
                _ => null,
            };
        }
    }
}