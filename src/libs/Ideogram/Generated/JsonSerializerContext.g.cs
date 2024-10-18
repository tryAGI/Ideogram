
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::Ideogram.JsonConverters.AspectRatioJsonConverter),
            typeof(global::Ideogram.JsonConverters.AspectRatioNullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.ModelEnumJsonConverter),
            typeof(global::Ideogram.JsonConverters.ModelEnumNullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.MagicPromptOptionJsonConverter),
            typeof(global::Ideogram.JsonConverters.MagicPromptOptionNullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.StyleTypeJsonConverter),
            typeof(global::Ideogram.JsonConverters.StyleTypeNullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.ResolutionJsonConverter),
            typeof(global::Ideogram.JsonConverters.ResolutionNullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.ColorPalettePresetNameJsonConverter),
            typeof(global::Ideogram.JsonConverters.ColorPalettePresetNameNullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.InternalTestingEnumFieldJsonConverter),
            typeof(global::Ideogram.JsonConverters.InternalTestingEnumFieldNullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.ColorPaletteWithPresetNameOrMembersJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}