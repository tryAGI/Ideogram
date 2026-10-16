using System.Net.Http;

namespace Ideogram;

// Preserve the v1 constructor and AuthorizeUsingBearer API while honoring the
// provider's documented Api-Key wire protocol. Explicit Api-Key headers win.
internal static class LegacyApiKeyAuthentication
{
    internal static void Apply(HttpRequestMessage request, IReadOnlyCollection<EndPointAuthorization> authorizations)
    {
        if (request.Headers.Authorization is { Scheme: "Bearer", Parameter: { Length: > 0 } apiKey } &&
            authorizations.Any(authorization => authorization.Type == "Http" && authorization.Name == "Bearer" && authorization.Value == apiKey))
        {
            if (!request.Headers.Contains("Api-Key"))
            {
                request.Headers.Add("Api-Key", apiKey);
            }
            request.Headers.Authorization = null;
        }
    }
}

public sealed partial class AccountClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class AssetReferenceUsageClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class AutoModelClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class BatchClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class DatasetsClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class DesignClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class EditWorkflowClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class GenerateClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class GenerationsClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class IdeogramClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class ImageDescribeClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class ImagesGenerateClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class ImagesInpaintClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class ImagesPreciseEditClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class ImagesReframeClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class ImagesRemixClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class ImagesUpscaleClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class IntegrationsClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class InternalTestingClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class ManageClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class MiniAppsClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class ModelsClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class ObjectRemovalClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class PromptClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class ProvenanceClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class ToolClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class ToolsClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class VideoEditClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class VideoGenerateClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class VisionClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}

public sealed partial class WebhooksClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) => LegacyApiKeyAuthentication.Apply(request, Authorizations);
}
