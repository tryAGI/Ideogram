
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
            typeof(global::Ideogram.JsonConverters.InternalTestingEnumFieldJsonConverter),

            typeof(global::Ideogram.JsonConverters.InternalTestingEnumFieldNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.MagicPromptVersionEnumJsonConverter),

            typeof(global::Ideogram.JsonConverters.MagicPromptVersionEnumNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.ModelEnumJsonConverter),

            typeof(global::Ideogram.JsonConverters.ModelEnumNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.TextSpanV3FontFxItemJsonConverter),

            typeof(global::Ideogram.JsonConverters.TextSpanV3FontFxItemNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.TextItemV3AlignmentJsonConverter),

            typeof(global::Ideogram.JsonConverters.TextItemV3AlignmentNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.TextItemV3StyleClassJsonConverter),

            typeof(global::Ideogram.JsonConverters.TextItemV3StyleClassNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.TextItemV3GlyphTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.TextItemV3GlyphTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.ToolTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.ToolTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.SegmentByJsonConverter),

            typeof(global::Ideogram.JsonConverters.SegmentByNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.UsageSourceJsonConverter),

            typeof(global::Ideogram.JsonConverters.UsageSourceNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.ModelVersionJsonConverter),

            typeof(global::Ideogram.JsonConverters.ModelVersionNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.ApiProfileTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.ApiProfileTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.ApiProfileRoleJsonConverter),

            typeof(global::Ideogram.JsonConverters.ApiProfileRoleNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.ApiKeyStatusJsonConverter),

            typeof(global::Ideogram.JsonConverters.ApiKeyStatusNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.InvoiceStatusJsonConverter),

            typeof(global::Ideogram.JsonConverters.InvoiceStatusNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.DatasetAssetFailureReasonJsonConverter),

            typeof(global::Ideogram.JsonConverters.DatasetAssetFailureReasonNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.ModelStatusJsonConverter),

            typeof(global::Ideogram.JsonConverters.ModelStatusNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.TrainingRunStatusJsonConverter),

            typeof(global::Ideogram.JsonConverters.TrainingRunStatusNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.DescribeModelVersionJsonConverter),

            typeof(global::Ideogram.JsonConverters.DescribeModelVersionNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.MagicPromptOptionJsonConverter),

            typeof(global::Ideogram.JsonConverters.MagicPromptOptionNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.StyleTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.StyleTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.ResolutionV3JsonConverter),

            typeof(global::Ideogram.JsonConverters.ResolutionV3NullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.AspectRatioV3JsonConverter),

            typeof(global::Ideogram.JsonConverters.AspectRatioV3NullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.RenderingSpeedJsonConverter),

            typeof(global::Ideogram.JsonConverters.RenderingSpeedNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.ColorPalettePresetNameJsonConverter),

            typeof(global::Ideogram.JsonConverters.ColorPalettePresetNameNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.StyleTypeV3JsonConverter),

            typeof(global::Ideogram.JsonConverters.StyleTypeV3NullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.StylePresetV3JsonConverter),

            typeof(global::Ideogram.JsonConverters.StylePresetV3NullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.UpscaleFactorJsonConverter),

            typeof(global::Ideogram.JsonConverters.UpscaleFactorNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.ResolutionJsonConverter),

            typeof(global::Ideogram.JsonConverters.ResolutionNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.AspectRatioJsonConverter),

            typeof(global::Ideogram.JsonConverters.AspectRatioNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.ResolutionV4JsonConverter),

            typeof(global::Ideogram.JsonConverters.ResolutionV4NullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.AssetTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.AssetTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.SharingPermissionJsonConverter),

            typeof(global::Ideogram.JsonConverters.SharingPermissionNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.OrganizationTypeJsonConverter),

            typeof(global::Ideogram.JsonConverters.OrganizationTypeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.OrganizationRoleEnumJsonConverter),

            typeof(global::Ideogram.JsonConverters.OrganizationRoleEnumNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.ListCustomModelsScopeJsonConverter),

            typeof(global::Ideogram.JsonConverters.ListCustomModelsScopeNullableJsonConverter),

            typeof(global::Ideogram.JsonConverters.ColorPaletteWithPresetNameOrMembersJsonConverter),

            typeof(global::Ideogram.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequestV4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DescribeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.Description>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Description))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DescribeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DescribeModelVersion), TypeInfoPropertyName = "DescribeModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelEnum), TypeInfoPropertyName = "ModelEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptOption), TypeInfoPropertyName = "MagicPromptOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StyleType), TypeInfoPropertyName = "StyleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV3), TypeInfoPropertyName = "ResolutionV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatioV3), TypeInfoPropertyName = "AspectRatioV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RenderingSpeed), TypeInfoPropertyName = "RenderingSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteWithPresetNameOrMembers), TypeInfoPropertyName = "ColorPaletteWithPresetNameOrMembers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StyleTypeV3), TypeInfoPropertyName = "StyleTypeV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.StylePresetV3), TypeInfoPropertyName = "StylePresetV32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateGraphicRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateDesignRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayerizeDesignRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateTransparentImageRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleFactor), TypeInfoPropertyName = "UpscaleFactor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemixImageRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.EditImageRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TryOnRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReframeImageRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReplaceBackgroundRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InternalTestingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InternalTestingNestedObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InternalTestingNestedObjectRequiredFields))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.InternalTestingNestedObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InternalTestingEnumField), TypeInfoPropertyName = "InternalTestingEnumField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RemixImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InitialImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ReframeImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Resolution), TypeInfoPropertyName = "Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UpscaleInitialImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AspectRatio), TypeInfoPropertyName = "AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptVersionEnum), TypeInfoPropertyName = "MagicPromptVersionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationResponseV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ImageGenerationObjectV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationObjectV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationResponseV4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ImageGenerationObjectV4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageGenerationObjectV4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ResolutionV4), TypeInfoPropertyName = "ResolutionV42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayeredImageGenerationObjectV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.TextContainerV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextContainerV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ImageLayerV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageLayerV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.LayeredImageGenerationResponseV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.LayeredImageGenerationObjectV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GenerateImageSafetyError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MagicPromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InternalBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SamplingRequestParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InternalBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextSpanV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.TextSpanV3FontFxItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextSpanV3FontFxItem), TypeInfoPropertyName = "TextSpanV3FontFxItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextItemV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextItemV3Alignment), TypeInfoPropertyName = "TextItemV3Alignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextItemV3StyleClass), TypeInfoPropertyName = "TextItemV3StyleClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TextItemV3GlyphType), TypeInfoPropertyName = "TextItemV3GlyphType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.TextSpanV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.TextItemV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InternalBatchResultsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.InternalBatchResultsResponseResultsInner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InternalBatchResultsResponseResultsInner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ImageSafetyError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ManageApiSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.MetronomeLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RechargeSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Price))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RechargeSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostApiSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostApiSubscriptionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostApiSubscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostApiReactivateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetApiKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.RedactedApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.RedactedApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ManageApiStripeSubscriptionResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ApiProfileApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiProfileApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ApiKeyStatus), TypeInfoPropertyName = "ApiKeyStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PromoteOrganizationMembersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ListOrganizationInvoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.Invoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Invoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InvoiceStatus), TypeInfoPropertyName = "InvoiceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.InvoiceLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.InvoiceLineItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ListDatasetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.SharingInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SharingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.CreateDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UploadDatasetAssetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.DatasetUploadSucceededAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DatasetUploadSucceededAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.DatasetUploadFailedAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DatasetUploadFailedAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.DatasetAssetFailureReason), TypeInfoPropertyName = "DatasetAssetFailureReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.UploadDatasetAssetsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TrainDatasetModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TrainDatasetModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.CustomModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.CustomModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ModelStatus), TypeInfoPropertyName = "ModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.TrainingRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TrainingRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.TrainingRunStatus), TypeInfoPropertyName = "TrainingRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.GetModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteWithPresetName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteWithMembers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPalettePresetName), TypeInfoPropertyName = "ColorPalettePresetName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ColorPaletteMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ColorPaletteMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.AssetType), TypeInfoPropertyName = "AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.SharingPermission), TypeInfoPropertyName = "SharingPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.OrganizationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.OrganizationType), TypeInfoPropertyName = "OrganizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.OrganizationRoleEnum), TypeInfoPropertyName = "OrganizationRoleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.OrganizationAvatarObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.PostInternalTesting200Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ModelVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ToolType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ideogram.ListCustomModelsScope), TypeInfoPropertyName = "ListCustomModelsScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ideogram.ModelStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.Description>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.InternalTestingNestedObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ImageGenerationObjectV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ImageGenerationObjectV4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.TextContainerV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ImageLayerV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.LayeredImageGenerationObjectV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.TextSpanV3FontFxItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.TextSpanV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.TextItemV3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.InternalBatchResultsResponseResultsInner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.RedactedApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.SpendCommitInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.UsageSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ToolUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ApiProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ApiProfileApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ApiOrganizationUserSuggestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.OrganizationMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.OrganizationMemberOperationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.LiteOrganizationMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.Invoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.InvoiceLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.SharingInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.DatasetUploadSucceededAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.DatasetUploadFailedAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.CustomModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.TrainingRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ColorPaletteMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ModelVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ToolType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ideogram.ModelStatus>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}