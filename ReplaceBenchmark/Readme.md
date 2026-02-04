# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.102
  [Host]   : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.2 (10.0.2, 10.0.225.61305), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method               | value                | Mean         | Error        | StdDev    | StdErr    | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|-------------:|----------:|----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     60.95 ns |     1.770 ns |  0.097 ns |  0.056 ns |     60.86 ns |     61.05 ns | 16,406,303.9 | 0.0229 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |     91.76 ns |    16.682 ns |  0.914 ns |  0.528 ns |     91.20 ns |     92.81 ns | 10,898,452.6 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    106.54 ns |    21.895 ns |  1.200 ns |  0.693 ns |    105.29 ns |    107.68 ns |  9,385,789.3 | 0.0592 |     248 B |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    118.37 ns |     2.753 ns |  0.151 ns |  0.087 ns |    118.21 ns |    118.51 ns |  8,447,852.4 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    149.16 ns |    18.396 ns |  1.008 ns |  0.582 ns |    148.14 ns |    150.15 ns |  6,704,075.1 |      - |         - |
| ReplaceString        | ****(...)**** [500]  |  4,887.24 ns |   239.524 ns | 13.129 ns |  7.580 ns |  4,877.35 ns |  4,902.14 ns |    204,614.3 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  |  5,975.31 ns |   855.859 ns | 46.912 ns | 27.085 ns |  5,941.93 ns |  6,028.95 ns |    167,355.4 | 0.2518 |    1072 B |
| ReplaceString        | ****(...)**** [1000] |  9,725.25 ns | 1,337.783 ns | 73.328 ns | 42.336 ns |  9,640.92 ns |  9,773.96 ns |    102,825.1 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 11,827.94 ns |   223.161 ns | 12.232 ns |  7.062 ns | 11,819.54 ns | 11,841.97 ns |     84,545.6 | 0.4883 |    2072 B |
