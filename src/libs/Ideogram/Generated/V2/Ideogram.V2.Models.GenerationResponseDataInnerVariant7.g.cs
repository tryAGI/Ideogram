
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// ImageJudgmentResultObject variant
    /// </summary>
    public sealed partial class GenerationResponseDataInnerVariant7
    {
        /// <summary>
        /// Discriminator value: image_judgment.result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.GenerationResponseDataInnerVariant7ObjectTypeJsonConverter))]
        public global::Ideogram.V2.GenerationResponseDataInnerVariant7ObjectType ObjectType { get; set; }

        /// <summary>
        /// Every mistake the check found, most important first: those at or above 0.33 confidence first (fixable before `acceptable`, most confident first), then the rest by confidence. Empty when it found none. Without product photos the product's construction and color are not compared, so an empty list does not mean it is built right.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.V2.ImageJudgmentIssue> Issues { get; set; }

        /// <summary>
        /// Version of the check; results are comparable within one version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int JudgeVersion { get; set; }

        /// <summary>
        /// Present when the check found nothing it stands behind: what an empty result does not cover, or that the check could not tell.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponseDataInnerVariant7" /> class.
        /// </summary>
        /// <param name="issues">
        /// Every mistake the check found, most important first: those at or above 0.33 confidence first (fixable before `acceptable`, most confident first), then the rest by confidence. Empty when it found none. Without product photos the product's construction and color are not compared, so an empty list does not mean it is built right.
        /// </param>
        /// <param name="judgeVersion">
        /// Version of the check; results are comparable within one version.
        /// </param>
        /// <param name="objectType">
        /// Discriminator value: image_judgment.result
        /// </param>
        /// <param name="note">
        /// Present when the check found nothing it stands behind: what an empty result does not cover, or that the check could not tell.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationResponseDataInnerVariant7(
            global::System.Collections.Generic.IList<global::Ideogram.V2.ImageJudgmentIssue> issues,
            int judgeVersion,
            global::Ideogram.V2.GenerationResponseDataInnerVariant7ObjectType objectType,
            string? note)
        {
            this.ObjectType = objectType;
            this.Issues = issues ?? throw new global::System.ArgumentNullException(nameof(issues));
            this.JudgeVersion = judgeVersion;
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponseDataInnerVariant7" /> class.
        /// </summary>
        public GenerationResponseDataInnerVariant7()
        {
        }

    }
}