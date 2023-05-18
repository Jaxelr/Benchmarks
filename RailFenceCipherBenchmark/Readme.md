# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.1702)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]   : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|              Method |                value |       Mean |       Error |    StdDev |    StdErr |         Min |        Max |      Op/s |     Gen0 |   Gen1 | Allocated |
|-------------------- |--------------------- |-----------:|------------:|----------:|----------:|------------:|-----------:|----------:|---------:|-------:|----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |   1.057 μs |   3.0475 μs | 0.1670 μs | 0.0964 μs |   0.8993 μs |   1.232 μs | 946,213.0 |   0.5245 | 0.0019 |   3.22 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   2.625 μs |   0.6002 μs | 0.0329 μs | 0.0190 μs |   2.5997 μs |   2.662 μs | 380,911.2 |   1.2779 |      - |   7.84 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |   3.669 μs |   3.9839 μs | 0.2184 μs | 0.1261 μs |   3.4514 μs |   3.888 μs | 272,535.3 |   1.2398 | 0.0153 |   7.61 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |   5.528 μs |   5.2241 μs | 0.2864 μs | 0.1653 μs |   5.2381 μs |   5.811 μs | 180,900.1 |   1.4420 | 0.0153 |   8.84 KB |
| RailFenceLoopEncode |  ****(...)**** [500] |   8.708 μs |   3.8187 μs | 0.2093 μs | 0.1208 μs |   8.4812 μs |   8.894 μs | 114,839.9 |   7.8125 | 0.1068 |  47.89 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  17.585 μs |   9.8478 μs | 0.5398 μs | 0.3116 μs |  17.2201 μs |  18.205 μs |  56,865.2 |  18.3716 | 0.4578 | 112.66 KB |
| RailFenceLinqEncode |  ****(...)**** [500] |  25.795 μs |   6.8481 μs | 0.3754 μs | 0.2167 μs |  25.3691 μs |  26.079 μs |  38,767.8 |   5.9509 | 0.2441 |  36.46 KB |
| RailFenceLoopDecode |  ****(...)**** [500] |  43.232 μs |   6.7236 μs | 0.3685 μs | 0.2128 μs |  42.8450 μs |  43.579 μs |  23,131.1 |  55.1758 | 0.6104 | 338.03 KB |
| RailFenceLinqEncode | ****(...)**** [1000] |  45.817 μs |   4.3111 μs | 0.2363 μs | 0.1364 μs |  45.6038 μs |  46.071 μs |  21,826.1 |  10.4980 | 0.7324 |  64.36 KB |
| RailFenceLinqDecode |  ****(...)**** [500] |  64.635 μs |  56.9279 μs | 3.1204 μs | 1.8016 μs |  61.7705 μs |  67.960 μs |  15,471.6 |   6.2256 | 0.3662 |  38.64 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 130.563 μs | 125.9010 μs | 6.9011 μs | 3.9843 μs | 122.6586 μs | 135.388 μs |   7,659.1 | 195.3125 | 3.6621 | 1197.4 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 141.919 μs |  80.0090 μs | 4.3856 μs | 2.5320 μs | 137.7046 μs | 146.458 μs |   7,046.3 |  10.9863 | 0.9766 |  67.82 KB |
