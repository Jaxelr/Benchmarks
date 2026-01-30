# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.102
  [Host]   : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method          | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s      | Gen0   | Gen1   | Allocated |
|---------------- |---------:|----------:|----------:|----------:|---------:|---------:|----------:|-------:|-------:|----------:|
| ParallelForEach | 1.984 μs |  6.077 μs | 0.3331 μs | 0.1923 μs | 1.788 μs | 2.369 μs | 504,023.2 | 2.5330 |      - |   9.75 KB |
| AsParallel      | 7.927 μs | 35.525 μs | 1.9472 μs | 1.1242 μs | 5.702 μs | 9.323 μs | 126,153.4 | 3.1738 | 0.0305 |  12.63 KB |
