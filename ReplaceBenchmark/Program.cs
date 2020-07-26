using BenchmarkDotNet.Running;

namespace ReplaceBenchmark
{
    internal static class Program
    {
        private static void Main() => _ = BenchmarkRunner.Run<ReplaceBenchmark>();
    }
}
