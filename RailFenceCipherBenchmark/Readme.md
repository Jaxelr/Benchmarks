# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6899)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.306
  [Host]   : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean        | Error       | StdDev    | StdErr    | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|------------:|----------:|----------:|------------:|------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    475.1 ns |    225.7 ns |  12.37 ns |   7.14 ns |    467.8 ns |    489.4 ns | 2,104,611.3 |   0.7286 |      - |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,573.0 ns |    550.3 ns |  30.16 ns |  17.41 ns |  1,549.6 ns |  1,607.0 ns |   635,715.8 |   1.8673 |      - |    7.63 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  1,917.5 ns |    493.7 ns |  27.06 ns |  15.62 ns |  1,886.3 ns |  1,933.9 ns |   521,502.3 |   1.5755 |      - |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  2,634.7 ns |  1,165.4 ns |  63.88 ns |  36.88 ns |  2,561.0 ns |  2,674.5 ns |   379,554.9 |   1.9073 |      - |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  4,420.0 ns |    830.8 ns |  45.54 ns |  26.29 ns |  4,370.2 ns |  4,459.4 ns |   226,242.1 |   9.0179 |      - |   36.84 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  9,705.4 ns | 17,694.2 ns | 969.88 ns | 559.96 ns |  8,893.8 ns | 10,779.5 ns |   103,035.7 |  22.0032 |      - |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [500]  | 10,970.6 ns | 15,709.7 ns | 861.10 ns | 497.16 ns | 10,376.3 ns | 11,958.1 ns |    91,152.8 |   5.9967 |      - |   24.49 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 18,513.3 ns |  6,579.6 ns | 360.65 ns | 208.22 ns | 18,168.3 ns | 18,887.8 ns |    54,015.1 |   9.9487 | 0.0610 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 24,031.5 ns |  9,820.6 ns | 538.30 ns | 310.79 ns | 23,716.6 ns | 24,653.1 ns |    41,612.1 |   8.3313 | 0.0305 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 31,075.0 ns |  9,035.8 ns | 495.28 ns | 285.95 ns | 30,739.7 ns | 31,643.9 ns |    32,180.2 |  80.0171 |      - |  327.02 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 49,107.3 ns | 15,262.0 ns | 836.56 ns | 482.99 ns | 48,620.4 ns | 50,073.3 ns |    20,363.6 |  14.4653 |      - |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 79,281.7 ns |  8,024.5 ns | 439.85 ns | 253.95 ns | 78,840.3 ns | 79,720.0 ns |    12,613.3 | 287.5977 |      - | 1174.66 KB |
