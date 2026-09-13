
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInner), TypeInfoPropertyName = "GenerationResponseDataInner2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageObjectWithoutPromptOrSeed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.DetectedTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.VideoObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizeDesignIdeogramV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.LayerizedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizedImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizedImageObjectObjectType), TypeInfoPropertyName = "LayerizedImageObjectObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizeDesignIdeogramV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockAlignment), TypeInfoPropertyName = "DetectedTextBlockAlignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.DetectedTextBlockFormattingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockFormattingItem), TypeInfoPropertyName = "DetectedTextBlockFormattingItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockRole), TypeInfoPropertyName = "DetectedTextBlockRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType), TypeInfoPropertyName = "AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationResponseDataInner?), TypeInfoPropertyName = "NullableGenerationResponseDataInner2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizedImageObjectObjectType?), TypeInfoPropertyName = "NullableLayerizedImageObjectObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockAlignment?), TypeInfoPropertyName = "NullableDetectedTextBlockAlignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockFormattingItem?), TypeInfoPropertyName = "NullableDetectedTextBlockFormattingItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DetectedTextBlockRole?), TypeInfoPropertyName = "NullableDetectedTextBlockRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType?), TypeInfoPropertyName = "NullableAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.DetectedTextBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.LayerizedImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.DetectedTextBlockFormattingItem>))]
    internal sealed partial class DesignSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DesignSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DesignSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DesignSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Ideogram.JsonConverters.GenerationResponseDataInnerJsonConverter());
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
                    typeToConvert == typeof(global::Ideogram.LayerizedImageObjectObjectType)

                    || typeToConvert == typeof(global::Ideogram.LayerizedImageObjectObjectType?)

                    || typeToConvert == typeof(global::Ideogram.DetectedTextBlockAlignment)

                    || typeToConvert == typeof(global::Ideogram.DetectedTextBlockAlignment?)

                    || typeToConvert == typeof(global::Ideogram.DetectedTextBlockFormattingItem)

                    || typeToConvert == typeof(global::Ideogram.DetectedTextBlockFormattingItem?)

                    || typeToConvert == typeof(global::Ideogram.DetectedTextBlockRole)

                    || typeToConvert == typeof(global::Ideogram.DetectedTextBlockRole?)

                    || typeToConvert == typeof(global::Ideogram.AssetType)

                    || typeToConvert == typeof(global::Ideogram.AssetType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Ideogram.LayerizedImageObjectObjectType))
                {
                    return new global::Ideogram.JsonConverters.LayerizedImageObjectObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.LayerizedImageObjectObjectType?))
                {
                    return new global::Ideogram.JsonConverters.LayerizedImageObjectObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.DetectedTextBlockAlignment))
                {
                    return new global::Ideogram.JsonConverters.DetectedTextBlockAlignmentJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.DetectedTextBlockAlignment?))
                {
                    return new global::Ideogram.JsonConverters.DetectedTextBlockAlignmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.DetectedTextBlockFormattingItem))
                {
                    return new global::Ideogram.JsonConverters.DetectedTextBlockFormattingItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.DetectedTextBlockFormattingItem?))
                {
                    return new global::Ideogram.JsonConverters.DetectedTextBlockFormattingItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.DetectedTextBlockRole))
                {
                    return new global::Ideogram.JsonConverters.DetectedTextBlockRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.DetectedTextBlockRole?))
                {
                    return new global::Ideogram.JsonConverters.DetectedTextBlockRoleNullableJsonConverter();
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
                    0 => new DesignSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}