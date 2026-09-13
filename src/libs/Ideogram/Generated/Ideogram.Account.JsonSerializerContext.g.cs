
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ListAccountApiKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ApiProfileApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiProfileApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetAccountUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.AccountUsageBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AccountUsageBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.AccountUsageLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AccountUsageLineItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AccountUsageLineItemSource), TypeInfoPropertyName = "AccountUsageLineItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AccountUsageApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AccountUsageBilledUnits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ListAccountInvoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.AccountInvoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AccountInvoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InvoiceStatus), TypeInfoPropertyName = "InvoiceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.AccountInvoiceLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AccountInvoiceLineItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiKeyStatus), TypeInfoPropertyName = "ApiKeyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetAccountUsageBucketWidth), TypeInfoPropertyName = "GetAccountUsageBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.GetAccountUsageSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetAccountUsageSource), TypeInfoPropertyName = "GetAccountUsageSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AccountUsageLineItemSource?), TypeInfoPropertyName = "NullableAccountUsageLineItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InvoiceStatus?), TypeInfoPropertyName = "NullableInvoiceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiKeyStatus?), TypeInfoPropertyName = "NullableApiKeyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetAccountUsageBucketWidth?), TypeInfoPropertyName = "NullableGetAccountUsageBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetAccountUsageSource?), TypeInfoPropertyName = "NullableGetAccountUsageSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ApiProfileApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.AccountUsageBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.AccountUsageLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.AccountInvoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.AccountInvoiceLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.GetAccountUsageSource>))]
    internal sealed partial class AccountSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccountSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AccountSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AccountSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Ideogram.AccountUsageLineItemSource)

                    || typeToConvert == typeof(global::Ideogram.AccountUsageLineItemSource?)

                    || typeToConvert == typeof(global::Ideogram.ApiKeyStatus)

                    || typeToConvert == typeof(global::Ideogram.ApiKeyStatus?)

                    || typeToConvert == typeof(global::Ideogram.InvoiceStatus)

                    || typeToConvert == typeof(global::Ideogram.InvoiceStatus?)

                    || typeToConvert == typeof(global::Ideogram.GetAccountUsageBucketWidth)

                    || typeToConvert == typeof(global::Ideogram.GetAccountUsageBucketWidth?)

                    || typeToConvert == typeof(global::Ideogram.GetAccountUsageSource)

                    || typeToConvert == typeof(global::Ideogram.GetAccountUsageSource?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Ideogram.AccountUsageLineItemSource))
                {
                    return new global::Ideogram.JsonConverters.AccountUsageLineItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.AccountUsageLineItemSource?))
                {
                    return new global::Ideogram.JsonConverters.AccountUsageLineItemSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ApiKeyStatus))
                {
                    return new global::Ideogram.JsonConverters.ApiKeyStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ApiKeyStatus?))
                {
                    return new global::Ideogram.JsonConverters.ApiKeyStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.InvoiceStatus))
                {
                    return new global::Ideogram.JsonConverters.InvoiceStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.InvoiceStatus?))
                {
                    return new global::Ideogram.JsonConverters.InvoiceStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GetAccountUsageBucketWidth))
                {
                    return new global::Ideogram.JsonConverters.GetAccountUsageBucketWidthJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GetAccountUsageBucketWidth?))
                {
                    return new global::Ideogram.JsonConverters.GetAccountUsageBucketWidthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GetAccountUsageSource))
                {
                    return new global::Ideogram.JsonConverters.GetAccountUsageSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.GetAccountUsageSource?))
                {
                    return new global::Ideogram.JsonConverters.GetAccountUsageSourceNullableJsonConverter();
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
                    0 => new AccountSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}