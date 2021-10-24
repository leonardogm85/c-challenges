using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges
{
    public class PrimeNumber
    {
        private static readonly IEnumerable<int> _steps = Enumerable.Empty<int>()
            .Append(2)
            .Append(3)
            .Append(5)
            .Append(7);

        public PrimeNumber(int value) => Value = value;

        public int Value { get; private set; }

        private bool IsDivisible(int number, int step) => number % step == 0;

        private bool IsPrime(int number) =>
            number > 1
            &&
            _steps.All(step => number == step || !IsDivisible(number, step));

        public bool IsPrime() => IsPrime(Value);

        public IEnumerable<int> GetSequence() => Enumerable.Range(1, Value).Where(number => IsPrime(number));

        public override string ToString() => new StringBuilder()
            .AppendFormat("Number: {0}", Value)

            .AppendFormat("; Is Prime: {0}", IsPrime())

            .Append("; Sequence: ").AppendJoin(",", GetSequence())

            .ToString();
    }
}
