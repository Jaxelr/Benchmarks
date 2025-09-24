# Rail Fence Cipher 

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.6584)
Unknown processor
.NET SDK 9.0.305
  [Host]   : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean        | Error        | StdDev    | StdErr    | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|-------------:|----------:|----------:|------------:|------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    415.4 ns |     99.63 ns |   5.46 ns |   3.15 ns |    412.1 ns |    421.7 ns | 2,407,418.9 |   0.7286 |      - |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,321.2 ns |     99.66 ns |   5.46 ns |   3.15 ns |  1,317.5 ns |  1,327.5 ns |   756,867.0 |   1.8673 |      - |    7.63 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  1,694.3 ns |  1,522.73 ns |  83.47 ns |  48.19 ns |  1,643.2 ns |  1,790.6 ns |   590,207.0 |   1.5774 |      - |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  2,269.1 ns |    144.30 ns |   7.91 ns |   4.57 ns |  2,263.6 ns |  2,278.2 ns |   440,706.2 |   1.9073 |      - |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  3,641.1 ns |    110.47 ns |   6.06 ns |   3.50 ns |  3,634.3 ns |  3,646.0 ns |   274,645.1 |   9.0179 |      - |   36.84 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  7,949.5 ns |  3,358.96 ns | 184.12 ns | 106.30 ns |  7,767.9 ns |  8,136.0 ns |   125,793.9 |  22.0032 |      - |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  8,755.7 ns |    679.10 ns |  37.22 ns |  21.49 ns |  8,717.9 ns |  8,792.3 ns |   114,211.8 |   5.9967 |      - |   24.49 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 16,076.4 ns |  5,654.54 ns | 309.94 ns | 178.95 ns | 15,745.0 ns | 16,359.1 ns |    62,202.9 |   9.9487 | 0.0610 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 20,187.5 ns | 16,255.21 ns | 891.00 ns | 514.42 ns | 19,424.8 ns | 21,166.8 ns |    49,535.7 |   8.3313 | 0.0305 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 26,316.0 ns |  4,180.12 ns | 229.13 ns | 132.29 ns | 26,076.2 ns | 26,532.7 ns |    37,999.7 |  80.0476 |      - |  327.02 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 40,272.2 ns |  5,018.00 ns | 275.05 ns | 158.80 ns | 40,038.1 ns | 40,575.1 ns |    24,831.0 |  14.4653 |      - |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 67,731.4 ns | 17,795.22 ns | 975.42 ns | 563.16 ns | 67,154.2 ns | 68,857.6 ns |    14,764.2 | 287.5977 |      - | 1174.66 KB |
