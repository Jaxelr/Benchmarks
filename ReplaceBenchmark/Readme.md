# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3194)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.103
  [Host]   : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean         | Error        | StdDev     | StdErr     | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|-------------:|-----------:|-----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     81.49 ns |    21.580 ns |   1.183 ns |   0.683 ns |     80.73 ns |     82.85 ns | 12,271,479.0 | 0.0153 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    118.14 ns |     6.487 ns |   0.356 ns |   0.205 ns |    117.73 ns |    118.35 ns |  8,464,829.8 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    128.17 ns |    13.611 ns |   0.746 ns |   0.431 ns |    127.38 ns |    128.87 ns |  7,802,195.3 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    129.01 ns |    16.067 ns |   0.881 ns |   0.508 ns |    128.06 ns |    129.81 ns |  7,751,537.1 | 0.0393 |     248 B |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    132.63 ns |    75.837 ns |   4.157 ns |   2.400 ns |    129.49 ns |    137.34 ns |  7,539,978.4 |      - |         - |
| ReplaceString        | ****(...)**** [500]  |  6,151.21 ns |   818.712 ns |  44.876 ns |  25.909 ns |  6,107.28 ns |  6,196.98 ns |    162,569.6 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  |  6,912.83 ns | 2,521.634 ns | 138.219 ns |  79.801 ns |  6,810.54 ns |  7,070.08 ns |    144,658.5 | 0.1678 |    1072 B |
| ReplaceString        | ****(...)**** [1000] | 12,280.84 ns |   226.952 ns |  12.440 ns |   7.182 ns | 12,266.48 ns | 12,288.29 ns |     81,427.6 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 12,867.08 ns | 5,672.977 ns | 310.955 ns | 179.530 ns | 12,649.27 ns | 13,223.19 ns |     77,717.7 | 0.3204 |    2072 B |
