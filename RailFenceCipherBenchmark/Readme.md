# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|              Method |                value |       Mean |      Error |    StdDev |    StdErr |         Min |        Max |      Op/s |     Gen0 |   Gen1 | Allocated |
|-------------------- |--------------------- |-----------:|-----------:|----------:|----------:|------------:|-----------:|----------:|---------:|-------:|----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |   1.025 μs |  0.4927 μs | 0.0270 μs | 0.0156 μs |   0.9940 μs |   1.042 μs | 975,422.0 |   0.5245 | 0.0019 |   3.22 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   2.603 μs |  0.4498 μs | 0.0247 μs | 0.0142 μs |   2.5745 μs |   2.621 μs | 384,241.0 |   1.2779 |      - |   7.84 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |   5.099 μs |  1.0760 μs | 0.0590 μs | 0.0341 μs |   5.0399 μs |   5.158 μs | 196,098.9 |   1.4420 | 0.0153 |   8.84 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |   7.150 μs | 18.2363 μs | 0.9996 μs | 0.5771 μs |   6.1036 μs |   8.095 μs | 139,855.0 |   1.2398 | 0.0153 |   7.61 KB |
| RailFenceLoopEncode |  ****(...)**** [500] |   8.662 μs |  1.7975 μs | 0.0985 μs | 0.0569 μs |   8.5663 μs |   8.763 μs | 115,447.9 |   7.8125 | 0.0763 |  47.89 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  17.339 μs |  7.8795 μs | 0.4319 μs | 0.2494 μs |  17.0568 μs |  17.837 μs |  57,672.1 |  18.3716 | 0.3052 | 112.66 KB |
| RailFenceLinqEncode |  ****(...)**** [500] |  26.339 μs |  3.6885 μs | 0.2022 μs | 0.1167 μs |  26.1797 μs |  26.567 μs |  37,966.3 |   5.9509 | 0.2136 |  36.46 KB |
| RailFenceLoopDecode |  ****(...)**** [500] |  44.352 μs | 23.9722 μs | 1.3140 μs | 0.7586 μs |  43.3692 μs |  45.845 μs |  22,546.7 |  55.1758 | 0.4272 | 338.03 KB |
| RailFenceLinqEncode | ****(...)**** [1000] |  44.753 μs |  5.7811 μs | 0.3169 μs | 0.1830 μs |  44.4385 μs |  45.072 μs |  22,344.8 |  10.4980 | 0.6714 |  64.36 KB |
| RailFenceLinqDecode |  ****(...)**** [500] |  61.245 μs |  9.3675 μs | 0.5135 μs | 0.2964 μs |  60.9075 μs |  61.836 μs |  16,327.8 |   6.2256 | 0.2441 |  38.64 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 120.074 μs | 34.7157 μs | 1.9029 μs | 1.0986 μs | 118.6950 μs | 122.245 μs |   8,328.2 | 195.4346 | 2.3193 | 1197.4 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 134.985 μs | 12.6161 μs | 0.6915 μs | 0.3993 μs | 134.3446 μs | 135.718 μs |   7,408.3 |  10.9863 | 0.9766 |  67.82 KB |
