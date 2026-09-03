
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A provider-neutral integration operation family.
    /// </summary>
    public enum IntegrationType
    {
        /// <summary>
        ///
        /// </summary>
        DigitalAssetManagement,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationType value)
        {
            return value switch
            {
                IntegrationType.DigitalAssetManagement => "DIGITAL_ASSET_MANAGEMENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationType? ToEnum(string value)
        {
            return value switch
            {
                "DIGITAL_ASSET_MANAGEMENT" => IntegrationType.DigitalAssetManagement,
                _ => null,
            };
        }
    }
}