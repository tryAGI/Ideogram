
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The compositional breakdown of a V4 prompt — background plus an ordered list of elements.<br/>
    /// Example: {"background":"background","elements":[{"bbox":[0,0,1000,1000],"type":"obj","desc":"desc","color_palette":["#FFD700","#FFD700"]},{"bbox":[0,0,1000,1000],"type":"obj","desc":"desc","color_palette":["#FFD700","#FFD700"]}]}
    /// </summary>
    public sealed partial class V4CompositionalDeconstruction
    {
        /// <summary>
        /// Description of the background of the scene.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Background { get; set; }

        /// <summary>
        /// Ordered list of elements (objects and text) composing the scene.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elements")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.V4PromptElement> Elements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V4CompositionalDeconstruction" /> class.
        /// </summary>
        /// <param name="background">
        /// Description of the background of the scene.
        /// </param>
        /// <param name="elements">
        /// Ordered list of elements (objects and text) composing the scene.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V4CompositionalDeconstruction(
            string background,
            global::System.Collections.Generic.IList<global::Ideogram.V4PromptElement> elements)
        {
            this.Background = background ?? throw new global::System.ArgumentNullException(nameof(background));
            this.Elements = elements ?? throw new global::System.ArgumentNullException(nameof(elements));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V4CompositionalDeconstruction" /> class.
        /// </summary>
        public V4CompositionalDeconstruction()
        {
        }

    }
}