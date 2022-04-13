using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace ForBenchmark
{
    [BenchmarkCategory("For Loops")]
    [AllStatisticsColumn]
    [MemoryDiagnoser]
    [ShortRunJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MarkdownExporterAttribute.GitHub]
    public class ForBenchmark
    {
        [Params(1)]
        public int Increment { get; set; }

        [Params(10_000, 100_000)]
        public int Iterations { get; set; }

        [Benchmark(Baseline = true)]
        public int ForWithIncrementBy1()
        {
            int iters = Iterations;
            int a = 0;
            for (int i = 0; i < iters; i++)
                a += Increment;
            return a;
        }

        [Benchmark]
        public int ForWithCustomIncrement()
        {
            int iters = Iterations;
            int a = 0;
            int inc = Increment;
            for (int i = 0; i < iters; i += inc)
                a += i;
            return a;
        }

        [Benchmark]
        public int ForeachWithEnumerableRange()
        {
            int a = 0;
            foreach (int i in Enumerable.Range(0, Iterations))
                a += Increment;
            return a;
        }

        [Benchmark]
        public int ForeachWithYieldReturn()
        {
            int a = 0;
            foreach (int i in Extensions.CustomRange(0, Iterations - 1, Increment))
                a += Increment;
            return a;
        }

        [Benchmark]
        public int ForeachWithRangeEnumerator()
        {
            int num = 0;
            RangeEnumerator enumerator = Extensions.GetEnumerator(new Range(0, Iterations - 1));
            while (enumerator.MoveNext())
            {
                int current = enumerator.Current;
                num += current;
            }
            return num;
        }

        [Benchmark]
        public int ForeachWithRangeEnumeratorRaw()
        {
            int a = 0;
            var enumerator = (0..(Iterations - 1)).GetEnumerator();
            while (enumerator.MoveNext())
                a += enumerator.Current;
            return a;
        }
    }
}
