# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.402
  [Host]   : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean       | Error      | StdDev    | StdErr    | Min        | Max        | Op/s      | Gen0     | Gen1   | Allocated |
|-------------------- |--------------------- |-----------:|-----------:|----------:|----------:|-----------:|-----------:|----------:|---------:|-------:|----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |   1.238 μs |   1.139 μs | 0.0624 μs | 0.0360 μs |   1.166 μs |   1.279 μs | 807,799.0 |   0.5245 | 0.0019 |   3.22 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   4.295 μs |  14.696 μs | 0.8055 μs | 0.4651 μs |   3.532 μs |   5.137 μs | 232,852.1 |   1.2741 |      - |   7.84 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |   4.631 μs |   1.429 μs | 0.0783 μs | 0.0452 μs |   4.557 μs |   4.713 μs | 215,919.5 |   1.2360 | 0.0153 |   7.61 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |   8.012 μs |  26.986 μs | 1.4792 μs | 0.8540 μs |   7.131 μs |   9.720 μs | 124,814.5 |   1.4343 | 0.0153 |   8.84 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  11.913 μs |   4.736 μs | 0.2596 μs | 0.1499 μs |  11.705 μs |  12.204 μs |  83,945.1 |   7.8125 | 0.0763 |  47.89 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  25.714 μs |   4.031 μs | 0.2209 μs | 0.1276 μs |  25.490 μs |  25.932 μs |  38,889.6 |  18.3716 | 0.3052 | 112.66 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  56.189 μs | 131.240 μs | 7.1937 μs | 4.1533 μs |  51.227 μs |  64.439 μs |  17,797.1 |   5.8594 | 0.2441 |  36.46 KB |
| RailFenceLoopDecode | ****(...)**** [500]  |  62.542 μs |  31.366 μs | 1.7193 μs | 0.9926 μs |  61.322 μs |  64.509 μs |  15,989.1 |  55.1758 | 0.4272 | 338.03 KB |
| RailFenceLinqEncode | ****(...)**** [1000] |  66.691 μs |  35.296 μs | 1.9347 μs | 1.1170 μs |  64.980 μs |  68.791 μs |  14,994.6 |  10.4980 | 0.6104 |  64.36 KB |
| RailFenceLinqDecode | ****(...)**** [500]  |  80.168 μs |  55.678 μs | 3.0519 μs | 1.7620 μs |  77.195 μs |  83.293 μs |  12,473.8 |   6.2256 | 0.2441 |  38.64 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 151.031 μs | 109.604 μs | 6.0078 μs | 3.4686 μs | 144.200 μs | 155.492 μs |   6,621.1 | 195.3125 | 2.1973 | 1197.4 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 167.934 μs |  24.627 μs | 1.3499 μs | 0.7794 μs | 166.668 μs | 169.355 μs |   5,954.7 |  10.9863 | 0.9766 |  67.82 KB |
