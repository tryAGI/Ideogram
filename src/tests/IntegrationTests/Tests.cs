namespace Ideogram.IntegrationTests;

[TestClass]
public partial class Tests
{
    public IdeogramClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("IDEOGRAM_API_KEY") ??
            throw new AssertInconclusiveException("IDEOGRAM_API_KEY environment variable is not found.");

        var api = new IdeogramClient(apiKey);
        
        return api;
    }
}
