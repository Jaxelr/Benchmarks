# Rail Fence Cipher

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8875/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.302
  [Host]   : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean        | Error       | StdDev      | StdErr    | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|------------:|------------:|----------:|------------:|------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    555.9 ns |    117.8 ns |     6.45 ns |   3.73 ns |    548.6 ns |    560.6 ns | 1,798,800.9 |   0.7286 |      - |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,919.5 ns |    639.4 ns |    35.05 ns |  20.23 ns |  1,891.7 ns |  1,958.9 ns |   520,971.7 |   1.5697 |      - |    6.41 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  2,140.4 ns |    804.9 ns |    44.12 ns |  25.47 ns |  2,110.4 ns |  2,191.1 ns |   467,202.7 |   1.5755 |      - |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  2,908.3 ns |    812.2 ns |    44.52 ns |  25.70 ns |  2,860.2 ns |  2,948.0 ns |   343,838.0 |   1.9073 |      - |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  5,175.7 ns |  2,213.6 ns |   121.33 ns |  70.05 ns |  5,038.6 ns |  5,269.4 ns |   193,210.7 |   9.0179 |      - |   36.84 KB |
| RailFenceLinqEncode | ****(...)**** [500]  | 10,042.4 ns |  4,651.5 ns |   254.97 ns | 147.20 ns |  9,773.8 ns | 10,281.1 ns |    99,577.9 |   5.9967 |      - |   24.49 KB |
| RailFenceLoopEncode | ****(...)**** [1000] | 11,153.7 ns |  4,647.6 ns |   254.75 ns | 147.08 ns | 10,970.2 ns | 11,444.6 ns |    89,656.4 |  22.0032 |      - |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 19,373.6 ns |  4,383.7 ns |   240.29 ns | 138.73 ns | 19,202.5 ns | 19,648.3 ns |    51,616.6 |   9.9487 | 0.0610 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 24,236.4 ns |  5,064.1 ns |   277.58 ns | 160.26 ns | 23,985.2 ns | 24,534.4 ns |    41,260.3 |   8.3313 | 0.0305 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 36,604.4 ns | 12,417.3 ns |   680.63 ns | 392.96 ns | 35,818.6 ns | 37,005.3 ns |    27,319.1 |  76.2329 |      - |  311.39 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 50,869.5 ns | 14,034.8 ns |   769.30 ns | 444.15 ns | 50,267.3 ns | 51,736.1 ns |    19,658.1 |  14.4653 |      - |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 90,917.2 ns | 19,793.1 ns | 1,084.93 ns | 626.38 ns | 90,031.7 ns | 92,127.4 ns |    10,999.0 | 279.9072 |      - | 1143.41 KB |
