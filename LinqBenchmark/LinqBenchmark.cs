using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace LinqBenchmark
{
    [BenchmarkCategory("Linq")]
    [AllStatisticsColumn]
    [MemoryDiagnoser]
    [ShortRunJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MarkdownExporterAttribute.GitHub]
    public class LinqBenchmark
    {
        [ArgumentsSource(nameof(InputData))]
        [Benchmark]
        public bool AnyUsage(IEnumerable<int> list, int value) => list.Any(m => m == value);

        [ArgumentsSource(nameof(InputData))]
        [Benchmark]
#pragma warning disable CA1827 // We want to test Count versus Any
        public bool CountUsage(IEnumerable<int> list, int value) => list.Count(m => m == value) > 0;
#pragma warning restore CA1827 //

        [ArgumentsSource(nameof(InputData))]
        [Benchmark]
        public int FirstUsage(IEnumerable<int> list, int value) => list.First(m => m == value);

        [ArgumentsSource(nameof(InputData))]
        [Benchmark]
        public int SingleUsage(IEnumerable<int> list, int value) => list.Single(m => m == value);

        [ArgumentsSource(nameof(InputData))]
        [Benchmark]
        public List<int> WhereUsage(IEnumerable<int> list, int value) => list.Where(m => m == value).ToList();

        public static IEnumerable<object[]> InputData()
        {
            yield return new object[] { Enumerable.Range(0, 1000), 100 };
            yield return new object[] { Enumerable.Range(0, 10000), 1000 };
            yield return new object[] { Enumerable.Range(0, 100000), 10000 };
        }
    }
}
