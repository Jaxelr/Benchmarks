using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailFenceCipherBenchmark
{
    public class RailFenceCipherLinq
    {
        private readonly int rails;

        public RailFenceCipherLinq(int rails) => this.rails = --rails;

        internal int GetRow(int i) => rails - Math.Abs((i % (2 * rails)) - rails);

        internal IEnumerable<T> ZigZagIndex<T>(IEnumerable<T> seq) => seq
            .Select((c, i) => (c, r: GetRow(i)))
            .GroupBy(v => v.r)
            .SelectMany(v => v.Select(vc => vc.c));

        public string Encode(string input) => string.Join("", ZigZagIndex(input));

        public string Decode(string input) =>
            ZigZagIndex(Enumerable.Range(0, input.Length))
            .Zip(input, (f, s) => (i: f, c: s))
            .OrderBy(v => v.i)
            .Aggregate(new StringBuilder(), (sb, v) => sb.Append(v.c), sb => sb.ToString());
    }
}
