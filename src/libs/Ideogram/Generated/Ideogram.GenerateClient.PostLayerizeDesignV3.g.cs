
#nullable enable

namespace Ideogram
{
    public partial class GenerateClient
    {
        partial void PreparePostLayerizeDesignV3Arguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Ideogram.LayerizeDesignRequestV3 request);
        partial void PreparePostLayerizeDesignV3Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Ideogram.LayerizeDesignRequestV3 request);
        partial void ProcessPostLayerizeDesignV3Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostLayerizeDesignV3ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Layerize an existing flat graphic image with text detection and correction<br/>
        /// Processes an existing flat graphic image to detect and correct text layers without generating a new image from scratch.<br/>
        /// The uploaded image is analyzed for text content, which is then removed and returned as structured text layers with font matching, sizing, and color information.<br/>
        /// Supported image formats include JPEG, PNG, and WebP (max size 10MB).<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.LayeredImageGenerationResponseV3> PostLayerizeDesignV3Async(

            global::Ideogram.LayerizeDesignRequestV3 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostLayerizeDesignV3Arguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Ideogram.PathBuilder(
                path: "/v1/ideogram-v3/layerize-design",
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
            var __contentFlatGraphicImage = new global::System.Net.Http.ByteArrayContent(request.FlatGraphicImage ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentFlatGraphicImage,
                name: "\"flat_graphic_image\"",
                fileName: request.FlatGraphicImagename != null ? $"\"{request.FlatGraphicImagename}\"" : string.Empty);
            if (__contentFlatGraphicImage.Headers.ContentDisposition != null)
            {
                __contentFlatGraphicImage.Headers.ContentDisposition.FileNameStar = null;
            }
            if (request.Prompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Prompt}"),
                    name: "\"prompt\"");
            } 
            if (request.Seed != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Seed}"),
                    name: "\"seed\"");
            } 
            if (request.RequestedFontFile != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.RequestedFontFile}"),
                    name: "\"requested_font_file\"");
            } 
            if (request.UploadedFontFile != default)
            {

                var __contentUploadedFontFile = new global::System.Net.Http.ByteArrayContent(request.UploadedFontFile ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentUploadedFontFile,
                    name: "\"uploaded_font_file\"",
                    fileName: request.UploadedFontFilename != null ? $"\"{request.UploadedFontFilename}\"" : string.Empty);
                if (__contentUploadedFontFile.Headers.ContentDisposition != null)
                {
                    __contentUploadedFontFile.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.ReferenceAssetImages != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.ReferenceAssetImages, x => x))}]"),
                    name: "\"reference_asset_images\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePostLayerizeDesignV3Request(
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
            ProcessPostLayerizeDesignV3Response(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Ideogram.ApiException(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
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
                global::System.Exception? __exception_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::Ideogram.ApiException(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
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
                global::System.Exception? __exception_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        var __contentStream_429 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::Ideogram.ApiException(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
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
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessPostLayerizeDesignV3ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Ideogram.LayeredImageGenerationResponseV3.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
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
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Ideogram.LayeredImageGenerationResponseV3.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
            }
        }

        /// <summary>
        /// Layerize an existing flat graphic image with text detection and correction<br/>
        /// Processes an existing flat graphic image to detect and correct text layers without generating a new image from scratch.<br/>
        /// The uploaded image is analyzed for text content, which is then removed and returned as structured text layers with font matching, sizing, and color information.<br/>
        /// Supported image formats include JPEG, PNG, and WebP (max size 10MB).<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="flatGraphicImage">
        /// The flat graphic image to process for text detection and correction. The image should be in JPEG, PNG or WebP format (max size 10MB).
        /// </param>
        /// <param name="flatGraphicImagename">
        /// The flat graphic image to process for text detection and correction. The image should be in JPEG, PNG or WebP format (max size 10MB).
        /// </param>
        /// <param name="prompt">
        /// An optional prompt to describe the image. If not provided, a prompt will be auto-generated from the image via captioning.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="requestedFontFile">
        /// A font name from the available font library to use for text rendering. When provided, font matching is skipped and this font is used for all text layers. Cannot be used together with uploaded_font_file.<br/>
        /// Example: Ubuntu-Regular.ttf
        /// </param>
        /// <param name="uploadedFontFile">
        /// A custom font file to use for text rendering. Supported formats are .ttf, .otf, .woff, and .woff2 (max size 5MB). When provided, font matching is skipped and this font is used for all text layers. Cannot be used together with requested_font_file.
        /// </param>
        /// <param name="uploadedFontFilename">
        /// A custom font file to use for text rendering. Supported formats are .ttf, .otf, .woff, and .woff2 (max size 5MB). When provided, font matching is skipped and this font is used for all text layers. Cannot be used together with requested_font_file.
        /// </param>
        /// <param name="referenceAssetImages">
        /// A set of asset images (e.g., logos, icons) to use as references for detection and replacement (maximum 10 images). The images should be in JPEG, PNG or WebP format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.LayeredImageGenerationResponseV3> PostLayerizeDesignV3Async(
            byte[] flatGraphicImage,
            string flatGraphicImagename,
            string? prompt = default,
            int? seed = default,
            string? requestedFontFile = default,
            byte[]? uploadedFontFile = default,
            string? uploadedFontFilename = default,
            global::System.Collections.Generic.IList<byte[]>? referenceAssetImages = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Ideogram.LayerizeDesignRequestV3
            {
                FlatGraphicImage = flatGraphicImage,
                FlatGraphicImagename = flatGraphicImagename,
                Prompt = prompt,
                Seed = seed,
                RequestedFontFile = requestedFontFile,
                UploadedFontFile = uploadedFontFile,
                UploadedFontFilename = uploadedFontFilename,
                ReferenceAssetImages = referenceAssetImages,
            };

            return await PostLayerizeDesignV3Async(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}