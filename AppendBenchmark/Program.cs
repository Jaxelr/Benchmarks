using BenchmarkDotNet.Running;

namespace AppendBenchmark
{
    internal static class Program
    {
        private static void Main()
        {
            _ = BenchmarkRunner.Run<AppendBenchmark>();
        }
    }
}