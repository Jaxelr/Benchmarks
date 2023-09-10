using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace DictionaryBenchmark;

[BenchmarkCategory("Dictionary")]
[AllStatisticsColumn]
[HideColumns("Q1", "Q3", "Median", "RatioSD")]
[MemoryDiagnoser]
[LongRunJob]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
[MarkdownExporterAttribute.GitHub]
public class DictionaryBenchmark
{
    private Dictionary<int, string> plainDictionary;
    private ImmutableDictionary<int, string> immutableDictionary;
    private ReadOnlyDictionary<int, string> readOnlyDictionary;

    [Params(100, 1_000, 10_000)]
    public int Items;

    public int Iterations { get; set; }

    [IterationSetup]
    public void Setup()
    {
        var _items = Enumerable
            .Range(0, Items)
            .Select(x => new KeyValuePair<int, string>(x, Guid.NewGuid().ToString()))
            .ToArray();

        plainDictionary = new Dictionary<int, string>(_items);
        readOnlyDictionary = new ReadOnlyDictionary<int, string>(plainDictionary);
        immutableDictionary = plainDictionary.ToImmutableDictionary();
    }

    [BenchmarkCategory("Read"), Benchmark(Baseline = true)]
    public void ReadPlainDictionary()
    {
        for (int i = 0; i < Items; i++)
        {
            plainDictionary.TryGetValue(i, out _);
        }
    }

    [BenchmarkCategory("Read"), Benchmark]
    public void ReadReadOnlyDictionary()
    {
        for (int i = 0; i < Items; i++)
        {
            readOnlyDictionary.TryGetValue(i, out _);
        }
    }

    [BenchmarkCategory("Read"), Benchmark]
    public void ReadImmutableDictionary()
    {
        for (int i = 0; i < Items; i++)
        {
            immutableDictionary.TryGetValue(i, out _);
        }
    }

    [BenchmarkCategory("Write"), Benchmark(Baseline = true)]
    public void WritePlainDictionary()
    {
        for (int i = 0; i < Items; i++)
        {
            plainDictionary[i] = Guid.NewGuid().ToString();
        }
    }

    [BenchmarkCategory("Write"), Benchmark]
    public void WriteReadOnlyDictionary()
    {
        for (int i = 0; i < Items; i++)
        {
            plainDictionary[i] = Guid.NewGuid().ToString();
        }

        readOnlyDictionary = new ReadOnlyDictionary<int, string>(plainDictionary);
    }

    [BenchmarkCategory("Write"), Benchmark]
    public void WriteImmutableDictionary()
    {
        for (int i = 0; i < Items; i++)
        {
            immutableDictionary = immutableDictionary.SetItem(i, Guid.NewGuid().ToString());
        }
    }

    [BenchmarkCategory("Remove"), Benchmark(Baseline = true)]
    public void RemovePlainDictionary()
    {
        for (int i = 0; i < Items; i++)
        {
            plainDictionary.Remove(i);
        }
    }

    [BenchmarkCategory("Remove"), Benchmark]
    public void RemoveReadOnlyDictionary()
    {
        for (int i = 0; i < Items; i++)
        {
            plainDictionary.Remove(i);
        }

        readOnlyDictionary = new ReadOnlyDictionary<int, string>(plainDictionary);
    }

    [BenchmarkCategory("Remove"), Benchmark]
    public void RemoveImmutableDictionary()
    {
        for (int i = 0; i < Items; i++)
        {
            immutableDictionary = immutableDictionary.Remove(i);
        }
    }

    [BenchmarkCategory("Add"), Benchmark(Baseline = true)]
    public void AddPlainDictionary()
    {
        for (int i = Items + 1; i < Items * 2; i++)
        {
            plainDictionary.Add(i, Guid.NewGuid().ToString());
        }
    }

    [BenchmarkCategory("Add"), Benchmark]
    public void AddReadOnlyDictionary()
    {
        for (int i = Items + 1; i < Items * 2; i++)
        {
            plainDictionary.Add(i, Guid.NewGuid().ToString());
        }

        readOnlyDictionary = new ReadOnlyDictionary<int, string>(plainDictionary);
    }

    [BenchmarkCategory("Add"), Benchmark]
    public void AddImmutableDictionary()
    {
        for (int i = Items + 1; i < Items * 2; i++)
        {
            immutableDictionary = immutableDictionary.Add(i, Guid.NewGuid().ToString());
        }
    }
}
