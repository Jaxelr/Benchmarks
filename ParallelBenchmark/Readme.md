# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.203
  [Host]   : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method          | Mean     | Error    | StdDev    | StdErr    | Min      | Max      | Op/s      | Gen0   | Gen1   | Allocated |
|---------------- |---------:|---------:|----------:|----------:|---------:|---------:|----------:|-------:|-------:|----------:|
| ParallelForEach | 3.074 μs | 5.403 μs | 0.2962 μs | 0.1710 μs | 2.759 μs | 3.347 μs | 325,259.8 | 2.3346 |      - |   9.14 KB |
| AsParallel      | 8.641 μs | 5.353 μs | 0.2934 μs | 0.1694 μs | 8.360 μs | 8.945 μs | 115,725.6 | 3.1433 | 0.0305 |  12.63 KB |
