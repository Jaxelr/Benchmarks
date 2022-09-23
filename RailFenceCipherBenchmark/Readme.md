# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.521)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.401
  [Host]   : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|              Method |                value |       Mean |      Error |     StdDev |     StdErr |        Min |        Max |      Op/s |     Gen0 |   Gen1 | Allocated |
|-------------------- |--------------------- |-----------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------:|-------:|----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |   1.531 μs |   1.740 μs |  0.0954 μs |  0.0551 μs |   1.473 μs |   1.641 μs | 653,097.0 |   0.5245 | 0.0019 |   3.22 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   4.802 μs |   2.753 μs |  0.1509 μs |  0.0871 μs |   4.628 μs |   4.902 μs | 208,254.8 |   1.2741 |      - |   7.84 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |   7.007 μs |   3.265 μs |  0.1789 μs |  0.1033 μs |   6.811 μs |   7.162 μs | 142,722.3 |   1.2360 | 0.0153 |   7.61 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  10.017 μs |  22.911 μs |  1.2558 μs |  0.7250 μs |   8.629 μs |  11.073 μs |  99,827.1 |   1.4343 | 0.0153 |   8.84 KB |
| RailFenceLoopEncode |  ****(...)**** [500] |  16.117 μs |  34.332 μs |  1.8819 μs |  1.0865 μs |  14.088 μs |  17.806 μs |  62,047.0 |   7.8125 | 0.0916 |  47.89 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  37.057 μs |  66.967 μs |  3.6707 μs |  2.1193 μs |  33.444 μs |  40.783 μs |  26,985.6 |  18.3716 | 0.4272 | 112.66 KB |
| RailFenceLinqEncode |  ****(...)**** [500] |  52.184 μs |  35.523 μs |  1.9472 μs |  1.1242 μs |  50.471 μs |  54.302 μs |  19,162.8 |   5.9204 | 0.2441 |  36.46 KB |
| RailFenceLinqEncode | ****(...)**** [1000] |  86.452 μs | 132.141 μs |  7.2431 μs |  4.1818 μs |  79.173 μs |  93.659 μs |  11,567.1 |  10.4980 | 0.7324 |  64.36 KB |
| RailFenceLoopDecode |  ****(...)**** [500] |  86.702 μs | 194.689 μs | 10.6716 μs |  6.1612 μs |  78.878 μs |  98.859 μs |  11,533.7 |  55.1758 | 0.6104 | 338.03 KB |
| RailFenceLinqDecode |  ****(...)**** [500] | 106.880 μs | 128.196 μs |  7.0268 μs |  4.0569 μs |  98.766 μs | 111.019 μs |   9,356.3 |   6.2256 | 0.2441 |  38.64 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 281.471 μs | 362.237 μs | 19.8554 μs | 11.4635 μs | 263.739 μs | 302.923 μs |   3,552.8 |  10.9863 | 0.7324 |  67.82 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 305.979 μs | 230.931 μs | 12.6581 μs |  7.3082 μs | 291.656 μs | 315.664 μs |   3,268.2 | 195.3125 | 3.4180 | 1197.4 KB |
