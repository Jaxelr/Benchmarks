# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9457)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.401
  [Host]   : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | Mean     | Error     | StdDev    | StdErr    | Min      | Max       | Op/s      | Gen0   | Allocated |
|---------------- |---------:|----------:|----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| ParallelForEach | 2.134 μs |  4.692 μs | 0.2572 μs | 0.1485 μs | 1.929 μs |  2.422 μs | 468,685.5 | 2.5253 |   9.72 KB |
| AsParallel      | 6.621 μs | 55.563 μs | 3.0456 μs | 1.7584 μs | 4.819 μs | 10.138 μs | 151,030.4 | 3.1738 |  12.63 KB |
