# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3476)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.201
  [Host]   : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean        | Error       | StdDev      | StdErr    | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|------------:|------------:|----------:|------------:|------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    527.1 ns |    137.8 ns |     7.55 ns |   4.36 ns |    522.0 ns |    535.8 ns | 1,897,184.8 |   0.4854 | 0.0019 |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,591.1 ns |    174.6 ns |     9.57 ns |   5.53 ns |  1,580.1 ns |  1,597.5 ns |   628,490.9 |   1.2455 | 0.0038 |    7.63 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  2,044.1 ns |    459.2 ns |    25.17 ns |  14.53 ns |  2,026.0 ns |  2,072.8 ns |   489,210.4 |   1.0490 | 0.0114 |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  2,900.5 ns |    496.4 ns |    27.21 ns |  15.71 ns |  2,883.3 ns |  2,931.9 ns |   344,764.1 |   1.2703 | 0.0191 |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  4,891.0 ns |  2,543.6 ns |   139.42 ns |  80.50 ns |  4,770.7 ns |  5,043.8 ns |   204,457.5 |   6.0120 | 0.0610 |   36.84 KB |
| RailFenceLoopEncode | ****(...)**** [1000] | 10,208.2 ns |  6,803.7 ns |   372.93 ns | 215.31 ns |  9,938.3 ns | 10,633.8 ns |    97,960.1 |  14.6637 | 0.2594 |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [500]  | 16,096.0 ns |  3,238.4 ns |   177.51 ns | 102.48 ns | 15,891.0 ns | 16,198.8 ns |    62,127.2 |   3.9978 | 0.1526 |   24.49 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 27,100.6 ns |  7,221.2 ns |   395.82 ns | 228.53 ns | 26,855.3 ns | 27,557.2 ns |    36,899.6 |   6.6223 | 0.4883 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 28,172.6 ns |  8,215.7 ns |   450.33 ns | 260.00 ns | 27,671.9 ns | 28,544.4 ns |    35,495.5 |   5.5542 | 0.3052 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 30,537.8 ns |  3,687.6 ns |   202.13 ns | 116.70 ns | 30,381.2 ns | 30,766.0 ns |    32,746.3 |  53.3447 | 0.4272 |  327.02 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 60,275.1 ns | 22,449.1 ns | 1,230.51 ns | 710.44 ns | 58,871.9 ns | 61,170.3 ns |    16,590.6 |   9.6436 | 0.9155 |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 84,677.4 ns |  2,876.4 ns |   157.67 ns |  91.03 ns | 84,525.1 ns | 84,840.0 ns |    11,809.5 | 191.6504 | 2.1973 | 1174.66 KB |
