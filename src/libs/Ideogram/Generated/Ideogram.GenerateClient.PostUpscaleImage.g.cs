
#nullable enable

namespace Ideogram
{
    public partial class GenerateClient
    {
        partial void PreparePostUpscaleImageArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Ideogram.UpscaleImageRequest request);
        partial void PreparePostUpscaleImageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Ideogram.UpscaleImageRequest request);
        partial void ProcessPostUpscaleImageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostUpscaleImageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upscale<br/>
        /// Upscale provided images synchronously with an optional prompt.<br/>
        /// Supported image formats include JPEG, PNG, and WEBP
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageResponse> PostUpscaleImageAsync(
            global::Ideogram.UpscaleImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePostUpscaleImageArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/upscale",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (_authorization != null)
            {{
                httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                    scheme: _authorization.Name,
                    parameter: _authorization.Value);
            }}
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.ImageRequest}"),
                name: "image_request");
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
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePostUpscaleImageRequest(
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
            ProcessPostUpscaleImageResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPostUpscaleImageResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Ideogram.GenerateImageResponse), JsonSerializerContext) as global::Ideogram.GenerateImageResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Upscale<br/>
        /// Upscale provided images synchronously with an optional prompt.<br/>
        /// Supported image formats include JPEG, PNG, and WEBP
        /// </summary>
        /// <param name="imageRequest">
        /// A request to upscale a provided image with the help of an optional prompt.
        /// </param>
        /// <param name="imageFile">
        /// An image binary; only JPEG, WEBPs and PNGs are supported at this time
        /// </param>
        /// <param name="imageFilename">
        /// An image binary; only JPEG, WEBPs and PNGs are supported at this time
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageResponse> PostUpscaleImageAsync(
            global::Ideogram.UpscaleInitialImageRequest imageRequest,
            byte[] imageFile,
            string imageFilename,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Ideogram.UpscaleImageRequest
            {
                ImageRequest = imageRequest,
                ImageFile = imageFile,
                ImageFilename = imageFilename,
            };

            return await PostUpscaleImageAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}