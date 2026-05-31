
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A non-text element (object, character, background detail) in the V4 prompt layout.
    /// </summary>
    public sealed partial class V4ObjPromptElement
    {
        /// <summary>
        /// Discriminator. Must be `obj`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.V4ObjPromptElementTypeJsonConverter))]
        public global::Ideogram.V4ObjPromptElementType Type { get; set; }

        /// <summary>
        /// Bounding box for an element, expressed as four integers in `[0, 1000]`<br/>
        /// with `[y_min, x_min, y_max, x_max]` semantics (row-first). Values are<br/>
        /// normalized so the canvas is `1000 x 1000` regardless of the final<br/>
        /// resolution.<br/>
        /// Example: [0, 0, 1000, 1000]
        /// </summary>
        /// <example>[0, 0, 1000, 1000]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        public global::System.Collections.Generic.IList<int>? Bbox { get; set; }

        /// <summary>
        /// Description of the object element.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Desc { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V4ObjPromptElement" /> class.
        /// </summary>
        /// <param name="desc">
        /// Description of the object element.
        /// </param>
        /// <param name="type">
        /// Discriminator. Must be `obj`.
        /// </param>
        /// <param name="bbox">
        /// Bounding box for an element, expressed as four integers in `[0, 1000]`<br/>
        /// with `[y_min, x_min, y_max, x_max]` semantics (row-first). Values are<br/>
        /// normalized so the canvas is `1000 x 1000` regardless of the final<br/>
        /// resolution.<br/>
        /// Example: [0, 0, 1000, 1000]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V4ObjPromptElement(
            string desc,
            global::Ideogram.V4ObjPromptElementType type,
            global::System.Collections.Generic.IList<int>? bbox)
        {
            this.Type = type;
            this.Bbox = bbox;
            this.Desc = desc ?? throw new global::System.ArgumentNullException(nameof(desc));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V4ObjPromptElement" /> class.
        /// </summary>
        public V4ObjPromptElement()
        {
        }

    }
}