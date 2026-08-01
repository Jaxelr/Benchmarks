# Replace a set of characters from a string

This is a benchmark test using the different replace methods for a string.

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8875/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.302
  [Host]   : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | value                | Mean         | Error        | StdDev     | StdErr    | Min          | Max          | Op/s         | Gen0   | Allocated |
|--------------------- |--------------------- |-------------:|-------------:|-----------:|----------:|-------------:|-------------:|-------------:|-------:|----------:|
| ReplaceString        | Rando(...)tween [39] |     62.67 ns |     8.603 ns |   0.472 ns |  0.272 ns |     62.16 ns |     63.09 ns | 15,957,833.4 | 0.0229 |      96 B |
| ReplaceRegexBuilder  | Rando(...)tween [39] |     90.85 ns |    15.441 ns |   0.846 ns |  0.489 ns |     89.93 ns |     91.60 ns | 11,007,505.2 |      - |         - |
| ReplaceStringBuilder | Rando(...)tween [39] |    103.38 ns |    32.235 ns |   1.767 ns |  1.020 ns |    101.82 ns |    105.30 ns |  9,673,043.8 | 0.0592 |     248 B |
| ReplaceRegexBuilder  | ****(...)**** [500]  |    122.74 ns |    63.429 ns |   3.477 ns |  2.007 ns |    118.95 ns |    125.78 ns |  8,147,168.8 |      - |         - |
| ReplaceRegexBuilder  | ****(...)**** [1000] |    151.47 ns |    68.090 ns |   3.732 ns |  2.155 ns |    148.36 ns |    155.61 ns |  6,602,150.2 |      - |         - |
| ReplaceString        | ****(...)**** [500]  |  4,887.69 ns |   561.443 ns |  30.775 ns | 17.768 ns |  4,862.97 ns |  4,922.16 ns |    204,595.7 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [500]  |  5,980.59 ns |   998.104 ns |  54.709 ns | 31.587 ns |  5,928.27 ns |  6,037.41 ns |    167,207.6 | 0.2518 |    1072 B |
| ReplaceString        | ****(...)**** [1000] | 10,040.24 ns | 2,916.101 ns | 159.841 ns | 92.284 ns |  9,866.06 ns | 10,180.21 ns |     99,599.2 |      - |      24 B |
| ReplaceStringBuilder | ****(...)**** [1000] | 24,292.71 ns | 2,851.190 ns | 156.283 ns | 90.230 ns | 24,135.76 ns | 24,448.32 ns |     41,164.6 | 0.4883 |    2072 B |
