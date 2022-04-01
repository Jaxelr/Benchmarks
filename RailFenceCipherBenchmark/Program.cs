using BenchmarkDotNet.Running;

namespace RailFenceCipherBenchmark
{
    internal static class Program
    {
        private static void Main() => BenchmarkRunner.Run<RailFenceCipherBenchmark>();
    }
}
