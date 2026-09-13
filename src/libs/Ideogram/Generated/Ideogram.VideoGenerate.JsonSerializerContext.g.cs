
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SeedDance2AspectRatio), TypeInfoPropertyName = "SeedDance2AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SeedDance2Resolution), TypeInfoPropertyName = "SeedDance2Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason), TypeInfoPropertyName = "GenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoSeedDance2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoSeedDance2TextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoSeedDance2ImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoSeedDance25Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoSeedDance25TextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SeedDance25Resolution), TypeInfoPropertyName = "SeedDance25Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoSeedDance25ImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoMinimaxH3TextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MinimaxH3AspectRatio), TypeInfoPropertyName = "MinimaxH3AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MinimaxH3Resolution), TypeInfoPropertyName = "MinimaxH3Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoMinimaxH3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoMinimaxH3ImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoKlingV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoKlingV3StandardTextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.KlingV3AspectRatio), TypeInfoPropertyName = "KlingV3AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.KlingV3ShotType), TypeInfoPropertyName = "KlingV3ShotType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateVideoKlingV3StandardImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType), TypeInfoPropertyName = "AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SeedDance2AspectRatio?), TypeInfoPropertyName = "NullableSeedDance2AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SeedDance2Resolution?), TypeInfoPropertyName = "NullableSeedDance2Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerationRejectReason?), TypeInfoPropertyName = "NullableGenerationRejectReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SeedDance25Resolution?), TypeInfoPropertyName = "NullableSeedDance25Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MinimaxH3AspectRatio?), TypeInfoPropertyName = "NullableMinimaxH3AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MinimaxH3Resolution?), TypeInfoPropertyName = "NullableMinimaxH3Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.KlingV3AspectRatio?), TypeInfoPropertyName = "NullableKlingV3AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.KlingV3ShotType?), TypeInfoPropertyName = "NullableKlingV3ShotType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType?), TypeInfoPropertyName = "NullableAssetType2")]
    internal sealed partial class VideoGenerateSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoGenerateSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerateSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VideoGenerateSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::Ideogram.SeedDance25Resolution)

                    || typeToConvert == typeof(global::Ideogram.SeedDance25Resolution?)

                    || typeToConvert == typeof(global::Ideogram.SeedDance2AspectRatio)

                    || typeToConvert == typeof(global::Ideogram.SeedDance2AspectRatio?)

                    || typeToConvert == typeof(global::Ideogram.SeedDance2Resolution)

                    || typeToConvert == typeof(global::Ideogram.SeedDance2Resolution?)

                    || typeToConvert == typeof(global::Ideogram.AssetType)

                    || typeToConvert == typeof(global::Ideogram.AssetType?)

                    || typeToConvert == typeof(global::Ideogram.MinimaxH3AspectRatio)

                    || typeToConvert == typeof(global::Ideogram.MinimaxH3AspectRatio?)

                    || typeToConvert == typeof(global::Ideogram.MinimaxH3Resolution)

                    || typeToConvert == typeof(global::Ideogram.MinimaxH3Resolution?)

                    || typeToConvert == typeof(global::Ideogram.KlingV3AspectRatio)

                    || typeToConvert == typeof(global::Ideogram.KlingV3AspectRatio?)

                    || typeToConvert == typeof(global::Ideogram.KlingV3ShotType)

                    || typeToConvert == typeof(global::Ideogram.KlingV3ShotType?);
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

                if (typeToConvert == typeof(global::Ideogram.SeedDance25Resolution))
                {
                    return new global::Ideogram.JsonConverters.SeedDance25ResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SeedDance25Resolution?))
                {
                    return new global::Ideogram.JsonConverters.SeedDance25ResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SeedDance2AspectRatio))
                {
                    return new global::Ideogram.JsonConverters.SeedDance2AspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SeedDance2AspectRatio?))
                {
                    return new global::Ideogram.JsonConverters.SeedDance2AspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SeedDance2Resolution))
                {
                    return new global::Ideogram.JsonConverters.SeedDance2ResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SeedDance2Resolution?))
                {
                    return new global::Ideogram.JsonConverters.SeedDance2ResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AssetType))
                {
                    return new global::Ideogram.JsonConverters.AssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AssetType?))
                {
                    return new global::Ideogram.JsonConverters.AssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MinimaxH3AspectRatio))
                {
                    return new global::Ideogram.JsonConverters.MinimaxH3AspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MinimaxH3AspectRatio?))
                {
                    return new global::Ideogram.JsonConverters.MinimaxH3AspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MinimaxH3Resolution))
                {
                    return new global::Ideogram.JsonConverters.MinimaxH3ResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MinimaxH3Resolution?))
                {
                    return new global::Ideogram.JsonConverters.MinimaxH3ResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.KlingV3AspectRatio))
                {
                    return new global::Ideogram.JsonConverters.KlingV3AspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.KlingV3AspectRatio?))
                {
                    return new global::Ideogram.JsonConverters.KlingV3AspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.KlingV3ShotType))
                {
                    return new global::Ideogram.JsonConverters.KlingV3ShotTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.KlingV3ShotType?))
                {
                    return new global::Ideogram.JsonConverters.KlingV3ShotTypeNullableJsonConverter();
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
                    0 => new VideoGenerateSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}