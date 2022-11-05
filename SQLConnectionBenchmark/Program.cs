using BenchmarkDotNet.Running;

namespace SQLConnectionBenchmark;

public class Program
{
    public static void Main() => BenchmarkRunner.Run(typeof(Program).Assembly);
}
