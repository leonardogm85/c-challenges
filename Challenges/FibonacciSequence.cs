using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges
{
    public class FibonacciSequence
    {
        public int Value { get; private set; }

        public FibonacciSequence(int value) => Value = value;

        public IEnumerable<int> GetSequence()
        {
            var sequence = Enumerable
            .Range(0, Value)
            .ToList();

            for (var index = 2; index < Value; index++)
            {
                checked
                {
                    sequence[index] = sequence[index - 1] + sequence[index - 2];
                }
            }

            return sequence.AsEnumerable();
        }

        public override string ToString() => new StringBuilder()
            .AppendFormat("Number: {0}", Value)

            .Append("; Sequence: ").AppendJoin(",", GetSequence())

            .ToString();
    }
}
