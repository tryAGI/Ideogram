
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Validation outcome for the detected manifest. `VALID` and `TRUSTED`<br/>
    /// both mean the content is unmodified since it was signed; `INVALID`<br/>
    /// means the content or its manifest was altered after signing.
    /// </summary>
    public enum ProvenanceVerifyResponseValidationState
    {
        /// <summary>
        ///
        /// </summary>
        Invalid,
        /// <summary>
        ///
        /// </summary>
        Trusted,
        /// <summary>
        ///
        /// </summary>
        Valid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProvenanceVerifyResponseValidationStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProvenanceVerifyResponseValidationState value)
        {
            return value switch
            {
                ProvenanceVerifyResponseValidationState.Invalid => "INVALID",
                ProvenanceVerifyResponseValidationState.Trusted => "TRUSTED",
                ProvenanceVerifyResponseValidationState.Valid => "VALID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProvenanceVerifyResponseValidationState? ToEnum(string value)
        {
            return value switch
            {
                "INVALID" => ProvenanceVerifyResponseValidationState.Invalid,
                "TRUSTED" => ProvenanceVerifyResponseValidationState.Trusted,
                "VALID" => ProvenanceVerifyResponseValidationState.Valid,
                _ => null,
            };
        }
    }
}