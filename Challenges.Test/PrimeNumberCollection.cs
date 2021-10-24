using Xunit;

namespace Challenges.Test
{
    [CollectionDefinition(nameof(PrimeNumberCollection))]
    public class PrimeNumberCollection : ICollectionFixture<PrimeNumberFixture>
    {
    }
}
