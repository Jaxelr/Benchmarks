using BenchmarkDotNet.Running;

namespace TupleBenchmark
{
    internal static class Program
    {
        private static void Main() => BenchmarkRunner.Run<TupleBenchmark>();
    }
}
