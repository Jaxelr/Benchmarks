using BenchmarkDotNet.Running;

namespace CsvBenchmark;

internal static class Program
{
    private static void Main() => BenchmarkRunner.Run<CsvBenchmark>();
}
