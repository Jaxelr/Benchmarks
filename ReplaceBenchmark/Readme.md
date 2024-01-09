# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean         | Error       | StdDev     | StdErr     | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|------------:|-----------:|-----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     88.94 ns |    60.17 ns |   3.298 ns |   1.904 ns |     85.19 ns |     91.41 ns | 11,243,546.2 | 0.0153 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    145.46 ns |    21.09 ns |   1.156 ns |   0.667 ns |    144.45 ns |    146.72 ns |  6,874,603.1 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    149.37 ns |    83.25 ns |   4.563 ns |   2.634 ns |    145.43 ns |    154.37 ns |  6,694,640.7 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    161.27 ns |   200.53 ns |  10.992 ns |   6.346 ns |    149.08 ns |    170.42 ns |  6,200,817.9 | 0.0393 |     248 B |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    165.12 ns |   238.69 ns |  13.083 ns |   7.554 ns |    155.47 ns |    180.01 ns |  6,056,079.2 |      - |         - |
| ReplaceStringBuilder | ****(...)**** [500]  |  7,311.38 ns | 1,598.83 ns |  87.637 ns |  50.597 ns |  7,232.02 ns |  7,405.44 ns |    136,773.0 | 0.1678 |    1072 B |
| ReplaceString        | ****(...)**** [500]  |  7,701.25 ns | 2,632.02 ns | 144.270 ns |  83.294 ns |  7,581.96 ns |  7,861.60 ns |    129,849.0 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 14,622.93 ns | 1,141.99 ns |  62.596 ns |  36.140 ns | 14,562.88 ns | 14,687.80 ns |     68,385.8 | 0.3204 |    2072 B |
| ReplaceString        | ****(...)**** [1000] | 14,782.55 ns | 8,491.74 ns | 465.461 ns | 268.734 ns | 14,495.34 ns | 15,319.59 ns |     67,647.3 |      - |      24 B |
