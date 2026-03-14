
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"badge":"badge","subscription_plan_id":"subscription_plan_id","display_handle":"display_handle","user_id":"user_id","photo_url":"photo_url"}
    /// </summary>
    public sealed partial class User
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_handle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayHandle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photo_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhotoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_plan_id")]
        public string? SubscriptionPlanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("badge")]
        public string? Badge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="displayHandle"></param>
        /// <param name="photoUrl"></param>
        /// <param name="subscriptionPlanId"></param>
        /// <param name="badge"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public User(
            string userId,
            string displayHandle,
            string photoUrl,
            string? subscriptionPlanId,
            string? badge)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.DisplayHandle = displayHandle ?? throw new global::System.ArgumentNullException(nameof(displayHandle));
            this.PhotoUrl = photoUrl ?? throw new global::System.ArgumentNullException(nameof(photoUrl));
            this.SubscriptionPlanId = subscriptionPlanId;
            this.Badge = badge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        public User()
        {
        }
    }
}