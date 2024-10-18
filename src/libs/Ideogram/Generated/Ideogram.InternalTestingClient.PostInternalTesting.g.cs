
#nullable enable

namespace Ideogram
{
    public partial class InternalTestingClient
    {
        partial void PreparePostInternalTestingArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Ideogram.InternalTestingRequest request);
        partial void PreparePostInternalTestingRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
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
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.PostInternalTesting200Response> PostInternalTestingAsync(
            global::Ideogram.InternalTestingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePostInternalTestingArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/internal-testing",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (request.XPosition != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.XPosition}"),
                    name: "x_position");
            } 
            if (request.ImageFile != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.ImageFile ?? global::System.Array.Empty<byte>())
                    {
                        Headers =
                        {
                            ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                        },
                    },
                    name: "image_file",
                    fileName: request.ImageFilename ?? string.Empty);
            } 
            if (request.AnotherImageFile != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.AnotherImageFile ?? global::System.Array.Empty<byte>())
                    {
                        Headers =
                        {
                            ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                        },
                    },
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
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePostInternalTestingRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPostInternalTestingResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPostInternalTestingResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Ideogram.PostInternalTesting200Response.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Testing<br/>
        /// Just a testing endpoint
        /// </summary>
        /// <param name="xPosition"></param>
        /// <param name="imageFile"></param>
        /// <param name="imageFilename"></param>
        /// <param name="anotherImageFile"></param>
        /// <param name="anotherImageFilename"></param>
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
            var request = new global::Ideogram.InternalTestingRequest
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
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}