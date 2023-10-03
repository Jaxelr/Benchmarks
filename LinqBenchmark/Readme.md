# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2283/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.401
  [Host]   : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|      Method |                 list | value |         Mean |          Error |       StdDev |       StdErr |          Min |          Max |        Op/s |   Gen0 | Allocated |
|------------ |--------------------- |------ |-------------:|---------------:|-------------:|-------------:|-------------:|-------------:|------------:|-------:|----------:|
|  FirstUsage | Syste(...)rator [36] |   100 |     689.6 ns |       187.6 ns |     10.28 ns |      5.94 ns |     678.2 ns |     698.0 ns | 1,450,077.5 | 0.0200 |     128 B |
|    AnyUsage | Syste(...)rator [36] |   100 |     771.7 ns |     1,713.7 ns |     93.94 ns |     54.23 ns |     684.3 ns |     871.1 ns | 1,295,824.2 | 0.0200 |     128 B |
|    AnyUsage | Syste(...)rator [36] |  1000 |   5,449.4 ns |     4,416.0 ns |    242.06 ns |    139.75 ns |   5,176.4 ns |   5,637.6 ns |   183,505.0 | 0.0153 |     128 B |
|  FirstUsage | Syste(...)rator [36] |  1000 |   5,777.1 ns |     3,612.5 ns |    198.02 ns |    114.32 ns |   5,642.9 ns |   6,004.6 ns |   173,095.8 | 0.0153 |     128 B |
| SingleUsage | Syste(...)rator [36] |   100 |   5,866.8 ns |     2,524.7 ns |    138.39 ns |     79.90 ns |   5,723.6 ns |   5,999.8 ns |   170,450.3 | 0.0153 |     128 B |
|  CountUsage | Syste(...)rator [36] |   100 |   6,671.4 ns |     2,528.2 ns |    138.58 ns |     80.01 ns |   6,541.2 ns |   6,817.1 ns |   149,893.5 | 0.0153 |     128 B |
|  WhereUsage | Syste(...)rator [36] |   100 |   7,678.9 ns |     2,602.3 ns |    142.64 ns |     82.36 ns |   7,576.0 ns |   7,841.7 ns |   130,227.6 | 0.0381 |     256 B |
| SingleUsage | Syste(...)rator [36] |  1000 |  52,801.6 ns |    54,942.5 ns |  3,011.58 ns |  1,738.74 ns |  50,212.0 ns |  56,106.4 ns |    18,938.8 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] |  1000 |  57,653.4 ns |    70,663.8 ns |  3,873.32 ns |  2,236.26 ns |  53,826.8 ns |  61,571.8 ns |    17,345.0 |      - |     256 B |
|    AnyUsage | Syste(...)rator [36] | 10000 |  58,223.6 ns |    38,169.0 ns |  2,092.17 ns |  1,207.92 ns |  56,094.8 ns |  60,277.1 ns |    17,175.2 |      - |     128 B |
|  CountUsage | Syste(...)rator [36] |  1000 |  59,457.2 ns |    44,148.6 ns |  2,419.94 ns |  1,397.15 ns |  56,671.5 ns |  61,039.0 ns |    16,818.8 |      - |     128 B |
|  FirstUsage | Syste(...)rator [36] | 10000 |  62,644.9 ns |    12,955.8 ns |    710.15 ns |    410.01 ns |  62,226.2 ns |  63,464.8 ns |    15,963.0 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 569,326.5 ns |   768,011.3 ns | 42,097.29 ns | 24,304.88 ns | 522,309.1 ns | 603,521.9 ns |     1,756.5 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] | 10000 | 582,447.2 ns | 1,131,507.6 ns | 62,021.75 ns | 35,808.27 ns | 512,383.5 ns | 630,324.4 ns |     1,716.9 |      - |     256 B |
|  CountUsage | Syste(...)rator [36] | 10000 | 607,224.5 ns |   614,809.9 ns | 33,699.80 ns | 19,456.59 ns | 578,084.1 ns | 644,128.6 ns |     1,646.8 |      - |     128 B |
