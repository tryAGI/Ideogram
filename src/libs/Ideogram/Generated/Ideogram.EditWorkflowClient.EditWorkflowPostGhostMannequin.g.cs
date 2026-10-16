
#nullable enable

namespace Ideogram
{
    public partial class EditWorkflowClient
    {


        private static readonly global::Ideogram.EndPointSecurityRequirement s_EditWorkflowPostGhostMannequinSecurityRequirement0 =
            new global::Ideogram.EndPointSecurityRequirement
            {
                Authorizations = new global::Ideogram.EndPointAuthorizationRequirement[]
                {                    new global::Ideogram.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Ideogram.EndPointSecurityRequirement[] s_EditWorkflowPostGhostMannequinSecurityRequirements =
            new global::Ideogram.EndPointSecurityRequirement[]
            {                s_EditWorkflowPostGhostMannequinSecurityRequirement0,
            };
        partial void PrepareEditWorkflowPostGhostMannequinArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? dryRun,
            global::Ideogram.EditWorkflowPostGhostMannequinRequest request);
        partial void PrepareEditWorkflowPostGhostMannequinRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? dryRun,
            global::Ideogram.EditWorkflowPostGhostMannequinRequest request);
        partial void ProcessEditWorkflowPostGhostMannequinResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEditWorkflowPostGhostMannequinResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Ghost Mannequin<br/>
        /// Turns photos of one garment into a ghost-mannequin product image on a<br/>
        /// clean white studio background, removing the person, mannequin, hanger,<br/>
        /// and other clothing. Upload the photos using `multipart/form-data`, in<br/>
        /// the directional fields (such as `front_image`) when the camera<br/>
        /// direction is known and in `garment_images` otherwise.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.GhostMannequinResponse> EditWorkflowPostGhostMannequinAsync(

            global::Ideogram.EditWorkflowPostGhostMannequinRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await EditWorkflowPostGhostMannequinAsResponseAsync(

                request: request,
                dryRun: dryRun,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Ghost Mannequin<br/>
        /// Turns photos of one garment into a ghost-mannequin product image on a<br/>
        /// clean white studio background, removing the person, mannequin, hanger,<br/>
        /// and other clothing. Upload the photos using `multipart/form-data`, in<br/>
        /// the directional fields (such as `front_image`) when the camera<br/>
        /// direction is known and in `garment_images` otherwise.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GhostMannequinResponse>> EditWorkflowPostGhostMannequinAsResponseAsync(

            global::Ideogram.EditWorkflowPostGhostMannequinRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEditWorkflowPostGhostMannequinArguments(
                httpClient: HttpClient,
                dryRun: ref dryRun,
                request: request);


            var __authorizations = global::Ideogram.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_EditWorkflowPostGhostMannequinSecurityRequirements,
                operationName: "EditWorkflowPostGhostMannequinAsync");

            using var __timeoutCancellationTokenSource = global::Ideogram.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Ideogram.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Ideogram.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Ideogram.PathBuilder(
                                path: "/v2/tool/ghost-mannequin",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("dry_run", dryRun?.ToString().ToLowerInvariant())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Ideogram.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (request.GarmentImages != default)
                            {

                                for (var __iGarmentImages = 0; __iGarmentImages < request.GarmentImages.Count; __iGarmentImages++)
                                {
                                    var __contentGarmentImages = new global::System.Net.Http.ByteArrayContent(request.GarmentImages[__iGarmentImages]);
                                __contentGarmentImages.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                                    __httpRequestContent.Add(
                                        content: __contentGarmentImages,
                                        name: "\"garment_images\"",
                                        fileName: $"\"file{__iGarmentImages}.bin\"");
                                    if (__contentGarmentImages.Headers.ContentDisposition != null)
                                    {
                                        __contentGarmentImages.Headers.ContentDisposition.FileNameStar = null;
                                    }
                                }

                            }
                            if (request.FrontImage != default)
                            {

                                var __contentFrontImage = new global::System.Net.Http.ByteArrayContent(request.FrontImage ?? global::System.Array.Empty<byte>());
                                __contentFrontImage.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.FrontImagename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.FrontImagename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentFrontImage,
                                    name: "\"front_image\"",
                                    fileName: request.FrontImagename != null ? $"\"{request.FrontImagename}\"" : string.Empty);
                                if (__contentFrontImage.Headers.ContentDisposition != null)
                                {
                                    __contentFrontImage.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.BackImage != default)
                            {

                                var __contentBackImage = new global::System.Net.Http.ByteArrayContent(request.BackImage ?? global::System.Array.Empty<byte>());
                                __contentBackImage.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.BackImagename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.BackImagename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentBackImage,
                                    name: "\"back_image\"",
                                    fileName: request.BackImagename != null ? $"\"{request.BackImagename}\"" : string.Empty);
                                if (__contentBackImage.Headers.ContentDisposition != null)
                                {
                                    __contentBackImage.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.LeftImage != default)
                            {

                                var __contentLeftImage = new global::System.Net.Http.ByteArrayContent(request.LeftImage ?? global::System.Array.Empty<byte>());
                                __contentLeftImage.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.LeftImagename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.LeftImagename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentLeftImage,
                                    name: "\"left_image\"",
                                    fileName: request.LeftImagename != null ? $"\"{request.LeftImagename}\"" : string.Empty);
                                if (__contentLeftImage.Headers.ContentDisposition != null)
                                {
                                    __contentLeftImage.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.RightImage != default)
                            {

                                var __contentRightImage = new global::System.Net.Http.ByteArrayContent(request.RightImage ?? global::System.Array.Empty<byte>());
                                __contentRightImage.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.RightImagename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.RightImagename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentRightImage,
                                    name: "\"right_image\"",
                                    fileName: request.RightImagename != null ? $"\"{request.RightImagename}\"" : string.Empty);
                                if (__contentRightImage.Headers.ContentDisposition != null)
                                {
                                    __contentRightImage.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.TopImage != default)
                            {

                                var __contentTopImage = new global::System.Net.Http.ByteArrayContent(request.TopImage ?? global::System.Array.Empty<byte>());
                                __contentTopImage.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.TopImagename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.TopImagename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentTopImage,
                                    name: "\"top_image\"",
                                    fileName: request.TopImagename != null ? $"\"{request.TopImagename}\"" : string.Empty);
                                if (__contentTopImage.Headers.ContentDisposition != null)
                                {
                                    __contentTopImage.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.BottomImage != default)
                            {

                                var __contentBottomImage = new global::System.Net.Http.ByteArrayContent(request.BottomImage ?? global::System.Array.Empty<byte>());
                                __contentBottomImage.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.BottomImagename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.BottomImagename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentBottomImage,
                                    name: "\"bottom_image\"",
                                    fileName: request.BottomImagename != null ? $"\"{request.BottomImagename}\"" : string.Empty);
                                if (__contentBottomImage.Headers.ContentDisposition != null)
                                {
                                    __contentBottomImage.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.OutputReferenceAssetIdentifier != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.OutputReferenceAssetIdentifier.ToJson(JsonSerializerContext)),
                                    name: "\"output_reference_asset_identifier\"");

                            }
                            if (request.OutputReferenceImage != default)
                            {

                                var __contentOutputReferenceImage = new global::System.Net.Http.ByteArrayContent(request.OutputReferenceImage ?? global::System.Array.Empty<byte>());
                                __contentOutputReferenceImage.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.OutputReferenceImagename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.OutputReferenceImagename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentOutputReferenceImage,
                                    name: "\"output_reference_image\"",
                                    fileName: request.OutputReferenceImagename != null ? $"\"{request.OutputReferenceImagename}\"" : string.Empty);
                                if (__contentOutputReferenceImage.Headers.ContentDisposition != null)
                                {
                                    __contentOutputReferenceImage.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(request.View.ToValueString()),
                                name: "\"view\"");

                            if (request.Instruction != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Instruction ?? string.Empty),
                                    name: "\"instruction\"");

                            }
                            if (request.Metadata != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Metadata ?? string.Empty),
                                    name: "\"metadata\"");

                            }
                            if (request.AspectRatio != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.AspectRatio ?? string.Empty),
                                    name: "\"aspect_ratio\"");

                            }
                            if (request.Quality != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Quality).HasValue ? (request.Quality).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"quality\"");

                            }
                            if (request.Seed != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Seed, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"seed\"");

                            }
                            if (request.WebhookUrl != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.WebhookUrl ?? string.Empty),
                                    name: "\"webhook_url\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::Ideogram.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareEditWorkflowPostGhostMannequinRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    dryRun: dryRun,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Ideogram.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Ideogram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "EditWorkflowPostGhostMannequin",
                                methodName: "EditWorkflowPostGhostMannequinAsync",
                                pathTemplate: "\"/v2/tool/ghost-mannequin\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Ideogram.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Ideogram.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Ideogram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "EditWorkflowPostGhostMannequin",
                                methodName: "EditWorkflowPostGhostMannequinAsync",
                                pathTemplate: "\"/v2/tool/ghost-mannequin\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Ideogram.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Ideogram.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Ideogram.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Ideogram.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Ideogram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "EditWorkflowPostGhostMannequin",
                                methodName: "EditWorkflowPostGhostMannequinAsync",
                                pathTemplate: "\"/v2/tool/ghost-mannequin\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Ideogram.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessEditWorkflowPostGhostMannequinResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Ideogram.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Ideogram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "EditWorkflowPostGhostMannequin",
                                methodName: "EditWorkflowPostGhostMannequinAsync",
                                pathTemplate: "\"/v2/tool/ghost-mannequin\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Ideogram.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Ideogram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "EditWorkflowPostGhostMannequin",
                                methodName: "EditWorkflowPostGhostMannequinAsync",
                                pathTemplate: "\"/v2/tool/ghost-mannequin\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Invalid input provided.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                string? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_400, typeof(string), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_400, typeof(string), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Ideogram.ApiException<string>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Unauthorized.
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                string? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_401, typeof(string), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_401, typeof(string), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::Ideogram.ApiException<string>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Insufficient credits or quota.
                            if ((int)__response.StatusCode == 402)
                            {
                                string? __content_402 = null;
                                global::System.Exception? __exception_402 = null;
                                global::Ideogram.GenerationErrorResponse? __value_402 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_402 = global::Ideogram.GenerationErrorResponse.FromJson(__content_402, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_402 = global::Ideogram.GenerationErrorResponse.FromJson(__content_402, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_402 = __ex;
                                }


                                throw global::Ideogram.ApiException<global::Ideogram.GenerationErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_402,
                                    responseBody: __content_402,
                                    responseObject: __value_402,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Not authorized to create ghost-mannequin images.
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                string? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_403, typeof(string), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_403, typeof(string), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::Ideogram.ApiException<string>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // An input asset was not found or is not readable.
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                string? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_404, typeof(string), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_404, typeof(string), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Ideogram.ApiException<string>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The combined raw image uploads exceed 100 MB.
                            if ((int)__response.StatusCode == 413)
                            {
                                string? __content_413 = null;
                                global::System.Exception? __exception_413 = null;
                                string? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_413, typeof(string), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_413, typeof(string), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }


                                throw global::Ideogram.ApiException<string>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_413,
                                    responseBody: __content_413,
                                    responseObject: __value_413,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The instruction did not pass prompt safety validation.
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                string? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_422, typeof(string), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_422, typeof(string), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::Ideogram.ApiException<string>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Too many requests.
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::Ideogram.GenerationErrorResponse? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::Ideogram.GenerationErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::Ideogram.GenerationErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::Ideogram.ApiException<global::Ideogram.GenerationErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessEditWorkflowPostGhostMannequinResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Ideogram.GhostMannequinResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GhostMannequinResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Ideogram.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Ideogram.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Ideogram.GhostMannequinResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GhostMannequinResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Ideogram.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Ideogram.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Ghost Mannequin<br/>
        /// Turns photos of one garment into a ghost-mannequin product image on a<br/>
        /// clean white studio background, removing the person, mannequin, hanger,<br/>
        /// and other clothing. Upload the photos using `multipart/form-data`, in<br/>
        /// the directional fields (such as `front_image`) when the camera<br/>
        /// direction is known and in `garment_images` otherwise.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="garmentImages">
        /// Additional photos of the same garment, up to 50 MB each. JPEG,<br/>
        /// PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and MPO are supported.<br/>
        /// Multipart requests only.
        /// </param>
        /// <param name="frontImage">
        /// Optional front-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="frontImagename">
        /// Optional front-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="backImage">
        /// Optional back-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="backImagename">
        /// Optional back-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="leftImage">
        /// Optional left-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="leftImagename">
        /// Optional left-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="rightImage">
        /// Optional right-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="rightImagename">
        /// Optional right-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="topImage">
        /// Optional top-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="topImagename">
        /// Optional top-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="bottomImage">
        /// Optional bottom-view garment photo, up to 50 MB. Multipart<br/>
        /// requests only.
        /// </param>
        /// <param name="bottomImagename">
        /// Optional bottom-view garment photo, up to 50 MB. Multipart<br/>
        /// requests only.
        /// </param>
        /// <param name="outputReferenceAssetIdentifier">
        /// An identifier for an ideogram asset.
        /// </param>
        /// <param name="outputReferenceImage">
        /// Optional presentation example, up to 50 MB. Multipart requests only.<br/>
        /// Guides pose, framing, and lighting without copying its garment,<br/>
        /// colors, text, or branding. Garment photos remain authoritative for<br/>
        /// product identity; view and aspect_ratio take precedence, and the<br/>
        /// background remains white. Does not replace a required garment photo.<br/>
        /// Mutually exclusive with `output_reference_asset_identifier`.
        /// </param>
        /// <param name="outputReferenceImagename">
        /// Optional presentation example, up to 50 MB. Multipart requests only.<br/>
        /// Guides pose, framing, and lighting without copying its garment,<br/>
        /// colors, text, or branding. Garment photos remain authoritative for<br/>
        /// product identity; view and aspect_ratio take precedence, and the<br/>
        /// background remains white. Does not replace a required garment photo.<br/>
        /// Mutually exclusive with `output_reference_asset_identifier`.
        /// </param>
        /// <param name="view">
        /// Camera view for the output garment.
        /// </param>
        /// <param name="instruction">
        /// Optional reconstruction guidance or identity-critical garment<br/>
        /// details to check against the photos. The output always uses a clean<br/>
        /// white studio background.
        /// </param>
        /// <param name="metadata">
        /// Optional JSON object serialized as a string containing factual<br/>
        /// product context, such as title, brand, category, color, material,<br/>
        /// item code, and exact printed text. Metadata helps disambiguate the<br/>
        /// garment photos but does not add features they do not show.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Defaults to `1:1` when omitted. Supported<br/>
        /// values are `1:1`, `3:4`, `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
        /// </param>
        /// <param name="webhookUrl">
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.GhostMannequinResponse> EditWorkflowPostGhostMannequinAsync(
            global::Ideogram.V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView view,
            bool? dryRun = default,
            global::System.Collections.Generic.IList<byte[]>? garmentImages = default,
            byte[]? frontImage = default,
            string? frontImagename = default,
            byte[]? backImage = default,
            string? backImagename = default,
            byte[]? leftImage = default,
            string? leftImagename = default,
            byte[]? rightImage = default,
            string? rightImagename = default,
            byte[]? topImage = default,
            string? topImagename = default,
            byte[]? bottomImage = default,
            string? bottomImagename = default,
            global::Ideogram.AssetIdentifier? outputReferenceAssetIdentifier = default,
            byte[]? outputReferenceImage = default,
            string? outputReferenceImagename = default,
            string? instruction = default,
            string? metadata = default,
            string? aspectRatio = default,
            global::Ideogram.GhostMannequinQuality? quality = default,
            int? seed = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Ideogram.EditWorkflowPostGhostMannequinRequest
            {
                GarmentImages = garmentImages,
                FrontImage = frontImage,
                FrontImagename = frontImagename,
                BackImage = backImage,
                BackImagename = backImagename,
                LeftImage = leftImage,
                LeftImagename = leftImagename,
                RightImage = rightImage,
                RightImagename = rightImagename,
                TopImage = topImage,
                TopImagename = topImagename,
                BottomImage = bottomImage,
                BottomImagename = bottomImagename,
                OutputReferenceAssetIdentifier = outputReferenceAssetIdentifier,
                OutputReferenceImage = outputReferenceImage,
                OutputReferenceImagename = outputReferenceImagename,
                View = view,
                Instruction = instruction,
                Metadata = metadata,
                AspectRatio = aspectRatio,
                Quality = quality,
                Seed = seed,
                WebhookUrl = webhookUrl,
            };

            return await EditWorkflowPostGhostMannequinAsync(
                dryRun: dryRun,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}