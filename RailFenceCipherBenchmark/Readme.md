# Rail Fence Cipher

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7840/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.103
  [Host]   : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method              | value                | Mean        | Error       | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|------------:|------------:|------------:|------------:|------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    475.2 ns |    155.3 ns |     8.51 ns |     4.91 ns |    466.1 ns |    483.0 ns | 2,104,329.9 |   0.7286 |      - |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,572.8 ns |    562.5 ns |    30.83 ns |    17.80 ns |  1,542.7 ns |  1,604.3 ns |   635,821.3 |   1.5697 |      - |    6.41 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  1,804.6 ns |    778.8 ns |    42.69 ns |    24.65 ns |  1,761.8 ns |  1,847.2 ns |   554,135.8 |   1.5774 |      - |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  2,566.2 ns |  1,339.6 ns |    73.43 ns |    42.39 ns |  2,483.7 ns |  2,624.3 ns |   389,683.5 |   1.9073 |      - |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  4,692.4 ns |  3,298.0 ns |   180.78 ns |   104.37 ns |  4,484.9 ns |  4,815.9 ns |   213,111.6 |   9.0179 |      - |   36.84 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  8,920.5 ns |  6,686.8 ns |   366.53 ns |   211.62 ns |  8,553.5 ns |  9,286.5 ns |   112,101.2 |  22.0032 |      - |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  9,489.3 ns |  5,003.4 ns |   274.25 ns |   158.34 ns |  9,172.8 ns |  9,656.5 ns |   105,381.9 |   5.9967 |      - |   24.49 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 15,435.4 ns |  6,765.5 ns |   370.84 ns |   214.10 ns | 15,077.8 ns | 15,818.1 ns |    64,786.3 |   9.9487 | 0.0305 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 23,567.5 ns | 19,708.3 ns | 1,080.28 ns |   623.70 ns | 22,681.1 ns | 24,770.8 ns |    42,431.2 |   8.3313 | 0.0305 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 29,153.3 ns | 21,339.9 ns | 1,169.71 ns |   675.33 ns | 28,402.7 ns | 30,501.1 ns |    34,301.4 |  76.2329 |      - |  311.39 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 43,479.2 ns | 39,860.9 ns | 2,184.91 ns | 1,261.46 ns | 41,165.7 ns | 45,507.6 ns |    22,999.5 |  14.4653 |      - |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 74,239.1 ns |  8,489.0 ns |   465.31 ns |   268.65 ns | 73,782.2 ns | 74,712.4 ns |    13,470.0 | 279.9072 |      - | 1143.41 KB |
