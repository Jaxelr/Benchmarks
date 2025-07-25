# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.302
  [Host]   : .NET 9.0.7 (9.0.725.31616), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.7 (9.0.725.31616), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean        | Error       | StdDev     | StdErr     | Min         | Max         | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |------------:|------------:|-----------:|-----------:|------------:|------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |    53.61 ns |    47.60 ns |   2.609 ns |   1.507 ns |    51.71 ns |    56.59 ns | 18,652,586.9 | 0.0229 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    92.15 ns |    37.03 ns |   2.030 ns |   1.172 ns |    90.72 ns |    94.47 ns | 10,851,656.1 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    99.42 ns |    10.86 ns |   0.595 ns |   0.344 ns |    99.01 ns |   100.10 ns | 10,058,193.5 | 0.0592 |     248 B |
| ReplaceRegexBuilder  | ****(...)**** [500]  |   114.87 ns |   105.53 ns |   5.784 ns |   3.340 ns |   108.74 ns |   120.23 ns |  8,705,721.7 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |   168.53 ns |    99.92 ns |   5.477 ns |   3.162 ns |   165.31 ns |   174.85 ns |  5,933,706.3 |      - |         - |
| ReplaceStringBuilder | ****(...)**** [500]  | 4,241.26 ns | 6,363.57 ns | 348.808 ns | 201.385 ns | 3,907.16 ns | 4,603.12 ns |    235,778.9 | 0.2518 |    1072 B |
| ReplaceString        | ****(...)**** [500]  | 5,808.40 ns | 7,593.75 ns | 416.239 ns | 240.316 ns | 5,367.25 ns | 6,194.18 ns |    172,164.4 |      - |      24 B |
| ReplaceString        | ****(...)**** [1000] | 8,601.06 ns |   878.21 ns |  48.138 ns |  27.792 ns | 8,567.33 ns | 8,656.19 ns |    116,264.7 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 9,215.97 ns |   786.00 ns |  43.083 ns |  24.874 ns | 9,166.63 ns | 9,246.17 ns |    108,507.3 | 0.4883 |    2072 B |
