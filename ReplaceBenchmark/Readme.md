# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8655/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.301
  [Host]   : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.9 (10.0.9, 10.0.926.27113), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method               | value                | Mean         | Error        | StdDev     | StdErr    | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|-------------:|-----------:|----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     57.90 ns |    21.671 ns |   1.188 ns |  0.686 ns |     57.07 ns |     59.26 ns | 17,269,776.5 | 0.0229 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |     87.52 ns |     4.013 ns |   0.220 ns |  0.127 ns |     87.30 ns |     87.74 ns | 11,426,511.3 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    102.25 ns |    30.044 ns |   1.647 ns |  0.951 ns |    100.79 ns |    104.04 ns |  9,779,729.9 | 0.0592 |     248 B |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    115.88 ns |     4.945 ns |   0.271 ns |  0.157 ns |    115.66 ns |    116.18 ns |  8,629,565.6 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    145.34 ns |    25.595 ns |   1.403 ns |  0.810 ns |    143.81 ns |    146.58 ns |  6,880,648.7 |      - |         - |
| ReplaceString        | ****(...)**** [500]  |  4,873.62 ns |   598.074 ns |  32.782 ns | 18.927 ns |  4,835.77 ns |  4,892.81 ns |    205,186.1 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  |  5,917.28 ns |   155.963 ns |   8.549 ns |  4.936 ns |  5,909.33 ns |  5,926.32 ns |    168,996.4 | 0.2518 |    1072 B |
| ReplaceString        | ****(...)**** [1000] |  9,840.83 ns |   287.539 ns |  15.761 ns |  9.100 ns |  9,829.25 ns |  9,858.78 ns |    101,617.4 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 12,013.95 ns | 2,166.401 ns | 118.748 ns | 68.559 ns | 11,912.13 ns | 12,144.39 ns |     83,236.6 | 0.4883 |    2072 B |
