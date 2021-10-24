using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges.Test
{
    public class FibonacciSequenceFixture
    {
        private readonly IEnumerable<int> _numbers;
        private readonly IDictionary<int, IEnumerable<int>> _sequence;

        public FibonacciSequenceFixture()
        {
            _numbers = Enumerable.Range(0, 20);

            _sequence = new Dictionary<int, IEnumerable<int>>
            {
                 { 0, new List<int>() },
                 { 1, new List<int> { 0 } },
                 { 2, new List<int> { 0, 1 } },
                 { 3, new List<int> { 0, 1, 1 } },
                 { 4, new List<int> { 0, 1, 1, 2 } },
                 { 5, new List<int> { 0, 1, 1, 2, 3 } },
                 { 6, new List<int> { 0, 1, 1, 2, 3, 5 } },
                 { 7, new List<int> { 0, 1, 1, 2, 3, 5, 8 } },
                 { 8, new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 } },
                 { 9, new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21 } },
                 { 10, new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 } },
                 { 11, new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 } },
                 { 12, new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 } },
                 { 13, new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 } },
                 { 14, new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233 } },
                 { 15, new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 } },
                 { 16, new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 } },
                 { 17, new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987 } },
                 { 18, new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597 } },
                 { 19, new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584 } }
            };
        }

        public IEnumerable<int> GetNumbers() => _numbers;

        public IEnumerable<int> GetSequence(int number) => _sequence[number];

        public string ToString(int number) => new StringBuilder()
            .AppendFormat("Number: {0}", number)

            .Append("; Sequence: ").AppendJoin(",", GetSequence(number))

            .ToString();
    }
}
