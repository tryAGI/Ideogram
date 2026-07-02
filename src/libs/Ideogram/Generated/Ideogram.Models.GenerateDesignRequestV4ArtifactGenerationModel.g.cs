
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Experimental. Model to use for the HTML/layout and base-plate handoff generation call.<br/>
    /// Default Value: claude-sonnet-4-6
    /// </summary>
    public enum GenerateDesignRequestV4ArtifactGenerationModel
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
    public static class GenerateDesignRequestV4ArtifactGenerationModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateDesignRequestV4ArtifactGenerationModel value)
        {
            return value switch
            {
                GenerateDesignRequestV4ArtifactGenerationModel.ClaudeOpus46 => "claude-opus-4-6",
                GenerateDesignRequestV4ArtifactGenerationModel.ClaudeOpus47 => "claude-opus-4-7",
                GenerateDesignRequestV4ArtifactGenerationModel.ClaudeSonnet46 => "claude-sonnet-4-6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateDesignRequestV4ArtifactGenerationModel? ToEnum(string value)
        {
            return value switch
            {
                "claude-opus-4-6" => GenerateDesignRequestV4ArtifactGenerationModel.ClaudeOpus46,
                "claude-opus-4-7" => GenerateDesignRequestV4ArtifactGenerationModel.ClaudeOpus47,
                "claude-sonnet-4-6" => GenerateDesignRequestV4ArtifactGenerationModel.ClaudeSonnet46,
                _ => null,
            };
        }
    }
}