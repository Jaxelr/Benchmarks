# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3194)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.103
  [Host]   : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean        | Error         | StdDev      | StdErr      | Min         | Max          | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|--------------:|------------:|------------:|------------:|-------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    555.8 ns |      69.58 ns |     3.81 ns |     2.20 ns |    551.7 ns |     559.2 ns | 1,799,315.9 |   0.4854 | 0.0019 |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,635.8 ns |     533.98 ns |    29.27 ns |    16.90 ns |  1,605.2 ns |   1,663.6 ns |   611,303.9 |   1.2455 | 0.0038 |    7.63 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  2,033.9 ns |     633.41 ns |    34.72 ns |    20.05 ns |  2,002.6 ns |   2,071.2 ns |   491,673.9 |   1.0490 | 0.0114 |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  3,097.5 ns |      25.79 ns |     1.41 ns |     0.82 ns |  3,096.2 ns |   3,099.0 ns |   322,838.2 |   1.2703 | 0.0191 |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  5,569.7 ns |   7,913.07 ns |   433.74 ns |   250.42 ns |  5,072.2 ns |   5,868.2 ns |   179,542.2 |   6.0120 | 0.0610 |   36.84 KB |
| RailFenceLoopEncode | ****(...)**** [1000] | 10,947.0 ns |   6,887.78 ns |   377.54 ns |   217.97 ns | 10,682.7 ns |  11,379.4 ns |    91,348.9 |  14.6637 | 0.2594 |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [500]  | 16,345.6 ns |   2,863.12 ns |   156.94 ns |    90.61 ns | 16,238.3 ns |  16,525.8 ns |    61,178.4 |   3.9978 | 0.1526 |   24.49 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 29,761.8 ns |  18,389.20 ns | 1,007.97 ns |   581.95 ns | 29,000.2 ns |  30,904.8 ns |    33,600.1 |   5.5542 | 0.3052 |   34.13 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 31,870.4 ns |  42,806.11 ns | 2,346.35 ns | 1,354.66 ns | 30,143.4 ns |  34,541.8 ns |    31,377.1 |   6.6223 | 0.4883 |   40.67 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 37,391.9 ns | 121,398.50 ns | 6,654.26 ns | 3,841.84 ns | 33,071.9 ns |  45,054.8 ns |    26,743.8 |  53.3447 | 0.4272 |  327.02 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 59,614.1 ns |   6,298.09 ns |   345.22 ns |   199.31 ns | 59,361.5 ns |  60,007.4 ns |    16,774.6 |   9.6436 | 0.8545 |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 94,378.9 ns | 120,464.31 ns | 6,603.06 ns | 3,812.28 ns | 90,350.1 ns | 101,999.3 ns |    10,595.6 | 191.6504 | 2.1973 | 1174.66 KB |
