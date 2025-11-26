# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.7171)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]   : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean        | Error       | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|------------:|------------:|------------:|------------:|------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    427.0 ns |    107.0 ns |     5.87 ns |     3.39 ns |    421.9 ns |    433.4 ns | 2,342,090.7 |   0.7286 |      - |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,405.3 ns |    133.4 ns |     7.31 ns |     4.22 ns |  1,397.1 ns |  1,411.2 ns |   711,601.9 |   1.8673 |      - |    7.63 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  2,136.1 ns |    688.2 ns |    37.72 ns |    21.78 ns |  2,092.9 ns |  2,162.7 ns |   468,143.0 |   1.5755 |      - |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  2,493.8 ns |    291.6 ns |    15.98 ns |     9.23 ns |  2,481.5 ns |  2,511.9 ns |   400,992.3 |   1.9073 |      - |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  3,949.3 ns |    610.4 ns |    33.46 ns |    19.32 ns |  3,915.8 ns |  3,982.7 ns |   253,209.7 |   9.0179 |      - |   36.84 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  8,302.9 ns |  1,107.6 ns |    60.71 ns |    35.05 ns |  8,242.9 ns |  8,364.3 ns |   120,440.0 |  22.0032 |      - |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  9,451.9 ns |  3,088.9 ns |   169.32 ns |    97.75 ns |  9,316.5 ns |  9,641.8 ns |   105,798.4 |   5.9967 |      - |   24.49 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 17,601.3 ns |  2,358.6 ns |   129.28 ns |    74.64 ns | 17,482.0 ns | 17,738.7 ns |    56,814.0 |   9.9487 | 0.0610 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 20,717.3 ns | 10,642.5 ns |   583.35 ns |   336.80 ns | 20,331.0 ns | 21,388.4 ns |    48,268.8 |   8.3313 | 0.0305 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 27,224.6 ns |  8,614.8 ns |   472.20 ns |   272.63 ns | 26,700.6 ns | 27,617.2 ns |    36,731.5 |  80.0476 |      - |  327.02 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 48,023.0 ns | 51,140.7 ns | 2,803.19 ns | 1,618.42 ns | 46,270.7 ns | 51,256.1 ns |    20,823.3 |  14.4653 |      - |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 74,685.5 ns | 10,468.0 ns |   573.79 ns |   331.28 ns | 74,044.5 ns | 75,151.2 ns |    13,389.5 | 287.5977 |      - | 1174.66 KB |
