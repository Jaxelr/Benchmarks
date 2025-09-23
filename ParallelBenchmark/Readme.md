# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.6584/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.305
  [Host]   : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | Mean     | Error    | StdDev    | StdErr    | Min      | Max      | Op/s      | Gen0   | Allocated |
|---------------- |---------:|---------:|----------:|----------:|---------:|---------:|----------:|-------:|----------:|
| ParallelForEach | 2.975 μs | 1.692 μs | 0.0928 μs | 0.0536 μs | 2.899 μs | 3.079 μs | 336,096.5 | 2.3422 |   9.15 KB |
| AsParallel      | 8.274 μs | 4.455 μs | 0.2442 μs | 0.1410 μs | 8.055 μs | 8.537 μs | 120,853.8 | 3.1586 |  12.63 KB |
