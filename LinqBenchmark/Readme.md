# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]   : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|      Method |                 list | value |         Mean |        Error |       StdDev |       StdErr |          Min |          Max |        Op/s |   Gen0 | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|------------:|-------:|----------:|
|    AnyUsage | Syste(...)rator [36] |   100 |     551.5 ns |     770.9 ns |     42.26 ns |     24.40 ns |     506.6 ns |     590.5 ns | 1,813,283.4 | 0.0200 |     128 B |
|  FirstUsage | Syste(...)rator [36] |   100 |     818.8 ns |     739.4 ns |     40.53 ns |     23.40 ns |     772.3 ns |     846.4 ns | 1,221,326.1 | 0.0200 |     128 B |
|  FirstUsage | Syste(...)rator [36] |  1000 |   4,937.9 ns |   5,112.2 ns |    280.22 ns |    161.78 ns |   4,639.2 ns |   5,195.0 ns |   202,515.5 | 0.0153 |     128 B |
| SingleUsage | Syste(...)rator [36] |   100 |   5,179.4 ns |  11,109.8 ns |    608.96 ns |    351.59 ns |   4,718.0 ns |   5,869.6 ns |   193,073.0 | 0.0153 |     128 B |
|    AnyUsage | Syste(...)rator [36] |  1000 |   5,492.9 ns |   6,886.1 ns |    377.45 ns |    217.92 ns |   5,093.8 ns |   5,844.1 ns |   182,052.3 | 0.0153 |     128 B |
|  CountUsage | Syste(...)rator [36] |   100 |   5,521.3 ns |   3,545.2 ns |    194.33 ns |    112.19 ns |   5,329.3 ns |   5,717.9 ns |   181,115.9 | 0.0153 |     128 B |
|  WhereUsage | Syste(...)rator [36] |   100 |   6,454.6 ns |  10,296.9 ns |    564.41 ns |    325.86 ns |   5,936.7 ns |   7,056.2 ns |   154,927.3 | 0.0381 |     256 B |
|    AnyUsage | Syste(...)rator [36] | 10000 |  47,668.4 ns |  25,441.5 ns |  1,394.54 ns |    805.14 ns |  46,785.9 ns |  49,276.1 ns |    20,978.3 |      - |     128 B |
|  FirstUsage | Syste(...)rator [36] | 10000 |  51,918.7 ns |  26,089.3 ns |  1,430.04 ns |    825.64 ns |  50,576.3 ns |  53,422.7 ns |    19,260.9 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] |  1000 |  52,074.3 ns |  98,151.5 ns |  5,380.02 ns |  3,106.15 ns |  47,021.4 ns |  57,730.6 ns |    19,203.3 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] |  1000 |  52,365.6 ns |  14,541.3 ns |    797.06 ns |    460.18 ns |  51,458.6 ns |  52,954.7 ns |    19,096.5 |      - |     256 B |
|  CountUsage | Syste(...)rator [36] |  1000 |  55,672.6 ns | 114,661.1 ns |  6,284.96 ns |  3,628.62 ns |  51,944.4 ns |  62,928.9 ns |    17,962.2 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] | 10000 | 472,793.9 ns |  83,909.3 ns |  4,599.35 ns |  2,655.44 ns | 467,574.9 ns | 476,255.2 ns |     2,115.1 |      - |     256 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 490,204.1 ns | 682,678.9 ns | 37,419.93 ns | 21,604.41 ns | 468,292.6 ns | 533,411.4 ns |     2,040.0 |      - |     128 B |
|  CountUsage | Syste(...)rator [36] | 10000 | 497,689.0 ns | 125,641.3 ns |  6,886.83 ns |  3,976.11 ns | 492,099.3 ns | 505,382.3 ns |     2,009.3 |      - |     128 B |
