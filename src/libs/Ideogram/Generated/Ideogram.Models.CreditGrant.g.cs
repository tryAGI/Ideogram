
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"effective_at":"effective_at","amount_consumed":{"amount":1050,"currency_code":"USD"},"expires_at":"expires_at","amount_available":{"amount":1050,"currency_code":"USD"},"grant_id":"grant_id","name":"name","amount_issued":{"amount":1050,"currency_code":"USD"}}
    /// </summary>
    public sealed partial class CreditGrant
    {
        /// <summary>
        /// The Metronome grant identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GrantId { get; set; }

        /// <summary>
        /// The grant name as shown in Metronome (e.g. "Ideogram API Usage").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </summary>
        /// <example>{"amount":1050,"currency_code":"USD"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_issued")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Price AmountIssued { get; set; }

        /// <summary>
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </summary>
        /// <example>{"amount":1050,"currency_code":"USD"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_consumed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Price AmountConsumed { get; set; }

        /// <summary>
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </summary>
        /// <example>{"amount":1050,"currency_code":"USD"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Price AmountAvailable { get; set; }

        /// <summary>
        /// ISO-8601 timestamp when the grant becomes effective.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EffectiveAt { get; set; }

        /// <summary>
        /// ISO-8601 timestamp when the grant expires. Omitted if the grant has no expiration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditGrant" /> class.
        /// </summary>
        /// <param name="grantId">
        /// The Metronome grant identifier.
        /// </param>
        /// <param name="name">
        /// The grant name as shown in Metronome (e.g. "Ideogram API Usage").
        /// </param>
        /// <param name="amountIssued">
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </param>
        /// <param name="amountConsumed">
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </param>
        /// <param name="amountAvailable">
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </param>
        /// <param name="effectiveAt">
        /// ISO-8601 timestamp when the grant becomes effective.
        /// </param>
        /// <param name="expiresAt">
        /// ISO-8601 timestamp when the grant expires. Omitted if the grant has no expiration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditGrant(
            string grantId,
            string name,
            global::Ideogram.Price amountIssued,
            global::Ideogram.Price amountConsumed,
            global::Ideogram.Price amountAvailable,
            string effectiveAt,
            string? expiresAt)
        {
            this.GrantId = grantId ?? throw new global::System.ArgumentNullException(nameof(grantId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AmountIssued = amountIssued ?? throw new global::System.ArgumentNullException(nameof(amountIssued));
            this.AmountConsumed = amountConsumed ?? throw new global::System.ArgumentNullException(nameof(amountConsumed));
            this.AmountAvailable = amountAvailable ?? throw new global::System.ArgumentNullException(nameof(amountAvailable));
            this.EffectiveAt = effectiveAt ?? throw new global::System.ArgumentNullException(nameof(effectiveAt));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditGrant" /> class.
        /// </summary>
        public CreditGrant()
        {
        }

    }
}