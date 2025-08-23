# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4946/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.304
  [Host]   : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s                | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|--------------------:|-------:|----------:|
| Sealed_AddToArray | 2.0143 ns | 0.0941 ns | 0.0052 ns | 0.0030 ns | 2.0085 ns | 2.0182 ns |       496,438,969.7 | 0.0057 |      24 B |
| Open_AddToArray   | 3.0022 ns | 0.5200 ns | 0.0285 ns | 0.0165 ns | 2.9798 ns | 3.0343 ns |       333,087,384.2 | 0.0057 |      24 B |
|                   |           |           |           |           |           |           |                     |        |           |
| Sealed_Casting    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |            Infinity |      - |         - |
| Open_Casting      | 0.0015 ns | 0.0488 ns | 0.0027 ns | 0.0015 ns | 0.0000 ns | 0.0046 ns |   647,560,604,696.0 |      - |         - |
|                   |           |           |           |           |           |           |                     |        |           |
| Open_IntMethod    | 0.0027 ns | 0.0669 ns | 0.0037 ns | 0.0021 ns | 0.0005 ns | 0.0069 ns |   371,100,374,645.7 |      - |         - |
| Sealed_IntMethod  | 0.0210 ns | 0.0707 ns | 0.0039 ns | 0.0022 ns | 0.0166 ns | 0.0241 ns |    47,678,489,078.1 |      - |         - |
|                   |           |           |           |           |           |           |                     |        |           |
| Sealed_ToString   | 1.8695 ns | 0.0744 ns | 0.0041 ns | 0.0024 ns | 1.8652 ns | 1.8733 ns |       534,893,233.4 |      - |         - |
| Open_ToString     | 1.9374 ns | 0.2754 ns | 0.0151 ns | 0.0087 ns | 1.9244 ns | 1.9539 ns |       516,168,164.0 |      - |         - |
|                   |           |           |           |           |           |           |                     |        |           |
| Open_VoidMethod   | 0.0003 ns | 0.0089 ns | 0.0005 ns | 0.0003 ns | 0.0000 ns | 0.0008 ns | 3,559,365,162,430.9 |      - |         - |
| Sealed_VoidMethod | 0.1349 ns | 0.1464 ns | 0.0080 ns | 0.0046 ns | 0.1258 ns | 0.1411 ns |     7,415,596,737.6 |      - |         - |
