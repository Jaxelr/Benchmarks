# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.300
  [Host]   : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method          | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s      | Gen0   | Allocated |
|---------------- |---------:|----------:|----------:|----------:|---------:|---------:|----------:|-------:|----------:|
| ParallelForEach | 3.033 μs | 0.3015 μs | 0.0165 μs | 0.0095 μs | 3.016 μs | 3.049 μs | 329,708.8 | 2.3651 |   9.22 KB |
| AsParallel      | 8.305 μs | 2.2028 μs | 0.1207 μs | 0.0697 μs | 8.183 μs | 8.424 μs | 120,404.7 | 3.1586 |  12.63 KB |
