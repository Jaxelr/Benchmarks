using BenchmarkDotNet.Running;

namespace TupleBenchmark
{
    internal static class Program
    {
        private static void Main() => _ = BenchmarkRunner.Run<TupleBenchmark>();
    }
}
