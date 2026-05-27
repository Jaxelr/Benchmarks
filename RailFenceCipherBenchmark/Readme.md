# Rail Fence Cipher

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.300
  [Host]   : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method              | value                | Mean        | Error       | StdDev      | StdErr    | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|------------:|------------:|----------:|------------:|------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    542.8 ns |    133.7 ns |     7.33 ns |   4.23 ns |    537.1 ns |    551.1 ns | 1,842,147.3 |   0.7286 |      - |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,686.0 ns |    496.8 ns |    27.23 ns |  15.72 ns |  1,654.7 ns |  1,703.8 ns |   593,113.3 |   1.5697 |      - |    6.41 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  2,137.1 ns |  1,905.6 ns |   104.45 ns |  60.31 ns |  2,055.4 ns |  2,254.8 ns |   467,933.8 |   1.5774 |      - |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  2,790.7 ns |  2,152.3 ns |   117.97 ns |  68.11 ns |  2,717.6 ns |  2,926.8 ns |   358,335.6 |   1.9073 |      - |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  4,050.8 ns |    594.1 ns |    32.57 ns |  18.80 ns |  4,015.8 ns |  4,080.2 ns |   246,866.8 |   9.0179 |      - |   36.84 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  8,813.0 ns |  3,035.1 ns |   166.37 ns |  96.05 ns |  8,623.3 ns |  8,934.0 ns |   113,468.6 |   5.9967 |      - |   24.49 KB |
| RailFenceLoopEncode | ****(...)**** [1000] | 10,366.0 ns |  4,719.0 ns |   258.67 ns | 149.34 ns | 10,068.4 ns | 10,536.8 ns |    96,469.1 |  22.0032 |      - |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 17,543.2 ns |  3,783.2 ns |   207.37 ns | 119.72 ns | 17,364.4 ns | 17,770.5 ns |    57,002.0 |   9.9487 | 0.0610 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 20,751.1 ns |  1,481.6 ns |    81.21 ns |  46.89 ns | 20,672.3 ns | 20,834.6 ns |    48,190.1 |   8.3313 | 0.0305 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 31,838.5 ns |  8,375.5 ns |   459.09 ns | 265.06 ns | 31,365.6 ns | 32,282.4 ns |    31,408.5 |  76.2329 |      - |  311.39 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 45,636.1 ns | 15,064.1 ns |   825.72 ns | 476.73 ns | 44,946.0 ns | 46,550.9 ns |    21,912.5 |  14.4653 |      - |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 83,051.8 ns | 22,957.7 ns | 1,258.39 ns | 726.53 ns | 81,655.5 ns | 84,098.1 ns |    12,040.7 | 279.9072 |      - | 1143.41 KB |
