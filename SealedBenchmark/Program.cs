using BenchmarkDotNet.Running;

namespace SealedBenchmark;

internal static class Program
{
    private static void Main() => BenchmarkRunner.Run<SealedBenchmark>();
}
