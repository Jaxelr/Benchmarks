# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4349)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.301
  [Host]   : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean         | Error        | StdDev      | StdErr      | Min         | Max          | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |-------------:|-------------:|------------:|------------:|------------:|-------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |     574.0 ns |     465.5 ns |    25.52 ns |    14.73 ns |    546.3 ns |     596.4 ns | 1,742,105.0 |   0.4854 | 0.0019 |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   1,656.6 ns |     776.8 ns |    42.58 ns |    24.58 ns |  1,610.5 ns |   1,694.6 ns |   603,653.5 |   1.2455 | 0.0038 |    7.63 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |   2,058.6 ns |     378.7 ns |    20.76 ns |    11.98 ns |  2,036.1 ns |   2,076.9 ns |   485,756.8 |   1.0490 | 0.0114 |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |   3,060.3 ns |   2,057.5 ns |   112.78 ns |    65.11 ns |  2,952.7 ns |   3,177.6 ns |   326,769.4 |   1.2703 | 0.0191 |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |   6,428.5 ns |  12,073.3 ns |   661.78 ns |   382.08 ns |  5,905.0 ns |   7,172.3 ns |   155,558.2 |   6.0120 | 0.0610 |   36.84 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  10,627.0 ns |   1,935.4 ns |   106.08 ns |    61.25 ns | 10,504.6 ns |  10,690.8 ns |    94,099.8 |  14.6637 | 0.2594 |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  23,605.9 ns |  20,718.6 ns | 1,135.65 ns |   655.67 ns | 22,457.3 ns |  24,728.2 ns |    42,362.4 |   3.9978 | 0.1526 |   24.49 KB |
| RailFenceLinqEncode | ****(...)**** [1000] |  28,464.8 ns |   6,360.9 ns |   348.66 ns |   201.30 ns | 28,129.9 ns |  28,825.8 ns |    35,131.1 |   6.6223 | 0.4883 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  |  28,636.3 ns |   8,935.8 ns |   489.80 ns |   282.79 ns | 28,071.4 ns |  28,943.8 ns |    34,920.8 |   5.5542 | 0.3052 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  |  32,285.2 ns |  10,431.3 ns |   571.77 ns |   330.11 ns | 31,750.3 ns |  32,887.8 ns |    30,974.0 |  53.3447 | 0.4272 |  327.02 KB |
| RailFenceLinqDecode | ****(...)**** [1000] |  57,383.9 ns |   3,103.4 ns |   170.11 ns |    98.21 ns | 57,249.5 ns |  57,575.2 ns |    17,426.5 |   9.6436 | 0.9155 |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 102,494.1 ns | 140,485.9 ns | 7,700.51 ns | 4,445.89 ns | 96,731.3 ns | 111,239.8 ns |     9,756.7 | 191.6504 | 2.1973 | 1174.66 KB |
