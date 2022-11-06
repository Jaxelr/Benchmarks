using BenchmarkDotNet.Running;

namespace ForBenchmark;

internal static class Program
{
    private static void Main() => BenchmarkRunner.Run<ForBenchmark>();
}
