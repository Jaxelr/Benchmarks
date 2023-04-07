# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1413)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.202
  [Host]   : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|      Method |                 list | value |         Mean |        Error |       StdDev |      StdErr |          Min |          Max |        Op/s |   Gen0 | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|-------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
|    AnyUsage | Syste(...)rator [36] |   100 |     882.5 ns |     537.0 ns |     29.43 ns |    16.99 ns |     848.6 ns |     899.8 ns | 1,133,090.4 | 0.0200 |     128 B |
|  FirstUsage | Syste(...)rator [36] |   100 |     909.7 ns |     220.5 ns |     12.09 ns |     6.98 ns |     898.4 ns |     922.5 ns | 1,099,230.0 | 0.0200 |     128 B |
|  FirstUsage | Syste(...)rator [36] |  1000 |   7,000.8 ns |   2,925.8 ns |    160.37 ns |    92.59 ns |   6,890.9 ns |   7,184.8 ns |   142,841.1 | 0.0153 |     128 B |
|    AnyUsage | Syste(...)rator [36] |  1000 |   7,006.3 ns |   1,299.9 ns |     71.25 ns |    41.14 ns |   6,954.6 ns |   7,087.6 ns |   142,729.0 | 0.0153 |     128 B |
| SingleUsage | Syste(...)rator [36] |   100 |   7,365.3 ns |   6,152.2 ns |    337.22 ns |   194.69 ns |   7,093.7 ns |   7,742.7 ns |   135,772.6 | 0.0153 |     128 B |
|  WhereUsage | Syste(...)rator [36] |   100 |   8,164.8 ns |   9,287.8 ns |    509.10 ns |   293.93 ns |   7,821.3 ns |   8,749.7 ns |   122,477.1 | 0.0305 |     256 B |
|  CountUsage | Syste(...)rator [36] |   100 |   8,373.7 ns |   9,863.7 ns |    540.66 ns |   312.15 ns |   7,751.2 ns |   8,726.9 ns |   119,422.2 | 0.0153 |     128 B |
|    AnyUsage | Syste(...)rator [36] | 10000 |  61,507.1 ns |  10,864.4 ns |    595.52 ns |   343.82 ns |  60,863.1 ns |  62,038.0 ns |    16,258.3 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] |  1000 |  65,099.1 ns |   8,800.2 ns |    482.37 ns |   278.50 ns |  64,795.9 ns |  65,655.3 ns |    15,361.2 |      - |     128 B |
|  FirstUsage | Syste(...)rator [36] | 10000 |  66,627.5 ns |  27,700.3 ns |  1,518.34 ns |   876.62 ns |  65,208.1 ns |  68,228.5 ns |    15,008.8 |      - |     128 B |
|  CountUsage | Syste(...)rator [36] |  1000 |  70,056.8 ns |  52,523.2 ns |  2,878.97 ns | 1,662.18 ns |  68,026.7 ns |  73,351.7 ns |    14,274.1 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] |  1000 |  71,113.1 ns |  59,263.5 ns |  3,248.43 ns | 1,875.48 ns |  68,871.7 ns |  74,838.5 ns |    14,062.1 |      - |     256 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 646,840.7 ns | 222,350.0 ns | 12,187.75 ns | 7,036.60 ns | 639,236.7 ns | 660,898.2 ns |     1,546.0 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] | 10000 | 654,379.6 ns | 224,401.5 ns | 12,300.20 ns | 7,101.52 ns | 646,329.5 ns | 668,538.3 ns |     1,528.2 |      - |     256 B |
|  CountUsage | Syste(...)rator [36] | 10000 | 686,253.9 ns | 204,639.3 ns | 11,216.97 ns | 6,476.12 ns | 674,883.2 ns | 697,310.5 ns |     1,457.2 |      - |     128 B |
