
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ApiProfileApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiProfileApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InvoiceStatus), TypeInfoPropertyName = "InvoiceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ManageApiSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MetronomeLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RechargeSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Price))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RechargeSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostApiSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostApiSubscriptionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostApiSubscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ManageApiCreditSummaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.CreditGrant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.CreditGrant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostApiReactivateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetApiKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.RedactedApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RedactedApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.CreateApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiKeyStatus), TypeInfoPropertyName = "ApiKeyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PatchApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ManageApiStripeSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ManageApiPaymentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetApiTermsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiTerms))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostApiTermsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostAddCreditsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostAddCreditsError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostAddCreditsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetUserCreditsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SpendCommitInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.SpendCommitInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SpendCommitInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetUsageInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.UsageSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UsageSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ToolUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolType), TypeInfoPropertyName = "ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelVersion), TypeInfoPropertyName = "ModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SegmentBy), TypeInfoPropertyName = "SegmentBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UsageSource), TypeInfoPropertyName = "UsageSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetApiProfilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ApiProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiProfileType), TypeInfoPropertyName = "ApiProfileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiProfileRole), TypeInfoPropertyName = "ApiProfileRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpdateOrganizationApiPropertiesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpdateOrganizationApiPropertiesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetApiOrganizationUserSuggestionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ApiOrganizationUserSuggestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiOrganizationUserSuggestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetOrganizationMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.OrganizationMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.OrganizationMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.CreateApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetApiKeysV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.OrganizationMemberOperationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.OrganizationMemberOperationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.OrganizationMemberOperationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AddOrganizationMembersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.LiteOrganizationMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LiteOrganizationMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemoveOrganizationMembersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PromoteOrganizationAdminsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DemoteOrganizationAdminsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.CancelOrganizationInviteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResendOrganizationInviteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ListOrganizationInvoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.Invoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Invoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.InvoiceLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InvoiceLineItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetOrganizationBillingPortalResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ModelVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ToolType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InvoiceStatus?), TypeInfoPropertyName = "NullableInvoiceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiKeyStatus?), TypeInfoPropertyName = "NullableApiKeyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ToolType?), TypeInfoPropertyName = "NullableToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelVersion?), TypeInfoPropertyName = "NullableModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SegmentBy?), TypeInfoPropertyName = "NullableSegmentBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UsageSource?), TypeInfoPropertyName = "NullableUsageSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiProfileType?), TypeInfoPropertyName = "NullableApiProfileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiProfileRole?), TypeInfoPropertyName = "NullableApiProfileRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ApiProfileApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.CreditGrant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.RedactedApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.SpendCommitInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.UsageSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ToolUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ApiProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ApiOrganizationUserSuggestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.OrganizationMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.OrganizationMemberOperationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.LiteOrganizationMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.Invoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.InvoiceLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ModelVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ToolType>))]
    internal sealed partial class ManageSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManageSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ManageSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ManageSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Ideogram.ApiKeyStatus)

                    || typeToConvert == typeof(global::Ideogram.ApiKeyStatus?)

                    || typeToConvert == typeof(global::Ideogram.ToolType)

                    || typeToConvert == typeof(global::Ideogram.ToolType?)

                    || typeToConvert == typeof(global::Ideogram.SegmentBy)

                    || typeToConvert == typeof(global::Ideogram.SegmentBy?)

                    || typeToConvert == typeof(global::Ideogram.UsageSource)

                    || typeToConvert == typeof(global::Ideogram.UsageSource?)

                    || typeToConvert == typeof(global::Ideogram.ModelVersion)

                    || typeToConvert == typeof(global::Ideogram.ModelVersion?)

                    || typeToConvert == typeof(global::Ideogram.ApiProfileType)

                    || typeToConvert == typeof(global::Ideogram.ApiProfileType?)

                    || typeToConvert == typeof(global::Ideogram.ApiProfileRole)

                    || typeToConvert == typeof(global::Ideogram.ApiProfileRole?)

                    || typeToConvert == typeof(global::Ideogram.InvoiceStatus)

                    || typeToConvert == typeof(global::Ideogram.InvoiceStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Ideogram.ApiKeyStatus))
                {
                    return new global::Ideogram.JsonConverters.ApiKeyStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ApiKeyStatus?))
                {
                    return new global::Ideogram.JsonConverters.ApiKeyStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ToolType))
                {
                    return new global::Ideogram.JsonConverters.ToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ToolType?))
                {
                    return new global::Ideogram.JsonConverters.ToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SegmentBy))
                {
                    return new global::Ideogram.JsonConverters.SegmentByJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.SegmentBy?))
                {
                    return new global::Ideogram.JsonConverters.SegmentByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.UsageSource))
                {
                    return new global::Ideogram.JsonConverters.UsageSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.UsageSource?))
                {
                    return new global::Ideogram.JsonConverters.UsageSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ModelVersion))
                {
                    return new global::Ideogram.JsonConverters.ModelVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ModelVersion?))
                {
                    return new global::Ideogram.JsonConverters.ModelVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ApiProfileType))
                {
                    return new global::Ideogram.JsonConverters.ApiProfileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ApiProfileType?))
                {
                    return new global::Ideogram.JsonConverters.ApiProfileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ApiProfileRole))
                {
                    return new global::Ideogram.JsonConverters.ApiProfileRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.ApiProfileRole?))
                {
                    return new global::Ideogram.JsonConverters.ApiProfileRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.InvoiceStatus))
                {
                    return new global::Ideogram.JsonConverters.InvoiceStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Ideogram.InvoiceStatus?))
                {
                    return new global::Ideogram.JsonConverters.InvoiceStatusNullableJsonConverter();
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
                    0 => new ManageSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}