# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]   : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.1 (10.0.1, 10.0.125.57005), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
| Method               | value                | Mean         | Error      | StdDev    | StdErr    | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|-----------:|----------:|----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     60.03 ns |   3.895 ns |  0.214 ns |  0.123 ns |     59.87 ns |     60.27 ns | 16,658,690.0 | 0.0229 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |     89.46 ns |   3.903 ns |  0.214 ns |  0.124 ns |     89.22 ns |     89.63 ns | 11,178,736.9 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    103.13 ns |  11.110 ns |  0.609 ns |  0.352 ns |    102.63 ns |    103.81 ns |  9,696,451.9 | 0.0592 |     248 B |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    116.42 ns |  13.786 ns |  0.756 ns |  0.436 ns |    115.55 ns |    116.89 ns |  8,589,601.2 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    159.11 ns |  61.771 ns |  3.386 ns |  1.955 ns |    155.20 ns |    161.10 ns |  6,284,839.6 |      - |         - |
| ReplaceString        | ****(...)**** [500]  |  4,888.41 ns | 107.192 ns |  5.876 ns |  3.392 ns |  4,881.69 ns |  4,892.58 ns |    204,565.5 |      - |      24 B |
| ReplaceString        | ****(...)**** [1000] |  9,769.86 ns | 314.972 ns | 17.265 ns |  9.968 ns |  9,750.31 ns |  9,783.00 ns |    102,355.6 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 11,799.81 ns | 375.198 ns | 20.566 ns | 11.874 ns | 11,782.32 ns | 11,822.47 ns |     84,747.1 | 0.4883 |    2072 B |
| ReplaceStringBuilder | ****(...)**** [500]  | 12,040.99 ns | 363.502 ns | 19.925 ns | 11.504 ns | 12,018.55 ns | 12,056.62 ns |     83,049.7 | 0.2441 |    1072 B |
