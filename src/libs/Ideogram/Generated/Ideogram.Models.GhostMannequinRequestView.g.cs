
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Camera view for the output garment.
    /// </summary>
    public enum GhostMannequinRequestView
    {
        /// <summary>
        ///
        /// </summary>
        Back,
        /// <summary>
        ///
        /// </summary>
        Front,
        /// <summary>
        ///
        /// </summary>
        ThreeQuarter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GhostMannequinRequestViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GhostMannequinRequestView value)
        {
            return value switch
            {
                GhostMannequinRequestView.Back => "BACK",
                GhostMannequinRequestView.Front => "FRONT",
                GhostMannequinRequestView.ThreeQuarter => "THREE_QUARTER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GhostMannequinRequestView? ToEnum(string value)
        {
            return value switch
            {
                "BACK" => GhostMannequinRequestView.Back,
                "FRONT" => GhostMannequinRequestView.Front,
                "THREE_QUARTER" => GhostMannequinRequestView.ThreeQuarter,
                _ => null,
            };
        }
    }
}