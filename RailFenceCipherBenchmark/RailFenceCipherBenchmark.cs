using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace RailFenceCipherBenchmark
{
    [BenchmarkCategory("RailFenceCipher")]
    [MemoryDiagnoser]
    [ShortRunJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MarkdownExporterAttribute.GitHub]
    public class RailFenceBenchmark
    {
        private const int N = 30;
        private readonly RailFenceCipherLinq cipherLinq;
        private readonly RailFenceCipherLoop cipherLoop;

        public RailFenceBenchmark()
        {
            cipherLinq = new(N);
            cipherLoop = new(N);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Arrays))]
        public string RailFenceLinq(string value) => cipherLinq.Encode(value);

        [Benchmark]
        [ArgumentsSource(nameof(Arrays))]
        public string RailFenceLoop(string value) => cipherLoop.Encode(value);

        public static IEnumerable<object[]> Arrays()
        {
            yield return new object[] { new string('*', 500) };
            yield return new object[] { new string('*', 1000) };
            yield return new object[] { "Random*String*With*Asterisks*In*Between" };
        }
    }
}
