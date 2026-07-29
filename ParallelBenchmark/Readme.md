# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8875/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.302
  [Host]   : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s      | Gen0   | Allocated |
|---------------- |---------:|----------:|----------:|----------:|---------:|---------:|----------:|-------:|----------:|
| ParallelForEach | 3.112 μs | 0.3954 μs | 0.0217 μs | 0.0125 μs | 3.099 μs | 3.137 μs | 321,299.8 | 2.3270 |    9.1 KB |
| AsParallel      | 8.269 μs | 0.6993 μs | 0.0383 μs | 0.0221 μs | 8.226 μs | 8.296 μs | 120,926.6 | 3.1586 |  12.63 KB |
