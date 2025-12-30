# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]   : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s             | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|-----------------:|-------:|----------:|
| Sealed_AddToArray | 2.7868 ns | 0.2928 ns | 0.0161 ns | 0.0093 ns | 2.7695 ns | 2.8012 ns |    358,831,753.2 | 0.0057 |      24 B |
| Open_AddToArray   | 4.0976 ns | 1.7203 ns | 0.0943 ns | 0.0544 ns | 3.9936 ns | 4.1775 ns |    244,042,571.3 | 0.0057 |      24 B |
|                   |           |           |           |           |           |           |                  |        |           |
| Sealed_Casting    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
| Open_Casting      | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
|                   |           |           |           |           |           |           |                  |        |           |
| Sealed_IntMethod  | 0.0439 ns | 0.4740 ns | 0.0260 ns | 0.0150 ns | 0.0139 ns | 0.0595 ns | 22,793,710,989.5 |      - |         - |
| Open_IntMethod    | 0.0918 ns | 0.6333 ns | 0.0347 ns | 0.0200 ns | 0.0523 ns | 0.1176 ns | 10,898,203,062.5 |      - |         - |
|                   |           |           |           |           |           |           |                  |        |           |
| Sealed_ToString   | 0.9196 ns | 0.8504 ns | 0.0466 ns | 0.0269 ns | 0.8733 ns | 0.9666 ns |  1,087,452,277.3 |      - |         - |
| Open_ToString     | 0.9397 ns | 0.3753 ns | 0.0206 ns | 0.0119 ns | 0.9169 ns | 0.9567 ns |  1,064,123,565.8 |      - |         - |
|                   |           |           |           |           |           |           |                  |        |           |
| Open_VoidMethod   | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
| Sealed_VoidMethod | 0.0825 ns | 0.0304 ns | 0.0017 ns | 0.0010 ns | 0.0809 ns | 0.0842 ns | 12,116,857,887.2 |      - |         - |
