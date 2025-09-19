
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUserCreditsResponse
    {
        /// <summary>
        /// Represents a price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_credits")]
        public global::Ideogram.Price? AvailableCredits { get; set; }

        /// <summary>
        /// Represents a price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_spend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Price TotalSpend { get; set; }

        /// <summary>
        /// Represents a price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_daily_spend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Price AverageDailySpend { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserCreditsResponse" /> class.
        /// </summary>
        /// <param name="availableCredits">
        /// Represents a price.
        /// </param>
        /// <param name="totalSpend">
        /// Represents a price.
        /// </param>
        /// <param name="averageDailySpend">
        /// Represents a price.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUserCreditsResponse(
            global::Ideogram.Price totalSpend,
            global::Ideogram.Price averageDailySpend,
            global::Ideogram.Price? availableCredits)
        {
            this.TotalSpend = totalSpend ?? throw new global::System.ArgumentNullException(nameof(totalSpend));
            this.AverageDailySpend = averageDailySpend ?? throw new global::System.ArgumentNullException(nameof(averageDailySpend));
            this.AvailableCredits = availableCredits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserCreditsResponse" /> class.
        /// </summary>
        public GetUserCreditsResponse()
        {
        }
    }
}