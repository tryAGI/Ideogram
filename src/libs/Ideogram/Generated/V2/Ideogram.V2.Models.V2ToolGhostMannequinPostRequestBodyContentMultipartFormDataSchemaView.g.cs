
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// Camera view for the output garment.
    /// </summary>
    public enum V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView
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
    public static class V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView value)
        {
            return value switch
            {
                V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView.Back => "back",
                V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView.Front => "front",
                V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView.ThreeQuarter => "three_quarter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView? ToEnum(string value)
        {
            return value switch
            {
                "back" => V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView.Back,
                "front" => V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView.Front,
                "three_quarter" => V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView.ThreeQuarter,
                _ => null,
            };
        }
    }
}