using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace TupleBenchmark;

[BenchmarkCategory("Tuple")]
[AllStatisticsColumn]
[HideColumns("Q1", "Q3", "Median", "RatioSD")]
[MemoryDiagnoser]
[ShortRunJob]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[MarkdownExporterAttribute.GitHub]
public class TupleBenchmark
{
    [Benchmark(Baseline = true)]
    [ArgumentsSource(nameof(InputData))]
    public (int, string) TupleSruct(int item1, string item2) => (item1, item2);

    [Benchmark]
    [ArgumentsSource(nameof(InputData))]
    public Tuple<int, string> TupleClass(int item1, string item2) => Tuple.Create(item1, item2);

    [Benchmark]
    [ArgumentsSource(nameof(InputData))]
    public ValueTuple<int, string> ValueTuple(int item1, string item2) => (item1, item2);

    public static IEnumerable<object[]> InputData()
    {
        yield return new object[] { 4, "Random Text" };
        yield return new object[] { 101, new string('X', 20) };
    }
}
