# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2454)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean        | Error        | StdDev      | StdErr    | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|-------------:|------------:|----------:|------------:|------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    535.2 ns |     82.84 ns |     4.54 ns |   2.62 ns |    530.2 ns |    539.0 ns | 1,868,616.0 |   0.4854 | 0.0019 |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,585.1 ns |    302.54 ns |    16.58 ns |   9.57 ns |  1,571.9 ns |  1,603.7 ns |   630,894.9 |   1.2455 | 0.0038 |    7.63 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  2,066.4 ns |    378.54 ns |    20.75 ns |  11.98 ns |  2,044.7 ns |  2,086.1 ns |   483,929.3 |   1.0490 | 0.0114 |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  3,097.7 ns |    483.27 ns |    26.49 ns |  15.29 ns |  3,067.6 ns |  3,117.7 ns |   322,824.0 |   1.2665 | 0.0153 |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  5,525.7 ns | 10,320.11 ns |   565.68 ns | 326.60 ns |  4,882.9 ns |  5,947.6 ns |   180,971.6 |   6.0120 | 0.0610 |   36.84 KB |
| RailFenceLoopEncode | ****(...)**** [1000] | 10,983.6 ns | 12,816.83 ns |   702.53 ns | 405.61 ns | 10,502.9 ns | 11,789.9 ns |    91,044.5 |  14.6637 | 0.2594 |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [500]  | 17,674.3 ns | 12,935.66 ns |   709.05 ns | 409.37 ns | 17,213.7 ns | 18,490.8 ns |    56,579.2 |   3.9978 | 0.1526 |   24.49 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 29,481.9 ns | 15,735.63 ns |   862.52 ns | 497.98 ns | 28,972.6 ns | 30,477.8 ns |    33,919.1 |   6.6223 | 0.4883 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 29,965.5 ns | 19,943.08 ns | 1,093.15 ns | 631.13 ns | 28,769.8 ns | 30,913.6 ns |    33,371.7 |   5.5542 | 0.3052 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 35,402.6 ns | 13,479.94 ns |   738.88 ns | 426.59 ns | 34,631.9 ns | 36,105.0 ns |    28,246.5 |  53.3447 | 0.4272 |  327.02 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 57,275.5 ns | 12,351.12 ns |   677.01 ns | 390.87 ns | 56,552.3 ns | 57,894.2 ns |    17,459.5 |   9.6436 | 0.9155 |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 85,144.4 ns | 10,314.78 ns |   565.39 ns | 326.43 ns | 84,526.3 ns | 85,635.5 ns |    11,744.8 | 191.6504 | 2.1973 | 1174.66 KB |
