# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6899)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.306
  [Host]   : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s      | Gen0   | Allocated |
|---------------- |---------:|----------:|----------:|----------:|---------:|---------:|----------:|-------:|----------:|
| ParallelForEach | 2.778 μs | 0.7044 μs | 0.0386 μs | 0.0223 μs | 2.754 μs | 2.823 μs | 359,947.4 | 2.3422 |   9.17 KB |
| AsParallel      | 4.568 μs | 0.5211 μs | 0.0286 μs | 0.0165 μs | 4.536 μs | 4.592 μs | 218,935.1 | 3.1738 |  12.63 KB |
