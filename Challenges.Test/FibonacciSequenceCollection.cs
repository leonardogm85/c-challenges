using Xunit;

namespace Challenges.Test
{
    [CollectionDefinition(nameof(FibonacciSequenceCollection))]
    public class FibonacciSequenceCollection : ICollectionFixture<FibonacciSequenceFixture>
    {
    }
}
