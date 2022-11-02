# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.674)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]   : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|              Method |                value |       Mean |      Error |     StdDev |    StdErr |        Min |        Max |      Op/s |     Gen0 |   Gen1 | Allocated |
|-------------------- |--------------------- |-----------:|-----------:|-----------:|----------:|-----------:|-----------:|----------:|---------:|-------:|----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |   1.755 μs |   1.884 μs |  0.1033 μs | 0.0596 μs |   1.677 μs |   1.872 μs | 569,669.2 |   0.5245 | 0.0019 |   3.22 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   5.183 μs |   3.408 μs |  0.1868 μs | 0.1079 μs |   5.050 μs |   5.396 μs | 192,952.4 |   1.2741 |      - |   7.84 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |   7.271 μs |   7.938 μs |  0.4351 μs | 0.2512 μs |   6.943 μs |   7.764 μs | 137,540.4 |   1.2360 | 0.0153 |   7.61 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  10.602 μs |   5.495 μs |  0.3012 μs | 0.1739 μs |  10.349 μs |  10.935 μs |  94,322.4 |   1.4343 | 0.0153 |   8.84 KB |
| RailFenceLoopEncode |  ****(...)**** [500] |  15.721 μs |  31.709 μs |  1.7381 μs | 1.0035 μs |  13.822 μs |  17.233 μs |  63,607.3 |   7.8125 | 0.1068 |  47.89 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  35.412 μs |   9.092 μs |  0.4984 μs | 0.2877 μs |  34.962 μs |  35.947 μs |  28,239.4 |  18.3716 | 0.4272 | 112.66 KB |
| RailFenceLinqEncode |  ****(...)**** [500] |  41.160 μs |  70.502 μs |  3.8645 μs | 2.2312 μs |  38.686 μs |  45.613 μs |  24,295.3 |   5.9204 | 0.2441 |  36.46 KB |
| RailFenceLinqEncode | ****(...)**** [1000] |  78.098 μs |  20.160 μs |  1.1050 μs | 0.6380 μs |  76.823 μs |  78.790 μs |  12,804.5 |  10.4980 | 0.7324 |  64.36 KB |
| RailFenceLinqDecode |  ****(...)**** [500] | 102.465 μs |  30.410 μs |  1.6669 μs | 0.9624 μs | 101.454 μs | 104.389 μs |   9,759.5 |   6.2256 | 0.2441 |  38.64 KB |
| RailFenceLoopDecode |  ****(...)**** [500] | 107.796 μs | 238.684 μs | 13.0831 μs | 7.5535 μs |  93.621 μs | 119.408 μs |   9,276.8 |  55.1758 | 0.4883 | 338.03 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 235.995 μs | 191.516 μs | 10.4976 μs | 6.0608 μs | 223.997 μs | 243.488 μs |   4,237.4 |  10.7422 | 0.4883 |  67.82 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 270.202 μs | 179.119 μs |  9.8181 μs | 5.6685 μs | 260.180 μs | 279.803 μs |   3,700.9 | 195.3125 | 3.4180 | 1197.4 KB |
