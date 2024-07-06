using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace ListBenchmark;

[BenchmarkCategory("List")]
[AllStatisticsColumn]
[HideColumns("Q1", "Q3", "Median", "RatioSD")]
[MemoryDiagnoser]
[ShortRunJob]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[MarkdownExporterAttribute.GitHub]
public class ListBenchmark
{
    [Params(100, 10_000)]
    public int Size { get; set; }

    private readonly string smallItem = new('*', 100);
    private readonly string largeItem = new('*', 10_000);

    [Benchmark]
    public List<string> AllocateListSmallItem()
    {
        var list = new List<string>();

        for (int i = 0; i < Size; i++)
            list.Add(smallItem);

        return list;
    }

    [Benchmark]
    public List<string> AllocateListLargeItem()
    {
        var list = new List<string>();

        for (int i = 0; i < Size; i++)
            list.Add(largeItem);

        return list;
    }

    [Benchmark]
    public List<string> PreprovisionListSmallItem()
    {
        var list = new List<string>(Size);

        for (int i = 0; i < Size; i++)
            list.Add(smallItem);

        return list;
    }

    [Benchmark]
    public List<string> PreprovisionListLargeItem()
    {
        var list = new List<string>(Size);

        for (int i = 0; i < Size; i++)
            list.Add(largeItem);

        return list;
    }
}
