# Rail Fence Cipher

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.102
  [Host]   : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method              | value                | Mean        | Error        | StdDev      | StdErr    | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|-------------:|------------:|----------:|------------:|------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    435.2 ns |     73.85 ns |     4.05 ns |   2.34 ns |    431.4 ns |    439.4 ns | 2,297,871.8 |   0.7286 |      - |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,511.0 ns |    414.55 ns |    22.72 ns |  13.12 ns |  1,492.5 ns |  1,536.4 ns |   661,801.3 |   1.5697 |      - |    6.41 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  1,709.8 ns |    775.84 ns |    42.53 ns |  24.55 ns |  1,672.6 ns |  1,756.2 ns |   584,867.9 |   1.5774 |      - |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  2,367.1 ns |    509.84 ns |    27.95 ns |  16.13 ns |  2,350.1 ns |  2,399.4 ns |   422,453.7 |   1.9073 |      - |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  3,689.1 ns |    356.79 ns |    19.56 ns |  11.29 ns |  3,668.6 ns |  3,707.6 ns |   271,066.7 |   9.0179 |      - |   36.84 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  7,607.4 ns |    877.94 ns |    48.12 ns |  27.78 ns |  7,572.4 ns |  7,662.3 ns |   131,450.2 |   5.9967 |      - |   24.49 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  8,935.5 ns |  3,551.51 ns |   194.67 ns | 112.39 ns |  8,767.5 ns |  9,148.9 ns |   111,912.5 |  22.0032 |      - |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 16,551.0 ns |  4,531.54 ns |   248.39 ns | 143.41 ns | 16,329.6 ns | 16,819.6 ns |    60,419.4 |   9.9487 | 0.0610 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 17,884.3 ns |  5,290.89 ns |   290.01 ns | 167.44 ns | 17,716.5 ns | 18,219.2 ns |    55,915.0 |   8.3313 | 0.0305 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 29,237.7 ns | 19,483.81 ns | 1,067.97 ns | 616.59 ns | 28,562.5 ns | 30,468.9 ns |    34,202.5 |  76.2329 |      - |  311.39 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 41,206.6 ns |  7,281.52 ns |   399.12 ns | 230.43 ns | 40,754.7 ns | 41,511.0 ns |    24,267.9 |  14.4653 |      - |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 81,136.6 ns | 18,592.88 ns | 1,019.14 ns | 588.40 ns | 80,035.7 ns | 82,047.1 ns |    12,324.9 | 279.9072 |      - | 1143.41 KB |
