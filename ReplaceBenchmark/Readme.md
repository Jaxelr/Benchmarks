# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.201
  [Host]   : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.5 (10.0.5, 10.0.526.15411), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method               | value                | Mean         | Error         | StdDev     | StdErr     | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|--------------:|-----------:|-----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     50.72 ns |      1.609 ns |   0.088 ns |   0.051 ns |     50.63 ns |     50.80 ns | 19,717,204.3 | 0.0229 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |     79.31 ns |      3.949 ns |   0.216 ns |   0.125 ns |     79.08 ns |     79.50 ns | 12,609,384.8 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |     88.42 ns |      0.944 ns |   0.052 ns |   0.030 ns |     88.37 ns |     88.48 ns | 11,309,340.6 | 0.0592 |     248 B |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    101.40 ns |     10.237 ns |   0.561 ns |   0.324 ns |    100.77 ns |    101.82 ns |  9,861,562.5 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    141.68 ns |    162.699 ns |   8.918 ns |   5.149 ns |    135.05 ns |    151.82 ns |  7,058,004.3 |      - |         - |
| ReplaceString        | ****(...)**** [500]  |  4,324.36 ns |  2,061.962 ns | 113.023 ns |  65.254 ns |  4,201.88 ns |  4,424.63 ns |    231,248.0 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  |  5,037.09 ns |    202.763 ns |  11.114 ns |   6.417 ns |  5,025.22 ns |  5,047.25 ns |    198,527.3 | 0.2518 |    1072 B |
| ReplaceString        | ****(...)**** [1000] |  8,328.15 ns |    192.116 ns |  10.531 ns |   6.080 ns |  8,316.21 ns |  8,336.14 ns |    120,074.7 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 10,496.22 ns | 14,431.100 ns | 791.017 ns | 456.694 ns | 10,036.63 ns | 11,409.60 ns |     95,272.4 | 0.4883 |    2072 B |
