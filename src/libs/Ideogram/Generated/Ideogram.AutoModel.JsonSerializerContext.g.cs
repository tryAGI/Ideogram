
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV4), TypeInfoPropertyName = "AspectRatioV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptOption), TypeInfoPropertyName = "MagicPromptOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteWithPresetNameOrMembers), TypeInfoPropertyName = "ColorPaletteWithPresetNameOrMembers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StyleTypeV3), TypeInfoPropertyName = "StyleTypeV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StylePresetV3), TypeInfoPropertyName = "StylePresetV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason), TypeInfoPropertyName = "GenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.GeneratedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GeneratedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolTextToImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolTextToImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolTextToImageRequestResolutionTier), TypeInfoPropertyName = "ToolTextToImageRequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolImageToImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolImageToImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolImageToImageRequestResolutionTier), TypeInfoPropertyName = "ToolImageToImageRequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolRemixResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolRemixRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolRemixRequestResolutionTier), TypeInfoPropertyName = "ToolRemixRequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteWithPresetName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteWithMembers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPalettePresetName), TypeInfoPropertyName = "ColorPalettePresetName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ColorPaletteMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType), TypeInfoPropertyName = "AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV4?), TypeInfoPropertyName = "NullableAspectRatioV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptOption?), TypeInfoPropertyName = "NullableMagicPromptOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteWithPresetNameOrMembers?), TypeInfoPropertyName = "NullableColorPaletteWithPresetNameOrMembers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StyleTypeV3?), TypeInfoPropertyName = "NullableStyleTypeV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StylePresetV3?), TypeInfoPropertyName = "NullableStylePresetV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason?), TypeInfoPropertyName = "NullableGenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolTextToImageRequestResolutionTier?), TypeInfoPropertyName = "NullableToolTextToImageRequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolImageToImageRequestResolutionTier?), TypeInfoPropertyName = "NullableToolImageToImageRequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolRemixRequestResolutionTier?), TypeInfoPropertyName = "NullableToolRemixRequestResolutionTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPalettePresetName?), TypeInfoPropertyName = "NullableColorPalettePresetName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType?), TypeInfoPropertyName = "NullableAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.AssetIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.GeneratedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ColorPaletteMember>))]
    internal sealed partial class AutoModelSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoModelSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AutoModelSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AutoModelSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Ideogram.JsonConverters.ColorPaletteWithPresetNameOrMembersJsonConverter());
            options.Converters.Add(new global::Ideogram.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Ideogram.GenerationRejectReason)

                    || typeToConvert == typeof(global::Ideogram.GenerationRejectReason?)

                    || typeToConvert == typeof(global::Ideogram.ToolTextToImageRequestResolutionTier)

                    || typeToConvert == typeof(global::Ideogram.ToolTextToImageRequestResolutionTier?)

                    || typeToConvert == typeof(global::Ideogram.ToolImageToImageRequestResolutionTier)

                    || typeToConvert == typeof(global::Ideogram.ToolImageToImageRequestResolutionTier?)

                    || typeToConvert == typeof(global::Ideogram.ToolRemixRequestResolutionTier)

                    || typeToConvert == typeof(global::Ideogram.ToolRemixRequestResolutionTier?)

                    || typeToConvert == typeof(global::Ideogram.AspectRatioV4)

                    || typeToConvert == typeof(global::Ideogram.AspectRatioV4?)

                    || typeToConvert == typeof(global::Ideogram.MagicPromptOption)

                    || typeToConvert == typeof(global::Ideogram.MagicPromptOption?)

                    || typeToConvert == typeof(global::Ideogram.ColorPalettePresetName)

                    || typeToConvert == typeof(global::Ideogram.ColorPalettePresetName?)

                    || typeToConvert == typeof(global::Ideogram.StyleTypeV3)

                    || typeToConvert == typeof(global::Ideogram.StyleTypeV3?)

                    || typeToConvert == typeof(global::Ideogram.StylePresetV3)

                    || typeToConvert == typeof(global::Ideogram.StylePresetV3?)

                    || typeToConvert == typeof(global::Ideogram.AssetType)

                    || typeToConvert == typeof(global::Ideogram.AssetType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Ideogram.GenerationRejectReason))
                {
                    return new global::Ideogram.JsonConverters.GenerationRejectReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GenerationRejectReason?))
                {
                    return new global::Ideogram.JsonConverters.GenerationRejectReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ToolTextToImageRequestResolutionTier))
                {
                    return new global::Ideogram.JsonConverters.ToolTextToImageRequestResolutionTierJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ToolTextToImageRequestResolutionTier?))
                {
                    return new global::Ideogram.JsonConverters.ToolTextToImageRequestResolutionTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ToolImageToImageRequestResolutionTier))
                {
                    return new global::Ideogram.JsonConverters.ToolImageToImageRequestResolutionTierJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ToolImageToImageRequestResolutionTier?))
                {
                    return new global::Ideogram.JsonConverters.ToolImageToImageRequestResolutionTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ToolRemixRequestResolutionTier))
                {
                    return new global::Ideogram.JsonConverters.ToolRemixRequestResolutionTierJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ToolRemixRequestResolutionTier?))
                {
                    return new global::Ideogram.JsonConverters.ToolRemixRequestResolutionTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AspectRatioV4))
                {
                    return new global::Ideogram.JsonConverters.AspectRatioV4JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AspectRatioV4?))
                {
                    return new global::Ideogram.JsonConverters.AspectRatioV4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MagicPromptOption))
                {
                    return new global::Ideogram.JsonConverters.MagicPromptOptionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MagicPromptOption?))
                {
                    return new global::Ideogram.JsonConverters.MagicPromptOptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ColorPalettePresetName))
                {
                    return new global::Ideogram.JsonConverters.ColorPalettePresetNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ColorPalettePresetName?))
                {
                    return new global::Ideogram.JsonConverters.ColorPalettePresetNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.StyleTypeV3))
                {
                    return new global::Ideogram.JsonConverters.StyleTypeV3JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.StyleTypeV3?))
                {
                    return new global::Ideogram.JsonConverters.StyleTypeV3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.StylePresetV3))
                {
                    return new global::Ideogram.JsonConverters.StylePresetV3JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.StylePresetV3?))
                {
                    return new global::Ideogram.JsonConverters.StylePresetV3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AssetType))
                {
                    return new global::Ideogram.JsonConverters.AssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AssetType?))
                {
                    return new global::Ideogram.JsonConverters.AssetTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new AutoModelSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}