using BenchmarkDotNet.Running;

namespace ParallelBenchmark;

internal static class Program
{
    private static void Main() => BenchmarkRunner.Run<ParallelBenchmark>();
}
