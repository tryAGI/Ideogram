
#nullable enable

namespace Ideogram
{
    public partial class InternalTestingClient
    {
        partial void PreparePostInternalTestingArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xTestHeader,
            ref string? xTestHeader2,
            global::Ideogram.InternalTestingRequest request);
        partial void PreparePostInternalTestingRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xTestHeader,
            string? xTestHeader2,
            global::Ideogram.InternalTestingRequest request);
        partial void ProcessPostInternalTestingResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostInternalTestingResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Testing<br/>
        /// Just a testing endpoint
        /// </summary>
        /// <param name="xTestHeader"></param>
        /// <param name="xTestHeader2"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.PostInternalTesting200Response> PostInternalTestingAsync(
            global::Ideogram.InternalTestingRequest request,
            string? xTestHeader = default,
            string? xTestHeader2 = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostInternalTestingArguments(
                httpClient: HttpClient,
                xTestHeader: ref xTestHeader,
                xTestHeader2: ref xTestHeader2,
                request: request);

            var __pathBuilder = new global::Ideogram.PathBuilder(
                path: "/internal-testing",
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

            if (xTestHeader != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-Test-Header", xTestHeader.ToString());
            }
            if (xTestHeader2 != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-Test-Header-2", xTestHeader2.ToString());
            }

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (xTestHeader != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{xTestHeader}"),
                    name: "X-Test-Header");
            } 
            if (xTestHeader2 != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{xTestHeader2}"),
                    name: "X-Test-Header-2");
            } 
            if (request.XPosition != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.XPosition}"),
                    name: "x_position");
            } 
            if (request.ImageFile != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.ImageFile ?? global::System.Array.Empty<byte>()),
                    name: "image_file",
                    fileName: request.ImageFilename ?? string.Empty);
            } 
            if (request.AnotherImageFile != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.AnotherImageFile ?? global::System.Array.Empty<byte>()),
                    name: "another_image_file",
                    fileName: request.AnotherImageFilename ?? string.Empty);
            } 
            if (request.SomeText != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SomeText}"),
                    name: "some_text");
            } 
            if (request.NestedObject != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.NestedObject}"),
                    name: "nested_object");
            } 
            if (request.NestedObjectRequiredFields != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.NestedObjectRequiredFields}"),
                    name: "nested_object_required_fields");
            } 
            if (request.DateTypeField != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DateTypeField}"),
                    name: "date_type_field");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.RequiredDateTypeField}"),
                name: "required_date_type_field");
            if (request.DateTimeTypeField != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DateTimeTypeField}"),
                    name: "date_time_type_field");
            } 
            if (request.RepeatedPrimitiveField != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.RepeatedPrimitiveField, x => x))}]"),
                    name: "repeated_primitive_field");
            } 
            if (request.RepeatedComplexField != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.RepeatedComplexField, x => x))}]"),
                    name: "repeated_complex_field");
            } 
            if (request.EnumTypeField != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.EnumTypeField?.ToValueString()}"),
                    name: "enum_type_field");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePostInternalTestingRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xTestHeader: xTestHeader,
                xTestHeader2: xTestHeader2,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPostInternalTestingResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

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
                ProcessPostInternalTestingResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Ideogram.PostInternalTesting200Response.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Ideogram.PostInternalTesting200Response.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Testing<br/>
        /// Just a testing endpoint
        /// </summary>
        /// <param name="xTestHeader"></param>
        /// <param name="xTestHeader2"></param>
        /// <param name="xPosition"></param>
        /// <param name="imageFile">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imageFilename">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="anotherImageFile">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="anotherImageFilename">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="someText"></param>
        /// <param name="nestedObject"></param>
        /// <param name="nestedObjectRequiredFields"></param>
        /// <param name="dateTypeField"></param>
        /// <param name="requiredDateTypeField"></param>
        /// <param name="dateTimeTypeField"></param>
        /// <param name="repeatedPrimitiveField"></param>
        /// <param name="repeatedComplexField"></param>
        /// <param name="enumTypeField"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.PostInternalTesting200Response> PostInternalTestingAsync(
            global::System.DateTime requiredDateTypeField,
            string? xTestHeader = default,
            string? xTestHeader2 = default,
            int? xPosition = default,
            byte[]? imageFile = default,
            string? imageFilename = default,
            byte[]? anotherImageFile = default,
            string? anotherImageFilename = default,
            string? someText = default,
            global::Ideogram.InternalTestingNestedObject? nestedObject = default,
            global::Ideogram.InternalTestingNestedObjectRequiredFields? nestedObjectRequiredFields = default,
            global::System.DateTime? dateTypeField = default,
            global::System.DateTime? dateTimeTypeField = default,
            global::System.Collections.Generic.IList<string>? repeatedPrimitiveField = default,
            global::System.Collections.Generic.IList<global::Ideogram.InternalTestingNestedObject>? repeatedComplexField = default,
            global::Ideogram.InternalTestingEnumField? enumTypeField = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Ideogram.InternalTestingRequest
            {
                XPosition = xPosition,
                ImageFile = imageFile,
                ImageFilename = imageFilename,
                AnotherImageFile = anotherImageFile,
                AnotherImageFilename = anotherImageFilename,
                SomeText = someText,
                NestedObject = nestedObject,
                NestedObjectRequiredFields = nestedObjectRequiredFields,
                DateTypeField = dateTypeField,
                RequiredDateTypeField = requiredDateTypeField,
                DateTimeTypeField = dateTimeTypeField,
                RepeatedPrimitiveField = repeatedPrimitiveField,
                RepeatedComplexField = repeatedComplexField,
                EnumTypeField = enumTypeField,
            };

            return await PostInternalTestingAsync(
                xTestHeader: xTestHeader,
                xTestHeader2: xTestHeader2,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}