# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4946/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.304
  [Host]   : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean        | Error       | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|------------:|------------:|------------:|------------:|------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    476.8 ns |    151.9 ns |     8.33 ns |     4.81 ns |    468.8 ns |    485.4 ns | 2,097,477.9 |   0.7286 |      - |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,374.6 ns |    731.2 ns |    40.08 ns |    23.14 ns |  1,348.2 ns |  1,420.7 ns |   727,473.2 |   1.8673 |      - |    7.63 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  1,729.0 ns |    974.6 ns |    53.42 ns |    30.84 ns |  1,667.5 ns |  1,764.0 ns |   578,375.3 |   1.5774 |      - |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  2,396.1 ns |  1,356.0 ns |    74.33 ns |    42.91 ns |  2,349.7 ns |  2,481.9 ns |   417,338.7 |   1.9073 |      - |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  3,870.2 ns |  4,263.3 ns |   233.68 ns |   134.92 ns |  3,621.9 ns |  4,085.8 ns |   258,386.6 |   9.0179 |      - |   36.84 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  8,413.2 ns |    800.7 ns |    43.89 ns |    25.34 ns |  8,369.7 ns |  8,457.5 ns |   118,860.7 |   5.9967 |      - |   24.49 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  8,890.3 ns |  4,009.9 ns |   219.80 ns |   126.90 ns |  8,665.5 ns |  9,104.7 ns |   112,481.9 |  22.0032 |      - |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 17,103.7 ns | 11,792.1 ns |   646.37 ns |   373.18 ns | 16,467.5 ns | 17,759.8 ns |    58,466.7 |   9.9487 | 0.0610 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 22,129.7 ns |  2,671.8 ns |   146.45 ns |    84.55 ns | 21,978.4 ns | 22,270.8 ns |    45,188.0 |   8.3313 | 0.0305 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 25,840.7 ns |  7,007.3 ns |   384.09 ns |   221.76 ns | 25,609.8 ns | 26,284.1 ns |    38,698.6 |  80.0476 |      - |  327.02 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 45,495.2 ns | 59,078.1 ns | 3,238.27 ns | 1,869.61 ns | 42,081.2 ns | 48,523.1 ns |    21,980.3 |  14.4653 |      - |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 74,402.1 ns | 59,486.3 ns | 3,260.64 ns | 1,882.53 ns | 71,923.0 ns | 78,095.7 ns |    13,440.5 | 287.5977 |      - | 1174.66 KB |
