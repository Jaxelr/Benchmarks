using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AppendBenchmark;

[BenchmarkCategory("Append")]
[AllStatisticsColumn]
[MemoryDiagnoser]
[HideColumns("Q1", "Q3", "Median", "RatioSD")]
[ShortRunJob]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[MarkdownExporterAttribute.GitHub]
public class AppendBenchmark
{
    [Benchmark(Baseline = true)]
    [ArgumentsSource(nameof(Arrays))]
    public int[] Append(int[] array, int value) => array.Append(value);

    [Benchmark]
    [ArgumentsSource(nameof(Arrays))]
    public int[] AppendCopyTo(int[] array, int value) => array.AppendCopyTo(value);

    [Benchmark]
    [ArgumentsSource(nameof(Arrays))]
    public int[] AppendConcat(int[] array, int value) => array.AppendConcat(value);

    [Benchmark]
    [ArgumentsSource(nameof(Arrays))]
    public int[] AppendToList(int[] array, int value) => array.AppendToList(value);

    public static IEnumerable<object[]> Arrays()
    {
        yield return new object[] { Enumerable.Range(0, 1000).ToArray(), 4 };
        yield return new object[] { Enumerable.Range(0, 1000).ToArray(), 101 };
        yield return new object[] { Enumerable.Range(0, 10000).ToArray(), 4 };
        yield return new object[] { Enumerable.Range(0, 10000).ToArray(), 101 };
    }
}
