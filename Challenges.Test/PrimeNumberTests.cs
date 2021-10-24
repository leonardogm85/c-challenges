using System.Linq;
using Xunit;

namespace Challenges.Test
{
    [Collection(nameof(PrimeNumberCollection))]
    public class PrimeNumberTests
    {
        private readonly PrimeNumberFixture _fixture;

        public PrimeNumberTests(PrimeNumberFixture fixture) => _fixture = fixture;

        [Fact(DisplayName = "Is prime number")]
        [Trait("Category", "Prime number")]
        public void PrimeNumber_IsPrime_ReturnTrue()
        {
            // Arrange
            var primes = _fixture
                .GetPrimes()
                .Select(prime => new PrimeNumber(prime));

            // Act & Assert
            Assert.All(primes, number => Assert.True(number.IsPrime()));
        }

        [Fact(DisplayName = "Isn't prime number")]
        [Trait("Category", "Prime number")]
        public void PrimeNumber_IsPrime_ReturnFalse()
        {
            // Arrange
            var normals = _fixture
                .GetNormals()
                .Select(normal => new PrimeNumber(normal));

            // Act & Assert
            Assert.All(normals, number => Assert.False(number.IsPrime()));
        }

        [Fact(DisplayName = "Get valid sequence")]
        [Trait("Category", "Prime number")]
        public void PrimeNumber_GetSequence_ReturnSequence()
        {
            // Arrange
            var numbers = Enumerable
                .Concat(_fixture.GetPrimes(), _fixture.GetNormals())
                .Select(number => new PrimeNumber(number));

            // Act & Assert
            Assert.All(numbers, number => Assert.Equal(number.GetSequence(), _fixture.GetSequence(number.Value)));
        }

        [Fact(DisplayName = "To string.")]
        [Trait("Category", "Prime number")]
        public void PrimeNumber_ToString_ReturnMessage()
        {
            // Arrange
            var numbers = Enumerable
                .Concat(_fixture.GetPrimes(), _fixture.GetNormals())
                .Select(number => new PrimeNumber(number));

            // Act & Assert
            Assert.All(numbers, number => Assert.Equal(number.ToString(), _fixture.ToString(number.Value)));
        }
    }
}
