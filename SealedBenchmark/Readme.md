# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.403
  [Host]   : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean       | Error      | StdDev    | StdErr    | Min       | Max        | Op/s             | Gen0   | Allocated |
|------------------ |-----------:|-----------:|----------:|----------:|----------:|-----------:|-----------------:|-------:|----------:|
| Sealed_AddToArray |  7.7441 ns |  7.2964 ns | 0.3999 ns | 0.2309 ns | 7.3613 ns |  8.1592 ns |    129,130,941.7 | 0.0038 |      24 B |
| Open_AddToArray   | 10.1512 ns | 21.3800 ns | 1.1719 ns | 0.6766 ns | 9.4298 ns | 11.5034 ns |     98,510,239.0 | 0.0038 |      24 B |
|                   |            |            |           |           |           |            |                  |        |           |
| Sealed_Casting    |  0.0269 ns |  0.8497 ns | 0.0466 ns | 0.0269 ns | 0.0000 ns |  0.0807 ns | 37,189,040,933.9 |      - |         - |
| Open_Casting      |  8.1968 ns | 26.1793 ns | 1.4350 ns | 0.8285 ns | 7.2475 ns |  9.8476 ns |    121,998,940.4 |      - |         - |
|                   |            |            |           |           |           |            |                  |        |           |
| Sealed_IntMethod  |  0.0000 ns |  0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |         Infinity |      - |         - |
| Open_IntMethod    |  0.0000 ns |  0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |         Infinity |      - |         - |
|                   |            |            |           |           |           |            |                  |        |           |
| Open_ToString     |  8.6350 ns |  7.3449 ns | 0.4026 ns | 0.2324 ns | 8.3373 ns |  9.0931 ns |    115,807,300.9 |      - |         - |
| Sealed_ToString   |  9.1179 ns |  5.5980 ns | 0.3068 ns | 0.1772 ns | 8.8230 ns |  9.4354 ns |    109,673,990.4 |      - |         - |
|                   |            |            |           |           |           |            |                  |        |           |
| Sealed_VoidMethod |  0.0286 ns |  0.9027 ns | 0.0495 ns | 0.0286 ns | 0.0000 ns |  0.0857 ns | 35,003,884,518.1 |      - |         - |
| Open_VoidMethod   |  0.9299 ns |  1.4260 ns | 0.0782 ns | 0.0451 ns | 0.8457 ns |  1.0002 ns |  1,075,409,281.9 |      - |         - |
