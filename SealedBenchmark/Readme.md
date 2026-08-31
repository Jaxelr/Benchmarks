# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.400
  [Host]   : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s             | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|-----------------:|-------:|----------:|
| Sealed_AddToArray | 2.9158 ns | 1.3096 ns | 0.0718 ns | 0.0414 ns | 2.8579 ns | 2.9961 ns |    342,961,987.6 | 0.0057 |      24 B |
| Open_AddToArray   | 4.2044 ns | 1.3602 ns | 0.0746 ns | 0.0430 ns | 4.1205 ns | 4.2631 ns |    237,848,081.7 | 0.0057 |      24 B |
|                   |           |           |           |           |           |           |                  |        |           |
| Sealed_Casting    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
| Open_Casting      | 0.0124 ns | 0.0855 ns | 0.0047 ns | 0.0027 ns | 0.0071 ns | 0.0155 ns | 80,361,876,858.6 |      - |         - |
|                   |           |           |           |           |           |           |                  |        |           |
| Sealed_IntMethod  | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
| Open_IntMethod    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
|                   |           |           |           |           |           |           |                  |        |           |
| Sealed_ToString   | 0.2096 ns | 0.5782 ns | 0.0317 ns | 0.0183 ns | 0.1798 ns | 0.2429 ns |  4,769,890,683.7 |      - |         - |
| Open_ToString     | 0.4243 ns | 1.0443 ns | 0.0572 ns | 0.0330 ns | 0.3804 ns | 0.4891 ns |  2,356,691,211.8 |      - |         - |
|                   |           |           |           |           |           |           |                  |        |           |
| Sealed_VoidMethod | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
| Open_VoidMethod   | 0.0269 ns | 0.0092 ns | 0.0005 ns | 0.0003 ns | 0.0265 ns | 0.0275 ns | 37,199,863,637.0 |      - |         - |
