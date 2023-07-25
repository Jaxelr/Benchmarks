# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.1992/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]   : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|              Method |                value |       Mean |      Error |     StdDev |     StdErr |         Min |        Max |      Op/s |     Gen0 |   Gen1 | Allocated |
|-------------------- |--------------------- |-----------:|-----------:|-----------:|-----------:|------------:|-----------:|----------:|---------:|-------:|----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |   1.109 μs |   2.913 μs |  0.1597 μs |  0.0922 μs |   0.9961 μs |   1.292 μs | 901,844.5 |   0.5245 | 0.0019 |   3.22 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   3.455 μs |   3.809 μs |  0.2088 μs |  0.1205 μs |   3.2774 μs |   3.685 μs | 289,413.7 |   1.2779 |      - |   7.84 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |   4.052 μs |   5.186 μs |  0.2843 μs |  0.1641 μs |   3.7982 μs |   4.359 μs | 246,761.6 |   1.2360 | 0.0153 |   7.61 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |   7.441 μs |   7.602 μs |  0.4167 μs |  0.2406 μs |   7.0364 μs |   7.869 μs | 134,394.9 |   1.4420 | 0.0153 |   8.84 KB |
| RailFenceLoopEncode |  ****(...)**** [500] |  10.225 μs |  23.255 μs |  1.2747 μs |  0.7359 μs |   9.4769 μs |  11.697 μs |  97,800.9 |   7.8125 | 0.0763 |  47.89 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  21.829 μs |  42.450 μs |  2.3268 μs |  1.3434 μs |  19.1683 μs |  23.482 μs |  45,810.4 |  18.3716 | 0.3052 | 112.66 KB |
| RailFenceLinqEncode |  ****(...)**** [500] |  32.262 μs | 113.518 μs |  6.2223 μs |  3.5925 μs |  27.7767 μs |  39.366 μs |  30,996.3 |   5.9204 | 0.2441 |  36.46 KB |
| RailFenceLoopDecode |  ****(...)**** [500] |  52.229 μs | 118.211 μs |  6.4795 μs |  3.7410 μs |  48.0661 μs |  59.694 μs |  19,146.4 |  55.1758 | 0.3662 | 338.03 KB |
| RailFenceLinqEncode | ****(...)**** [1000] |  59.158 μs |   5.980 μs |  0.3278 μs |  0.1893 μs |  58.8134 μs |  59.466 μs |  16,903.8 |  10.4980 | 0.6104 |  64.36 KB |
| RailFenceLinqDecode |  ****(...)**** [500] |  65.750 μs |  45.089 μs |  2.4715 μs |  1.4269 μs |  63.2446 μs |  68.186 μs |  15,209.0 |   6.2256 | 0.2441 |  38.64 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 134.418 μs | 350.803 μs | 19.2287 μs | 11.1017 μs | 113.5236 μs | 151.370 μs |   7,439.5 | 195.3125 | 2.1973 | 1197.4 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 155.517 μs | 249.786 μs | 13.6916 μs |  7.9049 μs | 144.4065 μs | 170.813 μs |   6,430.2 |  10.9863 | 0.9766 |  67.82 KB |
