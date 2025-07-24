# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.302
  [Host]   : .NET 9.0.7 (9.0.725.31616), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.7 (9.0.725.31616), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean        | Error        | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|-------------:|------------:|------------:|------------:|------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    399.3 ns |     40.43 ns |     2.22 ns |     1.28 ns |    397.0 ns |    401.4 ns | 2,504,265.5 |   0.7286 |      - |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,281.3 ns |    103.23 ns |     5.66 ns |     3.27 ns |  1,277.2 ns |  1,287.8 ns |   780,427.0 |   1.8673 |      - |    7.63 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  1,600.9 ns |    140.68 ns |     7.71 ns |     4.45 ns |  1,595.8 ns |  1,609.7 ns |   624,662.8 |   1.5774 |      - |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  2,160.6 ns |    144.23 ns |     7.91 ns |     4.56 ns |  2,151.6 ns |  2,166.1 ns |   462,826.8 |   1.9073 |      - |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  3,700.3 ns |    322.48 ns |    17.68 ns |    10.21 ns |  3,687.5 ns |  3,720.5 ns |   270,248.5 |   9.0179 |      - |   36.84 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  7,592.8 ns |  1,798.56 ns |    98.59 ns |    56.92 ns |  7,513.5 ns |  7,703.2 ns |   131,703.0 |  22.0032 |      - |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  8,467.4 ns |    771.90 ns |    42.31 ns |    24.43 ns |  8,418.7 ns |  8,495.2 ns |   118,100.1 |   5.9967 |      - |   24.49 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 15,417.6 ns | 13,799.13 ns |   756.38 ns |   436.69 ns | 14,911.3 ns | 16,287.1 ns |    64,861.0 |   9.9487 | 0.0305 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 18,233.4 ns |    581.23 ns |    31.86 ns |    18.39 ns | 18,197.5 ns | 18,258.5 ns |    54,844.5 |   8.3313 | 0.0305 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 23,512.9 ns |  1,299.96 ns |    71.26 ns |    41.14 ns | 23,462.7 ns | 23,594.4 ns |    42,529.9 |  80.0476 |      - |  327.02 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 44,032.0 ns | 40,020.11 ns | 2,193.64 ns | 1,266.50 ns | 41,657.8 ns | 45,983.6 ns |    22,710.7 |  14.4653 |      - |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 66,496.3 ns |  9,135.10 ns |   500.73 ns |   289.09 ns | 66,204.2 ns | 67,074.4 ns |    15,038.4 | 287.5977 |      - | 1174.66 KB |
