using Xunit;

namespace Livraria.Henrique.SeleniumTest.Fixtures
{
    [CollectionDefinition("Chrome Driver")]
    public class CollectionFixture : ICollectionFixture<TestFixture>
    {
    }
}
