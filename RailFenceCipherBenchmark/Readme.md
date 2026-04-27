# Rail Fence Cipher

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.203
  [Host]   : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method              | value                | Mean        | Error       | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|------------:|------------:|------------:|------------:|------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    468.9 ns |    531.8 ns |    29.15 ns |    16.83 ns |    439.3 ns |    497.5 ns | 2,132,587.0 |   0.7286 |      - |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,451.7 ns |    239.0 ns |    13.10 ns |     7.56 ns |  1,436.7 ns |  1,460.4 ns |   688,828.9 |   1.5697 |      - |    6.41 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  1,853.4 ns |    205.3 ns |    11.25 ns |     6.50 ns |  1,843.8 ns |  1,865.8 ns |   539,539.7 |   1.5774 |      - |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  2,437.4 ns |  1,561.9 ns |    85.61 ns |    49.43 ns |  2,382.2 ns |  2,536.1 ns |   410,266.7 |   1.9073 |      - |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  4,625.6 ns |  1,652.2 ns |    90.56 ns |    52.29 ns |  4,521.1 ns |  4,681.3 ns |   216,189.6 |   9.0179 |      - |   36.84 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  8,402.7 ns |    718.0 ns |    39.36 ns |    22.72 ns |  8,369.2 ns |  8,446.1 ns |   119,008.8 |  22.0032 |      - |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  8,571.7 ns |  8,958.8 ns |   491.06 ns |   283.52 ns |  8,225.7 ns |  9,133.7 ns |   116,663.2 |   5.9967 |      - |   24.49 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 16,172.9 ns | 10,397.6 ns |   569.92 ns |   329.05 ns | 15,592.5 ns | 16,731.7 ns |    61,832.0 |   9.9487 | 0.0305 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 19,891.3 ns |  3,035.6 ns |   166.39 ns |    96.07 ns | 19,733.0 ns | 20,064.8 ns |    50,273.2 |   8.3313 |      - |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 29,135.6 ns | 11,338.8 ns |   621.52 ns |   358.83 ns | 28,561.0 ns | 29,795.3 ns |    34,322.2 |  76.2329 |      - |  311.39 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 56,780.0 ns | 17,186.1 ns |   942.03 ns |   543.88 ns | 56,061.8 ns | 57,846.6 ns |    17,611.8 |  14.4653 | 0.0610 |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 74,754.7 ns | 71,432.0 ns | 3,915.43 ns | 2,260.57 ns | 72,416.6 ns | 79,275.0 ns |    13,377.1 | 279.9072 |      - | 1143.41 KB |
