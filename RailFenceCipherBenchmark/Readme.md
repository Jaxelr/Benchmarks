# Rail Fence Cipher

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]   : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method              | value                | Mean        | Error        | StdDev    | StdErr    | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|-------------:|----------:|----------:|------------:|------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    426.7 ns |     56.43 ns |   3.09 ns |   1.79 ns |    424.6 ns |    430.3 ns | 2,343,463.4 |   0.7286 |      - |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,414.6 ns |    279.73 ns |  15.33 ns |   8.85 ns |  1,399.2 ns |  1,429.8 ns |   706,922.4 |   1.5697 |      - |    6.41 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  1,609.5 ns |    153.53 ns |   8.42 ns |   4.86 ns |  1,603.2 ns |  1,619.1 ns |   621,298.2 |   1.5774 |      - |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  2,258.4 ns |    105.94 ns |   5.81 ns |   3.35 ns |  2,252.8 ns |  2,264.4 ns |   442,789.2 |   1.9073 |      - |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  3,947.8 ns |    860.30 ns |  47.16 ns |  27.23 ns |  3,908.8 ns |  4,000.2 ns |   253,308.4 |   9.0179 |      - |   36.84 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  8,126.8 ns |  1,397.19 ns |  76.58 ns |  44.22 ns |  8,079.8 ns |  8,215.2 ns |   123,049.5 |  22.0032 |      - |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  8,495.9 ns |  1,671.04 ns |  91.60 ns |  52.88 ns |  8,390.3 ns |  8,554.0 ns |   117,703.3 |   5.9967 |      - |   24.49 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 14,609.8 ns |    198.13 ns |  10.86 ns |   6.27 ns | 14,597.3 ns | 14,617.0 ns |    68,447.4 |   9.9487 | 0.0305 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 19,191.6 ns |  7,106.53 ns | 389.53 ns | 224.90 ns | 18,872.5 ns | 19,625.7 ns |    52,106.1 |   8.3313 | 0.0305 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 26,410.3 ns |  3,410.57 ns | 186.94 ns | 107.93 ns | 26,241.7 ns | 26,611.3 ns |    37,864.0 |  76.2329 |      - |  311.39 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 37,189.0 ns |  2,690.87 ns | 147.50 ns |  85.16 ns | 37,037.9 ns | 37,332.6 ns |    26,889.7 |  14.4653 |      - |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 68,352.5 ns | 16,101.46 ns | 882.58 ns | 509.56 ns | 67,346.1 ns | 68,994.7 ns |    14,630.0 | 279.9072 |      - | 1143.41 KB |
