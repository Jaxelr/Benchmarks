# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2454)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean         | Error        | StdDev    | StdErr    | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|-------------:|----------:|----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     86.07 ns |    13.471 ns |  0.738 ns |  0.426 ns |     85.45 ns |     86.89 ns | 11,618,543.8 | 0.0153 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    118.15 ns |     9.156 ns |  0.502 ns |  0.290 ns |    117.61 ns |    118.59 ns |  8,463,642.1 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    122.33 ns |     8.186 ns |  0.449 ns |  0.259 ns |    121.87 ns |    122.77 ns |  8,174,314.3 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    125.57 ns |     6.340 ns |  0.348 ns |  0.201 ns |    125.33 ns |    125.97 ns |  7,963,772.1 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    131.96 ns |    14.366 ns |  0.787 ns |  0.455 ns |    131.07 ns |    132.56 ns |  7,578,048.1 | 0.0393 |     248 B |
| ReplaceString        | ****(...)**** [500]  |  6,097.84 ns |   232.292 ns | 12.733 ns |  7.351 ns |  6,083.70 ns |  6,108.40 ns |    163,992.6 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  |  6,348.85 ns |   519.821 ns | 28.493 ns | 16.451 ns |  6,315.99 ns |  6,366.60 ns |    157,508.7 | 0.1678 |    1072 B |
| ReplaceString        | ****(...)**** [1000] | 12,325.20 ns | 1,173.671 ns | 64.333 ns | 37.143 ns | 12,251.03 ns | 12,365.78 ns |     81,134.6 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 12,762.05 ns |   346.840 ns | 19.011 ns | 10.976 ns | 12,741.42 ns | 12,778.85 ns |     78,357.3 | 0.3204 |    2072 B |
