
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
            typeof(global::AutoSDK.JsonConverters.AspectRatioJsonConverter),
            typeof(global::AutoSDK.JsonConverters.AspectRatioNullableJsonConverter),
            typeof(global::AutoSDK.JsonConverters.ModelEnumJsonConverter),
            typeof(global::AutoSDK.JsonConverters.ModelEnumNullableJsonConverter),
            typeof(global::AutoSDK.JsonConverters.MagicPromptOptionJsonConverter),
            typeof(global::AutoSDK.JsonConverters.MagicPromptOptionNullableJsonConverter),
            typeof(global::AutoSDK.JsonConverters.StyleTypeJsonConverter),
            typeof(global::AutoSDK.JsonConverters.StyleTypeNullableJsonConverter),
            typeof(global::AutoSDK.JsonConverters.ResolutionJsonConverter),
            typeof(global::AutoSDK.JsonConverters.ResolutionNullableJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}