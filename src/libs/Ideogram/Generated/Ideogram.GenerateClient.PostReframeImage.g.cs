
#nullable enable

namespace Ideogram
{
    public partial class GenerateClient
    {
        partial void PreparePostReframeImageArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Ideogram.ReframeImageRequest request);
        partial void PreparePostReframeImageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Ideogram.ReframeImageRequest request);
        partial void ProcessPostReframeImageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostReframeImageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Reframe<br/>
        /// Reframe a square image to a chosen resolution. The supported image formats include JPEG, PNG, and WebP.<br/>
        /// Image links are available for a limited period of time; if you would like to keep the image, you must download it
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageResponse> PostReframeImageAsync(
            global::Ideogram.ReframeImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostReframeImageArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/reframe",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
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
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.ImageFile ?? global::System.Array.Empty<byte>()),
                name: "image_file",
                fileName: request.ImageFilename ?? string.Empty);
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Resolution.ToValueString()}"),
                name: "resolution");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Model.ToValueString()}"),
                name: "model");
            if (request.NumImages != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.NumImages}"),
                    name: "num_images");
            } 
            if (request.Seed != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Seed}"),
                    name: "seed");
            } 
            if (request.StyleType != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.StyleType?.ToValueString()}"),
                    name: "style_type");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePostReframeImageRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPostReframeImageResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                }

                throw new global::Ideogram.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                }

                throw new global::Ideogram.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Prompt or Image failed the safety checks.
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::Ideogram.GenerateImageSafetyError? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::Ideogram.GenerateImageSafetyError.FromJson(__content_422, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::Ideogram.GenerateImageSafetyError.FromJsonStreamAsync(__contentStream_422, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Ideogram.ApiException<global::Ideogram.GenerateImageSafetyError>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                if (ReadResponseAsString)
                {
                    __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    var __contentStream_429 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                }

                throw new global::Ideogram.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessPostReframeImageResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Ideogram.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::Ideogram.GenerateImageResponse.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Ideogram.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::Ideogram.GenerateImageResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Reframe<br/>
        /// Reframe a square image to a chosen resolution. The supported image formats include JPEG, PNG, and WebP.<br/>
        /// Image links are available for a limited period of time; if you would like to keep the image, you must download it
        /// </summary>
        /// <param name="imageFile">
        /// The image being reframed; only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imageFilename">
        /// The image being reframed; only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="resolution">
        /// (For model_version for 2.0 only, cannot be used in conjunction with aspect_ratio) The resolution to use for image generation, represented in width x height. If not specified, defaults to using aspect_ratio.<br/>
        /// Example: RESOLUTION_1024_1024
        /// </param>
        /// <param name="model">
        /// The model used to generate an image or edit one. /generate and /remix supports all model types, however, /edit is only supported for V_2 and V_2_TURBO.<br/>
        /// Default Value: V_2<br/>
        /// Example: V_2_TURBO
        /// </param>
        /// <param name="numImages">
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Example: 12345
        /// </param>
        /// <param name="styleType">
        /// The style type to generate with; this is only applicable for models V_2 and above and should not be specified for model versions V_1.<br/>
        /// Example: REALISTIC
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageResponse> PostReframeImageAsync(
            byte[] imageFile,
            string imageFilename,
            global::Ideogram.Resolution resolution,
            global::Ideogram.ModelEnum model,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.StyleType? styleType = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Ideogram.ReframeImageRequest
            {
                ImageFile = imageFile,
                ImageFilename = imageFilename,
                Resolution = resolution,
                Model = model,
                NumImages = numImages,
                Seed = seed,
                StyleType = styleType,
            };

            return await PostReframeImageAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}