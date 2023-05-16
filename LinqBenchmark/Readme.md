# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1702)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]   : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|      Method |                 list | value |         Mean |         Error |       StdDev |       StdErr |          Min |          Max |        Op/s |   Gen0 | Allocated |
|------------ |--------------------- |------ |-------------:|--------------:|-------------:|-------------:|-------------:|-------------:|------------:|-------:|----------:|
|  FirstUsage | Syste(...)rator [36] |   100 |     479.5 ns |     121.11 ns |      6.64 ns |      3.83 ns |     473.0 ns |     486.3 ns | 2,085,624.8 | 0.0200 |     128 B |
|    AnyUsage | Syste(...)rator [36] |   100 |     509.8 ns |      69.08 ns |      3.79 ns |      2.19 ns |     505.4 ns |     512.3 ns | 1,961,647.2 | 0.0200 |     128 B |
| SingleUsage | Syste(...)rator [36] |   100 |   4,185.0 ns |   1,394.85 ns |     76.46 ns |     44.14 ns |   4,114.3 ns |   4,266.2 ns |   238,947.7 | 0.0153 |     128 B |
|    AnyUsage | Syste(...)rator [36] |  1000 |   4,550.1 ns |   3,633.65 ns |    199.17 ns |    114.99 ns |   4,378.1 ns |   4,768.3 ns |   219,775.7 | 0.0153 |     128 B |
|  CountUsage | Syste(...)rator [36] |   100 |   4,730.3 ns |     557.77 ns |     30.57 ns |     17.65 ns |   4,696.0 ns |   4,754.6 ns |   211,402.5 | 0.0153 |     128 B |
|  WhereUsage | Syste(...)rator [36] |   100 |   5,327.9 ns |   3,464.03 ns |    189.88 ns |    109.62 ns |   5,213.5 ns |   5,547.1 ns |   187,689.5 | 0.0381 |     256 B |
|  FirstUsage | Syste(...)rator [36] |  1000 |   5,492.5 ns |   7,447.54 ns |    408.22 ns |    235.69 ns |   5,247.1 ns |   5,963.7 ns |   182,066.7 | 0.0153 |     128 B |
|  WhereUsage | Syste(...)rator [36] |  1000 |  43,906.2 ns |   6,207.13 ns |    340.23 ns |    196.43 ns |  43,643.5 ns |  44,290.6 ns |    22,775.8 |      - |     256 B |
|    AnyUsage | Syste(...)rator [36] | 10000 |  45,004.0 ns |  44,657.03 ns |  2,447.80 ns |  1,413.24 ns |  42,398.3 ns |  47,255.3 ns |    22,220.2 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] |  1000 |  45,727.9 ns |  45,467.30 ns |  2,492.22 ns |  1,438.88 ns |  44,001.7 ns |  48,585.1 ns |    21,868.5 |      - |     128 B |
|  FirstUsage | Syste(...)rator [36] | 10000 |  46,074.3 ns |  35,788.00 ns |  1,961.66 ns |  1,132.57 ns |  44,697.2 ns |  48,320.4 ns |    21,704.1 |      - |     128 B |
|  CountUsage | Syste(...)rator [36] |  1000 |  49,275.0 ns |  47,404.42 ns |  2,598.40 ns |  1,500.18 ns |  47,302.0 ns |  52,219.1 ns |    20,294.3 |      - |     128 B |
|  CountUsage | Syste(...)rator [36] | 10000 | 469,338.0 ns |  80,366.22 ns |  4,405.14 ns |  2,543.31 ns | 466,621.6 ns | 474,420.6 ns |     2,130.7 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 474,461.2 ns | 344,056.85 ns | 18,858.92 ns | 10,888.20 ns | 458,560.0 ns | 495,296.8 ns |     2,107.7 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] | 10000 | 563,754.3 ns | 446,829.49 ns | 24,492.23 ns | 14,140.60 ns | 536,380.1 ns | 583,594.4 ns |     1,773.8 |      - |     256 B |
