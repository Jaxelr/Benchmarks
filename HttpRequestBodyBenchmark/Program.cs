using BenchmarkDotNet.Running;

namespace HttpRequestBodyBenchmark;

internal static class Program
{
    private static void Main() => BenchmarkRunner.Run<RequestBodyBenchmark>();
}
