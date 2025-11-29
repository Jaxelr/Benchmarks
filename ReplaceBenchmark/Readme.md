# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.7171)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.100
  [Host]   : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 9.0.11 (9.0.11, 9.0.1125.51716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean        | Error         | StdDev     | StdErr     | Min         | Max         | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |------------:|--------------:|-----------:|-----------:|------------:|------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |    54.61 ns |      5.068 ns |   0.278 ns |   0.160 ns |    54.31 ns |    54.85 ns | 18,311,072.3 | 0.0229 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |    93.65 ns |      0.588 ns |   0.032 ns |   0.019 ns |    93.62 ns |    93.69 ns | 10,678,253.8 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [500]  |   118.97 ns |     27.171 ns |   1.489 ns |   0.860 ns |   117.25 ns |   119.84 ns |  8,405,305.4 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |   128.96 ns |     10.258 ns |   0.562 ns |   0.325 ns |   128.42 ns |   129.54 ns |  7,754,422.9 | 0.0591 |     248 B |
| ReplaceRegexBuilder  | ****(...)**** [1000] |   147.41 ns |     39.485 ns |   2.164 ns |   1.250 ns |   144.93 ns |   148.91 ns |  6,783,878.0 |      - |         - |
| ReplaceString        | ****(...)**** [500]  | 4,519.52 ns |  5,585.951 ns | 306.185 ns | 176.776 ns | 4,286.76 ns | 4,866.37 ns |    221,262.5 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  | 4,794.86 ns |  3,567.972 ns | 195.573 ns | 112.914 ns | 4,653.51 ns | 5,018.06 ns |    208,556.6 | 0.2518 |    1072 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 8,702.56 ns |  2,453.642 ns | 134.492 ns |  77.649 ns | 8,547.34 ns | 8,784.48 ns |    114,908.8 | 0.4883 |    2072 B |
| ReplaceString        | ****(...)**** [1000] | 9,106.17 ns | 10,103.552 ns | 553.810 ns | 319.742 ns | 8,709.42 ns | 9,738.88 ns |    109,815.6 |      - |      24 B |
