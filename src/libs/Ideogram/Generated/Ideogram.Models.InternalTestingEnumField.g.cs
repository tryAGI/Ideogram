
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
        Drei,
        /// <summary>
        /// 
        /// </summary>
        Ein,
        /// <summary>
        /// 
        /// </summary>
        Zwei,
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
                InternalTestingEnumField.Drei => "DREI",
                InternalTestingEnumField.Ein => "EIN",
                InternalTestingEnumField.Zwei => "ZWEI",
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
                "DREI" => InternalTestingEnumField.Drei,
                "EIN" => InternalTestingEnumField.Ein,
                "ZWEI" => InternalTestingEnumField.Zwei,
                _ => null,
            };
        }
    }
}