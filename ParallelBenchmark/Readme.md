# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7840/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.103
  [Host]   : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method          | Mean     | Error    | StdDev    | StdErr    | Min      | Max      | Op/s      | Gen0   | Allocated |
|---------------- |---------:|---------:|----------:|----------:|---------:|---------:|----------:|-------:|----------:|
| ParallelForEach | 3.149 μs | 3.919 μs | 0.2148 μs | 0.1240 μs | 2.949 μs | 3.376 μs | 317,559.5 | 2.3575 |   9.22 KB |
| AsParallel      | 9.651 μs | 3.659 μs | 0.2006 μs | 0.1158 μs | 9.519 μs | 9.882 μs | 103,613.6 | 3.1433 |  12.63 KB |
