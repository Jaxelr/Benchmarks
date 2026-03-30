# Rail Fence Cipher

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.201
  [Host]   : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method              | value                | Mean        | Error        | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|-------------:|------------:|------------:|------------:|------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    431.2 ns |     47.66 ns |     2.61 ns |     1.51 ns |    429.0 ns |    434.1 ns | 2,318,994.9 |   0.7286 |      - |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,439.6 ns |    555.92 ns |    30.47 ns |    17.59 ns |  1,407.6 ns |  1,468.3 ns |   694,637.4 |   1.5697 |      - |    6.41 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  1,659.0 ns |     37.06 ns |     2.03 ns |     1.17 ns |  1,657.1 ns |  1,661.2 ns |   602,762.6 |   1.5774 |      - |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  2,345.0 ns |    250.04 ns |    13.71 ns |     7.91 ns |  2,329.2 ns |  2,354.1 ns |   426,438.7 |   1.9073 |      - |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  3,896.9 ns |    370.57 ns |    20.31 ns |    11.73 ns |  3,880.5 ns |  3,919.6 ns |   256,617.5 |   9.0179 |      - |   36.84 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  8,321.8 ns |  3,024.08 ns |   165.76 ns |    95.70 ns |  8,181.0 ns |  8,504.5 ns |   120,166.7 |  22.0032 |      - |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  8,488.1 ns |  2,241.89 ns |   122.89 ns |    70.95 ns |  8,346.2 ns |  8,560.9 ns |   117,812.1 |   5.9967 |      - |   24.49 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 16,177.8 ns |  2,564.99 ns |   140.60 ns |    81.17 ns | 16,062.4 ns | 16,334.4 ns |    61,813.2 |   9.9487 | 0.0305 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 20,024.7 ns | 10,367.02 ns |   568.25 ns |   328.08 ns | 19,666.6 ns | 20,679.9 ns |    49,938.3 |   8.3313 | 0.0305 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 27,428.7 ns |  2,638.54 ns |   144.63 ns |    83.50 ns | 27,340.6 ns | 27,595.6 ns |    36,458.2 |  76.2329 |      - |  311.39 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 42,461.4 ns | 28,699.71 ns | 1,573.13 ns |   908.25 ns | 41,511.4 ns | 44,277.2 ns |    23,550.8 |  14.4653 |      - |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 73,314.5 ns | 34,162.47 ns | 1,872.56 ns | 1,081.12 ns | 71,237.1 ns | 74,872.6 ns |    13,639.9 | 279.9072 |      - | 1143.41 KB |
