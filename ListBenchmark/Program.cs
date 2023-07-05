using BenchmarkDotNet.Running;

namespace ListBenchmark;

internal static class Program
{
    private static void Main() => BenchmarkRunner.Run<ListBenchmark>();
}
