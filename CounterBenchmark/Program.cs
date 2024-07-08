using BenchmarkDotNet.Running;

namespace CounterBenchmark;

internal static class Program
{
    private static void Main() => BenchmarkRunner.Run<CounterBenchmark>();
}
