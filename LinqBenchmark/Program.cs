using BenchmarkDotNet.Running;

namespace LinqBenchmark
{
    internal static class Program
    {
        private static void Main() => _ = BenchmarkRunner.Run<LinqBenchmark>();
    }
}
