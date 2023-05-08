using BenchmarkDotNet.Running;

namespace LoggingBenchmark;

internal static class Program
{
    private static void Main() => BenchmarkRunner.Run<LoggingBenchmark>();
}
