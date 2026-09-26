# Rail Fence Cipher

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9457)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.401
  [Host]   : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean         | Error       | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |-------------:|------------:|------------:|------------:|-------------:|-------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |     548.4 ns |    135.9 ns |     7.45 ns |     4.30 ns |     541.8 ns |     556.5 ns | 1,823,329.2 |   0.7286 |      - |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |   1,727.2 ns |    126.1 ns |     6.91 ns |     3.99 ns |   1,719.7 ns |   1,733.3 ns |   578,986.3 |   1.5697 |      - |    6.41 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |   1,954.1 ns |  1,067.3 ns |    58.50 ns |    33.78 ns |   1,892.9 ns |   2,009.5 ns |   511,741.9 |   1.5774 |      - |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |   2,772.8 ns |    233.3 ns |    12.79 ns |     7.38 ns |   2,763.3 ns |   2,787.4 ns |   360,639.9 |   1.9073 |      - |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |   3,991.1 ns |  1,106.8 ns |    60.67 ns |    35.03 ns |   3,922.3 ns |   4,036.8 ns |   250,559.2 |   9.0179 |      - |   36.84 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |   8,399.1 ns |    568.0 ns |    31.13 ns |    17.97 ns |   8,368.3 ns |   8,430.6 ns |   119,060.9 |   5.9967 |      - |   24.49 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  11,848.0 ns |  5,846.7 ns |   320.48 ns |   185.03 ns |  11,479.9 ns |  12,064.8 ns |    84,402.5 |  22.0032 |      - |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [1000] |  17,701.1 ns |  4,804.5 ns |   263.35 ns |   152.05 ns |  17,509.8 ns |  18,001.5 ns |    56,493.6 |   9.9487 | 0.0610 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  |  19,744.9 ns |  1,176.1 ns |    64.47 ns |    37.22 ns |  19,694.6 ns |  19,817.6 ns |    50,646.0 |   8.3313 | 0.0305 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  |  31,646.0 ns | 33,176.5 ns | 1,818.51 ns | 1,049.92 ns |  29,590.5 ns |  33,045.5 ns |    31,599.6 |  76.2329 |      - |  311.39 KB |
| RailFenceLinqDecode | ****(...)**** [1000] |  47,734.6 ns | 20,851.2 ns | 1,142.93 ns |   659.87 ns |  46,432.2 ns |  48,570.6 ns |    20,949.2 |  14.4653 |      - |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 102,765.2 ns |  7,887.6 ns |   432.35 ns |   249.62 ns | 102,366.9 ns | 103,225.0 ns |     9,730.9 | 279.9072 |      - | 1143.41 KB |
