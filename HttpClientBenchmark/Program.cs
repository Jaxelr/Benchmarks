using BenchmarkDotNet.Running;

namespace HttpBenchmark;

internal static class Program
{
    private static void Main() => BenchmarkRunner.Run<HttpBenchmark>();
}
