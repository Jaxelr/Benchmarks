# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.203
  [Host]   : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s                | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|--------------------:|-------:|----------:|
| Sealed_AddToArray | 2.9739 ns | 1.6714 ns | 0.0916 ns | 0.0529 ns | 2.8683 ns | 3.0327 ns |       336,259,993.4 | 0.0057 |      24 B |
| Open_AddToArray   | 4.0671 ns | 0.3024 ns | 0.0166 ns | 0.0096 ns | 4.0493 ns | 4.0820 ns |       245,873,572.5 | 0.0057 |      24 B |
|                   |           |           |           |           |           |           |                     |        |           |
| Sealed_Casting    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |            Infinity |      - |         - |
| Open_Casting      | 0.2472 ns | 2.6298 ns | 0.1441 ns | 0.0832 ns | 0.1067 ns | 0.3947 ns |     4,046,113,003.9 |      - |         - |
|                   |           |           |           |           |           |           |                     |        |           |
| Open_IntMethod    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |            Infinity |      - |         - |
| Sealed_IntMethod  | 0.0261 ns | 0.4531 ns | 0.0248 ns | 0.0143 ns | 0.0080 ns | 0.0544 ns |    38,360,617,823.5 |      - |         - |
|                   |           |           |           |           |           |           |                     |        |           |
| Open_ToString     | 0.5309 ns | 0.5996 ns | 0.0329 ns | 0.0190 ns | 0.5027 ns | 0.5670 ns |     1,883,731,588.3 |      - |         - |
| Sealed_ToString   | 0.8988 ns | 6.0567 ns | 0.3320 ns | 0.1917 ns | 0.5275 ns | 1.1671 ns |     1,112,621,722.5 |      - |         - |
|                   |           |           |           |           |           |           |                     |        |           |
| Sealed_VoidMethod | 0.0008 ns | 0.0249 ns | 0.0014 ns | 0.0008 ns | 0.0000 ns | 0.0024 ns | 1,270,399,697,113.1 |      - |         - |
| Open_VoidMethod   | 0.0009 ns | 0.0161 ns | 0.0009 ns | 0.0005 ns | 0.0000 ns | 0.0018 ns | 1,112,071,211,765.5 |      - |         - |
