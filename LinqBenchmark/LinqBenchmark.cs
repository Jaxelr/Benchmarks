using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace LinqBenchmark;

[BenchmarkCategory("Linq")]
[AllStatisticsColumn]
[HideColumns("Q1", "Q3", "Median", "RatioSD")]
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

    public List<string> ConvertAll() => Data.ConvertAll(m => m.Name);

#pragma warning disable RCS1077 // We want to measure ConvertAll versus Select

    public List<string> Select() => Data.Select(m => m.Name).ToList();

#pragma warning restore RCS1077 //

    public static IEnumerable<object[]> InputData()
    {
        yield return new object[] { Enumerable.Range(0, 1000), 100 };
        yield return new object[] { Enumerable.Range(0, 10000), 1000 };
        yield return new object[] { Enumerable.Range(0, 100000), 10000 };
    }

    public List<SampleData> Data = new()
    {
        new SampleData() { Id = 1, Name = "One" },
        new SampleData() { Id = 2, Name = "Two" },
        new SampleData() { Id = 3, Name = "Three" }
    };

    public class SampleData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
