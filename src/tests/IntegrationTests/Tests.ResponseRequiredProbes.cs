namespace Ideogram.IntegrationTests;

/// <summary>
/// Probes for response fields this spec declares <c>required</c> while also giving them a
/// <c>default</c>.
/// </summary>
/// <remarks>
/// The generated deserializers enforce <c>required</c>, so a field the service omits turns a
/// successful HTTP 200 into a <c>JsonException</c> - and a documented default is the spec saying the
/// producer may omit it. Anthropic's spec had `caller` in exactly this shape and never sends it, so
/// every response that used a server tool failed to deserialize while nothing exercised those
/// surfaces live.
///
/// Reaching the typed response at all is the whole point of these tests, so asserting that it came
/// back non-null is enough. Every call here is a read-only GET, so a pass costs nothing and changes
/// nothing. `scripts/audit_response_required_defaults.py --endpoints` in the workspace lists the
/// rest; this SDK's other candidates sit behind operations that need an organization id, so they
/// need a fixture rather than a bare call.
/// </remarks>
public partial class Tests
{
    [TestMethod]
    public async Task ProfilesResponseDeserializes()
    {
        var client = GetAuthenticatedClient();

        // GetApiProfilesResponse.profiles
        var response = await client.Manage.GetApiProfilesAsync();

        response.Should().NotBeNull();
    }

    [TestMethod]
    public async Task DatasetsResponseDeserializes()
    {
        var client = GetAuthenticatedClient();

        // ListDatasetsResponse.datasets
        var response = await client.Datasets.ListDatasetsAsync();

        response.Should().NotBeNull();
    }
}
