# Sealed class benchmark performance

These benchmarks measure the performance of using sealed class vs open classes. Taken from [this article](https://code-maze.com/improve-performance-sealed-classes-dotnet/)

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3155/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Mean       | Error      | StdDev    | StdErr    | Min        | Max        | Op/s            | Gen0   | Allocated |
|------------------ |-----------:|-----------:|----------:|----------:|-----------:|-----------:|----------------:|-------:|----------:|
| Sealed_AddToArray | 12.7456 ns | 15.7003 ns | 0.8606 ns | 0.4969 ns | 11.9888 ns | 13.6817 ns |    78,458,433.5 | 0.0038 |      24 B |
| Open_AddToArray   | 13.8753 ns | 29.3171 ns | 1.6070 ns | 0.9278 ns | 12.1493 ns | 15.3282 ns |    72,070,685.7 | 0.0038 |      24 B |
|                   |            |            |           |           |            |            |                 |        |           |
| Sealed_Casting    |  1.1463 ns |  6.7625 ns | 0.3707 ns | 0.2140 ns |  0.7282 ns |  1.4345 ns |   872,336,816.2 |      - |         - |
| Open_Casting      |  2.0404 ns |  5.1659 ns | 0.2832 ns | 0.1635 ns |  1.8013 ns |  2.3531 ns |   490,110,453.8 |      - |         - |
|                   |            |            |           |           |            |            |                 |        |           |
| Sealed_IntMethod  |  0.1074 ns |  3.3926 ns | 0.1860 ns | 0.1074 ns |  0.0000 ns |  0.3221 ns | 9,314,094,242.4 |      - |         - |
| Open_IntMethod    |  0.8227 ns |  3.8495 ns | 0.2110 ns | 0.1218 ns |  0.5847 ns |  0.9869 ns | 1,215,461,746.5 |      - |         - |
|                   |            |            |           |           |            |            |                 |        |           |
| Sealed_ToString   |  8.9692 ns | 17.2080 ns | 0.9432 ns | 0.5446 ns |  7.9098 ns |  9.7179 ns |   111,493,050.9 |      - |         - |
| Open_ToString     |  9.0973 ns |  6.8651 ns | 0.3763 ns | 0.2173 ns |  8.8688 ns |  9.5316 ns |   109,922,496.6 |      - |         - |
|                   |            |            |           |           |            |            |                 |        |           |
| Sealed_VoidMethod |  0.2410 ns |  4.0907 ns | 0.2242 ns | 0.1295 ns |  0.0000 ns |  0.4434 ns | 4,149,348,403.4 |      - |         - |
| Open_VoidMethod   |  1.2313 ns |  6.5594 ns | 0.3595 ns | 0.2076 ns |  0.8360 ns |  1.5389 ns |   812,159,409.7 |      - |         - |
