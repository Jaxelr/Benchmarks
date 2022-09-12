# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.856/21H2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.400
  [Host]   : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|              Method |                value |       Mean |       Error |    StdDev |    StdErr |        Min |        Max |      Op/s |     Gen0 |   Gen1 | Allocated |
|-------------------- |--------------------- |-----------:|------------:|----------:|----------:|-----------:|-----------:|----------:|---------:|-------:|----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |   1.097 μs |   0.4553 μs | 0.0250 μs | 0.0144 μs |   1.071 μs |   1.120 μs | 911,252.5 |   0.5245 | 0.0019 |   3.22 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   3.270 μs |   1.7098 μs | 0.0937 μs | 0.0541 μs |   3.208 μs |   3.378 μs | 305,799.0 |   1.2779 | 0.0038 |   7.84 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |   4.490 μs |   3.2423 μs | 0.1777 μs | 0.1026 μs |   4.351 μs |   4.690 μs | 222,741.0 |   1.2360 | 0.0153 |   7.61 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |   6.351 μs |   4.1110 μs | 0.2253 μs | 0.1301 μs |   6.102 μs |   6.540 μs | 157,457.8 |   1.4420 | 0.0153 |   8.84 KB |
| RailFenceLoopEncode |  ****(...)**** [500] |   9.513 μs |   8.0802 μs | 0.4429 μs | 0.2557 μs |   9.245 μs |  10.024 μs | 105,118.3 |   7.8125 | 0.1068 |  47.89 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  22.386 μs |  10.2685 μs | 0.5629 μs | 0.3250 μs |  21.955 μs |  23.023 μs |  44,669.8 |  18.3716 | 0.4272 | 112.66 KB |
| RailFenceLinqEncode |  ****(...)**** [500] |  25.844 μs |  38.0767 μs | 2.0871 μs | 1.2050 μs |  24.613 μs |  28.254 μs |  38,693.3 |   5.9509 | 0.2441 |  36.46 KB |
| RailFenceLinqEncode | ****(...)**** [1000] |  52.497 μs |  25.1459 μs | 1.3783 μs | 0.7958 μs |  51.166 μs |  53.918 μs |  19,048.8 |  10.4980 | 0.7324 |  64.36 KB |
| RailFenceLoopDecode |  ****(...)**** [500] |  59.472 μs |  29.1895 μs | 1.6000 μs | 0.9237 μs |  58.235 μs |  61.279 μs |  16,814.6 |  55.1758 | 0.6104 | 338.03 KB |
| RailFenceLinqDecode |  ****(...)**** [500] |  62.150 μs |  65.4447 μs | 3.5872 μs | 2.0711 μs |  60.043 μs |  66.292 μs |  16,090.2 |   6.2866 | 0.3662 |  38.64 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 158.032 μs |  37.2039 μs | 2.0393 μs | 1.1774 μs | 156.552 μs | 160.358 μs |   6,327.8 | 195.3125 | 3.6621 | 1197.4 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 161.645 μs | 173.9802 μs | 9.5364 μs | 5.5059 μs | 150.919 μs | 169.167 μs |   6,186.4 |  10.9863 | 0.9766 |  67.82 KB |
