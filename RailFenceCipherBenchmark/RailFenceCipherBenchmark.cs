using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace RailFenceCipherBenchmark
{
    [BenchmarkCategory("RailFenceCipher")]
    [AllStatisticsColumn]
    [MemoryDiagnoser]
    [HideColumns("Q1", "Q3", "Median", "RatioSD")]
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
        [ArgumentsSource(nameof(InputStringArrays))]
        public string RailFenceLinqEncode(string value) => cipherLinq.Encode(value);

        [Benchmark]
        [ArgumentsSource(nameof(InputStringArrays))]
        public string RailFenceLoopEncode(string value) => cipherLoop.Encode(value);

        [Benchmark]
        [ArgumentsSource(nameof(OutputStringArrays))]
        public string RailFenceLinqDecode(string value) => cipherLinq.Decode(value);

        [Benchmark]
        [ArgumentsSource(nameof(OutputStringArrays))]
        public string RailFenceLoopDecode(string value) => cipherLoop.Decode(value);

        public static IEnumerable<object[]> InputStringArrays()
        {
            yield return new object[] { new string('*', 500) };
            yield return new object[] { new string('*', 1000) };
            yield return new object[] { "Random*String*With*Asterisks*In*Between" };
        }

        public static IEnumerable<object[]> OutputStringArrays()
        {
            yield return new object[] { new string('*', 500) };
            yield return new object[] { new string('*', 1000) };
            yield return new object[] { "Rotgtsi*BeadmSrn*ihAtrssI*ewen*iW*ekntn" };
        }
    }
}
