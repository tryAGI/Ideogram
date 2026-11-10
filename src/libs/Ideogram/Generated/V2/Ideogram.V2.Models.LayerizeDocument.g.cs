
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// Original editable document; URLs are added when served and are never stored.
    /// </summary>
    public sealed partial class LayerizeDocument
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizeDocumentSchemaVersionJsonConverter))]
        public global::Ideogram.V2.LayerizeDocumentSchemaVersion SchemaVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canvas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.LayerizeCanvas Canvas { get; set; }

        /// <summary>
        /// Layers in back-to-front paint order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizeDocumentLayersInner> Layers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeDocument" /> class.
        /// </summary>
        /// <param name="canvas"></param>
        /// <param name="layers">
        /// Layers in back-to-front paint order.
        /// </param>
        /// <param name="schemaVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeDocument(
            global::Ideogram.V2.LayerizeCanvas canvas,
            global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizeDocumentLayersInner> layers,
            global::Ideogram.V2.LayerizeDocumentSchemaVersion schemaVersion)
        {
            this.SchemaVersion = schemaVersion;
            this.Canvas = canvas ?? throw new global::System.ArgumentNullException(nameof(canvas));
            this.Layers = layers ?? throw new global::System.ArgumentNullException(nameof(layers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeDocument" /> class.
        /// </summary>
        public LayerizeDocument()
        {
        }

    }
}