# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2033)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean        | Error        | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|-------------:|------------:|------------:|------------:|------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    656.2 ns |     725.1 ns |    39.74 ns |    22.95 ns |    626.6 ns |    701.4 ns | 1,523,978.1 |   0.4902 | 0.0019 |    3.01 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  2,004.1 ns |     890.8 ns |    48.83 ns |    28.19 ns |  1,966.0 ns |  2,059.2 ns |   498,967.5 |   1.2436 | 0.0038 |    7.63 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  2,422.9 ns |   1,239.8 ns |    67.96 ns |    39.24 ns |  2,376.9 ns |  2,500.9 ns |   412,735.7 |   1.0910 | 0.0114 |     6.7 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  3,455.1 ns |     606.3 ns |    33.23 ns |    19.19 ns |  3,419.0 ns |  3,484.4 ns |   289,428.0 |   1.4420 | 0.0191 |    8.84 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  5,073.0 ns |     528.1 ns |    28.95 ns |    16.71 ns |  5,046.7 ns |  5,104.0 ns |   197,121.4 |   6.0120 | 0.0610 |   36.88 KB |
| RailFenceLoopEncode | ****(...)**** [1000] | 10,721.1 ns |   8,978.9 ns |   492.16 ns |   284.15 ns | 10,378.3 ns | 11,285.1 ns |    93,273.7 |  14.6637 | 0.2594 |   89.92 KB |
| RailFenceLinqEncode | ****(...)**** [500]  | 15,891.9 ns |   7,177.9 ns |   393.44 ns |   227.16 ns | 15,546.8 ns | 16,320.4 ns |    62,925.0 |   4.0283 | 0.1526 |   24.74 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 27,880.3 ns |     904.3 ns |    49.57 ns |    28.62 ns | 27,824.8 ns | 27,920.1 ns |    35,867.6 |   6.6528 | 0.4883 |   40.92 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 30,898.5 ns |  11,885.0 ns |   651.46 ns |   376.12 ns | 30,340.4 ns | 31,614.3 ns |    32,364.0 |  53.3447 | 0.4272 |  327.02 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 31,343.4 ns |   7,579.0 ns |   415.43 ns |   239.85 ns | 30,948.1 ns | 31,776.4 ns |    31,904.7 |   6.2866 | 0.3052 |   38.64 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 84,681.5 ns | 154,555.3 ns | 8,471.70 ns | 4,891.14 ns | 77,054.8 ns | 93,800.0 ns |    11,809.0 |  10.9863 | 0.8545 |   67.82 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 95,188.9 ns |  66,321.1 ns | 3,635.28 ns | 2,098.83 ns | 93,035.5 ns | 99,386.1 ns |    10,505.4 | 191.6504 | 2.1973 | 1174.66 KB |
