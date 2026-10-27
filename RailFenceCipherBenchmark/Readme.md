# Rail Fence Cipher

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9711)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.403
  [Host]   : .NET 10.0.14 (10.0.14, 10.0.1426.52326), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.14 (10.0.14, 10.0.1426.52326), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean        | Error       | StdDev      | StdErr      | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|------------:|------------:|------------:|------------:|------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    498.9 ns |    273.4 ns |    14.99 ns |     8.65 ns |    485.1 ns |    514.8 ns | 2,004,309.3 |   0.7286 |      - |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,685.1 ns |    223.8 ns |    12.27 ns |     7.08 ns |  1,671.0 ns |  1,693.6 ns |   593,443.8 |   1.5697 |      - |    6.41 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  1,973.1 ns |    943.2 ns |    51.70 ns |    29.85 ns |  1,927.5 ns |  2,029.2 ns |   506,819.5 |   1.5774 |      - |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  2,769.0 ns |    547.9 ns |    30.03 ns |    17.34 ns |  2,736.1 ns |  2,795.0 ns |   361,145.8 |   1.9073 |      - |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  4,623.9 ns |    732.8 ns |    40.17 ns |    23.19 ns |  4,581.4 ns |  4,661.3 ns |   216,266.9 |   9.0179 |      - |   36.84 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  9,618.6 ns |    718.0 ns |    39.36 ns |    22.72 ns |  9,577.5 ns |  9,655.9 ns |   103,964.8 |   5.9967 |      - |   24.49 KB |
| RailFenceLoopEncode | ****(...)**** [1000] | 10,328.2 ns |  7,553.8 ns |   414.05 ns |   239.05 ns | 10,061.3 ns | 10,805.2 ns |    96,821.8 |  22.0032 |      - |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 18,112.0 ns |  5,429.0 ns |   297.58 ns |   171.81 ns | 17,893.9 ns | 18,451.0 ns |    55,211.9 |   9.9487 | 0.0610 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 20,803.2 ns |  4,192.9 ns |   229.83 ns |   132.69 ns | 20,575.0 ns | 21,034.6 ns |    48,069.6 |   8.3313 | 0.0305 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 28,112.1 ns |  1,806.3 ns |    99.01 ns |    57.16 ns | 28,002.2 ns | 28,194.4 ns |    35,571.9 |  76.2329 |      - |  311.39 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 46,976.6 ns | 35,685.9 ns | 1,956.06 ns | 1,129.33 ns | 44,933.5 ns | 48,832.1 ns |    21,287.2 |  14.4653 |      - |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 77,820.3 ns | 11,453.3 ns |   627.80 ns |   362.46 ns | 77,269.1 ns | 78,503.6 ns |    12,850.1 | 279.9072 |      - | 1143.41 KB |
