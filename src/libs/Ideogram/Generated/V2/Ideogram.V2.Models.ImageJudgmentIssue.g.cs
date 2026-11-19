
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// One mistake the check found.
    /// </summary>
    public sealed partial class ImageJudgmentIssue
    {
        /// <summary>
        /// The kind of mistake.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.ImageJudgmentIssueCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.ImageJudgmentIssueCategory Category { get; set; }

        /// <summary>
        /// `obvious`: a careful client would see it at normal size. `subtle`: visible when zooming in. `acceptable`: real, but a known limit nobody could fix by editing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.ImageJudgmentIssueSeverityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.ImageJudgmentIssueSeverity Severity { get; set; }

        /// <summary>
        /// One line naming the part and what is wrong.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// How sure the check is that the mistake is real and visible. When the judge was tuned, issues at or above 0.33 were mostly real and those below it mostly false alarms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// A box in the checked image's own pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("box")]
        public global::Ideogram.V2.ImageJudgmentBox? Box { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageJudgmentIssue" /> class.
        /// </summary>
        /// <param name="category">
        /// The kind of mistake.
        /// </param>
        /// <param name="severity">
        /// `obvious`: a careful client would see it at normal size. `subtle`: visible when zooming in. `acceptable`: real, but a known limit nobody could fix by editing.
        /// </param>
        /// <param name="reason">
        /// One line naming the part and what is wrong.
        /// </param>
        /// <param name="confidence">
        /// How sure the check is that the mistake is real and visible. When the judge was tuned, issues at or above 0.33 were mostly real and those below it mostly false alarms.
        /// </param>
        /// <param name="box">
        /// A box in the checked image's own pixels.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageJudgmentIssue(
            global::Ideogram.V2.ImageJudgmentIssueCategory category,
            global::Ideogram.V2.ImageJudgmentIssueSeverity severity,
            string reason,
            double confidence,
            global::Ideogram.V2.ImageJudgmentBox? box)
        {
            this.Category = category;
            this.Severity = severity;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Confidence = confidence;
            this.Box = box;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageJudgmentIssue" /> class.
        /// </summary>
        public ImageJudgmentIssue()
        {
        }

    }
}