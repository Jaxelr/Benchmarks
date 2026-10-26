# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9711)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.403
  [Host]   : .NET 10.0.14 (10.0.14, 10.0.1426.52326), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.14 (10.0.14, 10.0.1426.52326), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s      | Gen0   | Allocated |
|---------------- |---------:|----------:|----------:|----------:|---------:|---------:|----------:|-------:|----------:|
| ParallelForEach | 1.909 μs | 0.2003 μs | 0.0110 μs | 0.0063 μs | 1.897 μs | 1.919 μs | 523,887.2 | 2.5291 |   9.71 KB |
| AsParallel      | 4.431 μs | 1.2565 μs | 0.0689 μs | 0.0398 μs | 4.385 μs | 4.510 μs | 225,682.2 | 3.1738 |  12.63 KB |
