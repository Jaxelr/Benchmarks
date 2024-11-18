using System.Threading;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace CounterBenchmark;

[BenchmarkCategory("Counter")]
[AllStatisticsColumn]
[HideColumns("Q1", "Q3", "Median", "RatioSD")]
[MemoryDiagnoser]
[ExceptionDiagnoser]
[LongRunJob]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[MarkdownExporterAttribute.GitHub]
public class CounterBenchmark
{
    private static int testCounter = 0;

    [Benchmark]
    public void Increment() => testCounter++;

    [Benchmark]
    public void IncrementInterlocked() => Interlocked.Increment(ref testCounter);
}
