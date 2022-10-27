using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using SealedBenchmark.Models;

namespace SealedBenchmark
{
    [BenchmarkCategory("Sealed")]
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    [AllStatisticsColumn]
    [MemoryDiagnoser]
    [HideColumns("Q1", "Q3", "Median", "RatioSD")]
    [ShortRunJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MarkdownExporterAttribute.GitHub]
    public class SealedBenchmark
    {
        private readonly Bear bear = new();
        private readonly Husky husky = new();
        private readonly Animal animal = new();
        private readonly Bear[] bears = new Bear[1];
        private readonly Husky[] huskies = new Husky[1];

        [Benchmark]
        [BenchmarkCategory("VoidMethod")]
        public void Sealed_VoidMethod() => husky.DoNothing();

        [Benchmark]
        [BenchmarkCategory("VoidMethod")]
        public void Open_VoidMethod() => bear.DoNothing();

        [Benchmark]
        [BenchmarkCategory("ReturnMethod")]
        public int Sealed_IntMethod() => husky.GetAge();

        [Benchmark]
        [BenchmarkCategory("ReturnMethod")]
        public int Open_IntMethod() => bear.GetAge();

        [Benchmark]
        [BenchmarkCategory("StaticMethod")]
        public void Sealed_StaticMethod() => Husky.Walk();

        [Benchmark]
        [BenchmarkCategory("StaticMethod")]
        public void Open_StaticMethod() => Bear.Walk();

        [Benchmark]
        [BenchmarkCategory("ToString")]
        public string Sealed_ToString() => husky.ToString()!;

        [Benchmark]
        [BenchmarkCategory("ToString")]
        public string Open_ToString() => bear.ToString()!;

        [Benchmark]
        [BenchmarkCategory("Casting")]
        public Husky? Sealed_Casting() => animal as Husky;

        [Benchmark]
        [BenchmarkCategory("Casting")]
        public Bear? Open_Casting() => animal as Bear;

        [Benchmark]
        [BenchmarkCategory("AddToArray")]
        public void Sealed_AddToArray() => huskies[0] = new Husky();

        [Benchmark]
        [BenchmarkCategory("AddToArray")]
        public void Open_AddToArray() => bears[0] = new Bear();

        [Benchmark]
        [BenchmarkCategory("Declaration")]
        public void SealedDeclaredInMethod_VoidMethod()
        {
            var husky = new Husky();
            husky.DoNothing();
        }

        [Benchmark]
        [BenchmarkCategory("Declaration")]
        public void OpenDeclaredInMethod_VoidMethod()
        {
            var bear = new Bear();
            bear.DoNothing();
        }
    }
}
