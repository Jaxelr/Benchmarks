# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2033)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean         | Error        | StdDev     | StdErr     | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|-------------:|-----------:|-----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     81.92 ns |    10.059 ns |   0.551 ns |   0.318 ns |     81.48 ns |     82.54 ns | 12,207,349.2 | 0.0153 |      96 B |
| ReplaceStringBuilder | Rando(...)tween [39] |    135.40 ns |    15.449 ns |   0.847 ns |   0.489 ns |    134.49 ns |    136.16 ns |  7,385,276.8 | 0.0393 |     248 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    143.67 ns |     8.341 ns |   0.457 ns |   0.264 ns |    143.24 ns |    144.15 ns |  6,960,348.6 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    147.83 ns |     8.834 ns |   0.484 ns |   0.280 ns |    147.42 ns |    148.36 ns |  6,764,415.8 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    154.99 ns |     5.439 ns |   0.298 ns |   0.172 ns |    154.74 ns |    155.32 ns |  6,452,096.8 |      - |         - |
| ReplaceStringBuilder | ****(...)**** [500]  |  7,139.99 ns |   485.073 ns |  26.588 ns |  15.351 ns |  7,112.29 ns |  7,165.30 ns |    140,056.2 | 0.1678 |    1072 B |
| ReplaceString        | ****(...)**** [500]  |  7,288.20 ns |   236.688 ns |  12.974 ns |   7.490 ns |  7,274.45 ns |  7,300.22 ns |    137,208.2 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 14,454.07 ns |   847.812 ns |  46.471 ns |  26.830 ns | 14,401.72 ns | 14,490.47 ns |     69,184.7 | 0.3204 |    2072 B |
| ReplaceString        | ****(...)**** [1000] | 14,465.01 ns | 3,738.707 ns | 204.931 ns | 118.317 ns | 14,300.70 ns | 14,694.64 ns |     69,132.3 |      - |      24 B |
