# Rail Fence Cipher

I benchmark multiple implementations of a Rail Fence Cipher.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8655/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.301
  [Host]   : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | value                | Mean        | Error        | StdDev    | StdErr    | Min         | Max         | Op/s        | Gen0     | Gen1   | Allocated  |
|-------------------- |--------------------- |------------:|-------------:|----------:|----------:|------------:|------------:|------------:|---------:|-------:|-----------:|
| RailFenceLoopEncode | Rando(...)tween [39] |    426.5 ns |     55.84 ns |   3.06 ns |   1.77 ns |    423.0 ns |    428.5 ns | 2,344,489.6 |   0.7286 |      - |    2.98 KB |
| RailFenceLoopDecode | Rotgt(...)ekntn [39] |  1,429.3 ns |    328.75 ns |  18.02 ns |  10.40 ns |  1,412.7 ns |  1,448.5 ns |   699,645.3 |   1.5697 |      - |    6.41 KB |
| RailFenceLinqEncode | Rando(...)tween [39] |  1,628.8 ns |    240.18 ns |  13.16 ns |   7.60 ns |  1,618.0 ns |  1,643.4 ns |   613,952.6 |   1.5774 |      - |    6.45 KB |
| RailFenceLinqDecode | Rotgt(...)ekntn [39] |  2,309.7 ns |    680.88 ns |  37.32 ns |  21.55 ns |  2,277.0 ns |  2,350.3 ns |   432,955.2 |   1.9073 |      - |     7.8 KB |
| RailFenceLoopEncode | ****(...)**** [500]  |  3,880.1 ns |    295.93 ns |  16.22 ns |   9.37 ns |  3,862.7 ns |  3,894.9 ns |   257,726.6 |   9.0179 |      - |   36.84 KB |
| RailFenceLoopEncode | ****(...)**** [1000] |  8,148.7 ns |    723.33 ns |  39.65 ns |  22.89 ns |  8,123.3 ns |  8,194.4 ns |   122,718.6 |  22.0032 |      - |   89.89 KB |
| RailFenceLinqEncode | ****(...)**** [500]  |  8,202.0 ns |  1,469.29 ns |  80.54 ns |  46.50 ns |  8,111.7 ns |  8,266.4 ns |   121,921.8 |   5.9967 |      - |   24.49 KB |
| RailFenceLinqEncode | ****(...)**** [1000] | 14,728.3 ns |    888.87 ns |  48.72 ns |  28.13 ns | 14,676.3 ns | 14,772.9 ns |    67,896.6 |   9.9487 | 0.0305 |   40.67 KB |
| RailFenceLinqDecode | ****(...)**** [500]  | 18,738.6 ns |  1,988.13 ns | 108.98 ns |  62.92 ns | 18,675.1 ns | 18,864.4 ns |    53,365.7 |   8.3313 | 0.0305 |   34.13 KB |
| RailFenceLoopDecode | ****(...)**** [500]  | 26,478.9 ns |  2,648.02 ns | 145.15 ns |  83.80 ns | 26,333.3 ns | 26,623.6 ns |    37,765.9 |  76.2329 |      - |  311.39 KB |
| RailFenceLinqDecode | ****(...)**** [1000] | 40,161.8 ns | 10,106.07 ns | 553.95 ns | 319.82 ns | 39,535.6 ns | 40,587.9 ns |    24,899.3 |  14.4653 |      - |    59.2 KB |
| RailFenceLoopDecode | ****(...)**** [1000] | 69,662.0 ns |  8,356.85 ns | 458.07 ns | 264.47 ns | 69,164.0 ns | 70,065.4 ns |    14,355.0 | 279.9072 |      - | 1143.41 KB |
