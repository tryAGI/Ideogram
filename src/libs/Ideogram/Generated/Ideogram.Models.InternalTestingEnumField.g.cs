
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public enum InternalTestingEnumField
    {
        /// <summary>
        /// 
        /// </summary>
        EIN,
        /// <summary>
        /// 
        /// </summary>
        ZWEI,
        /// <summary>
        /// 
        /// </summary>
        DREI,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InternalTestingEnumFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternalTestingEnumField value)
        {
            return value switch
            {
                InternalTestingEnumField.EIN => "EIN",
                InternalTestingEnumField.ZWEI => "ZWEI",
                InternalTestingEnumField.DREI => "DREI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternalTestingEnumField? ToEnum(string value)
        {
            return value switch
            {
                "EIN" => InternalTestingEnumField.EIN,
                "ZWEI" => InternalTestingEnumField.ZWEI,
                "DREI" => InternalTestingEnumField.DREI,
                _ => null,
            };
        }
    }
}