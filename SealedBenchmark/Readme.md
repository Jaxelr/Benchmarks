# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.300
  [Host]   : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s                | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|--------------------:|-------:|----------:|
| Sealed_AddToArray | 2.7485 ns | 0.1858 ns | 0.0102 ns | 0.0059 ns | 2.7381 ns | 2.7584 ns |       363,828,400.5 | 0.0057 |      24 B |
| Open_AddToArray   | 3.9620 ns | 0.5698 ns | 0.0312 ns | 0.0180 ns | 3.9428 ns | 3.9980 ns |       252,400,550.0 | 0.0057 |      24 B |
|                   |           |           |           |           |           |           |                     |        |           |
| Sealed_Casting    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |            Infinity |      - |         - |
| Open_Casting      | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |            Infinity |      - |         - |
|                   |           |           |           |           |           |           |                     |        |           |
| Sealed_IntMethod  | 0.0371 ns | 0.0331 ns | 0.0018 ns | 0.0010 ns | 0.0357 ns | 0.0392 ns |    26,952,704,051.4 |      - |         - |
| Open_IntMethod    | 0.0589 ns | 1.7423 ns | 0.0955 ns | 0.0551 ns | 0.0032 ns | 0.1692 ns |    16,975,385,948.3 |      - |         - |
|                   |           |           |           |           |           |           |                     |        |           |
| Sealed_ToString   | 0.1581 ns | 0.0300 ns | 0.0016 ns | 0.0009 ns | 0.1562 ns | 0.1592 ns |     6,323,741,665.5 |      - |         - |
| Open_ToString     | 0.4676 ns | 0.0507 ns | 0.0028 ns | 0.0016 ns | 0.4647 ns | 0.4703 ns |     2,138,591,101.1 |      - |         - |
|                   |           |           |           |           |           |           |                     |        |           |
| Open_VoidMethod   | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |            Infinity |      - |         - |
| Sealed_VoidMethod | 0.0003 ns | 0.0080 ns | 0.0004 ns | 0.0003 ns | 0.0000 ns | 0.0008 ns | 3,945,646,095,051.4 |      - |         - |
