# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.7171)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]   : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | Mean      | Error      | StdDev    | StdErr    | Min       | Max       | Op/s      | Gen0   | Allocated |
|---------------- |----------:|-----------:|----------:|----------:|----------:|----------:|----------:|-------:|----------:|
| ParallelForEach |  2.655 μs |  0.2819 μs | 0.0155 μs | 0.0089 μs |  2.641 μs |  2.672 μs | 376,683.3 | 2.3193 |   9.08 KB |
| AsParallel      | 15.503 μs | 13.5921 μs | 0.7450 μs | 0.4301 μs | 14.647 μs | 16.007 μs |  64,505.3 | 3.1433 |  12.63 KB |
