# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.300
  [Host]   : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.8 (10.0.8, 10.0.826.23019), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method               | value                | Mean         | Error        | StdDev    | StdErr    | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|-------------:|----------:|----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     65.11 ns |     6.645 ns |  0.364 ns |  0.210 ns |     64.72 ns |     65.43 ns | 15,357,627.6 | 0.0229 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |     95.41 ns |     6.612 ns |  0.362 ns |  0.209 ns |     95.03 ns |     95.75 ns | 10,481,343.4 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    114.66 ns |     9.298 ns |  0.510 ns |  0.294 ns |    114.08 ns |    115.05 ns |  8,721,238.2 | 0.0592 |     248 B |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    139.45 ns |    35.884 ns |  1.967 ns |  1.136 ns |    137.21 ns |    140.86 ns |  7,170,880.2 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    167.75 ns |    40.236 ns |  2.205 ns |  1.273 ns |    166.24 ns |    170.28 ns |  5,961,244.8 |      - |         - |
| ReplaceString        | ****(...)**** [500]  |  4,942.48 ns |   620.179 ns | 33.994 ns | 19.626 ns |  4,914.94 ns |  4,980.47 ns |    202,327.7 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  |  6,803.19 ns |   985.850 ns | 54.038 ns | 31.199 ns |  6,742.02 ns |  6,844.46 ns |    146,989.9 | 0.2518 |    1072 B |
| ReplaceString        | ****(...)**** [1000] | 10,262.00 ns | 1,231.412 ns | 67.498 ns | 38.970 ns | 10,204.55 ns | 10,336.34 ns |     97,446.9 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 12,359.44 ns | 1,613.074 ns | 88.418 ns | 51.048 ns | 12,281.50 ns | 12,455.52 ns |     80,909.8 | 0.4883 |    2072 B |
