# Rail Fence Cipher

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.400
  [Host]   : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method              | value                | Mean        | Error       | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|------------:|------------:|------------:|------------:|------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    589.6 ns |    763.5 ns |    41.85 ns |    24.16 ns |    547.6 ns |    631.3 ns | 1,695,996.2 |   0.7286 |      - |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,531.3 ns |    971.0 ns |    53.23 ns |    30.73 ns |  1,478.9 ns |  1,585.4 ns |   653,041.3 |   1.5697 |      - |    6.41 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  1,843.5 ns |    704.5 ns |    38.61 ns |    22.29 ns |  1,814.9 ns |  1,887.4 ns |   542,445.4 |   1.5774 |      - |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  2,481.0 ns |    572.9 ns |    31.40 ns |    18.13 ns |  2,446.0 ns |  2,506.9 ns |   403,070.0 |   1.9073 |      - |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  4,108.9 ns |    958.8 ns |    52.55 ns |    30.34 ns |  4,051.6 ns |  4,154.8 ns |   243,374.0 |   9.0179 |      - |   36.84 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  9,186.2 ns |  2,143.2 ns |   117.48 ns |    67.83 ns |  9,071.9 ns |  9,306.6 ns |   108,858.4 |   5.9967 |      - |   24.49 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  9,729.6 ns |  4,451.3 ns |   243.99 ns |   140.87 ns |  9,457.0 ns |  9,927.4 ns |   102,778.6 |  22.0032 |      - |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 16,008.0 ns |  6,894.4 ns |   377.91 ns |   218.19 ns | 15,737.7 ns | 16,439.8 ns |    62,468.9 |   9.9487 | 0.0610 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 20,213.1 ns |  6,457.6 ns |   353.96 ns |   204.36 ns | 19,946.1 ns | 20,614.6 ns |    49,472.8 |   8.3313 |      - |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 29,510.4 ns |  8,775.2 ns |   481.00 ns |   277.70 ns | 29,031.3 ns | 29,993.3 ns |    33,886.3 |  76.2329 |      - |  311.39 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 42,799.0 ns | 10,687.5 ns |   585.82 ns |   338.22 ns | 42,188.7 ns | 43,356.8 ns |    23,365.1 |  14.4653 | 0.0610 |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 79,494.1 ns | 34,941.8 ns | 1,915.28 ns | 1,105.79 ns | 77,293.3 ns | 80,783.4 ns |    12,579.6 | 279.9072 |      - | 1143.41 KB |
