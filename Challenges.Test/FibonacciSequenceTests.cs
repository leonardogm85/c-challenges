using System;
using System.Linq;
using Xunit;

namespace Challenges.Test
{
    [Collection(nameof(FibonacciSequenceCollection))]
    public class FibonacciSequenceTests
    {
        private readonly FibonacciSequenceFixture _fixture;

        public FibonacciSequenceTests(FibonacciSequenceFixture fixture) => _fixture = fixture;

        [Fact(DisplayName = "Get valid sequence")]
        [Trait("Category", "Fibonacci sequence")]
        public void FibonacciSequence_GetSequence_ReturnSequence()
        {
            // Arrange
            var numbers = _fixture
                .GetNumbers()
                .Select(number => new FibonacciSequence(number));

            // Act & Assert
            Assert.All(numbers, number => Assert.Equal(number.GetSequence(), _fixture.GetSequence(number.Value)));
        }

        [Fact(DisplayName = "Throw overflow exception.")]
        [Trait("Category", "Fibonacci sequence")]
        public void FibonacciSequence_GetSequence_ThrowOverflowException()
        {
            // Arrange
            var fibonacci = new FibonacciSequence(100);

            // Act & Assert
            Assert.Throws<OverflowException>(fibonacci.GetSequence);
        }

        [Fact(DisplayName = "To string.")]
        [Trait("Category", "Fibonacci sequence")]
        public void FibonacciSequence_ToString_ReturnMessage()
        {
            // Arrange
            var numbers = _fixture
                .GetNumbers()
                .Select(number => new FibonacciSequence(number));

            // Act & Assert
            Assert.All(numbers, number => Assert.Equal(number.ToString(), _fixture.ToString(number.Value)));
        }
    }
}
