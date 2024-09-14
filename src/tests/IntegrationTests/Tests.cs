namespace Ideogram.IntegrationTests;

[TestClass]
public partial class Tests
{
    [TestMethod]
    public IdeogramApi GetAuthenticatedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("IDEOGRAM_API_KEY") ??
            throw new AssertInconclusiveException("IDEOGRAM_API_KEY environment variable is not found.");

        var api = new IdeogramApi(apiKey);
        
        return api;
    }
}
