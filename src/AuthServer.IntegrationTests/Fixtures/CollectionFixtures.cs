using Xunit;

namespace AuthServer.IntegrationTests.Fixtures
{
    [CollectionDefinition("WebHost collection")]
    public class DatabaseCollection : ICollectionFixture<WebHostFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}
