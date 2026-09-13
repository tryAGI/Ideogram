
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4JsonPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV4), TypeInfoPropertyName = "AspectRatioV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV3), TypeInfoPropertyName = "AspectRatioV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StyleTypeV3), TypeInfoPropertyName = "StyleTypeV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptVersionEnum), TypeInfoPropertyName = "MagicPromptVersionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.MagicPromptRequestMessagesInner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptRequestMessagesInner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptV4Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptV4Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4StyleDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4CompositionalDeconstruction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.V4PromptElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4PromptElement), TypeInfoPropertyName = "V4PromptElement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4ObjPromptElement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4TextPromptElement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4PromptElementDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4PromptElementDiscriminatorType), TypeInfoPropertyName = "V4PromptElementDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4ObjPromptElementType), TypeInfoPropertyName = "V4ObjPromptElementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4TextPromptElementType), TypeInfoPropertyName = "V4TextPromptElementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptRequestMessagesInnerRole), TypeInfoPropertyName = "MagicPromptRequestMessagesInnerRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV4?), TypeInfoPropertyName = "NullableAspectRatioV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV3?), TypeInfoPropertyName = "NullableAspectRatioV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StyleTypeV3?), TypeInfoPropertyName = "NullableStyleTypeV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptVersionEnum?), TypeInfoPropertyName = "NullableMagicPromptVersionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4PromptElement?), TypeInfoPropertyName = "NullableV4PromptElement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4PromptElementDiscriminatorType?), TypeInfoPropertyName = "NullableV4PromptElementDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4ObjPromptElementType?), TypeInfoPropertyName = "NullableV4ObjPromptElementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.V4TextPromptElementType?), TypeInfoPropertyName = "NullableV4TextPromptElementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptRequestMessagesInnerRole?), TypeInfoPropertyName = "NullableMagicPromptRequestMessagesInnerRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.MagicPromptRequestMessagesInner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.V4PromptElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    internal sealed partial class PromptSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PromptSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PromptSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Ideogram.JsonConverters.V4PromptElementJsonConverter());
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
                    typeToConvert == typeof(global::Ideogram.V4PromptElementDiscriminatorType)

                    || typeToConvert == typeof(global::Ideogram.V4PromptElementDiscriminatorType?)

                    || typeToConvert == typeof(global::Ideogram.V4ObjPromptElementType)

                    || typeToConvert == typeof(global::Ideogram.V4ObjPromptElementType?)

                    || typeToConvert == typeof(global::Ideogram.V4TextPromptElementType)

                    || typeToConvert == typeof(global::Ideogram.V4TextPromptElementType?)

                    || typeToConvert == typeof(global::Ideogram.AspectRatioV4)

                    || typeToConvert == typeof(global::Ideogram.AspectRatioV4?)

                    || typeToConvert == typeof(global::Ideogram.AspectRatioV3)

                    || typeToConvert == typeof(global::Ideogram.AspectRatioV3?)

                    || typeToConvert == typeof(global::Ideogram.StyleTypeV3)

                    || typeToConvert == typeof(global::Ideogram.StyleTypeV3?)

                    || typeToConvert == typeof(global::Ideogram.MagicPromptVersionEnum)

                    || typeToConvert == typeof(global::Ideogram.MagicPromptVersionEnum?)

                    || typeToConvert == typeof(global::Ideogram.MagicPromptRequestMessagesInnerRole)

                    || typeToConvert == typeof(global::Ideogram.MagicPromptRequestMessagesInnerRole?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Ideogram.V4PromptElementDiscriminatorType))
                {
                    return new global::Ideogram.JsonConverters.V4PromptElementDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V4PromptElementDiscriminatorType?))
                {
                    return new global::Ideogram.JsonConverters.V4PromptElementDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V4ObjPromptElementType))
                {
                    return new global::Ideogram.JsonConverters.V4ObjPromptElementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V4ObjPromptElementType?))
                {
                    return new global::Ideogram.JsonConverters.V4ObjPromptElementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V4TextPromptElementType))
                {
                    return new global::Ideogram.JsonConverters.V4TextPromptElementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.V4TextPromptElementType?))
                {
                    return new global::Ideogram.JsonConverters.V4TextPromptElementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AspectRatioV4))
                {
                    return new global::Ideogram.JsonConverters.AspectRatioV4JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AspectRatioV4?))
                {
                    return new global::Ideogram.JsonConverters.AspectRatioV4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AspectRatioV3))
                {
                    return new global::Ideogram.JsonConverters.AspectRatioV3JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AspectRatioV3?))
                {
                    return new global::Ideogram.JsonConverters.AspectRatioV3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.StyleTypeV3))
                {
                    return new global::Ideogram.JsonConverters.StyleTypeV3JsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.StyleTypeV3?))
                {
                    return new global::Ideogram.JsonConverters.StyleTypeV3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MagicPromptVersionEnum))
                {
                    return new global::Ideogram.JsonConverters.MagicPromptVersionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MagicPromptVersionEnum?))
                {
                    return new global::Ideogram.JsonConverters.MagicPromptVersionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MagicPromptRequestMessagesInnerRole))
                {
                    return new global::Ideogram.JsonConverters.MagicPromptRequestMessagesInnerRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.MagicPromptRequestMessagesInnerRole?))
                {
                    return new global::Ideogram.JsonConverters.MagicPromptRequestMessagesInnerRoleNullableJsonConverter();
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
                    0 => new PromptSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}