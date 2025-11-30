# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.7171)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]   : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|-------:|----------:|
| Sealed_AddToArray | 3.5248 ns | 3.1100 ns | 0.1705 ns | 0.0984 ns | 3.3328 ns | 3.6583 ns |     283,705,028.0 | 0.0057 |      24 B |
| Open_AddToArray   | 3.8246 ns | 1.0746 ns | 0.0589 ns | 0.0340 ns | 3.7764 ns | 3.8902 ns |     261,466,519.1 | 0.0057 |      24 B |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_Casting    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
| Open_Casting      | 0.0385 ns | 0.7113 ns | 0.0390 ns | 0.0225 ns | 0.0000 ns | 0.0780 ns |  25,963,637,911.2 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Open_IntMethod    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |      - |         - |
| Sealed_IntMethod  | 0.0037 ns | 0.1157 ns | 0.0063 ns | 0.0037 ns | 0.0000 ns | 0.0110 ns | 273,142,613,709.6 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Sealed_ToString   | 1.9978 ns | 0.5792 ns | 0.0317 ns | 0.0183 ns | 1.9613 ns | 2.0182 ns |     500,538,180.3 |      - |         - |
| Open_ToString     | 2.0547 ns | 1.2946 ns | 0.0710 ns | 0.0410 ns | 1.9919 ns | 2.1317 ns |     486,687,817.3 |      - |         - |
|                   |           |           |           |           |           |           |                   |        |           |
| Open_VoidMethod   | 0.0116 ns | 0.2468 ns | 0.0135 ns | 0.0078 ns | 0.0000 ns | 0.0265 ns |  86,054,473,450.8 |      - |         - |
| Sealed_VoidMethod | 0.0338 ns | 0.9962 ns | 0.0546 ns | 0.0315 ns | 0.0000 ns | 0.0968 ns |  29,584,880,640.1 |      - |         - |
