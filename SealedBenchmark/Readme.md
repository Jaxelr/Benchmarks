# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean      | Error      | StdDev    | StdErr    | Min       | Max       | Op/s             | Gen0   | Allocated |
|------------------ |----------:|-----------:|----------:|----------:|----------:|----------:|-----------------:|-------:|----------:|
| Sealed_AddToArray | 5.0116 ns |  2.9230 ns | 0.1602 ns | 0.0925 ns | 4.8795 ns | 5.1899 ns |    199,535,244.4 | 0.0038 |      24 B |
| Open_AddToArray   | 7.1395 ns | 20.5999 ns | 1.1291 ns | 0.6519 ns | 5.9237 ns | 8.1552 ns |    140,065,850.8 | 0.0038 |      24 B |
|                   |           |            |           |           |           |           |                  |        |           |
| Sealed_Casting    | 0.1833 ns |  0.0996 ns | 0.0055 ns | 0.0032 ns | 0.1783 ns | 0.1891 ns |  5,456,530,154.0 |      - |         - |
| Open_Casting      | 1.4828 ns |  0.4322 ns | 0.0237 ns | 0.0137 ns | 1.4580 ns | 1.5052 ns |    674,406,608.1 |      - |         - |
|                   |           |            |           |           |           |           |                  |        |           |
| Sealed_IntMethod  | 0.0000 ns |  0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
| Open_IntMethod    | 0.2083 ns |  0.0470 ns | 0.0026 ns | 0.0015 ns | 0.2054 ns | 0.2099 ns |  4,800,189,121.1 |      - |         - |
|                   |           |            |           |           |           |           |                  |        |           |
| Sealed_ToString   | 4.5186 ns |  1.3693 ns | 0.0751 ns | 0.0433 ns | 4.4483 ns | 4.5976 ns |    221,308,284.6 |      - |         - |
| Open_ToString     | 4.5794 ns |  1.1172 ns | 0.0612 ns | 0.0354 ns | 4.5306 ns | 4.6481 ns |    218,369,122.8 |      - |         - |
|                   |           |            |           |           |           |           |                  |        |           |
| Sealed_VoidMethod | 0.0000 ns |  0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         Infinity |      - |         - |
| Open_VoidMethod   | 0.0105 ns |  0.2894 ns | 0.0159 ns | 0.0092 ns | 0.0000 ns | 0.0287 ns | 95,254,056,279.1 |      - |         - |
