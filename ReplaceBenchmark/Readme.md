# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.6899)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.306
  [Host]   : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.10 (9.0.10, 9.0.1025.47515), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean         | Error        | StdDev     | StdErr     | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|-------------:|-----------:|-----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     59.30 ns |     5.663 ns |   0.310 ns |   0.179 ns |     59.09 ns |     59.66 ns | 16,863,193.0 | 0.0229 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |     99.97 ns |     6.176 ns |   0.339 ns |   0.195 ns |     99.58 ns |    100.20 ns | 10,003,282.9 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    112.29 ns |    78.097 ns |   4.281 ns |   2.471 ns |    109.81 ns |    117.23 ns |  8,905,688.0 | 0.0592 |     248 B |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    122.69 ns |    10.007 ns |   0.548 ns |   0.317 ns |    122.18 ns |    123.27 ns |  8,150,834.0 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    155.95 ns |    13.207 ns |   0.724 ns |   0.418 ns |    155.13 ns |    156.50 ns |  6,412,323.8 |      - |         - |
| ReplaceString        | ****(...)**** [500]  |  5,077.00 ns | 3,950.210 ns | 216.524 ns | 125.010 ns |  4,932.63 ns |  5,325.96 ns |    196,966.7 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  |  5,782.78 ns | 3,023.669 ns | 165.738 ns |  95.689 ns |  5,596.08 ns |  5,912.55 ns |    172,927.2 | 0.2518 |    1072 B |
| ReplaceString        | ****(...)**** [1000] | 10,029.45 ns | 3,109.657 ns | 170.451 ns |  98.410 ns |  9,926.83 ns | 10,226.21 ns |     99,706.3 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 11,131.94 ns | 4,805.077 ns | 263.382 ns | 152.064 ns | 10,828.51 ns | 11,301.50 ns |     89,831.6 | 0.4883 |    2072 B |
