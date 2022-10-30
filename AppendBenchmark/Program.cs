using BenchmarkDotNet.Running;

namespace AppendBenchmark;

internal static class Program
{
    private static void Main() => BenchmarkRunner.Run<AppendBenchmark>();
}
