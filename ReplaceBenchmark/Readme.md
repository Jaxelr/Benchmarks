# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.203
  [Host]   : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean         | Error        | StdDev     | StdErr    | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|-------------:|-----------:|----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     63.45 ns |    31.303 ns |   1.716 ns |  0.991 ns |     61.83 ns |     65.24 ns | 15,760,806.8 | 0.0229 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |     97.13 ns |    47.919 ns |   2.627 ns |  1.516 ns |     94.91 ns |    100.03 ns | 10,295,679.5 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    102.56 ns |     8.472 ns |   0.464 ns |  0.268 ns |    102.26 ns |    103.09 ns |  9,750,748.6 | 0.0592 |     248 B |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    117.89 ns |    34.004 ns |   1.864 ns |  1.076 ns |    116.05 ns |    119.77 ns |  8,482,233.6 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    146.86 ns |    25.572 ns |   1.402 ns |  0.809 ns |    146.05 ns |    148.47 ns |  6,809,425.9 |      - |         - |
| ReplaceString        | ****(...)**** [500]  |  4,845.66 ns | 1,977.663 ns | 108.402 ns | 62.586 ns |  4,776.56 ns |  4,970.59 ns |    206,370.4 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  |  5,904.59 ns |   244.399 ns |  13.396 ns |  7.734 ns |  5,896.58 ns |  5,920.06 ns |    169,359.8 | 0.2518 |    1072 B |
| ReplaceString        | ****(...)**** [1000] |  9,827.64 ns |   544.799 ns |  29.862 ns | 17.241 ns |  9,793.94 ns |  9,850.83 ns |    101,753.8 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 11,817.03 ns |    97.981 ns |   5.371 ns |  3.101 ns | 11,811.25 ns | 11,821.86 ns |     84,623.6 | 0.4883 |    2072 B |
