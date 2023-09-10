using BenchmarkDotNet.Running;

namespace DictionaryBenchmark;

internal static class Program
{
    private static void Main() => BenchmarkRunner.Run<DictionaryBenchmark>();
}
