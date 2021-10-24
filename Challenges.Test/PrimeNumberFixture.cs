using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges.Test
{
    public class PrimeNumberFixture
    {
        private readonly IEnumerable<int> _primes;
        private readonly IEnumerable<int> _normals;
        private readonly IDictionary<int, IEnumerable<int>> _sequence;

        public PrimeNumberFixture()
        {
            _primes = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19 };

            _normals = new List<int> { 0, 1, 4, 6, 8, 9, 10, 12, 14, 15, 16, 18 };

            _sequence = new Dictionary<int, IEnumerable<int>>
            {
                { 0, new List<int>() },
                { 1, new List<int>() },
                { 2, new List<int>{ 2 } },
                { 3, new List<int>{ 2, 3 } },
                { 4, new List<int>{ 2, 3 } },
                { 5, new List<int>{ 2, 3, 5 } },
                { 6, new List<int>{ 2, 3, 5 } },
                { 7, new List<int>{ 2, 3, 5, 7 } },
                { 8, new List<int>{ 2, 3, 5, 7 } },
                { 9, new List<int>{ 2, 3, 5, 7 } },
                { 10, new List<int>{ 2, 3, 5, 7 } },
                { 11, new List<int>{ 2, 3, 5, 7, 11 } },
                { 12, new List<int>{ 2, 3, 5, 7, 11 } },
                { 13, new List<int>{ 2, 3, 5, 7, 11, 13 } },
                { 14, new List<int>{ 2, 3, 5, 7, 11, 13 } },
                { 15, new List<int>{ 2, 3, 5, 7, 11, 13 } },
                { 16, new List<int>{ 2, 3, 5, 7, 11, 13 } },
                { 17, new List<int>{ 2, 3, 5, 7, 11, 13, 17 } },
                { 18, new List<int>{ 2, 3, 5, 7, 11, 13, 17 } },
                { 19, new List<int>{ 2, 3, 5, 7, 11, 13, 17, 19 } },
            };
        }

        private bool IsPrime(int number) => _primes.Any(prime => prime == number);

        public IEnumerable<int> GetPrimes() => _primes;

        public IEnumerable<int> GetNormals() => _normals;

        public IEnumerable<int> GetSequence(int number) => _sequence[number];

        public string ToString(int number) => new StringBuilder()
            .AppendFormat("Number: {0}", number)

            .AppendFormat("; Is Prime: {0}", IsPrime(number))

            .Append("; Sequence: ").AppendJoin(",", GetSequence(number))

            .ToString();
    }
}
