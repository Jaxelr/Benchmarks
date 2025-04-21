# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3775)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.203
  [Host]   : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean         | Error       | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |-------------:|------------:|------------:|------------:|-------------:|-------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |     552.8 ns |    161.8 ns |     8.87 ns |     5.12 ns |     544.0 ns |     561.7 ns | 1,809,057.7 |   0.4854 | 0.0019 |    2.98 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |   2,133.9 ns |    118.5 ns |     6.50 ns |     3.75 ns |   2,126.4 ns |   2,137.7 ns |   468,630.1 |   1.0490 | 0.0114 |    6.45 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   2,164.0 ns |  7,407.6 ns |   406.04 ns |   234.43 ns |   1,775.3 ns |   2,585.4 ns |   462,105.4 |   1.2455 | 0.0038 |    7.63 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |   3,343.2 ns |  6,649.8 ns |   364.50 ns |   210.44 ns |   3,010.4 ns |   3,732.8 ns |   299,114.7 |   1.2703 | 0.0191 |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |   6,870.9 ns | 23,803.3 ns | 1,304.74 ns |   753.29 ns |   5,423.6 ns |   7,956.9 ns |   145,541.7 |   6.0120 | 0.0610 |   36.84 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  10,632.3 ns | 12,983.7 ns |   711.68 ns |   410.89 ns |   9,810.5 ns |  11,043.7 ns |    94,053.3 |  14.6637 | 0.2594 |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  20,407.4 ns | 59,497.9 ns | 3,261.28 ns | 1,882.90 ns |  16,732.8 ns |  22,958.0 ns |    49,001.9 |   3.9978 | 0.1678 |   24.49 KB |
| RailFenceLinqEncode | ****(...)**** [1000] |  27,263.6 ns |  2,393.9 ns |   131.22 ns |    75.76 ns |  27,116.0 ns |  27,366.9 ns |    36,678.9 |   6.6223 | 0.4883 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  |  27,604.0 ns |  3,992.3 ns |   218.83 ns |   126.34 ns |  27,416.2 ns |  27,844.3 ns |    36,226.6 |   5.5542 | 0.3052 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  |  30,332.2 ns |  2,252.4 ns |   123.46 ns |    71.28 ns |  30,217.3 ns |  30,462.7 ns |    32,968.3 |  53.3447 | 0.4272 |  327.02 KB |
| RailFenceLinqDecode | ****(...)**** [1000] |  59,538.7 ns | 45,384.0 ns | 2,487.65 ns | 1,436.25 ns |  56,715.4 ns |  61,408.6 ns |    16,795.8 |   9.6436 | 0.8545 |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 110,337.1 ns | 81,813.3 ns | 4,484.46 ns | 2,589.11 ns | 106,088.4 ns | 115,025.0 ns |     9,063.1 | 191.6504 | 2.1973 | 1174.66 KB |
