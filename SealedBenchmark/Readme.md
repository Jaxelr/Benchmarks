# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.201
  [Host]   : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|-------:|----------:|
| Sealed_AddToArray | 2.6886 ns | 0.8070 ns | 0.0442 ns | 0.0255 ns | 2.6470 ns | 2.7350 ns |     371,946,198.5 | 0.0057 |      24 B |
| Open_AddToArray   | 3.9359 ns | 0.1832 ns | 0.0100 ns | 0.0058 ns | 3.9263 ns | 3.9463 ns |     254,069,390.3 | 0.0057 |      24 B |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_Casting    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
| Open_Casting      | 0.0123 ns | 0.0543 ns | 0.0030 ns | 0.0017 ns | 0.0088 ns | 0.0142 ns |  81,591,324,012.2 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_IntMethod  | 0.0047 ns | 0.0579 ns | 0.0032 ns | 0.0018 ns | 0.0018 ns | 0.0081 ns | 211,894,847,520.1 |      - |         - |
| Open_IntMethod    | 0.0055 ns | 0.0373 ns | 0.0020 ns | 0.0012 ns | 0.0034 ns | 0.0075 ns | 183,082,428,045.3 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_ToString   | 0.2300 ns | 0.3053 ns | 0.0167 ns | 0.0097 ns | 0.2133 ns | 0.2468 ns |   4,348,421,572.7 |      - |         - |
| Open_ToString     | 0.3791 ns | 0.2265 ns | 0.0124 ns | 0.0072 ns | 0.3685 ns | 0.3927 ns |   2,637,739,547.5 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_VoidMethod | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
| Open_VoidMethod   | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
