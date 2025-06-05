
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
            typeof(global::Ideogram.JsonConverters.DescribeModelVersionJsonConverter),
            typeof(global::Ideogram.JsonConverters.DescribeModelVersionNullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.ModelEnumJsonConverter),
            typeof(global::Ideogram.JsonConverters.ModelEnumNullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.MagicPromptOptionJsonConverter),
            typeof(global::Ideogram.JsonConverters.MagicPromptOptionNullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.StyleTypeJsonConverter),
            typeof(global::Ideogram.JsonConverters.StyleTypeNullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.AspectRatioJsonConverter),
            typeof(global::Ideogram.JsonConverters.AspectRatioNullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.MagicPromptVersionEnumJsonConverter),
            typeof(global::Ideogram.JsonConverters.MagicPromptVersionEnumNullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.ResolutionJsonConverter),
            typeof(global::Ideogram.JsonConverters.ResolutionNullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.ColorPalettePresetNameJsonConverter),
            typeof(global::Ideogram.JsonConverters.ColorPalettePresetNameNullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.ResolutionV3JsonConverter),
            typeof(global::Ideogram.JsonConverters.ResolutionV3NullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.AspectRatioV3JsonConverter),
            typeof(global::Ideogram.JsonConverters.AspectRatioV3NullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.RenderingSpeedJsonConverter),
            typeof(global::Ideogram.JsonConverters.RenderingSpeedNullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.StyleTypeV3JsonConverter),
            typeof(global::Ideogram.JsonConverters.StyleTypeV3NullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.InternalTestingEnumFieldJsonConverter),
            typeof(global::Ideogram.JsonConverters.InternalTestingEnumFieldNullableJsonConverter),
            typeof(global::Ideogram.JsonConverters.ColorPaletteWithPresetNameOrMembersJsonConverter),
            typeof(global::Ideogram.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}