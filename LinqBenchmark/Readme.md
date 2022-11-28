# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]   : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|      Method |                 list | value |         Mean |        Error |       StdDev |       StdErr |          Min |          Max |        Op/s |   Gen0 | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|------------:|-------:|----------:|
|  FirstUsage | Syste(...)rator [36] |   100 |     769.6 ns |     373.4 ns |     20.47 ns |     11.82 ns |     757.7 ns |     793.2 ns | 1,299,399.6 | 0.0200 |     128 B |
|    AnyUsage | Syste(...)rator [36] |   100 |     787.0 ns |     399.0 ns |     21.87 ns |     12.63 ns |     770.8 ns |     811.9 ns | 1,270,669.3 | 0.0200 |     128 B |
| SingleUsage | Syste(...)rator [36] |   100 |   6,955.3 ns |   4,020.2 ns |    220.36 ns |    127.22 ns |   6,719.2 ns |   7,155.5 ns |   143,775.5 | 0.0153 |     128 B |
|    AnyUsage | Syste(...)rator [36] |  1000 |   7,565.7 ns |   7,684.4 ns |    421.21 ns |    243.18 ns |   7,127.4 ns |   7,967.4 ns |   132,175.4 | 0.0153 |     128 B |
|  FirstUsage | Syste(...)rator [36] |  1000 |   7,605.0 ns |   5,361.8 ns |    293.90 ns |    169.68 ns |   7,375.5 ns |   7,936.3 ns |   131,492.3 | 0.0153 |     128 B |
|  CountUsage | Syste(...)rator [36] |   100 |   7,774.3 ns |   2,385.1 ns |    130.74 ns |     75.48 ns |   7,643.5 ns |   7,905.0 ns |   128,629.3 | 0.0153 |     128 B |
|  WhereUsage | Syste(...)rator [36] |   100 |   8,099.9 ns |   2,321.6 ns |    127.25 ns |     73.47 ns |   7,967.1 ns |   8,220.8 ns |   123,458.3 | 0.0305 |     256 B |
|    AnyUsage | Syste(...)rator [36] | 10000 |  65,088.4 ns |  48,351.6 ns |  2,650.31 ns |  1,530.16 ns |  62,270.7 ns |  67,531.5 ns |    15,363.7 |      - |     128 B |
|  FirstUsage | Syste(...)rator [36] | 10000 |  68,102.5 ns |  22,697.4 ns |  1,244.12 ns |    718.29 ns |  67,110.6 ns |  69,498.4 ns |    14,683.8 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] |  1000 |  68,729.6 ns |  33,553.8 ns |  1,839.19 ns |  1,061.86 ns |  66,969.1 ns |  70,638.5 ns |    14,549.8 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] |  1000 |  69,246.2 ns |  19,852.4 ns |  1,088.17 ns |    628.26 ns |  68,099.3 ns |  70,264.2 ns |    14,441.2 |      - |     256 B |
|  CountUsage | Syste(...)rator [36] |  1000 |  72,216.5 ns |  15,284.5 ns |    837.80 ns |    483.70 ns |  71,254.6 ns |  72,786.7 ns |    13,847.3 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 683,897.1 ns | 557,831.3 ns | 30,576.62 ns | 17,653.42 ns | 661,164.2 ns | 718,658.9 ns |     1,462.2 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] | 10000 | 697,842.6 ns | 520,411.2 ns | 28,525.50 ns | 16,469.20 ns | 673,888.9 ns | 729,399.3 ns |     1,433.0 |      - |     256 B |
|  CountUsage | Syste(...)rator [36] | 10000 | 757,205.2 ns | 450,428.1 ns | 24,689.48 ns | 14,254.48 ns | 732,919.6 ns | 782,279.7 ns |     1,320.6 |      - |     128 B |
