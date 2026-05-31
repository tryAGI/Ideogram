
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Experimental. Model to use for the inspiration vision prepass.<br/>
    /// Default Value: claude-sonnet-4-6
    /// </summary>
    public enum GenerateDesignRequestV4InspirationReferenceModel
    {
        /// <summary>
        /// 
        /// </summary>
        ClaudeOpus46,
        /// <summary>
        /// 
        /// </summary>
        ClaudeOpus47,
        /// <summary>
        /// 
        /// </summary>
        ClaudeSonnet46,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateDesignRequestV4InspirationReferenceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateDesignRequestV4InspirationReferenceModel value)
        {
            return value switch
            {
                GenerateDesignRequestV4InspirationReferenceModel.ClaudeOpus46 => "claude-opus-4-6",
                GenerateDesignRequestV4InspirationReferenceModel.ClaudeOpus47 => "claude-opus-4-7",
                GenerateDesignRequestV4InspirationReferenceModel.ClaudeSonnet46 => "claude-sonnet-4-6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateDesignRequestV4InspirationReferenceModel? ToEnum(string value)
        {
            return value switch
            {
                "claude-opus-4-6" => GenerateDesignRequestV4InspirationReferenceModel.ClaudeOpus46,
                "claude-opus-4-7" => GenerateDesignRequestV4InspirationReferenceModel.ClaudeOpus47,
                "claude-sonnet-4-6" => GenerateDesignRequestV4InspirationReferenceModel.ClaudeSonnet46,
                _ => null,
            };
        }
    }
}