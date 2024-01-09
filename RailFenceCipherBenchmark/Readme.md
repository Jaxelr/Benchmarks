# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean        | Error       | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated |
|-------------------- |--------------------- |------------:|------------:|------------:|------------:|------------:|------------:|------------:|---------:|-------:|----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    629.1 ns |  1,029.1 ns |    56.41 ns |    32.57 ns |    588.3 ns |    693.5 ns | 1,589,560.9 |   0.5245 | 0.0019 |   3.22 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,863.1 ns |  1,499.6 ns |    82.20 ns |    47.46 ns |  1,805.4 ns |  1,957.2 ns |   536,736.9 |   1.2798 |      - |   7.84 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  2,319.9 ns |    680.4 ns |    37.29 ns |    21.53 ns |  2,296.6 ns |  2,362.9 ns |   431,062.1 |   1.0910 | 0.0114 |    6.7 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  3,306.3 ns |    208.7 ns |    11.44 ns |     6.60 ns |  3,296.2 ns |  3,318.7 ns |   302,455.1 |   1.4420 | 0.0191 |   8.84 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  7,275.8 ns |  1,462.6 ns |    80.17 ns |    46.29 ns |  7,196.9 ns |  7,357.2 ns |   137,442.1 |   7.8125 | 0.0839 |  47.89 KB |
| RailFenceLoopEncode | ****(...)**** [1000] | 14,402.8 ns |  7,569.1 ns |   414.89 ns |   239.53 ns | 14,054.1 ns | 14,861.7 ns |    69,430.8 |  18.3716 | 0.3052 | 112.66 KB |
| RailFenceLinqEncode | ****(...)**** [500]  | 15,884.1 ns | 11,014.6 ns |   603.74 ns |   348.57 ns | 15,514.4 ns | 16,580.8 ns |    62,956.0 |   4.0283 | 0.1526 |  24.74 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 31,217.4 ns |  6,664.3 ns |   365.29 ns |   210.90 ns | 30,800.3 ns | 31,480.2 ns |    32,033.4 |   6.2866 | 0.3052 |  38.64 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 34,397.1 ns |  6,888.4 ns |   377.58 ns |   217.99 ns | 34,022.5 ns | 34,777.6 ns |    29,072.3 |  55.1758 | 0.4272 | 338.03 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 36,887.8 ns | 65,456.0 ns | 3,587.86 ns | 2,071.45 ns | 33,354.7 ns | 40,528.1 ns |    27,109.3 |   6.6528 | 0.4883 |  40.92 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 71,441.3 ns | 16,292.3 ns |   893.04 ns |   515.60 ns | 70,907.4 ns | 72,472.3 ns |    13,997.5 |  10.9863 | 0.8545 |  67.82 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 90,238.7 ns |  8,322.1 ns |   456.16 ns |   263.37 ns | 89,777.1 ns | 90,689.2 ns |    11,081.7 | 195.4346 | 2.3193 | 1197.4 KB |
