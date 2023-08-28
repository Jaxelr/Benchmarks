# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|      Method |                 list | value |         Mean |          Error |       StdDev |       StdErr |          Min |          Max |        Op/s |   Gen0 | Allocated |
|------------ |--------------------- |------ |-------------:|---------------:|-------------:|-------------:|-------------:|-------------:|------------:|-------:|----------:|
|    AnyUsage | Syste(...)rator [36] |   100 |     604.9 ns |       259.4 ns |     14.22 ns |      8.21 ns |     588.4 ns |     613.1 ns | 1,653,287.4 | 0.0200 |     128 B |
|  FirstUsage | Syste(...)rator [36] |   100 |     609.7 ns |       400.8 ns |     21.97 ns |     12.68 ns |     589.2 ns |     632.9 ns | 1,640,163.8 | 0.0200 |     128 B |
|    AnyUsage | Syste(...)rator [36] |  1000 |   5,117.8 ns |     2,172.7 ns |    119.09 ns |     68.76 ns |   4,989.9 ns |   5,225.5 ns |   195,395.6 | 0.0153 |     128 B |
|  FirstUsage | Syste(...)rator [36] |  1000 |   5,250.0 ns |     1,642.7 ns |     90.04 ns |     51.99 ns |   5,171.2 ns |   5,348.1 ns |   190,477.1 | 0.0153 |     128 B |
| SingleUsage | Syste(...)rator [36] |   100 |   5,642.6 ns |       491.7 ns |     26.95 ns |     15.56 ns |   5,625.5 ns |   5,673.7 ns |   177,223.5 | 0.0153 |     128 B |
|  CountUsage | Syste(...)rator [36] |   100 |   5,669.7 ns |     3,886.1 ns |    213.01 ns |    122.98 ns |   5,471.7 ns |   5,895.1 ns |   176,377.0 | 0.0153 |     128 B |
|  WhereUsage | Syste(...)rator [36] |   100 |   5,985.3 ns |     5,149.5 ns |    282.26 ns |    162.96 ns |   5,692.6 ns |   6,255.8 ns |   167,075.2 | 0.0381 |     256 B |
| SingleUsage | Syste(...)rator [36] |  1000 |  51,956.3 ns |    20,714.0 ns |  1,135.40 ns |    655.52 ns |  50,674.7 ns |  52,836.4 ns |    19,246.9 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] |  1000 |  53,352.3 ns |     7,596.1 ns |    416.37 ns |    240.39 ns |  52,977.5 ns |  53,800.5 ns |    18,743.3 |      - |     256 B |
|  CountUsage | Syste(...)rator [36] |  1000 |  54,151.5 ns |    27,779.7 ns |  1,522.70 ns |    879.13 ns |  52,480.6 ns |  55,461.0 ns |    18,466.7 |      - |     128 B |
|    AnyUsage | Syste(...)rator [36] | 10000 |  55,012.4 ns |    34,082.0 ns |  1,868.15 ns |  1,078.58 ns |  52,935.0 ns |  56,554.4 ns |    18,177.7 |      - |     128 B |
|  FirstUsage | Syste(...)rator [36] | 10000 |  55,576.1 ns |     9,732.0 ns |    533.45 ns |    307.99 ns |  55,081.7 ns |  56,141.5 ns |    17,993.3 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 531,695.0 ns |    96,259.4 ns |  5,276.30 ns |  3,046.27 ns | 526,768.2 ns | 537,262.3 ns |     1,880.8 |      - |     128 B |
|  CountUsage | Syste(...)rator [36] | 10000 | 582,762.1 ns |   569,634.6 ns | 31,223.60 ns | 18,026.95 ns | 546,935.1 ns | 604,172.8 ns |     1,716.0 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] | 10000 | 598,396.7 ns | 1,022,744.3 ns | 56,060.07 ns | 32,366.30 ns | 544,117.8 ns | 656,082.5 ns |     1,671.1 |      - |     256 B |
