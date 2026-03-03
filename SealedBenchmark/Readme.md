# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7922/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.103
  [Host]   : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|-------:|----------:|
| Sealed_AddToArray | 2.9323 ns | 1.1637 ns | 0.0638 ns | 0.0368 ns | 2.8695 ns | 2.9971 ns |     341,033,914.5 | 0.0057 |      24 B |
| Open_AddToArray   | 3.9045 ns | 0.4794 ns | 0.0263 ns | 0.0152 ns | 3.8827 ns | 3.9337 ns |     256,112,859.0 | 0.0057 |      24 B |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_Casting    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
| Open_Casting      | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Open_IntMethod    | 0.0073 ns | 0.0404 ns | 0.0022 ns | 0.0013 ns | 0.0051 ns | 0.0095 ns | 137,678,035,970.7 |      - |         - |
| Sealed_IntMethod  | 0.0285 ns | 0.0841 ns | 0.0046 ns | 0.0027 ns | 0.0257 ns | 0.0338 ns |  35,135,071,006.9 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_ToString   | 0.7476 ns | 1.4995 ns | 0.0822 ns | 0.0475 ns | 0.6576 ns | 0.8187 ns |   1,337,527,144.0 |      - |         - |
| Open_ToString     | 0.8126 ns | 1.2856 ns | 0.0705 ns | 0.0407 ns | 0.7561 ns | 0.8916 ns |   1,230,614,299.8 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_VoidMethod | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
| Open_VoidMethod   | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
