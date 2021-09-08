using System;
using System.Collections.Generic;
using System.Linq;

namespace ForBenchmark
{
    internal static class Extensions
    {
        internal static IEnumerable<int> CustomRange(int from, int to, int inc)
        {
            for (int i = from; i <= to; i += inc)
                yield return i;
        }

        internal static RangeEnumerator GetEnumerator(this Range @this) => (@this.Start, @this.End) switch
    {
        ({ IsFromEnd: true, Value: 0 }, { IsFromEnd: true, Value: 0 }) => new RangeEnumerator(0, int.MaxValue, 1),
        ({ IsFromEnd: true, Value: 0 }, { IsFromEnd: false, Value: var to }) => new RangeEnumerator(0, to + 1, 1),
        ({ IsFromEnd: false, Value: var from }, { IsFromEnd: true, Value: 0 }) => new RangeEnumerator(from, int.MaxValue, 1),
        ({ IsFromEnd: false, Value: var from }, { IsFromEnd: false, Value: var to })
            => (from < to) switch
            {
                true => new RangeEnumerator(from, to, 1),
                false => new RangeEnumerator(from, to, -1),
            },
        _ => throw new InvalidOperationException("Invalid range")
    };
    }
}
