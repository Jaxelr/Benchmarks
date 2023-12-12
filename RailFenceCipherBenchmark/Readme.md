# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean         | Error        | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0     | Gen1   | Allocated |
|-------------------- |--------------------- |-------------:|-------------:|------------:|------------:|-------------:|-------------:|------------:|---------:|-------:|----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |     771.0 ns |   1,384.5 ns |    75.89 ns |    43.82 ns |     721.6 ns |     858.4 ns | 1,297,053.2 |   0.5245 | 0.0019 |   3.22 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   2,076.8 ns |   1,301.9 ns |    71.36 ns |    41.20 ns |   2,021.8 ns |   2,157.4 ns |   481,521.6 |   1.2779 |      - |   7.84 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |   3,255.5 ns |   1,854.3 ns |   101.64 ns |    58.68 ns |   3,182.1 ns |   3,371.5 ns |   307,168.5 |   1.0910 | 0.0114 |    6.7 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |   5,487.9 ns |   4,487.2 ns |   245.96 ns |   142.00 ns |   5,280.5 ns |   5,759.6 ns |   182,218.9 |   1.4420 | 0.0153 |   8.84 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  13,100.0 ns |  24,229.3 ns | 1,328.09 ns |   766.77 ns |  11,824.3 ns |  14,474.9 ns |    76,336.0 |   7.8125 | 0.0610 |  47.89 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  27,265.5 ns |  38,507.1 ns | 2,110.70 ns | 1,218.62 ns |  24,868.9 ns |  28,847.3 ns |    36,676.3 |  18.3716 | 0.3052 | 112.66 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  44,731.7 ns | 126,997.5 ns | 6,961.16 ns | 4,019.03 ns |  37,720.9 ns |  51,642.1 ns |    22,355.5 |   4.0283 | 0.1221 |  24.74 KB |
| RailFenceLoopDecode | ****(...)**** [500]  |  44,969.9 ns |   9,815.1 ns |   538.00 ns |   310.61 ns |  44,530.1 ns |  45,569.8 ns |    22,237.1 |  55.1758 | 0.4272 | 338.03 KB |
| RailFenceLinqDecode | ****(...)**** [500]  |  47,656.1 ns |  84,844.6 ns | 4,650.62 ns | 2,685.03 ns |  44,748.3 ns |  53,019.8 ns |    20,983.7 |   6.2866 | 0.3052 |  38.64 KB |
| RailFenceLinqEncode | ****(...)**** [1000] |  55,069.9 ns |  71,067.4 ns | 3,895.44 ns | 2,249.04 ns |  50,650.3 ns |  58,004.1 ns |    18,158.7 |   6.6528 | 0.4883 |  40.92 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 100,519.0 ns |  51,380.5 ns | 2,816.34 ns | 1,626.01 ns |  98,303.2 ns | 103,688.3 ns |     9,948.4 |  10.9863 | 0.7324 |  67.82 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 126,784.8 ns | 105,650.9 ns | 5,791.08 ns | 3,343.48 ns | 122,488.5 ns | 133,370.6 ns |     7,887.4 | 195.3125 | 2.1973 | 1197.4 KB |
