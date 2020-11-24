using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System.Collections.Generic;
using System.Linq;

namespace LinqBenchmark
{
    [BenchmarkCategory("Linq")]
    [CategoriesColumn]
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
        public bool CountUsage(IEnumerable<int> list, int value) => list.Count(m => m == value) > 0;

        public IEnumerable<object[]> InputData()
        {
            yield return new object[] { Enumerable.Range(0, 1000), 100 };
            yield return new object[] { Enumerable.Range(0, 10000), 1000 };
            yield return new object[] { Enumerable.Range(0, 100000), 10000 };
        }
    }
}
