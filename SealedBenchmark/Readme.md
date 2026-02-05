# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.102
  [Host]   : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s                | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|--------------------:|-------:|----------:|
| Sealed_AddToArray | 2.9703 ns | 6.1611 ns | 0.3377 ns | 0.1950 ns | 2.7343 ns | 3.3572 ns |       336,661,306.1 | 0.0057 |      24 B |
| Open_AddToArray   | 4.1234 ns | 1.5828 ns | 0.0868 ns | 0.0501 ns | 4.0670 ns | 4.2233 ns |       242,515,715.8 | 0.0057 |      24 B |
|                   |           |           |           |           |           |           |                     |        |           |
| Sealed_Casting    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |            Infinity |      - |         - |
| Open_Casting      | 0.0056 ns | 0.1765 ns | 0.0097 ns | 0.0056 ns | 0.0000 ns | 0.0168 ns |   179,046,493,913.6 |      - |         - |
|                   |           |           |           |           |           |           |                     |        |           |
| Sealed_IntMethod  | 0.0071 ns | 0.1907 ns | 0.0105 ns | 0.0060 ns | 0.0000 ns | 0.0191 ns |   140,544,576,345.1 |      - |         - |
| Open_IntMethod    | 0.0080 ns | 0.0608 ns | 0.0033 ns | 0.0019 ns | 0.0044 ns | 0.0110 ns |   124,625,703,054.9 |      - |         - |
|                   |           |           |           |           |           |           |                     |        |           |
| Open_ToString     | 0.5913 ns | 0.0478 ns | 0.0026 ns | 0.0015 ns | 0.5894 ns | 0.5943 ns |     1,691,084,337.0 |      - |         - |
| Sealed_ToString   | 0.5942 ns | 0.0675 ns | 0.0037 ns | 0.0021 ns | 0.5918 ns | 0.5985 ns |     1,682,911,629.3 |      - |         - |
|                   |           |           |           |           |           |           |                     |        |           |
| Open_VoidMethod   | 0.0002 ns | 0.0050 ns | 0.0003 ns | 0.0002 ns | 0.0000 ns | 0.0005 ns | 6,298,837,450,136.9 |      - |         - |
| Sealed_VoidMethod | 0.0029 ns | 0.0073 ns | 0.0004 ns | 0.0002 ns | 0.0025 ns | 0.0032 ns |   342,472,248,187.3 |      - |         - |
