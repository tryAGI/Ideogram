
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InternalTestingRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x_position")]
        public int? XPosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file")]
        public byte[]? ImageFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_filename")]
        public string? ImageFilename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("another_image_file")]
        public byte[]? AnotherImageFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("another_image_filename")]
        public string? AnotherImageFilename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("some_text")]
        public string? SomeText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nested_object")]
        public global::Ideogram.InternalTestingNestedObject? NestedObject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nested_object_required_fields")]
        public global::Ideogram.InternalTestingNestedObjectRequiredFields? NestedObjectRequiredFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_type_field")]
        public global::System.DateTime? DateTypeField { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_date_type_field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime RequiredDateTypeField { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_time_type_field")]
        public global::System.DateTime? DateTimeTypeField { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repeated_primitive_field")]
        public global::System.Collections.Generic.IList<string>? RepeatedPrimitiveField { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repeated_complex_field")]
        public global::System.Collections.Generic.IList<global::Ideogram.InternalTestingNestedObject>? RepeatedComplexField { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum_type_field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.InternalTestingEnumFieldJsonConverter))]
        public global::Ideogram.InternalTestingEnumField? EnumTypeField { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTestingRequest" /> class.
        /// </summary>
        /// <param name="xPosition"></param>
        /// <param name="imageFile"></param>
        /// <param name="imageFilename"></param>
        /// <param name="anotherImageFile"></param>
        /// <param name="anotherImageFilename"></param>
        /// <param name="someText"></param>
        /// <param name="nestedObject"></param>
        /// <param name="nestedObjectRequiredFields"></param>
        /// <param name="dateTypeField"></param>
        /// <param name="requiredDateTypeField"></param>
        /// <param name="dateTimeTypeField"></param>
        /// <param name="repeatedPrimitiveField"></param>
        /// <param name="repeatedComplexField"></param>
        /// <param name="enumTypeField"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternalTestingRequest(
            global::System.DateTime requiredDateTypeField,
            int? xPosition,
            byte[]? imageFile,
            string? imageFilename,
            byte[]? anotherImageFile,
            string? anotherImageFilename,
            string? someText,
            global::Ideogram.InternalTestingNestedObject? nestedObject,
            global::Ideogram.InternalTestingNestedObjectRequiredFields? nestedObjectRequiredFields,
            global::System.DateTime? dateTypeField,
            global::System.DateTime? dateTimeTypeField,
            global::System.Collections.Generic.IList<string>? repeatedPrimitiveField,
            global::System.Collections.Generic.IList<global::Ideogram.InternalTestingNestedObject>? repeatedComplexField,
            global::Ideogram.InternalTestingEnumField? enumTypeField)
        {
            this.RequiredDateTypeField = requiredDateTypeField;
            this.XPosition = xPosition;
            this.ImageFile = imageFile;
            this.ImageFilename = imageFilename;
            this.AnotherImageFile = anotherImageFile;
            this.AnotherImageFilename = anotherImageFilename;
            this.SomeText = someText;
            this.NestedObject = nestedObject;
            this.NestedObjectRequiredFields = nestedObjectRequiredFields;
            this.DateTypeField = dateTypeField;
            this.DateTimeTypeField = dateTimeTypeField;
            this.RepeatedPrimitiveField = repeatedPrimitiveField;
            this.RepeatedComplexField = repeatedComplexField;
            this.EnumTypeField = enumTypeField;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTestingRequest" /> class.
        /// </summary>
        public InternalTestingRequest()
        {
        }
    }
}