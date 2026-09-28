# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9457)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.401
  [Host]   : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s                | Gen0   | Allocated |
|------------------ |----------:|----------:|----------:|----------:|----------:|----------:|--------------------:|-------:|----------:|
| Sealed_AddToArray | 3.0905 ns | 1.6149 ns | 0.0885 ns | 0.0511 ns | 3.0217 ns | 3.1904 ns |       323,572,306.4 | 0.0057 |      24 B |
| Open_AddToArray   | 5.3152 ns | 6.2875 ns | 0.3446 ns | 0.1990 ns | 4.9197 ns | 5.5517 ns |       188,141,363.1 | 0.0057 |      24 B |
|                   |           |           |           |           |           |           |                     |        |           |
| Sealed_Casting    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |            Infinity |      - |         - |
| Open_Casting      | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |            Infinity |      - |         - |
|                   |           |           |           |           |           |           |                     |        |           |
| Sealed_IntMethod  | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |            Infinity |      - |         - |
| Open_IntMethod    | 0.0007 ns | 0.0223 ns | 0.0012 ns | 0.0007 ns | 0.0000 ns | 0.0021 ns | 1,418,042,556,788.2 |      - |         - |
|                   |           |           |           |           |           |           |                     |        |           |
| Open_ToString     | 0.4603 ns | 0.2544 ns | 0.0139 ns | 0.0081 ns | 0.4452 ns | 0.4726 ns |     2,172,535,004.3 |      - |         - |
| Sealed_ToString   | 0.8216 ns | 7.3194 ns | 0.4012 ns | 0.2316 ns | 0.3585 ns | 1.0625 ns |     1,217,138,418.8 |      - |         - |
|                   |           |           |           |           |           |           |                     |        |           |
| Sealed_VoidMethod | 0.0013 ns | 0.0276 ns | 0.0015 ns | 0.0009 ns | 0.0000 ns | 0.0030 ns |   768,862,295,207.2 |      - |         - |
| Open_VoidMethod   | 0.0014 ns | 0.0198 ns | 0.0011 ns | 0.0006 ns | 0.0003 ns | 0.0024 ns |   692,498,381,632.1 |      - |         - |
